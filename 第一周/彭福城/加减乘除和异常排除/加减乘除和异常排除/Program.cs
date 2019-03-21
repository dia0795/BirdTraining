using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加减乘除和异常排除
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("请用户输入两个数字来进行下面的四则运算");
                     n1 = Convert.ToDouble(Console.ReadLine());
                     n2 = Convert.ToDouble(Console.ReadLine());
                    while (n2 == 0)
                    {
                        Console.WriteLine("分母不能为零，请用户重新输入");
                        n2 = Convert.ToDouble(Console.ReadLine() );                  
                    }
                   
                    break;
                }
                catch
                {
                    Console.WriteLine("输入的数字有误，请重新输入");
                }
            }
            Console.WriteLine("用户进行的加法运算结果是");
            Console.WriteLine("{0}+{1}={2}", n1, n2, Add(n1,n2));
            Console.WriteLine("用户进行的减法运算结果是");
            Console.WriteLine("{0}-{1}={2}", n1, n2, Sub(n1, n2));
            Console.WriteLine("用户进行的乘法运算结果是");
            Console.WriteLine("{0}*{1}={2}", n1, n2, Mul(n1, n2));
            Console.WriteLine("用户进行的除法运算结果是");
            Console.WriteLine("{0}/{1}={2}", n1, n2, Div(n1, n2));
            Console.ReadKey();

        }
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Sub(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Mul(double n1, double n2)
        {
            return n1 *n2;
        }
        public static double Div(double n1, double n2)
        {
            return n1 /n2;
        }
    }
}
