using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jiajianchengchu
{
    class Program
    {
        //加法运算
        static void Add(int a, int b)
        {
            try
            {
                Console.WriteLine("两个数相加的结果是：{0}+{1}={2}", a, b, a + b);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("引发overflowException异常"+ex.Message.ToString());
            }
            
        }
        //减法运算
        static void Sub(int a, int b)
        {
            Console.WriteLine("两个数相减的结果是：{0}-{1}={2}", a, b, a - b);
        }
        //乘法运算
        static void Mul(int a, int b)
        {
            try
            {
                Console.WriteLine("两个数相乘的结果是：{0}*{1}={2}", a, b, a * b);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("引发overflowException异常" + ex.Message.ToString());
            }

        }
        //除法运算
        static void Div(int a, int b)
        {
            try
            {
                Console.WriteLine("两个数相除的结果是：{0}/{1}={2}", a, b, a / b);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("引发DivideByZeroException异常\n" + ex.Message.ToString());

                Console.WriteLine("除数不能为零！" + " " + "两个数相除的结果不能给你！");

            }
            catch(Exception ex)
            {

            }

        }
        static void Main(string[] args)
        {
            int a;int b;
            Console.WriteLine("请输入第一个数：");
            a = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("请输入第二个数：");
            b = Convert.ToInt32((Console.ReadLine()));

            Add(a,b);
            Sub(a,b);
            Mul(a,b);
            Div(a,b);

            Console.ReadLine();
        }
    }
}
