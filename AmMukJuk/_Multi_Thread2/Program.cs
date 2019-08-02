using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _Multi_Thread2
{
    class Program
    {
        static void ThreadProc(object count)
        {
            for (int i = 0; i < (int)count; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Console.WriteLine("작업 쓰레드 종료");
        }
        static void Main(string[] args)
        {
            Thread T = new Thread(new ParameterizedThreadStart(ThreadProc));
            T.Start(5);
            for (; ; )
            {
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.A)
                {
                    Console.Beep();
                }
                if (cki.Key == ConsoleKey.B)
                {
                    break;
                }
            }
            Console.WriteLine("주스레드 종료");

        }
    }
}
