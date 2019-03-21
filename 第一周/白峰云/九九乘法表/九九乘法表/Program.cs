using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九乘法表");
            for (int i = 1; i <= 9; i++) //先建立一个外循环
            {
                for (int j = 1; j <= i; j++)//然后建立一个内循环
                {
                    Console.Write(j+"*"+i+"="+i*j+ "\t");  //循环计算值并且显示在同一行\t为在两次循环中加入空格字符 
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
