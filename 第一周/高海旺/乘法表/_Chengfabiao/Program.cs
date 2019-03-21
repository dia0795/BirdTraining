using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Chengfabiao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------九九乘法表----------------------------");
            for(int i=1;i<=9;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write("{0}×{1}={2}\t",j,i,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
