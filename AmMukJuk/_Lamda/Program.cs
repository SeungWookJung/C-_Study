using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lamda
{
    delegate int dele(int a);
    class Program
    {
        static void Main(string[] args)
        {
            //람다 1
            /*dele d2 =Add;*/

            //람다 2
            /*dele d = delegate(int a) { return a + 1; };
            int k = d(3);
            Console.WriteLine("k = " + k);
            */

            //람다 3
            dele d = (a => a + 1);
            int k = d(3);
            Console.WriteLine("k = " + k);
        }
    }
}
