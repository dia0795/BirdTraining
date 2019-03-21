using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将一行数字排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int Z;
            Console.WriteLine("请你输入将要进行排序的五个数字：");
            int[] nums = new int[5];
            for (int i = 0;i<5 ; i++)
            {

                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int n=5; n > 0; n--)
            {
                for (int i = 1; i < n; i++)
                {
                    if (nums[i] < nums[i - 1])
                    {
                        Z = nums[i - 1];
                        nums[i - 1] = nums[i];//
                        nums[i] = Z;
                    }
                }
            }
         Console.WriteLine("按从小到大的顺序排列的结果为:");
         for (int j=0;j<5;j++)
            {
                Console.Write(nums[j]+" ");
            }
            Console.ReadLine();
        }
    }
}
