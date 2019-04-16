using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    public class Borrower
    {
        public static string ID = "";
        public static int u = 100;
        public void BorrowerChoose()
        {
            Console.WriteLine("您好，图书借阅者！");
            BorrowerLogin();
            while (true)
            {
                Console.WriteLine("**********图书管理系统**********");
                Console.WriteLine("1.显示所有图书");
                Console.WriteLine("2.找书");
                Console.WriteLine("3.借书");
                Console.WriteLine("4.还书");
                Console.WriteLine("5.查询借阅历史记录");
                Console.WriteLine("6.退出");
                Console.WriteLine("********************************");
                Console.WriteLine();
                b: Console.WriteLine("请输入你要操作的项目：");
                string action1 = Console.ReadLine();
                switch (action1)
                {
                    case "1":
                        BooksShowAll();
                        break;
                    case "2":
                        BookFind();
                        break;
                    case "3":
                        //Console.WriteLine("请输入你要操作的项目：1.学生   2.老师");
                        //int action2 = int.Parse(Console.ReadLine());
                        //switch (action2)
                        //{
                        //    case 1:
                        //        BookStudentBorrow();
                        //        break;
                        //    case 2:
                        //        BookTeacherBorrow();
                        //        break;
                        //}//控制不能从一个case标签贯穿到另外一个case标签
                        if (ID == "学生")
                        {
                            BookStudentBorrow();
                        }
                        else if (ID == "老师")
                        {
                            BookTeacherBorrow();
                        }
                        break;
                    case "4":
                        BookReturn();
                        break;
                    case "5":
                        ReadBorrowHistory();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("非法输入！请重新输入");
                        goto b;//跳转至上面语句a
                }
            }
        }
        #region(借阅者注册)
        public void BorrowerRegister()
        {
            Console.WriteLine("*************欢迎注册*************");
            Console.WriteLine("请输入姓名：");
            string strname = Console.ReadLine();
            Console.WriteLine("请输入学号（作为密码登录使用）");
            string strno = Console.ReadLine();
            m: Console.WriteLine("您的身份是：\n请输入(学生/老师）");
            string strid = Console.ReadLine();
            if(strid!= "学生"&& strid != "老师")
            {
                Console.WriteLine("您的身份输入有误");
                goto m;
            }
            if (strid == "学生" || strid == "老师")
            {
                PersonMessage.borrowerlist.Add(new Person(strno, strname, strid));
            }
            //else
            //{
            //    Console.WriteLine("您的身份输入有误");
            //}
            Console.WriteLine("账号注册成功！");
            Console.WriteLine("你的账号是：姓名：{0}，学号：{1}，身份：{2}",strno, strname, strid);
            Borrower borrower = new Borrower();
        }
        #endregion
        #region(借阅者登录)
        public void BorrowerLogin()
        {
        bl: Console.WriteLine("请输入你的姓名：");
            string myname = Console.ReadLine();
            var t = PersonMessage.borrowerlist.Where(s => s.PersonName == myname).FirstOrDefault();
            if (t != null)
            {

                Console.WriteLine("请输入您的学号：");
                string number = Console.ReadLine();
                var q = PersonMessage.borrowerlist.Where(s => s.PersonNo == number).FirstOrDefault();
                if (q != null)
                {
                    if (q.PersonId == "学生")
                    {
                        ID = q.PersonId;
                        Console.WriteLine("您的身份为“学生”，您一共可以借阅图书 8 本");
                    }
                    else if (q.PersonId == "老师")
                    {
                        ID = q.PersonId; Console.WriteLine("您的身份为“学生”，您一共可以借阅图书 15 本");
                    }
                }
                else
                {
                    Console.WriteLine("学号不正确，登录失败！");
                    goto bl;
                }
                Console.WriteLine("欢迎借阅者：{0} 登录图书管理系统成功！", myname);

            }
            else
            {
                Console.WriteLine("该名称还没有进行注册！！！请登录其他账号或者注册用户");
                Console.WriteLine("请选择操作：\n1.登录其他账号\n2.注册用户");
                string q = Console.ReadLine();
                switch (q)
                {
                    case "1":
                        goto bl;
                    case "2":
                        BorrowerRegister();
                        break;
                }
            }
            

            //Console.WriteLine("请输入你的学号：");
            //string myborrowerNo = Console.ReadLine();
            //Console.WriteLine("请输入你的姓名：");
            //string myborrowerName = Console.ReadLine();
            //Console.WriteLine("学号：{0}   姓名：{1}    登录图书管理系统成功！", myborrowerNo, myborrowerName);

        }
        #endregion
        #region(显示所有图书)
        public void BooksShowAll()
        {
            Console.WriteLine("图书馆里共有{0}种", BookLibrary.booklist.Count);
            Console.WriteLine("图书目录如下：");
            Console.WriteLine("编号\t\t名称\t\t\t作者\t\t\t类型");
            Console.WriteLine();

            foreach (Book book in BookLibrary.booklist)
            {
                Console.WriteLine("{0}\t\t{1}\t\t\t{2}\t\t\t{3}", book.BookNo, book.BookName, book.BookAuthor, book.BookType);
                Console.WriteLine();

            }
        }
        #endregion
        #region(找书)
        public void BookFind()
        {
            Console.WriteLine("请输入要查找的图书名称：");
            string bookFind = Console.ReadLine();
            //foreach (Book book in BookLibrary.booklist)
            var p = BookLibrary.booklist.Where(s => s.BookName == bookFind).FirstOrDefault();
            if (p != null)
            {
                Console.WriteLine("图书馆存在图书：《{0}》，其编号为：{1},作者：{2}，类别为：{3}。可以借阅", p.BookName, p.BookNo, p.BookAuthor, p.BookType);
            }
            else
            {
                Console.WriteLine("图书馆没有该书籍：" + bookFind);
            }
        }
        #endregion
        #region(学生借书)
        public void BookStudentBorrow()
        {
            Console.WriteLine("您的身份是“学生”,目前剩余借阅书籍为{0} 本", (8 - Record.booklist.Count));
            Console.WriteLine("请输入要借阅的书名：");
            string borrowname = Console.ReadLine();
            var p = BookLibrary.booklist.Where(s => s.BookName == borrowname).FirstOrDefault();
            if (p != null)
            {
                string borrowtime = Convert.ToString(DateTime.Now);
                Console.WriteLine("请输入你的学号：");
                string no = Console.ReadLine();
                var q = PersonMessage.borrowerlist.Where(s => s.PersonNo == no).FirstOrDefault();
                if (q != null)
                {
                    u = u - 1;
                    if (Record.booklist.Count < 8)
                    {
                        Record.booklist.Add(new Record(q.PersonName, no, p.BookNo, p.BookName,borrowtime));
                        Console.WriteLine("已成功借阅图书《" + p.BookName + "》目前图书馆还藏有书籍的数量是" + u);
                        Console.WriteLine("此次借书时间为{0}，借阅时间为3个月", borrowtime);
                    }
                    else
                    {
                        Console.WriteLine("您所借阅的图书数量已达到最大！");
                    }
                }
            }
            else
            {
                Console.WriteLine("很遗憾！图书馆没有该书籍：" + borrowname);
            }

        }
        #endregion
        #region(老师借书)
        public void BookTeacherBorrow()
        {
            Console.WriteLine("您的身份是“老师”,目前剩余借阅书籍为{0} 本", (8 - Record.booklist.Count));
            Console.WriteLine("请输入要借阅的书名：");
            string borrowname = Console.ReadLine();
            var p = BookLibrary.booklist.Where(s => s.BookName == borrowname).FirstOrDefault();
            if (p != null)
            {
                string borrowtime = Convert.ToString(DateTime.Now);
                Console.WriteLine("请输入你的学号：");
                string no = Console.ReadLine();
                var q = PersonMessage.borrowerlist.Where(s => s.PersonNo == no).FirstOrDefault();
                if (q != null)
                {
                    u = u - 1;
                    if (Record.booklist1.Count < 15)
                    {
                        BookLibrary.booklist1.Remove(p);
                        Record.booklist1.Add(new Record(q.PersonName, no, p.BookNo, p.BookName, borrowtime));
                        Console.WriteLine("已成功借阅图书《" + p.BookName + "》目前图书馆书籍总量为" + u);
                        Console.WriteLine("此次借书时间为{0}，借阅时间为3个月", borrowtime);
                    }
                    else
                    {
                        Console.WriteLine("您所借阅的图书数量已达到最大！");
                    }
                }
            }
            else
            {
                Console.WriteLine("很遗憾！图书馆没有该书籍：" + borrowname);
            }
        }
        #endregion
        #region(借阅历史)
        public void ReadBorrowHistory()
        {
            if(Record.booklist.Count!=0)
            { 
            Console.WriteLine("您的借阅情况如下：");
            Console.WriteLine("目前已借图书  {0}  本", Record.booklist.Count);
            Console.WriteLine("借阅者姓名：\t借阅者学号：\t书籍编号：\t书籍名称：\t借阅时间：");
            foreach (Record record in Record.booklist)
            {
                Console.Write("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", record.BorrowerName, record.BorrowerNo, record.BorrowBookNo, record.BorrowBookName, record.BorrowTime);
                Console.WriteLine();
            }
            }
            else
            {
                Console.WriteLine("您没有借阅任何图书！");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion
        #region(还书)
        public void BookReturn()
        {
            Console.WriteLine("请输入要归还的图书名称：");
            string bookreturn = Console.ReadLine();
            var p = Record.booklist.Where(s => s.BorrowBookName == bookreturn).FirstOrDefault();
            if (p != null)
            {
                foreach (Record record in Record.booklist)
                {
                    if (record.BorrowBookName == p.BorrowBookName)
                        Record.booklist.Remove(record);
                    Console.WriteLine("还书成功");
                    return;
                }
                int a = BookLibrary.booklist.Count + 1;
                int b = Record.booklist.Count - 1;
                Console.WriteLine("已成功归还图书《" + p.BorrowBookName + "》目前图书馆书籍总量为{0},已借图书还剩 {1} 本", a, b);
            }
            else
            {
                Console.WriteLine("您没有借阅该图书：" + bookreturn);
            }
            Console.WriteLine();
        }
        #endregion
        
    }
}
