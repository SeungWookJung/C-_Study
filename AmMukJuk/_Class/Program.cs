using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class
{

    class Human
    {
        public string Name { get; set; }
        public int age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Human human = new Human();
            human.Name = "장길산";
            human.age = 32;
            Console.WriteLine("이름 : " + human.Name + ", 나이 : " + human.age);
            */

            Human human = new Human { Name = "정승욱", age = 25 };
            Console.WriteLine("이름 : " + human.Name + ", 나이 : " + human.age);
        }
    }
}
