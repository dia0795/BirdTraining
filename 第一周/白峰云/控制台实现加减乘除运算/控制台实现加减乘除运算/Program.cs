using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台实现加减乘除运算
{
    class Program
    {
        static void add(int x,int y)
        {
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);//分别在这个类下面建立4个加减乘除的函数
        }
        static void sub(int x, int y)
        {
            Console.WriteLine("{0}-{1}={2}", x, y, x -y);
        }
        static void mul(int x, int y)
        {
            Console.WriteLine("{0}*{1}={2}", x, y, x * y);
        }
        static void div(int x, int y)//由于被除数不能为零，所以用trycatch指令来显示异常当为零时报错
        {
            try
            {
                Console.WriteLine("{0}/{1}={2}", x, y, x / y);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("输入有误" + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            int x;int y;
            Console.Write("请输入第一个数");
            x = Convert.ToInt32(Console.ReadLine());//把键盘输入的数据转换格式赋值给x
            Console.Write("请输入第二个数");
            y = Convert.ToInt32(Console.ReadLine());
            add(x, y);
            sub(x, y);
            mul(x, y);
            div(x, y);
            Console.ReadLine();
        }
    }
}
