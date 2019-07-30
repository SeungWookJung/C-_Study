using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using A;

namespace A
{
    class MyClass { int i; }
}

namespace B
{
    class MyClass { double j; }
}

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            A.MyClass objA = new MyClass();
            B.MyClass objB = new B.MyClass();

            Console.WriteLine(objA.ToString());
            Console.WriteLine(objB.ToString());

            System.Int32 num = 3;*/

            int i = 1234;
            object box = i;
            Console.WriteLine(box);
            int j = (int)box;
            Console.WriteLine(j);

            double d = 3.14;
            object box1 = d;
            Console.WriteLine(box1);
            int d1 = (int)box1;
            Console.WriteLine(d1);

        }
    }
}
