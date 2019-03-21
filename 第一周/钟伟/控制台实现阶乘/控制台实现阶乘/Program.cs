using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台实现阶乘
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入n");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            if(n==0)
            {
                Console.WriteLine(n+"的阶乘是" + 1);
            }
            for (int i = 1; i <= n; i++)
                m *= i;
            Console.WriteLine(n+"的阶乘是"+m);
            Console.ReadLine();
        }
    }
}
