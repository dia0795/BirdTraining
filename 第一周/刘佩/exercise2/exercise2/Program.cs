using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九乘法表：");
            for(int j=1;j<10;j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("{0}X{1}={2} ",i,j, i * j  );
                }
                Console.WriteLine();
            }
            Console.Read();           
        }
    }
}
