using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str = "123456789";
            Console.WriteLine("최초 : " + str);

            str = str.Insert(3, "abcd");
            Console.WriteLine("삽입 : " + str);

            str = str.Remove(5, 4);
            Console.WriteLine("삭제 : " + str);

            str = str.Replace('8', '팔');
            Console.WriteLine("대체 : " + str);*/

            string str = "알파벳 : ";
            for(char c ='a';c<='z';c++)
            {
                str += c;
            }
            Console.WriteLine(str);
        }
    }
}
