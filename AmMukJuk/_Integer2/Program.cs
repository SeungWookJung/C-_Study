using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Integer2
{
    public class Integer
    {
        public int a;
        public Integer(int aa) { a = aa; }
        public int Add(int b) { return a + b; }
        public int Mul(int b) { return a * b; }
    }
    public static class IntegerExt
    {

        public static int sub(this Integer I, int b) { return I.a - b; }
        public static int Div(this Integer I, int b) { return I.a / b; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Integer integer = new Integer(10);
            Console.WriteLine("덧셈 : " + integer.Add(5));
            Console.WriteLine("뺄셈 : " + integer.sub(5));
            Console.WriteLine("곱셈 : " + integer.Mul(5));
            Console.WriteLine("나눗셈 : " + integer.Div(5));

        }
    }
}
