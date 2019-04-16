using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    class Borrower
    {
        public static string ID="";
        public static  int u = 100;

        public Borrower()
        {
            Console.WriteLine("您好，图书馆会员！欢迎前来借阅\n");
            BLogin();   
            while (true)
            {
                Console.WriteLine("请输入您要执行的操作：\n1.查询\n2.借阅\n3.归还\n4.切换为管理员登陆");
                int j = int.Parse(Console.ReadLine());
                switch (j)
                {
                    case 1:
                        BookSeek();
                        break;
                    case 2:
                        //if (ID == "学生") { BookBorrow(); }
                        //if (ID == "老师") { BookBorrow1(); }
                        break;
                    case 3:
                        BookReturn();
                        break;
                    case 4:
                        Manager ma = new Manager();
                        break;

                }
            }
        }
        #region(注册用户)
        public void Zhuce()
        {
            Console.WriteLine("*************欢迎注册*************");
            Console.WriteLine("请输入姓名：");
            string strname = Console.ReadLine();
            Console.WriteLine("请输入学号/工号（作为密码登陆使用）");
            string strno = Console.ReadLine();
            Console.WriteLine("您的身份是：\n请输入(学生/老师）");
            string strid = Console.ReadLine();
            if (strid == "学生" || strid == "老师")
            {
                Library.userlist.Add(new Person(strno, strname, strid));
            }
            else
            {
                Console.WriteLine("您的身份输入有误");
            }
            Console.WriteLine("**************注册成功************");
            Borrower bor = new Borrower();

        }
        #endregion
        #region(登陆管理)
        public void BLogin()
        {
            
            Y: Console.WriteLine("请输入您的登陆名称：");
            string name = Console.ReadLine();
            var y = Library.userlist.Where(s => s.PersonName == name).FirstOrDefault();
            if (y != null)
            {
                Console.WriteLine("请输入您的学号/工号：");
                string number = Console.ReadLine();
                var q = Library.userlist.Where(s => s.PersonNo == number).FirstOrDefault();
                if(q!=null)
                {
                    if (q.PersonId == "学生") { ID = q.PersonId; Console.WriteLine("您的身份为“学生”，您一共可以借阅图书 8 本"); }
                    if (q.PersonId == "老师") { ID = q.PersonId; Console.WriteLine("您的身份为“老师”，您一共可以借阅图书 15 本"); }
                }
                if (y.PersonNo != number)
                {
                    Console.WriteLine("学号不正确，登陆失败");
                    goto Y;
                }
                Console.WriteLine("欢迎登陆****************  图书馆用户：{0}  ****************", name);
            }
            else
            {
                Console.WriteLine("该名称还没有进行注册！！！请登陆其他账号或者注册用户");
                Console.WriteLine("请选择操作：\n1.登陆其他账号\n2.注册用户");
                string q = Console.ReadLine();
                switch(q)
                {
                    case "1":
                        goto Y;
                    case "2":
                        Zhuce();
                        break;
                       
                }
                
            }
        }
        #endregion
        #region(查找)
        public static void BookSeek()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("请输入要查找的书籍名称：");
            string str = Console.ReadLine();
            var p = Library.booklist.Where(s => s.BookName == str).FirstOrDefault();
            if (p != null)
            {
                Console.WriteLine("图书馆存在图书：《{0}》，其编号为：{1},类别为：{2}。可以借阅",p.BookName,p.BookNo,p.BookType);
            }
            else
            {
                Console.WriteLine("图书馆没有该书籍：" + str);
            }
            Console.WriteLine("*************************************************");

        }
        #endregion
        //#region(学生借阅)
        //public void BookBorrow()
        //{
        //    bool hh = true;
        //    while (hh)
        //    {
        //    Console.WriteLine("请输入要选择的操作：\t1.借阅历史查询\t2.借阅书籍\t3.返回");
        //        string e = Console.ReadLine();
        //        switch (e)
        //        {
                    
        //            case "1":
        //                Console.WriteLine("*************************************************");
        //                Console.WriteLine("目前已借图书  {0}  本", Library.allrecordlist.Count);
        //                Console.WriteLine("借阅者姓名：\t借阅者学号/工号：\t书籍编号：\t书籍名称：\t借阅时间：");
        //                foreach (Record bk in Library.allrecordlist)
        //                {
        //                    Console.Write("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", bk.Strname,bk.Strno,bk.Strbookno, bk.Strbookname, bk.Strtime);
        //                    Console.WriteLine();
        //                }
        //                Console.WriteLine("*************************************************");
        //                break;
        //            case "2":
        //                Console.WriteLine("您的身份是“学生”,目前剩余借阅书籍为{0} 本",  (8 - Library.allrecordlist.Count));
        //                Console.WriteLine("请输入要借阅的图书名称：");
        //                string str = Console.ReadLine();
        //                var p = Library.booklist.Where(s => s.BookName == str).FirstOrDefault();
        //                if (p != null)
        //                {
        //                    String k1 = p.BookNo;
        //                    string k2 = p.BookName;
        //                    string k3 = Convert.ToString(DateTime.Now);
        //                    Console.WriteLine("请输入您的学号/工号");
        //                    string p2 = Console.ReadLine();
        //                    var q = Library.userlist.Where(s => s.PersonNo == p2).FirstOrDefault();
        //                    if (q != null)
        //                    {
        //                        string p1 = q.PersonName;
        //                            u = u - 1;
        //                            if (Library.allrecordlist.Count < 8)
        //                            {
        //                            Library.allrecordlist.Add(new Record(p1, p2, k1, k2, k3));
        //                            Console.WriteLine("已成功借阅图书《" + p.BookName + "》\n目前图书馆书籍总量为" + u + " \n借阅时间为：" + k3);
        //                            }
        //                            else
        //                            {    
        //                                Console.WriteLine("借阅失败！！！借阅书籍已达上限");
        //                            }
        //                        }

        //                        Console.WriteLine("***************************************************");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("很遗憾！图书馆没有该书籍：" + str);
        //                    }
                        
        //                break;
        //            case "3":
        //                //Borrower bor = new Borrower();
        //                hh = false;
        //                break;
        //            default:
        //                Console.WriteLine("您的输入有误！！！");
        //                break;
        //        }
        //    }
        //}
        //#endregion
        //#region(老师借阅)
        //public void BookBorrow1()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("请输入要选择的操作：\t1.借阅历史查询\t2.借阅书籍\t3.返回");
        //        string e = Console.ReadLine();
        //        switch (e)
        //        {

        //            case "1":
        //                Console.WriteLine("*************************************************");
        //                Console.WriteLine("目前已借图书  {0}  本", Library.borelist.Count);
        //                Console.WriteLine("借阅者姓名：\t借阅者学号/工号：\t书籍编号：\t书籍名称：\t借阅时间：");
        //                foreach (Record bk in Library.borelist)
        //                {
        //                    Console.Write("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", bk.Strname, bk.Strno, bk.Strbookno, bk.Strbookname, bk.Strtime);
        //                    Console.WriteLine();
        //                }
        //                Console.WriteLine("*************************************************");
        //                break;
        //            case "2":
        //                Console.WriteLine("您的身份是“老师”,剩余借阅书籍为{0} 本", (15 - Library.borelist.Count));
        //                Console.WriteLine("请输入要借阅的图书名称：");
        //                string str = Console.ReadLine();
        //                var p = Library.booklist.Where(s => s.BookName == str).FirstOrDefault();
        //                if (p != null)
        //                {
        //                    String k1 = p.BookNo;
        //                    string k2 = p.BookName;
        //                    string k3 = Convert.ToString(DateTime.Now);
        //                    Console.WriteLine("请输入您的学号/工号");
        //                    string p2 = Console.ReadLine();
        //                    var q = Library.userlist.Where(s => s.PersonNo == p2).FirstOrDefault();
        //                    if (q != null)
        //                    {
        //                        string p1 = q.PersonName;
        //                        Library.allrecordlist.Add(new Record(p1, p2, k1, k2, k3));
        //                        u = u - 1;
        //                        if (Library.borelist.Count < 15)
        //                        {
        //                            Console.WriteLine("已成功借阅图书《" + p.BookName + "》\n目前图书馆书籍总量为" + u + " \n借阅时间为：" + k3);
        //                        }
        //                        else
        //                        {   int z = Library.borelist.Count - 1;
        //                            Library.borelist.RemoveAt(z);
        //                            Console.WriteLine("借阅失败！！！借阅书籍已达上限");
        //                        }
        //                    }

        //                    Console.WriteLine("***************************************************");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("很遗憾！图书馆没有该书籍：" + str);
        //                }

        //                break;
        //            case "3":
        //                Borrower bor = new Borrower();
        //                break;
        //            default:
        //                Console.WriteLine("您的输入有误！！！");
        //                break;
        //        }
        //    }
        //}
        //#endregion
        #region(归还)
        public void BookReturn()
        {
            Console.WriteLine("请输入要归还的图书名称：");
            string str = Console.ReadLine();
            var p = Library.recordlist.Where(s => s.Strbookname == str).FirstOrDefault();
            if (p != null)
            {
                foreach(Record bok1 in Library.recordlist)
                {
                    if(bok1.Strbookname==p.Strbookname)
                    Library.recordlist.Remove(bok1);
                    Console.WriteLine("还书成功");
                    return;
                }
                 
                int d = Library.booklist.Count+1;
                int f = Library.recordlist.Count - 1;
                Console.WriteLine("已成功归还图书《" + p.Strbookname+ "》目前图书馆书籍总量为{0},已借图书还剩 {1} 本",d,f);
            }
            else
            {
                Console.WriteLine("您没有借阅该图书：" + str);
            }
            Console.WriteLine();
        }
        #endregion

        
            }
        }
    


