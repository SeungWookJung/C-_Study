﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Packet2
{
    class Archive
    {
        public delegate bool SendingProg(int nFile);
        public static bool SendPacket(int nFiles,SendingProg Prog)
        {
            for(int i=0;i<nFiles;i++)
            {
                if(Prog(i) == false)
                {
                    return false;
                }
                System.Threading.Thread.Sleep(500);
            }
            return true;
        }
    }

    class Program
    {
        public static bool Progress(int nFile)
        {
            Console.WriteLine("{0} 번째 패킷 전송중...(취소시 ESC)", nFile + 1);

            if(Console.KeyAvailable)
            {
                ConsoleKeyInfo cki;
                cki = Console.ReadKey(false);
                if(cki.Key == ConsoleKey.Escape)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            if(Archive.SendPacket(10,Progress) == true)
            {
                Console.WriteLine("모든 패킷을 전송했습니다");
            }
            else
            {
                Console.WriteLine("취소되었습니다.");
            }

        }
    }
}
