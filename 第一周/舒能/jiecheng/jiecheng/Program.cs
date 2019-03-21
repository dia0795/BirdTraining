using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jiecheng
{
    class Program
    {
        static void Main(string[] args)
        {
            //求输入数字的阶乘

            Console.WriteLine("请输入需要计算阶乘的数");
            
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            for (int i = 1; i <= a; i++)
              {
                    b *= i;
              }
            Console.WriteLine("阶乘的结果是" + b);

            Console.ReadKey();
            
        }
    }
}
