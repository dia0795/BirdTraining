using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Management_System
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            Libarary libarary = new Libarary();
            libarary.ShowBooks();
            
            bool b = false;
            Borrower borrower1 = new Borrower();
            Book book = new Book();
            Console.WriteLine("欢迎您使用本校的图书管理系统");

            Console.WriteLine("第一步，请您输入您的账号");
            List<string> listWorkerNumber = new List<string>();
            listWorkerNumber.AddRange(new string[] {"100101","100102","100103","200104","200105","200106","300107","300108","300109" });
            borrower1.WorkerNumber = Console.ReadLine();

            Console.WriteLine("第二步，请您输入您的姓名");
            List<string> listWorkerName = new List<string>();
            listWorkerName.AddRange(new string[] { "孙一","刘二","张三", "赵四", "王五", "李六", "钱七", "罗八","涂九"});
            borrower1.WorkerName = Console.ReadLine();

            Console.WriteLine("第三步，请您输入您的密码");
            List<int> listWorkerPassNumber = new List<int>();
            listWorkerPassNumber.AddRange(new int[] { 100101196, 100102196, 100103196, 200104196, 200105196, 200106196,300107196,300108196,300109196});
            borrower1.WorkerPassNumber= Convert.ToInt32(Console.ReadLine());

            int i = 0;
            for (; i < 6; i++)
            {
                if ((borrower1.WorkerNumber == listWorkerNumber[i]) && (borrower1.WorkerName == listWorkerName[i]) && (borrower1.WorkerPassNumber == listWorkerPassNumber[i]))
                {
                    Console.WriteLine("用户登入成功");
                    b = true;
                    break;
                }              
            }
            if (i==6)
            {
                Console.WriteLine("用户登入失败");
            }

            while(b)
            {
                string identity = borrower1.WorkerNumber.Substring(0, 3);
                if (identity == "100")
                {
                    Console.WriteLine("您是学生用户");
                    Console.WriteLine("按0--借书功能/t按1--还书功能/t按3--查询借书记录，按4--可借书目录");
                    string order = Console.ReadLine();
                    switch (order)
                    {
                        case "0":libarary.AskingLoan(); break;
                        case "1":libarary.AskingReturn(); break;
                        case "2":; break;
                        case "3":; break;
                        case "4":; break;
                    }
                    break;

                }
                else if (identity == "200")
                {
                    Console.WriteLine("您是老师用户");
                    Console.WriteLine("按0--借书功能/t按1--还书功能/t按3--查询借书记录/t按4--可借书目录");
                    string order = Console.ReadLine();
                    switch (order)
                    {
                        case "0": libarary.AskingLoan(); break;
                        case "1": libarary.AskingReturn(); break;
                        case "2":; break;
                        case "3":; break;
                        case "4":; break;
                    }
                    break;

                }
                else if(identity == "300")
                {
                    Console.WriteLine("您是管理者用户");
                    Console.WriteLine("按0--借书功能/t按1--还书功能/t按3--查询借书记录/t按4--图书馆图书目录（可借图书目录/t按5--采购图书/t按6--添加销毁书籍/t按6--添加丢失书籍");
                    string order = Console.ReadLine();
                    switch (order)
                    {
                        case "0": libarary.AskingLoan(); break;
                        case "1": libarary.AskingReturn(); break;
                        case "2":; break;
                        case "3":; break;
                        case "4":; break;
                        case "5":; break;
                        case "6":; break;

                    }
                    break;
                }
               
            }
            Console.ReadKey();             

        }
    }
}
