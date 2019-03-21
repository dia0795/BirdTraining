using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _加减乘除计算
{
    interface IArithmetic
    {
        double Operation(double a, double b);
    }
    class Add:IArithmetic
        {
           public double Operation(double a, double b)
            {
                return (a + b);
            } 
        }
        class Subtract : IArithmetic
        {
           public double Operation(double a, double b)
            {
               return(a-b);
            }
        }
    class Multiply:IArithmetic
    {
       public double Operation(double a,double b)
        {
            return (a * b);
        }
    }
    class Divide:IArithmetic
    {
        public double Operation(double a,double b)
        {
            try
            {
                if (b==0)
                { throw new DivideByZeroException(); }
                return (a / b);
            }
            catch(Exception ex)
            {
                Console.WriteLine("不能除以零！！！");
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数a：");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入数b：");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("计算结果为：");
            IArithmetic Add = new Add();
            Console.WriteLine("{0}+{1}={2}", a, b, Add.Operation(a, b));
            IArithmetic Subtract = new Subtract();
            Console.WriteLine("{0}-{1}={2}", a, b, Subtract.Operation(a, b));
            IArithmetic Multiply = new Multiply();
            Console.WriteLine("{0}×{1}={2}", a, b, Multiply.Operation(a, b));
            IArithmetic Divide = new Divide();
            Console.WriteLine("{0}÷{1}={2}", a, b, Divide.Operation(a, b));
            Console.ReadKey();

        }
    }
}
