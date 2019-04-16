using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{      
        class Program
        {
        private static List<Record> orglist;

        static void Main(string[] args)
            {
            Console.WriteLine("****************欢迎登陆图书馆管理系统******************");
            Library .GetInstance();
            while (true)
            {
                Console.WriteLine("请对您的身份进行选择：\t1.管理员\t2.借阅者");
                string k = Console.ReadLine();
                switch (k)
                {
                    case "1":
                        #region(管理员)
                        Console.WriteLine("您好，图书馆管理员！\n");
                        #region(登陆)
                        while (true)
                        {
                            Y: Console.WriteLine("请输入您的姓名：");
                            string name = Console.ReadLine();
                            Console.WriteLine("请输入您的工号");
                            string no = Console.ReadLine();
                            Manager.Login(name, no);
                            switch (Manager.x)
                            {
                                case "不正确":
                                    Console.WriteLine("工号不正确，登陆失败");
                                    goto Y;
                                case "没注册":
                                    Console.WriteLine("该名称还没有进行注册！！！请登陆其他账号");
                                    goto Y;
                                case "正确":
                                    Console.WriteLine("欢迎登陆****************  管理员：{0}  ****************", name);
                                    break;
                                default:
                                    Console.WriteLine("输入有误");
                                    break;
                            }
                            break;
                        }
                        #endregion
                        bool ll = true;
                        while (ll)
                        {
                            Console.WriteLine("请选择要进行的操作：\n1.查询\n2.采购\n3.销毁\n4.丢失\n5.借书管理\n6.历史记录查询\n7.退出");
                            Console.WriteLine();
                            string a = Console.ReadLine();
                            switch (a)
                            {
                                case "1":
                                    #region(查询)
                                    Console.WriteLine("*************************************************");
                                    Console.WriteLine("现有图书共  {0}  本", Library.booklist.Count);
                                    Console.WriteLine("书籍编号：\t书籍名称：\t书籍类别：\t书籍状态：");
                                    foreach (Book bk in Library.booklist)
                                    {
                                        Console.Write("{0}\t\t{1}\t\t{2}\t\t{3}", bk.BookOnlyno, bk.BookName, bk.BookType, bk.BookStatus);
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine("*************************************************");
                                    Manager.BookSeek();
                                    continue;
                                #endregion
                                case "2":
                                    #region(采购)
                                    X: Console.WriteLine("请为采购的书籍编号：");
                                    string l4 = Console.ReadLine();
                                    var p = Library.booklist.Where(s => s.BookOnlyno == l4).FirstOrDefault();
                                    if (p != null)
                                    {
                                        Console.WriteLine("该编号已存在，请更换编号录入：");
                                        goto X;
                                    }
                                    Console.WriteLine("请输入采购的书籍名称：");
                                    string l2 = Console.ReadLine();
                                    Console.WriteLine("请输入采购的书籍分类：");
                                    string l3 = Console.ReadLine();
                                    Console.WriteLine("请输入采购的书籍型号：");
                                    string l1 = Console.ReadLine();
                                    string l5 = "正常";
                                    Manager.BookBuy(l1, l2, l3, l4, l5);
                                    Console.WriteLine("**********已成功购买图书：《{0}》,并已成功录入系统**********", l2);
                                    continue;
                                #endregion
                                case "3":
                                    #region(销毁)
                                    Console.WriteLine("请输入要销毁的图书编号：");
                                    string bkonlyno = Console.ReadLine();
                                    Manager.BookXiaoHui(bkonlyno);
                                    switch (Manager.x)
                                    {
                                        case "销毁":
                                            Console.WriteLine("已销毁");
                                            break;
                                        case "借出":
                                            Console.WriteLine("书籍被借出或已丢失");
                                            break;
                                        case "没书":
                                            Console.WriteLine("图书馆没有书籍:" + bkonlyno);
                                            break;
                                        default:
                                            Console.WriteLine("输入有误");
                                            break;
                                    }

                                    continue;
                                #endregion
                                case "4":
                                    #region(丢失)
                                    Console.WriteLine("请输入已丢失的图书编号：");
                                    string bkonlyno1 = Console.ReadLine();
                                    Manager.BookLose(bkonlyno1);
                                    switch (Manager.x)
                                    {
                                        case "已丢失":
                                            Console.WriteLine("已标记为丢失");
                                            break;
                                        case "已借出":
                                            Console.WriteLine("书籍被借出或已销毁");
                                            break;
                                        case "没书":
                                            Console.WriteLine("图书馆没有书籍:" + bkonlyno1);
                                            break;
                                        default:
                                            Console.WriteLine("输入有误");
                                            break;
                                    }
                                    continue;
                                #endregion
                                case "5":
                                    #region(借书管理)
                                    Console.WriteLine("请输入借书人学号：");
                                    string borrowerno = Console.ReadLine();
                                    Console.WriteLine("请输入要借的书籍编号：");
                                    string bookno = Console.ReadLine();
                                    Manager.BookBorrow(bookno, borrowerno);
                                    switch (Manager.x)
                                    {
                                        case "借书成功":
                                            Console.WriteLine("借书成功");
                                            break;
                                        default:
                                            Console.WriteLine("借书失败");
                                            break;
                                    }
                                    continue;
                                #endregion
                                case "6":
                                    #region(历史记录查询)
                                    string g = "";
                                    Console.WriteLine("选择查询模式：\n1.全部查询\n2.管理员操作\n3.借阅者操作");
                                    g = Console.ReadLine();
                                    switch (g)
                                    {
                                        case "1":
                                            {
                                                Console.WriteLine("*************************************************");
                                                Console.WriteLine("操作者身份：\t操作者编号：\t书籍编号：\t书籍名称：\t操作：\t借阅时间：");
                                                foreach (Record bk in Library.recordlist)
                                                {
                                                    Console.Write("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t{5}", bk.Strhandlerid, bk.Strhandlerno, bk.Strbookno, bk.Strbookname, bk.Strhandlername, bk.Strtime);
                                                    Console.WriteLine();
                                                }
                                                Console.WriteLine("*************************************************");

                                                continue;
                                            }
                                        case "2":
                                            orglist = Library.recordlist.Where(s => s.Strhandlerid == "管理员").ToList();
                                            foreach (Record rd in orglist)
                                            {
                                                Console.WriteLine("操作者身份：\t操作者编号：\t书籍编号：\t书籍名称：\t操作：\t借阅时间：");
                                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t{5}", rd.Strhandlerid, rd.Strhandlerno, rd.Strbookno, rd.Strbookname, rd.Strhandlername, rd.Strtime);
                                            }
                                            continue;

                                        case "3":

                                            orglist = Library.recordlist.Where(s => s.Strhandlerid == "老师" || s.Strhandlerid == "学生").ToList();
                                            foreach (Record rd in orglist)
                                            {
                                                Console.WriteLine("操作者身份：\t操作者编号：\t书籍编号：\t书籍名称：\t操作：\t借阅时间：");
                                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t{5}", rd.Strhandlerid, rd.Strhandlerno, rd.Strbookno, rd.Strbookname, rd.Strhandlername, rd.Strtime);
                                            }
                                            continue;
                                    }
                                    break;
                                #endregion
                                case "7":                  
                                    ll = false;
                                    break;
                                default:
                                    Console.WriteLine("您的输入有误！！！请重新输入：");
                                    break;
                            }
                            break;
                        }
                        continue;
                    #endregion
                    case "2":
                        #region(借阅者)

                        Borrower bor = new Borrower();
                        break;
                    default:
                        Console.WriteLine("您的输入有误！！！重新输入：");
                        break;
                        #endregion
                }
                continue;
            }
            }
        }
    }

