using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Management_System
{
    class Libarary
    {
        /// <summary>
        /// 创建货架
        /// </summary>
        WareHouse wh = new WareHouse();
        /// <summary>
        /// 创建图书馆对象时，给货架加书
        /// </summary>
        public Libarary()
        {
            wh.JinBook("Literature", 300);
            wh.JinBook("Engineering", 300);
            wh.JinBook("Art", 200);
            wh.JinBook("OldBook", 100);
            wh.JinBook("Magazine", 300);

        }

        public void AskingLoan()
        {
            Console.WriteLine("请问您需要借什么书");
            Console.WriteLine("我们这里有Literature，Engineering，Art,OldBook，Magazine书籍");
            string strTyper = Console.ReadLine();
            Console.WriteLine("请问您需要几本书");
            int count = Convert.ToInt32(Console.ReadLine());
            Book[] books = wh.LoanBook(strTyper, count);
            Console.WriteLine("借书的清单如下");
            foreach (var item in books)
            {
                Console.WriteLine("书的名称是{0}，\t书的编号是{1},\t书的单价是{2}",item.BookName,item.SerialNumbers,item.Price);
            }
        }

        public void AskingReturn()
        {
            Console.WriteLine("请问您需要还什么书");
            Console.WriteLine("我们这里有Literature，Engineering，Art,OldBook，Magazine书籍");
            string strTyper = Console.ReadLine();
            Console.WriteLine("请问您需要还几本书");
            int count = Convert.ToInt32(Console.ReadLine());
            Book[] books = wh.ReturnBook(strTyper, count);
            Console.WriteLine("还书的清单如下");
            foreach (var item in books)
            {
                Console.WriteLine("书的名称是{0}，\t书的编号是{1},\t书的单价是{2}", item.BookName, item.SerialNumbers, item.Price);
            }
        }

        public void ShowBooks()
        {
            wh.ShowBooks();
        }
    }
}
