using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加减乘除
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入参与运算的第一个数");
            string s1 = Console.ReadLine();
            int a = GetNumber(s1);
            Console.WriteLine("请输入参与运算的第二个数");
            string s2 = Console.ReadLine();
            int b = GetNumber(s2);
            int sum1= Jia(a,b);
            int sum2 = Jian(a,b);
            int sum3 = Chen(a,b);
            double sum4 = Chu(a,b);
            Console.WriteLine("加法运算的结果是{0}，减法运算的结果是{1}，乘法运算的结果是{2}，除法运算的结果是{3}",sum1,sum2,sum3,sum4);
            Console.ReadKey();
        }
        public static int GetNumber(string s)
        {
            while (true)//死循环（使此方法必定产生返回值，不出现无返回值的异常。发生异常后直到catch内输入的值不再异常才跳出循环）
            {
                try
                {
                    int num = Convert.ToInt32(s);
                    return num;  //跳出循环
                }
                catch
                {
                    Console.WriteLine("请重新输入参与运算的数，注意输入整数");
                    s = Console.ReadLine();
                }
            }
        }
        public static int Jia(int m, int n)//加法运算
        {
            int sum = m+n;
            return sum;
        }
        public static int Jian(int m, int n)//减法运算
        {
            int sum = m-n;
            return sum;
        }
        public static int Chen(int m, int n)//乘法运算
        {
            int sum = m*n;
            return sum;
        }
        public static double Chu(int m, int n)//除法运算
        {
            double  sum = (double)m/n;
            return sum;
        }
    }
}
