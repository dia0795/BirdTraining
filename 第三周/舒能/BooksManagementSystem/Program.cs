using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎进入图书管理系统！");
            Console.WriteLine("**********图书管理系统**********");
            BookLibrary book = new BookLibrary();
            PersonMessage pm = new PersonMessage();
            k: Console.WriteLine("请选择你的身份：1.管理员     2.借阅者");
            while (true)
            {
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        BookManager bm = new BookManager();
                        bm.ManagerChoose();
                        break;
                    case "2":
                        Borrower br = new Borrower();
                        br.BorrowerChoose();
                        break;
                    default:
                        Console.WriteLine("非法输入！请重新输入");
                        goto k;//跳转至上面语句a
                }
                break;
            }
            Console.ReadLine();
        }
    }
}
