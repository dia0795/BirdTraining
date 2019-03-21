using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_控制台实现加减乘除运算
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数：");
            
            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = num1 + num2;
                int num4 = num1 - num2;
                int num5 = num1 * num2;
                int num6 = num1 / num2;
                Console.WriteLine("相加得："+num3);
                Console.WriteLine("相减得："+num4);
                Console.WriteLine("相乘得："+num5);
                Console.WriteLine("相除得："+num6);
            }
            catch (OverflowException)
            {
                Console.WriteLine("溢出异常");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("除零异常");
                Console.WriteLine(ex.Message);
            }
            catch(FormatException)
            {
                Console.WriteLine("转换异常");
            }
            finally
            {
                Console.WriteLine("程序执行完毕");
            }
            Console.ReadLine();
        }
    }
}
