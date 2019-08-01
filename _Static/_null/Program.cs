using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _null
{
    class Program
    {
        static void Main(string[] args)
        {
            int? age;
            age = null;
            if (age.HasValue)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("알수없는 나이");
            }
        }
    }
}
