using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("알파벳 : ", 40);

            for(char c='a';c<='z';c++)
            {
                str.Append(c);
            }
            str[10] = '_';
            Console.WriteLine(str);
        }
    }
}
