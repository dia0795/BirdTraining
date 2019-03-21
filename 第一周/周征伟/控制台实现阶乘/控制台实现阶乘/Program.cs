using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台实现阶乘
{
    class Program
    { 
        static void Main(string[] args)
        {
        double  S = 1;
        int Z = int.Parse(Console.ReadLine());
        for (int i = Z ; i > 1; i--)
        {
                S *= i;
         }
            Console.WriteLine("{0}的阶乘为：{1}",Z , S);
            Console.ReadKey();
        }
        
    }
}
