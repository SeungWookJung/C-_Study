using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ADD
{
    class Program
    {
        public static int ADD(int a,int b) { return a + b; }
        public static int SUB(int a, int b) { return a - b; }
        public static int MUL(int a, int b) { return a * b; }
        public static int DIV(int a, int b) { return a / b; }

        static void Main(string[] args)
        {
            int num1, num2;
            int o;
            Console.Write("input number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("input number2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input number(1:+, 2:-, 3:*, 4:/)");
            o = Convert.ToInt32(Console.ReadLine());

            switch(o)
            {
                case 1:
                    Console.WriteLine("Result => {0}", ADD(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Result => {0}", SUB(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Result => {0}", MUL(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Result => {0}", DIV(num1, num2));
                    break;
            }

        }
    }
}
