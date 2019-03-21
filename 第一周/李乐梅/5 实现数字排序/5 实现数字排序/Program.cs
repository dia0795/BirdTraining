using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_实现数字排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要排序得10个数字：");
            int[] myintArray =new int[10];
            for (int i = 0; i < myintArray.Length; i++)
            {
                myintArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("您输入的数字为：");
            foreach(int outint in myintArray)
                Console.Write(outint+"\t");
            Console.WriteLine();
            //利用Sort实现升序排列
            Console.WriteLine("Sort实现升序后：");
            Array.Sort(myintArray);
            foreach (int outint in myintArray)
                Console.Write(outint + "\t");
            Console.WriteLine();
            //利用Reverse实现降序
            Console.WriteLine("Reverse实现降序后：");
            Array.Reverse(myintArray);
            foreach(int outint in myintArray)
                Console.Write(outint+"\t");
            Console.WriteLine();
            //使用冒泡排序法
            //冒泡升序
            Console.WriteLine("冒泡实现升序后：");
            for (int i = 0; i < myintArray.Length - 1; i++)
            {
                int temp = 0;
                for (int j = 0; j < myintArray.Length - 1 - i; j++)
                {
                    if (myintArray[j] > myintArray[j + 1])
                    {
                        temp = myintArray[j + 1];
                        myintArray[j + 1] = myintArray[j];
                        myintArray[j] = temp;
                    }
                }
            }
            foreach (int outint in myintArray)
                Console.Write(outint + "\t");
            Console.WriteLine();
            //冒泡降序
            Console.WriteLine("冒泡实现降序后：");
            for (int i = 0; i < myintArray.Length - 1; i++)
            {
                int temp = 0;
                for (int j = 0; j < myintArray.Length - 1 - i; j++)
                {
                    if (myintArray[j] < myintArray[j + 1])
                    {
                        temp = myintArray[j + 1];
                        myintArray[j + 1] = myintArray[j];
                        myintArray[j] = temp;
                    }
                }
            }
            foreach (int outint in myintArray)
                Console.Write(outint + "\t");
            Console.ReadLine();
        }
    }
}
