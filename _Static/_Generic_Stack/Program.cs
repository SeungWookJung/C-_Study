using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            for(int i=0;i<6;i++)
            {
                stack.Push(i);
            }
            while(stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
