using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 阶乘
{
    class 递归阶乘
    {
        static void Main()
        {
            Console.WriteLine("请输入进行阶乘操作的最大值");
            int Max = Convert.ToInt32(Console.ReadLine());
            Digui(Max);//递归方法，自己调用自己
            Console.ReadKey();
        }
        public static int gross = 1, i = 1;//定义全局变量
        public static void Digui(int max)
        { 
            if (i>max)
            {
                Console.WriteLine("执行阶乘操作后的结果为{0}。", gross);
                return;
            }
            gross = gross * i;
            i++;
            Digui(max);//递归方法，自己调用自己
        }

    }
}
