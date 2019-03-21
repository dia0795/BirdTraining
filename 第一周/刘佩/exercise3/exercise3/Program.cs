using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;  
            while(true)
            { 
                Console.WriteLine("请输入第一个数：");
                try
                {
                    a = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);break;
                }                   

                Console.WriteLine("请输入第二个数：");
                try
                {
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); break;
                }

                Console.WriteLine("请选择运算方式：1.加 2.减 3.乘 4.除");
                {
                    int op=0;
                    try
                    {
                        op = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }  
                    switch(op)
                    {
                        case 1:
                            Console.WriteLine(a + "+" + b + "=" + (a + b));
                            break;
                        case 2:
                            Console.WriteLine(a + "-" + b + "=" + (a - b));
                            break;
                        case 3:
                            Console.WriteLine(a + "*" + b + "=" + (a * b));
                            break;
                        case 4:
                            Console.WriteLine(a + "/" + b + "=" + (a / b));
                            break;
                        default:
                            Console.WriteLine("请输入正确的数字");
                            break;
                    }  
                }
            }
            Console.WriteLine("输入有误！程序终止");
            Console.Read();
        }
    }
}
