using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public abstract class FlashReader
    {
        public static string ReadFlash(Dictionary<int,int> mem)
        {
            var str = "";
            foreach (var pair in mem)
            {
                str += pair.Key.ToString() + " : " + pair.Value.ToString() + "\n";
            }
            return str;
        }
    }
}
