using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student b;
            b.Name = "홍길동";
            b.StNum = 902252;
            Console.WriteLine("{0}, {1}", b.Name, b.StNum);*/

            Student b = new Student("홍길동", 902521);
            b.OutInfo();
        }
    }

    struct Student
    {
        public string Name;
        public int StNum;
        public Student(string aName,int aStNum)
        {
            Name = aName;
            StNum = aStNum;
        }
        public void OutInfo()
        {
            Console.WriteLine(Name + ", " + StNum);

            return;
        }
    }
}
