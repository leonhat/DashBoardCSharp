using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardCSharp.Common
{
    class Utilities
    {
        public static void SplitText(string list)
        {
            IList<String> temp = list.Split('|');
            foreach (string element in temp)
            {
                System.Console.WriteLine(element);
            }
        }
    }
}
