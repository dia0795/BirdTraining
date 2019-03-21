using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _jiecheng
{
    public class Yunshuan
    {
        public static void  JC(ref int number)
        {
            
            Console.WriteLine("请输入一个整数：");
            number = Convert.ToInt32(Console.ReadLine());
            int n = number;
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                k *= i;
            }
            Console.WriteLine("{0}的阶乘为{1}",n,k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int val = 1;
            Yunshuan.JC(ref val);
            Console.ReadKey();
        }
    }
}
