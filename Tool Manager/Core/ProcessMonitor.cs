using System.Diagnostics;
using Tool_Manager.Model;
using Timer = System.Windows.Forms.Timer;

namespace Tool_Manager.Core
{
    internal class ProcessMonitor
    {
        private static IDictionary<string, List<Tool>> Apps = new Dictionary<string, List<Tool>>();

        private static List<Tool> Tools { get; set; } = new List<Tool>();

        private static readonly Timer _timer = new();
        private static readonly string _defaultAppPath = @"C:\Program Files (x86)\Steam\steamapps\common\Assetto Corsa Competizione\AC2\Binaries\Win64\AC2-Win64-Shipping.exe";

        private static string AppPath = "";

        internal class Tool
        {
            public int DelayedStart { get; set; } = 0;
            public int DelayedStop { get; set; } = 0;
            public Process Process { get; set; }
        }

        public static void Run()
        {
            Init();
            ResetTimer();
        }

        public static void Stop()
        {
            _timer.Dispose();
            Tools.Clear();
        }

        private static void ResetTimer()
        {
            _timer.Stop();
            _timer.Interval = 5000;
            _timer.Tick += Tick;
            _timer.Start();
        }

        private static void Init()
        {
            Tools = new List<Tool>();
            
            AppPath = Properties.Settings.Default.appPath;

            if (AppPath == null)
                AppPath = _defaultAppPath;

            AppTools appTools = Properties.Settings.Default.apps;

            if (appTools != null)
            {
                foreach (AppTool appTool in appTools)
                {
                    Tool tool = new ();
                    Process proc = new ();
                    proc.StartInfo.FileName = appTool.Path;
                    proc.StartInfo.Arguments = appTool.Arguments;
                    tool.DelayedStart = appTool.DelayedStart;
                    tool.DelayedStop = appTool.DelayedStop;
                    tool.Process = proc;
                    Tools.Add(tool);
                }
            }
        }

        private static void MonitorForExit(Process process)
        {
            process.WaitForExit();
            OnProcessClosed();
        }

        private static void OnProcessClosed()
        {
            foreach (Tool tool in Tools)
            {
                KillAll(ExtractProcessNameFromProcess(tool.Process));
            }

            ResetTimer();
        }

        private static string ExtractProcessNameFromPath(string path)
        {
            int startIndex = path.LastIndexOf('\\') + 1;
            int endIndex = path.LastIndexOf('.');

            return path[startIndex..endIndex];
        }

        private static string ExtractProcessNameFromProcess(Process proc)
        {
            return ExtractProcessNameFromPath(proc.StartInfo.FileName);
        }

        private static void Tick(object? sender, EventArgs? e)
        {
            using Process? proc = (from p in Process.GetProcessesByName(ExtractProcessNameFromPath(AppPath))
                                   where p.MainModule?.FileName == AppPath
                                   select p).FirstOrDefault();
            {
                if (proc != null)
                {
                    Debug.WriteLine("not null");
                    _timer.Stop();

                    foreach (Tool tool in Tools)
                    {
                        SafeStartTool(tool);
                    }

                    MonitorForExit(proc);
                }
            }

            GC.Collect();
        }

        private static void KillAll(string? processName)
        {
            Process[] subprocesses = Process.GetProcessesByName(processName);

            foreach (Process proc in subprocesses)
            {
                proc.Kill();
            }
        }

        private static void SafeStartTool(Tool tool)
        {
            using Process? proc = (from p in Process.GetProcessesByName(ExtractProcessNameFromPath(tool.Process.StartInfo.FileName))
                                   where p.MainModule?.FileName == tool.Process.StartInfo.FileName
                                   select p).FirstOrDefault();
            {
                if (proc == null)
                {
                    Thread thread = new(() =>
                    {
                        if (tool.DelayedStart > 0)
                            Thread.Sleep(tool.DelayedStart);

                        tool.Process.Start();
                    });
                    thread.Start();
                }
            }
        }

    }
}
