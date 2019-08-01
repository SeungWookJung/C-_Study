using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _attributes
{
    class Program
    {
        #region 외부 DLL 정의문
        [DllImport("User32.dll")]
        public static extern int MessageBox(int hParent, string Message, string Caption, int type);


        [DllImport("Kernel32.dll")]
        public static extern uint WinExec(string path, uint nCmdShow);

        #endregion

        static void Main(string[] args)
        {
            MessageBox(0, "메모장을 실행합니다", "알림", 0);
            WinExec("notepad.exe", 1);
        }
    }
}
