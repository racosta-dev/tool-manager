using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Manager.Core.Util
{
    public class StringUtil
    {
        public static string ExtractProcessNameFromPath(string path)
        {
            int startIndex = path.LastIndexOf('\\') + 1;
            int endIndex = path.LastIndexOf('.');

            return path[startIndex..endIndex];
        }
    }
}
