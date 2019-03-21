using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数字排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入需要排序的数的个数");
            //int n = Convert.ToInt32(Console.ReadLine ());
            char[] ch = new char[]{' '};
            Console.WriteLine("请输入各个进行排序的数");
            string[] number = Console.ReadLine().Split(ch); //将输入的字符串修剪成数组
            int[] nums = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                nums[i] = Convert.ToInt32(number[i]);
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int a = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = a;
                    }
                }
            }
            Console.WriteLine("数从小到大的排序为");
            //Console.Read();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("数的从大到小排序为");
            //Console.Read();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
    
