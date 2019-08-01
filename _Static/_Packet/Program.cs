using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Packet
{
    class Archive
    {
        public delegate void SendProg(int nFile);
        public static void SendPacket(int nFile, SendProg Prog)
        {
            for(int i=0;i<nFile;i++)
            {
                Prog(i);
                System.Threading.Thread.Sleep(500);
            }
        }
    }

    class Program
    {
        public static void Progress(int nFile)
        {
            Console.WriteLine("{0}번째 패킷을 전송 중...", nFile + 1);
        }
        public static void EngProgress(int nFile)
        {
            Console.WriteLine("Now Sending{0} Packet.wait please", nFile + 1);
        }
        static void Main(string[] args)
        {
            Archive.SendPacket(10, EngProgress);
            Console.WriteLine("모든 패킷을 전송 했습니다.");
        }
    }
}
