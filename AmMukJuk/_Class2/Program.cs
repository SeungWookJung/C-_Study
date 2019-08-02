using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class2
{

    class Human
    {
        public Human(string aName,int aAge)
        {
            Name = aName;
            Age = aAge;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("이순시", 32);
            Console.WriteLine("이름: " + human.Name + ", 나이: " + human.Age);
        }
    }
}
