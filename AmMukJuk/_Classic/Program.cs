using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Classic
{
    delegate int Add(int a,int b);
    delegate int Sub(int a, int b);
    delegate int Mul(int a, int b);
    delegate int Div(int a, int b);
    delegate int dele(int a, int b);

    class Program
    {
        
        static void Main(string[] args)
        {
            dele d = null;

            d += (n1, n2) => { int result = n1 + n2; Console.WriteLine(result); return result; };
            d += (n1, n2) => { int result = n1 - n2; Console.WriteLine(result); return result; };
            d += (n1, n2) => { int result = n1 * n2; Console.WriteLine(result); return result; };
            d += (n1, n2) => { int result = n1 / n2; Console.WriteLine(result); return result; };

            //d += delegate (int a, int b) { return a + b; };

            /* Add add = delegate (int a, int b) { return a + b; };
             Sub sub = delegate (int a, int b) { return a - b; };
             Mul mul = delegate (int a, int b) { return a * b; };
             Div div = delegate (int a, int b) { return a / b; };


             Console.Write("숫자를 입력해 주세요 : ");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("숫자를 입력해 주세요 : ");
             int num2 = Convert.ToInt32(Console.ReadLine());


             Console.Write("원하는 계산을 입력하세요 (1:+.2:-,3:*,4:/) : ");
             int s = Convert.ToInt32(Console.ReadLine());

             switch (s)
             {
                 case 1:
                     Console.WriteLine(add(num1, num2));
                     break;
                 case 2:
                     Console.WriteLine(sub(num1, num2));
                     break;
                 case 3:
                     Console.WriteLine(mul(num1, num2));
                     break;
                 case 4:
                     Console.WriteLine(div(num1, num2));
                     break;
             }
             */

        }
    }
}
