using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _JCdigui
{
    class JC
    {
      public static int F(int n)
        {
            if (n == 0)
                return 1;
            return n * F(n - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要计算的阶乘数：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("计算结果为："+JC.F(n));
            Console.ReadKey();
        }
    }
}
