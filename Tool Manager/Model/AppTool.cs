using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Manager.Model
{
    public class AppTools : Collection<AppTool>
    {

    }

    public class AppTool
    {
        public string Icon { get; set; }
        public string Path { get; set; }
        public string Arguments { get; set; }
        public int DelayedStart { get; set; }

    }
}
