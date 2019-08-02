using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_DLL;

namespace Calc_Exe
{

    class IntDoubleCalc:Class1
    {
        public static double AddD(double a, double b) { return a + b; }
        public static double SubD(double a, double b) { return a - b; }
        public static double MulD(double a, double b) { return a * b; }
        public static double DivD(double a, double b) { return a / b; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20, num2 = 50;
            int result = 0;
            result = Class1.Add(num1, num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);

            result = Class1.Sub(num1, num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);

            result = Class1.Mul(num1, num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);

            result = Class1.Div(num1, num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);


            double Dnum1 = 3.14, Dnum2 = 3.14;
            double result2 = 0;
            result2 = IntDoubleCalc.AddD(Dnum1, Dnum2);
            Console.WriteLine("{0} + {1} = {2}", Dnum1, Dnum2, result2);

            result2 = IntDoubleCalc.SubD(Dnum1, Dnum2);
            Console.WriteLine("{0} - {1} = {2}", Dnum1, Dnum2, result2);

            result2 = IntDoubleCalc.MulD(Dnum1, Dnum2);
            Console.WriteLine("{0} * {1} = {2}", Dnum1, Dnum2, result2);

            result2 = IntDoubleCalc.DivD(Dnum1, Dnum2);
            Console.WriteLine("{0} / {1} = {2}", Dnum1, Dnum2, result2);



        }
    }
}
