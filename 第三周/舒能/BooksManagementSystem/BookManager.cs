using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using BooksManagementSystem;

namespace BooksManagementSystem
{
    public class BookManager
    {
        public void ManagerChoose()
        {
            Console.WriteLine("您好，图书管理员！\n");
            ManagerLogin();
            while (true)
            { 
            Console.WriteLine("**********图书管理系统**********");
            Console.WriteLine("1.采购并录入");
            Console.WriteLine("2.查询");
            Console.WriteLine("3.删除");
            Console.WriteLine("4.显示所有图书");
            Console.WriteLine("5.退出");
            Console.WriteLine("********************************");
            Console.WriteLine();
            a: Console.WriteLine("请输入你要操作的项目：");
            string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        BookPurchaseEntering();
                        break;
                    case "2":
                        BookSearch();
                        break;
                    case "3":
                        BookDelete();
                        break;
                    case "4":
                        BooksShowAll();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("非法输入！请重新输入");
                        goto a;//跳转至上面语句a
                }
            }
        }
        #region(管理员登录界面)
        public void ManagerLogin()
        {
        bm: Console.WriteLine("请输入您的姓名：");
            string myname = Console.ReadLine();
            var t = PersonMessage.managerlist.Where(s => s.PersonName == myname).FirstOrDefault();
            if (t != null)
            {
                Console.WriteLine("请输入您的工号：");
                string number = Console.ReadLine();
                if (t.PersonNo != number)
                {
                    Console.WriteLine("工号不正确，登陆失败！");
                    goto bm;
                }
                Console.WriteLine("欢迎借阅者：{0} 登录图书管理系统成功！", myname);
            }
            else
            {
                Console.WriteLine("该名称不存在！！！请登陆其他账号！");
                goto bm;
            }
        }
        #endregion
        #region(采购录入界面)
        public void BookPurchaseEntering()
        {
            Console.WriteLine("请输入图书编号：");
            string bookNo = Console.ReadLine();
            var p = BookLibrary.booklist.Where(s => s.BookNo == bookNo).FirstOrDefault();
            if (p != null)
            {
                Console.WriteLine("编号已存在，请重新输入！");
                Console.WriteLine("请输入图书编号：");
                bookNo = Console.ReadLine();
            }
            Console.WriteLine("请输入图书名称：");
            string bookName = Console.ReadLine();
            Console.WriteLine("请输入图书作者：");
            string bookAuthor = Console.ReadLine();
            Console.WriteLine("请输入图书类型：");
            string bookType = Console.ReadLine();
            Book b7 = new Book(bookNo, bookName, bookAuthor, bookType);
            BookLibrary.booklist.Add(b7);
            Console.WriteLine("图书{0}采购录入成功！", b7.BookName);
        }
        #endregion
        #region(查询)
        public void BookSearch()
        {
            Console.WriteLine("请输入要查询的书名：");
            string findname = Console.ReadLine();
            Console.WriteLine("查询结果如下：");
            foreach (Book book in BookLibrary.booklist)
            {
                if (book.BookName == findname)
                {
                    Console.WriteLine("编号：{0} 名称：{1} 作者：{2} 类型：{3}", book.BookNo, book.BookName, book.BookName, book.BookType);
                }
                else
                {
                    Console.WriteLine("此书不存在！请重新进入查询界面输入书名！");
                }
                return ;
            }
        }
        #endregion
        #region(删除)
        public void BookDelete()
        {
            Console.WriteLine("请输入要删除的书名：");
            string deletename = Console.ReadLine();
            //foreach (Book book in booklist)
            //{
            //    if (book.BookName == deletename)
            //    {
            //        booklist.Remove(book);
            //        Console.WriteLine("{0}删除成功！", book.BookName);
            //    }
            //}
            //return;
            //foreach循环好像不能用于集合的add和remove
            var p = BookLibrary.booklist.Where(s => s.BookName == deletename).FirstOrDefault();
            if (p != null)
            {
                BookLibrary.booklist.Remove(p);
                int d = BookLibrary.booklist.Count - 1;
                Console.WriteLine("已成功销毁图书《" + p.BookName + "》目前图书馆书籍总量为" + d);
            }
            else
            {
                Console.WriteLine("图书馆没有书籍" + deletename);
            }
        }
        #endregion
        #region(显示所有图书)
        public void BooksShowAll()
        {
            Console.WriteLine("图书馆里共有{0}种", BookLibrary.booklist.Count);
            Console.WriteLine("图书目录如下：");
            Console.WriteLine("编号\t\t名称\t\t\t\t作者\t\t\t类型");
            Console.WriteLine();
            
            foreach (Book book in BookLibrary.booklist)
            {
                Console.WriteLine("{0}\t\t{1}\t\t\t{2}\t\t\t{3}", book.BookNo, book.BookName,book.BookAuthor, book.BookType);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion
    }
}
