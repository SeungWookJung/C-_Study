using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = "문자열";

            Console.WriteLine(str);

            string str2;
            str2 = "C# String";

            Console.WriteLine(str2);

            string str3;
            str3 = str + str2;

            Console.WriteLine(str3);
        }
    }
}
