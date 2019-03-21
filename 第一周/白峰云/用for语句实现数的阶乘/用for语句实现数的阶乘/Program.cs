using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用for语句实现数的阶乘
{
    class Program
    {
        private static double forjiecheng(int n)//定义一个静态函数
        { double result = 1;
            for (int i=1;i<=n;i++)//赋值i等于1当i<=n时，执行下面的语句，并且把i的数加一
            {
                result = result * i;//把result和i的乘积赋值给result
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数：");
            string n = Console.ReadLine();//获取键盘上输入的值
            double nj = forjiecheng(Convert.ToInt32(n));//convert，toint32是一个显示类型转换
            Console.WriteLine("n!=" + nj);
            Console.ReadLine();
     }
        }
    }
