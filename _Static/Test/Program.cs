using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int j;

            unsafe
            {
                int* pi;
                pi = &i;
                j = *pi;
            }
            Console.WriteLine("i={0},j={0}", i, j);

            int[] ar = {1,2,3,4,5 };

            unsafe
            {
                fixed(int* pi = &ar[0])
                {
                    for (int k = 0; k < 5; k++)
                    {
                        Console.WriteLine(pi[k]);
                    }
                }
            }
        }
    }
}
