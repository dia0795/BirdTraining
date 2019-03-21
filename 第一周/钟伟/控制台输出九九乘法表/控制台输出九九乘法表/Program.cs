using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台输出九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int H = 1; H < 10; H++)
            {
                for (int L = 1; L <= H; L++)
                {
                    Console.Write("{0}*{1}={2} ", L, H, L * H);
                }
                Console.WriteLine();
            }
            Console.ReadLine();



        }
    }
}
