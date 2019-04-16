using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tushuguanli
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****************图书管理系统*****************");
            Console.WriteLine("你是：\t1.学生\t2.访客");
            int d = Convert.ToInt32(Console.ReadLine());
            switch(d)
            {
                case 1:
                    new borrowbook();
                    Console.ReadLine();
                    break;
                case 2:
                    new borrowbook().chaxun();
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
