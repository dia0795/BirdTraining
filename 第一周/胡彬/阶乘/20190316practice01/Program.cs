using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190316practice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("请输入一个非负整数,我将为您求它的阶乘!");
            Console.WriteLine("-------------------------------");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2,result;
            for (result= 1,num2=1;num2 <= num1; num2++) result= num2 * result;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("!{0}={1}",num1,result);        
            Console.ReadKey();
        }
    }
}
