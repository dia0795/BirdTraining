using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    class Manager 
    {
        public Manager() 
        {
            Console.WriteLine("您好，图书馆管理员！\n");
            Login();
            while (true)
            {
                Console.WriteLine("请选择要进行的操作：\n1.查询\n2.采购\n3.销毁\n4.丢失\n5.借阅历史查询\n6.切换为借阅者登陆");
                Console.WriteLine();
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        BookSeek();
                        break;
                    case "2":
                        BookBuy();
                        break;
                    case "3":
                        BookXiaoHui();
                        break;
                    case "4":
                        BookLose();
                        break;
                    case "5":
                        RecordHistory();
                        break;
                    case "6":
                        Borrower bor = new Borrower();
                        break;
                    default:
                        Console.WriteLine("您的输入有误！！！请重新输入：");
                        break;
                }
            }
        }
        #region(登陆管理)
        public void Login()
        {
            Y: Console.WriteLine("请输入您的姓名：");
            string name = Console.ReadLine();
            var y = PersonKu.managerlist.Where(s => s.PersonName == name).FirstOrDefault();
            if (y != null)
            {
                Console.WriteLine("请输入您的工号：");
                string number = Console.ReadLine();
                if (y.PersonNo != number)
                {
                    Console.WriteLine("工号不正确，登陆失败");
                    goto Y;
                }
                Console.WriteLine("欢迎登陆****************  管理员：{0}  ****************", name);
            }
            else
            {
                Console.WriteLine("该名称还没有进行注册！！！请登陆其他账号");
                goto Y;
            }
        }
        #endregion
        #region(查找)
        public static void BookSeek()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("现有图书共  {0}  本", BookKu.booklist.Count);
            Console.WriteLine("书籍编号：\t书籍名称：\t书籍类别：");
            foreach (Book bk in BookKu.booklist)
            {
                Console.Write("{0}\t\t{1}\t\t{2}\t", bk.BookNo, bk.BookName, bk.BookType);
                Console.WriteLine();
            }
            Console.WriteLine("*************************************************");

        }
        #endregion
        #region(采购)
        public void BookBuy()
        {
            Console.WriteLine("请为采购的书籍编号：");
                X: string n1 = Console.ReadLine();
                var p = BookKu.booklist.Where(s => s.BookNo == n1).FirstOrDefault();
                if (p != null)
                {
                    Console.WriteLine("该编号已存在，请更换编号录入：");
                    goto X;
                }
            Console.WriteLine("请输入采购的书籍名称：");
            string n2 = Console.ReadLine();
            Console.WriteLine("请输入采购的书籍分类：");
            string n3 = Console.ReadLine();
            Book b6 = new Book(n1, n2, n3);
            BookKu.booklist.Add(b6);
            Console.WriteLine("**********已成功购买图书：《{0}》,并已成功录入系统**********",n2);
            Console.WriteLine();
        }
        #endregion
        #region(销毁)
        public void BookXiaoHui()
        {
            Console.WriteLine("请输入要销毁的图书名称：");
            string str= Console.ReadLine();
            var  p = BookKu.booklist.Where(s => s.BookName == str).FirstOrDefault();
            if (p != null)
            {
                int d = BookKu.booklist.Count - 1;
                Console.WriteLine("已成功销毁图书《" + p.BookName + "》目前图书馆书籍总量为" + Borrower.u);
            }
            else
            {
                Console.WriteLine("图书馆没有书籍"+str);
            }
        }
        #endregion
        #region(丢失)
        public void BookLose()
        {
            Console.WriteLine("请输入丢失的图书名称：");
            string str = Console.ReadLine();
            var p = BookKu.booklist.Where(s => s.BookName == str).FirstOrDefault();
            if (p != null)
            {
                Console.WriteLine("图书《" + p.BookName + "》已丢失，目前图书馆书籍总量为" + Borrower.u);
            }
            else
            {
                Console.WriteLine("图书馆没有对 {0} 进行收录，不存在丢失",str);
            }
        }
        #endregion
        #region(会员借阅历史查询)
        public void RecordHistory()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("目前已借图书  {0}  本", Record.booklist1.Count);
            Console.WriteLine("借阅者姓名：\t借阅者学号：\t书籍编号：\t书籍名称：\t借阅时间：");
            foreach (Record bk in Record.booklist1)
            {
                Console.Write("{0}\t\t{1}\t\t{2}\t{3}\t{4}", bk.Strname, bk.Strno, bk.Strbookno, bk.Strbookname, bk.Strtime);
                Console.WriteLine();
            }
            Console.WriteLine("*************************************************");
        }
        #endregion

    }
}

