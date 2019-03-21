using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用递归方法实现n的阶乘
{
    class Program
    {
        private static double forjiecheng(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * forjiecheng(n - 1);
            }
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数");
            string n = Console.ReadLine();
            double nj = forjiecheng(Convert.ToInt32(n));
            Console.WriteLine("n!="+nj);
            Console.ReadLine();
        }
    }
}
