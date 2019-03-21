using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入需要排序的整数数组：");

            string str = Console.ReadLine();
            char[] sp = { ' ' };
            string[] strArray = str.Split(sp, StringSplitOptions.RemoveEmptyEntries);

            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(strArray[i]);
            }
            //冒泡排序
            for (var i = 0; i < intArray.Length - 1; i++)
            {
                for (var j = 0; j < intArray.Length - 1 - i; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {    
                        var temp = intArray[j + 1];
                        intArray[j + 1] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            Console.Write("数组从小到大排序为：");
            for(int i=0;i<intArray.Length;i++)
            {
                Console.Write(intArray[i] + " ");
            }

            Console.Read();
        }
    }
}
