using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            int i = 0;
            int sum = 0;
            while(i<100)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("1부터 99 까지의 합 = {0}", sum);


            //do ~ while
            /*string snum;
            int num;
            do
            {
                Console.Write("숫자를 입력하세요(끝은 0)");
                snum = Console.ReadLine();
                num = Convert.ToInt32(snum);
                Console.WriteLine("입력한 값은 {0} 입니다.", num);

            } while (num != 0);*/


            //for
            /*for(int i=2;i<=9;i++)
            {
                for(int j=1;j<=9;j++)
                {
                    Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                }
                Console.WriteLine();
            }
            */


            //foreach
            /*int[] ar = { 33, 22, 11, 99, 88 };
            int max = 0;

            foreach(int a in ar)
            {
                if (max < a)
                    max = a;
            }
            Console.WriteLine("가장 큰값은 {0}", max);
            */
        }
    }
}
