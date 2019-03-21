using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序数字
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = new double[50];
            int t =0;
            Console.WriteLine("请用户输入一个50个数字之内的数组,以3.14作为结束输入");
            while(true)
            {
                try
                {
                    n[t] = Convert.ToDouble(Console.ReadLine());
                    while (n[t] != 3.14)//元素下标t必须为正整数或零去声明在使用；数组内的初值都为0；
                    {
                        t++;
                        n[t] = Convert.ToDouble(Console.ReadLine());

                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("用户输入的数字有误，请重新输入");
                }
            }
           
           
            for (int i = 1; i <=t; i++)
            {
                for (int j = 0; j <(t-i); j++)
                {
                    if (n[j] < n[j + 1])
                    {
                        double temp = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("数组冒泡排序的降序的结果如下");
            for (int i = 0; i <t ; i++)
            {             
                Console.Write("{0}\t",n[i]);
            }
            for (int i = 1; i <= t; i++)
            {
                for (int j = 0; j < (t - i); j++)
                {
                    if (n[j] >n[j + 1])
                    {
                        double temp = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("数组冒泡排序的升序序的结果如下");
            for (int i = 0; i < t; i++)
            {              
                Console.Write("{0}\t", n[i]);
            }
            Console.ReadKey();
        }
    }
}
