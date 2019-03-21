using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static int factorial(int val)
        {
            if(val==0)
            {
                return 1;
            }
            else if(val>=1)
            {
                return val*factorial(--val);
            }
            else
            {
                Console.WriteLine("您输入了负数！");
                return 0;
            }         
        }
        static void Main(string[] args)
        {
            Console.WriteLine("计算阶乘");
            while (true)
            {
                Console.WriteLine("请输入大于零的整数:");
                int val = int.Parse(Console.ReadLine());
                if(factorial(val)!=0)
                    Console.WriteLine("{0}!的值为:{1}", val, factorial(val));
            }            
        }
    }
}
