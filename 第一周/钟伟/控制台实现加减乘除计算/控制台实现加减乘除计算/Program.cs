using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台实现加减乘除计算
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            double b = Convert.ToDouble(Console.ReadLine());
            //if (b == 0)
            //{
            //    Console.WriteLine("请再输入一个非零数");
            //    double c = Convert.ToDouble(Console.ReadLine());
            //}
            double H = a + b;
            Console.WriteLine("{0}+{1}={2}", a, b, H);
            double C = a - b;
            Console.WriteLine("{0}-{1}={2}", a, b, C);
            double J = a * b;
            Console.WriteLine("{0}*{1}={2}", a, b, J);

            try
            {
                if (b == 0)
                    Console.WriteLine("");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                double S = a / b;
                Console.WriteLine("{0}/{1}={2}", a, b, S);

            }
            Console.ReadLine();
        }
    }
}
