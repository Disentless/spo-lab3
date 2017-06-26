using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public abstract class Converter
    {
        public class ConvertException : System.Exception
        {
            public override string ToString()
            {
                return "Ошибка конвертирования";
            }
        }

        public static int Str16ToInt(string str)
        {
            int res = 0;
            for (var i = 0; i < str.Length; ++i)
            {
                var ch = str[str.Length - i - 1];
                int p2 = (int)Math.Pow(16, i);
                if (ch >= '0' && ch <= '9')
                {
                    res += p2 * (ch - '0');
                }
                else if (ch >= 'A' && ch <= 'F')
                {
                    res += p2 * (ch - 'A' + 10);
                }
                else
                {
                    throw new ConvertException();
                }
            }
            return res;
        }
        public static int Str10ToInt(string str)
        {
            int res = 0;
            for (var i = 0; i < str.Length; ++i)
            {
                var ch = str[str.Length - i - 1];
                int p2 = (int)Math.Pow(10, i);
                if (ch >= '0' && ch <= '9')
                {
                    res += p2 * (ch - '0');
                }
                else
                {
                    throw new ConvertException();
                }
            }
            return res;
        }
        public static int Str2ToInt(string str)
        {
            int res = 0;
            for (var i = 0; i < str.Length; ++i)
            {
                var ch = str[str.Length - i - 1];
                int p2 = (int)Math.Pow(2, i);
                if (ch == '0' || ch == '1')
                {
                    res += p2 * (ch - '0');
                }
                else
                {
                    throw new ConvertException();
                }
            }
            return res;
        }
    }
}
