using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Generic_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            for(int i = 1; i< 6; i++)
            {
                queue.Enqueue(i);
            }
            while(queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());
            }
           
        }
    }
}
