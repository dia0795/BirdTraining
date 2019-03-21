using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台实现加减乘除计算
{
    class Program
    {
      
        public static int  Add(int x ,int  y)
        {
            return x + y;
        }
        public static int  Subtract(int  x, int  y)
        {
            return x - y;
        }
        public static int Ride(int x, int y)
        {
            return x * y;
        }
        
        public static double   Detach(int  x, int  y)
        {
            return x / y;
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("请输入将要计算的两个数：");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("随机数a和随机数b的和为：{0}", Program.Add(a, b));
                Console.WriteLine("随机数a和随机数b的差为：{0}", Program.Subtract(a, b));
                Console.WriteLine("随机数a和随机数b的积为：{0}", Program.Ride(a, b));
                Console.WriteLine("随机数a和随机数b的商为：{0}", Program.Detach(a, b));
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine("用零整除引发异常，");
            }
            catch (FormatException de)
            {
                Console.WriteLine(de.Message );
            }
            catch (OverflowException de)
            {
                Console.WriteLine(de.Message);
            }
            Console.ReadLine();
        }
    }
}
