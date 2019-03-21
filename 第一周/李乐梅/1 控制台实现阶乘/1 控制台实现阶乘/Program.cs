using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_控制台实现阶乘
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 请输入需要计算的阶乘的数：");
            for (; ; )
            {
                int num = int.Parse(Console.ReadLine());
                int jc = 1;
                for (int i = 1; i <= num; i++)
                {
                    jc *= i;
                }
                Console.WriteLine("阶乘的结果是：" + jc);
            }
        }
    }
}
