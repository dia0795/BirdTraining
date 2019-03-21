using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡法排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = new int[] { 2, 1, 3, 5, 4, 6 };
            for (int i = 0; i < arry.Length - 1; i++)
            {
                for(int j=0;j<arry.Length-1-i;j++)
                {
                    if(arry[j+1]<arry[j])
                    {
                        int temp = arry[j + 1];
                        arry[j + 1] = arry[j];
                        arry[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(arry[i]);
            }
            Console.ReadKey();


        }
    }
}
