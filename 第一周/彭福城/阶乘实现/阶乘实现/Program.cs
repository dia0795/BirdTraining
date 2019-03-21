using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 阶乘实现
{
    class Program
    {
        public static int result = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("请用户输入一个自然数");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int number=IsNaturalNumber(n);
                    Console.WriteLine("用户输入正确");
                    Console.WriteLine("这个{0}数的阶乘是{1}", number, Mul(number));
                    break;
                }
                catch
                {
                    Console.WriteLine("您输入的内容有误，请重新输入");                  
                }
            }                        
            Console.ReadKey();

        }
        public static int Mul(int i)
        {
            for (; i >0; )
            {
              return i*Mul(--i) ;//i--是不行的，会造成无限递归，因为这是先传参再自减
            }
            return 1;                               
        }
        public static int IsNaturalNumber(int n)
        {
            while (true)
            {
                if (n >= 0)
                {
                    return n;
                }
                else if (n<0)
                {
                    Console.WriteLine("您输入的数为负数，没有定义的阶乘，请重新输入");
                    while (true)
                    {
                        try
                        {
                            n = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("您输入的内容有误，请重新输入");
                            Console.WriteLine("请用户输入一个自然数");
                        }
                    }
                }               
           
               
            }
        }



    }
}
