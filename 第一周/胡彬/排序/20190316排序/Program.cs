using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190316排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            int i,j,small;

            Console.WriteLine("----------------------");
            Console.WriteLine("请输入数组的长度：");
            Console.WriteLine("----------------------");
            int length = Convert.ToInt32(Console.ReadLine());

            num = new int[length];

            for (i = 0; i < length; i++)
            {
                Console.Write("请输入第{0}个数组的值：", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0,small=num[0]; i < length; i++)
                for (j = i; j < length; j++)
                {
                    if (num[i] > num[j])
                    {
                        small = num[j]; num[j] = num[i];num[i] = small;
                    }//若后面的数字较小，则交换位置
                };

            Console.WriteLine("----------------------");
            Console.WriteLine("从小到大的顺序为:");
            Console.WriteLine("----------------------");
            for (i = 0; i < length; i++)
            {
                Console.Write("{0}<",num[i]);             
            }

            Console.ReadKey();
        }
    }
}
