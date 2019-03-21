using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paixu
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int[] array =new int[10];
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine("请输入第"+(i+1)+"个数：");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("排序前的结果为:");
            foreach (int a in array)
               Console.Write(a+" "); 
            Console.WriteLine();

            for (int i = 0; i < array.Length;i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        min = array[i];
                        array[i] = array[j];
                        array[j] = min;
                    }
                }
            }
            
            Console.WriteLine("排序后的结果为：");
            foreach (int b in array)
                Console.Write(b + " ");

            Console.ReadLine();
        }
    }
}
