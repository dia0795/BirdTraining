using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("将十个数存入数组中，然后冒泡排序");
            double[] c = new double[10] { 2, 3, 5, 7,12, 28, 77, 23, 17, 99 };
            int i, j;
            double m;
            for( i=0;i<10;++i)
            {
                for( j=0;j<10-i-1;++j)
                {
                    if(c[j]>c[j+1])
                    {
                        m =c[j];
                        c[j] = c[j+1];
                        c[j+1] = m;
                    }
                }
                
            }
            Console.Write("10个数冒泡排序后（按从小到大的顺序）为：");
            foreach(double var in c)
            {
                Console.Write(var);
                Console.Write("\t");
            }
            Console.ReadKey();
        }
    }
}
