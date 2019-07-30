using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A
{
    class MyClass {  }
}

namespace B
{
    class MyClass {  }
}

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            
            A.MyClass objA = new A.MyClass();
            B.MyClass objB = new B.MyClass();


            Console.WriteLine(objA.ToString());
            Console.WriteLine(objB.ToString());

            //System.Int32 num = 3;

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
