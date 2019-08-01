using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Event
{
    delegate void Notice();
    class Message
    {
        public void SendComplete()
        {
            Console.WriteLine("모두 전송했습니다");
        }
    }
    class Sender
    {
        public event Notice onComplete;
        public void Send()
        {
            for(int i=0;i<100;i+=10)
            {
                Console.WriteLine(i + "% 전송중");
                System.Threading.Thread.Sleep(200);
            }
            if(onComplete != null)
            {
                onComplete();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message();
            Sender s = new Sender();
            s.onComplete += m.SendComplete;
            s.Send();
        }
    }
}
