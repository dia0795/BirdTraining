using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一组要排序的数组：");
            char[] s = new char[] { ' ' };
            string[] arr =Console.ReadLine().Split(s);
            int[] arry1 = new int[arr.Length];
            for(int a=0;a<arr.Length;a++)
            {
                arry1[a] = Convert.ToInt32(arr[a]);
            }
            Console.WriteLine("排序结果为：");
            for(int i=0;i<arry1.Length;i++)
            {
                for(int j=0;j<=i;j++)
                    if(arry1[j]>arry1[i])
                    {
                        int temp = arry1[i];
                        arry1[i] = arry1[j];
                        arry1[j] = temp;
                    }
            }
            foreach(int b in arry1)
                Console.Write(b+" ");
            
            Console.ReadKey();

        }
    }
}
