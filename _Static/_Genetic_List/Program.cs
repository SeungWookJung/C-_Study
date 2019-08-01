using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Genetic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i=0;i<5;i++)
            {
                list.Add(i);
            }
            foreach(int a in list)
            {
                Console.WriteLine("{0}",a);
            }
            Console.WriteLine();
            list.RemoveAt(2);
            
        }
    }
}
