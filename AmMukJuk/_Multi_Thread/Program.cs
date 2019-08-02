﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _Multi_Thread
{
    class Program
    {
        static void ThreadProc()
        {
            for (int i = 0; i <10 ; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Console.WriteLine("작업 쓰레드 종료");
        }
        static void Main(string[] args)
        {
            Thread T = new Thread(new ThreadStart(ThreadProc));
            T.Start();
            for(; ; )
            {
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if(cki.Key == ConsoleKey.A)
                {
                    Console.Beep();
                }
                if(cki.Key == ConsoleKey.B)
                {
                    break;
                }
            }
            Console.WriteLine("주스레드 종료");

        }
    }
}
