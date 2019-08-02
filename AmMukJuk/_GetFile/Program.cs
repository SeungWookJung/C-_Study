using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _GetFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var Files = from f in Directory.GetFiles("C://Users/User/Documents/C-_Study/AmMukJuk/_GetFile") select f;
           
            foreach (var f in Files)
            {
                Console.WriteLine("Name : " + f);
            }
        }
    }
}
