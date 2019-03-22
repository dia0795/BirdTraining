using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190316加减乘除运算
{
    class Program
    {
        static void Main(string[] args)
        {
            Double  sum, subtruct, multiply, divide;
            int flag=0;
            Console.WriteLine("-----------------------------");
            Console.Write("输入第一个数：");
            string strNum1 = Console.ReadLine();
            Double  num1 = Double.Parse(strNum1);//输入数字后进行转换
            Console.WriteLine("-----------------------------");
            Console.Write("输入第二个数：");
            string strNum2 = Console.ReadLine();
            Double  num2 = Double.Parse(strNum2);//输入数字后进行转换
            sum = num1 + num2;
            subtruct = num1 - num2;
            multiply = num1 * num2;
            if (num2 == 0)
            {
                flag = 1;
                divide = 0;
            }
            else
                divide = num1 / num2;
            if (flag == 0)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("您输入的两个数对应加减乘除运算结果为：");
                Console.WriteLine("{0}+{1}={2},{0}-{1}={3},{0}*{1}={4},{0}/{1}={5}", num1, num2, sum, subtruct, multiply, divide);
            }
            else
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("您输入的两个数对应加减乘除运算结果为：");
                Console.WriteLine("{0}+{1}={2},{0}-{1}={3},{0}*{1}={4}", num1, num2, sum, subtruct, multiply);
                Console.WriteLine("除法计算错误！除数不能为0噢，小可爱o((≧▽≦o)");
            }
            Console.ReadKey();
        }
    }
}
