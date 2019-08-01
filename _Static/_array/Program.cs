using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _array
{
    delegate int IntCalc(int a, int b);

    class Program
    {
        public static int ADD(int a, int b) { return a + b; }
        public static int SUB(int a, int b) { return a - b; }
        public static int MUL(int a, int b) { return a * b; }
        public static int DIV(int a, int b) { return a / b; }


        static void Main(string[] args)
        {
            IntCalc[] arCalc = {ADD,SUB,MUL,DIV };
            int num1, num2;
            int o;

            Console.Write("input number1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("input number2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input number (1:+,2:-,3:*,4:/)");
            o= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result => {0}", arCalc[o - 1](num1, num2));
        }
    }
}
