using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t九九乘法口诀表");
            for (int i = 1; i <=9; i++)
            {
                for (int j = 1; j <=i ; j++)
                {
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
