using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190316输出乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            for (num1 = 1; num1 <=9; num1++)
                for (num2 = 1; num2 <=num1; num2++)
                {
                    Console.Write("{0}*{1}={2}", num1, num2,num1 * num2);//Console.Wrightline会自动换行

                   if (num2 < num1)
                        Console.Write("\t"); //跳一个空格
                    else
                        Console.Write("\n"); //换行             
                }
            Console.ReadKey();
        }
    }
}
