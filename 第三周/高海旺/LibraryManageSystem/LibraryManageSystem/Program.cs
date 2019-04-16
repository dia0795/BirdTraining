using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{      
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("****************欢迎登陆图书馆管理系统******************");
            BookKu.GetInstance();
            PersonKu ps = new PersonKu();
            Console.WriteLine("请对您的身份进行选择：\t1.管理员\t2.借阅者");
            while (true)
            {
                string k = Console.ReadLine();
                switch (k)
                {
                    case "1":
                        Manager ma = new Manager();
                        break;
                    case "2":
                        Borrower bor = new Borrower();
                        break;
                    default:
                        Console.WriteLine("您的输入有误！！！重新输入：");
                        break;
                }
                break;
            }
                Console.ReadKey();
            }
        }
    }

