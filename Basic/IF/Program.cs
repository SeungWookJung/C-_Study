using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 27;
            if (i % 2 == 0)
                Console.WriteLine("i는 짝수입니다.");
            else
                Console.WriteLine("i는 홀수입니다.");
                */

            int i = 5;
            switch(i)
            {
                case 1:
                    Console.WriteLine("하나");
                    break;
                case 2:
                    Console.WriteLine("둘");
                    break;
                case 3:
                    Console.WriteLine("셋");
                    break;
                case 4:
                    Console.WriteLine("넷");
                    break;
                case 5:
                    Console.WriteLine("다섯");
                    break;
                default:
                    Console.WriteLine("그외");
                    break;
            }

            string s = "둘";
            switch(s)
            {
                case "하나":
                    Console.WriteLine(1);
                    break;
                case "둘":
                    Console.WriteLine(2);
                    break;
                case "셋":
                    Console.WriteLine(3);
                    break;
                case "넷":
                    Console.WriteLine(4);
                    break;
                case "다섯":
                    Console.WriteLine(5);
                    break;
                default:
                    Console.WriteLine("그외");
                    break;
            }
        }
    }
}
