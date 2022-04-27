using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace Tool_Manager.Core
{
    internal class ProcessMonitor
    {
        private static List<Tool> Tools { get; set; } = new List<Tool>();

        private static readonly Timer _timer = new();
        //private static readonly string _appPath = @"C:\Program Files (x86)\Steam\steamapps\common\Assetto Corsa Competizione\acc.exe";
        //private static readonly string _appPath = @"C:\Windows\system32\notepad.exe";
        private static readonly string _appPath = @"C:\Program Files (x86)\Steam\steamapps\common\Assetto Corsa Competizione\AC2\Binaries\Win64\AC2-Win64-Shipping.exe";

        internal class Tool
        {
            public int DelayedStart { get; set; } = 0;
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
            Tool tool = new Tool();
            Process proc = new Process();
            proc.StartInfo.FileName = @"C:\Users\igneo\AppData\Local\racelabapps\RacelabApps.exe";
            tool.Process = proc;
            Tools.Add(tool);

            tool = new Tool();
            proc = new Process();
            proc.StartInfo.FileName = @"C:\Users\igneo\Documents\SRWE_236\SRWE.exe";
            proc.StartInfo.Arguments = @"--attach=AC2-Win64-Shipping --profile=C:\Users\igneo\Documents\SRWE_236\acc.xml";
            tool.DelayedStart = 7000;
            tool.Process = proc;
            Tools.Add(tool);

            tool = new Tool();
            proc = new Process();
            proc.StartInfo.FileName = @"C:\Program Files (x86)\Fanatec\FanaLab\Control\FanaLab.exe";
            tool.Process = proc;
            Tools.Add(tool);
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
            using Process? proc = (from p in Process.GetProcessesByName(ExtractProcessNameFromPath(_appPath))
                                   where p.MainModule?.FileName == _appPath
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
