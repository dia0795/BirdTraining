using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 阶乘
{
    class For阶乘
    {
        static void Main(string[] args)
        {
            int sum=1;
            Console.WriteLine("请输入你所要进行阶乘操作的最大值");
            //string Max =Console.ReadLine();
            int Max = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<= Max; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("阶乘操作完成后的结果为{0}。",sum);
            Console.ReadKey();
        }
    }
}
