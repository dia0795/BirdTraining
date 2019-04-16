using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlibraryManage
{
    class Library
    {
        public Library()//加载（初始化）数据库
        {
            Book book1 = new Book(101, "全球通史", "人文");
            Book book2 = new Book(102, "世界哲学史", "哲学");
            Book book3 = new Book(103, "演讲与口才", "文学");
            Book book4 = new Book(104, "基因传:众生之源", "医学");
            Dbs.books.Add(book1);
            Dbs.books.Add(book2);
            Dbs.books.Add(book3);
            Dbs.books.Add(book4);
        }

        int userID;
        int usertype;
        public void login()
        {
            Console.WriteLine("请选择用户类型：1.管理员 2.学生 3.退出系统");
            while (true)
            {
                try
                {
                    usertype = Convert.ToInt32(Console.ReadLine());
                    if (usertype >= 1 && usertype <= 3) break;
                    else Console.WriteLine("输入范围为1-3，请重新输入");
                }
                catch
                {
                    Console.WriteLine("输入格式错误，请重新输入！");
                }
            }

            if (usertype == 3) { Exit(); return; }

            Console.Write("请输入账号：");
            userID = Convert.ToInt32(Console.ReadLine());
            Manu(1);
        }

        private void Manu(int v)
        {
            if (usertype == 1)//管理员菜单
            {
                if (v == 1)//首次进入
                {
                    Console.WriteLine($"**************** {userID}你好，欢迎使用图书馆系统****************");
                    Console.WriteLine("                     1.图书查询");
                    Console.WriteLine("                     2.新增书本");
                    Console.WriteLine("                     3.借书");
                    Console.WriteLine("                     4.还书");
                    Console.WriteLine("                     5.借书记录");
                    Console.WriteLine("                     6.用户管理");
                    Console.WriteLine("                     7.退出登录");
                    Console.Write("请输入要进行的操作编号：");
                }
                else
                {
                    Console.WriteLine("***请输入下一步操作***\n1.图书查询 2.新增书本 3.借书 4.还书 5.借书记录 6.用户管理 7.退出登录");
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Listing(); break;
                    case 2: Add(); break;
                    case 3: Rent(); break;
                    case 4: Return(); break;
                    case 5: HistoryDisplay(); break;
                    case 6: ManageUser(); break;
                    case 7: Logout(); break;
                }
            }
            else //借用者菜单
            {
                if (v == 1)
                {
                    Console.WriteLine($"**************** {userID}你好，欢迎使用图书馆系统****************");
                    Console.WriteLine("                     1.图书查询");
                    Console.WriteLine("                     2.借书记录");
                    Console.WriteLine("                     3.退出登录");
                    Console.Write("请输入要进行的操作编号：");
                }
                else
                {
                    Console.WriteLine("***请输入下一步操作***\n1.图书查询 2.借书记录 3.退出登录");
                }

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Listing(); break;
                    case 2: HistoryDisplay(); break;
                    case 3: Logout(); break;
                }
            }
        }

        //查询书籍
        private void Listing()
        {
            Console.WriteLine("***书籍列表***");
            Console.WriteLine("书号\t书名\t\t分类\t状态");
            foreach (Book book in Dbs.books)
            {
                Console.WriteLine($"{book.id}\t{book.name}\t{book.sort}\t{book.situation}");
            }
            Manu(2);
        }
        //添加书籍
        private void Add()
        {
            Console.Write("***新增书籍***(输入r返回主菜单)\n请输入书号：");
            string input;
            input = Console.ReadLine();
            RBack(input);
            int id = Convert.ToInt32(input);

            Console.Write("请输入书名：");
            input = Console.ReadLine();
            RBack(input);
            string name = Convert.ToString(input);

            Console.Write("请输入分类：");
            input = Console.ReadLine();
            RBack(input);
            string srot = Convert.ToString(input);

            Book book = new Book(id, name, srot);
            Dbs.books.Add(book);
            Console.Write("***新增成功！***\n");
            Manu(2);
        }
        //借书
        private void Rent()
        {
            int index, renterID, bookID;
            Console.Write("***借书***(输入r返回主菜单)\n请输入借阅者ID：");
            string input = Console.ReadLine();
            RBack(input);
            renterID = int.Parse(input);
            do
            {
                Console.Write("请输入要借阅的书本编号：");
                input = Console.ReadLine();
                RBack(input);
                bookID = Convert.ToInt32(input);
                index = Dbs.books.FindIndex(p => p.id.Equals(bookID));//按值查找并返回list的下标
            } while (!Dbs.books[index].Rent(renterID));//调用借书方法,失败则重复借书 

            History his = new History(bookID, renterID);//添加一条记录
            Dbs.histories.Add(his);//存入数据库

            Manu(2);
        }
        //还书
        private void Return()
        {
            Console.Write("***还书***(输入r返回主菜单)\n请输入需归还的书籍编号：");
            string input = Console.ReadLine();
            RBack(input);
            int id = Convert.ToInt32(input);
            int index = Dbs.books.FindIndex(p => p.id == id);//根据书籍id查找记录
            Dbs.books[index].Return();//数据库调整记录

            index = Dbs.histories.FindIndex(p => p.bookID == id);//根据书籍id查找历史记录，获取下标
            Dbs.histories[index].returnTime = DateTime.Now.ToString();//将还书时间写入数据库

            Manu(2);
        }

        private void HistoryDisplay()
        {
            Console.Write("***借阅历史***(输入r返回主菜单)\n");
            if (usertype==1)//管理员可查看所有历史
            {
                Console.WriteLine("书号\t借阅者\t借出时间\t\t归还时间");
                foreach (History his in Dbs.histories)
                {
                    Console.WriteLine($"{his.bookID}\t{his.userID}\t{his.rentTime}\t{his.returnTime}");
                }
            }
            else//用户只可查看自己的历史记录
            {
                Console.WriteLine("书号\t借出时间\t\t归还时间");
                //根据登录者的ID来查找历史记录
                var query =
                    from his in Dbs.histories
                    where his.userID == userID
                    select his;

                foreach (History his in query)
                {
                    Console.WriteLine($"{his.bookID}\t{his.rentTime}\t{his.returnTime}");
                }
            }
            string input = Console.ReadLine();
            RBack(input);
        }

        private void ManageUser()
        {
            Console.Write("***用户管理***(输入r返回主菜单)\n");
            while(true)
            {
                Console.Write("请选择操作编号：1.添加管理员 2.添加教师 3.添加学生 4.查看用户 5.返回主菜单\n");
                string input = Console.ReadLine();
                RBack(input);

                if (Convert.ToInt32(input)==4)
                {
                    Console.WriteLine("ID\t姓名\t身份");
                    foreach (User u in Dbs.users)
                    {
                        Console.WriteLine($"{u.id}\t{u.name}\t{u.sort}");
                    }
                }
                else if(Convert.ToInt32(input) == 5)   Manu(2);
                else
                {
                    Console.Write("请输入编号：");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("请输入姓名：");
                    string name = Convert.ToString(Console.ReadLine());
                    switch (Convert.ToInt32(input))
                    {
                        case 1:
                            User user1 = new User(id, name, "管理员");
                            Dbs.users.Add(user1);
                            Console.WriteLine("添加成功！");
                            break;
                        case 2:
                            User user2 = new User(id, name, "教师");
                            Dbs.users.Add(user2);
                            Console.WriteLine("添加成功！");
                            break;
                        case 3:
                            User user3 = new User(id, name, "学生");
                            Dbs.users.Add(user3);
                            Console.WriteLine("添加成功！");
                            break;
                    }
                }                
            }
            
        }

        public void Exit()
        {
            Console.WriteLine("已退出系统");
        }
        
        private void Logout()
        {
            userID = 0;
            usertype = 0;
            login();
        }

        private void RBack(string v)//输入r返回主菜单
        {
            if (v.ToLower() == "r") Manu(2);
        }
    }
}
