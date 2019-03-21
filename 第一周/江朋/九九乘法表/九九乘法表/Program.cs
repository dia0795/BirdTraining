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
            for (int i = 1; i <10; i++)
            {
                for (int j = 1;j <i+1; j++)
                {
                    Console.Write("{0}*{1}={2}\t",j,i,j*i);
                }
                Console.WriteLine();//换行
            }
            Console.ReadKey();
        }
       
    }
}
