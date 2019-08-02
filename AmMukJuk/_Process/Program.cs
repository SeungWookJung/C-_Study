using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace _Process
{
    class Program
    {
        static void Main()
        {
            Process Proc = Process.Start("mspaint.exe");
            Thread.Sleep(5000);
            Proc.Kill();
        }
    }
}
