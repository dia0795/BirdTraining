using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tushuguanli
{
    public class borrowbook
    {
        public borrowbook()
        {
            Console.WriteLine("你好，欢迎借阅图书");
            Console.WriteLine("请选择你要执行的操作\n1.查询\n2.借阅\n3.还书\n");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (y)
            {
                case 1:
                    chaxun();
                    break;
                case 2:
                    jieyue();
                    break;
                case 3:
                    huanshu();
                    break;
            }
        }
        public void chaxun()
        {
            List<Book> newbooklist = new List<Book>();
            Console.WriteLine("请输入你要查询的书名");
            string chaxunming = Console.ReadLine();
            var j = newbooklist.Where(s => s.Bookname == chaxunming).FirstOrDefault();
            if (j != null)
            {
                Console.WriteLine("查询的{0}在图书馆中/t编号是{1}/t类型是{2}", j.Bookname, j.Bookno, j.Booktype);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("你查找的书尚未收入");
                Console.ReadLine();
            }
        }
        public void jieyue()
        {
            
            
            Console.WriteLine("要进行的操作\t1.借阅历史\t2.借阅\n");
            int o = int.Parse(Console.ReadLine());
            switch (o)
            {
                case 1:
                    Console.WriteLine("你已经借阅了{0}", BoorrowbookRecord.jieyuebooklist.Count);
                    Console.WriteLine("姓名{0}\t图书名\t图书编号\t借阅时间\t");
                    foreach (BoorrowbookRecord bk in BoorrowbookRecord.jieyuebooklist)
                    {
                        Console.WriteLine(" {0}\t\t{ 1}\t\t{ 2}\t{ 3}", bk.StrName, bk.StrBookno, bk.StrBookname, bk.StrTime);
                    }
                    break;
                case 2:
                    Console.WriteLine("请输入你要借阅的书名");
                    string e = Console.ReadLine();
                    var j = Bookroom.newbooklist.Where(s => s.Bookname == e).FirstOrDefault();
                    if (j != null)
                    {
                        string k1 = j.Bookno;
                        string k2 = j.Bookname;
                        string k3 = Convert.ToString(DateTime.Now);
                        yanzheng();
                        Console.WriteLine("请输入你的姓名");
                        string k4 = Console.ReadLine();
                        BoorrowbookRecord.jieyuebooklist.Add(new BoorrowbookRecord(k4, k1, k2, k3));
                        int d = Bookroom.newbooklist.Count - 1;
                        Console.WriteLine("已成功借阅图书《" + j.Bookname + "》\n目前图书馆书籍总量为" + d + " \n借阅时间为：" + k3);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("图书馆没有此书");
                        Console.ReadLine();
                    }
                    break;

            }
            void yanzheng()
            {
                
                Console.WriteLine("请输入你的姓名");
                string h = Console.ReadLine();
                var i = Personroom.newpersonlist.Where(l => l.Personname == h).FirstOrDefault();
                if (i != null)
                {
                    Console.WriteLine("欢迎用户{0}", i.Personname);
                }
                else
                {
                    Console.WriteLine("很抱歉你不是本校用户，不能进行借阅操作");
                    Console.ReadLine();
                }
            }

        }
        public void huanshu()
        {
            Console.WriteLine("请输入要还书的名称");
            string u = Console.ReadLine();
            var v = BoorrowbookRecord.jieyuebooklist.Where(s => s.StrBookname == u).FirstOrDefault();
            if (v != null)
            {
                foreach (BoorrowbookRecord w in BoorrowbookRecord.jieyuebooklist)
                {
                    if (w.StrBookname == v.StrBookname)
                    {
                        BoorrowbookRecord.jieyuebooklist.Remove(w);
                        Console.WriteLine("还书成功");
                        return;
                    }
                }
                int a = BoorrowbookRecord.jieyuebooklist.Count - 1;
                int b = Bookroom.newbooklist.Count + 1;
                Console.WriteLine("当前还有{0}未还，图书馆书总量还有{1}", a, b);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("你查找的书尚未收入");
                Console.ReadLine();

            }
        }
    }
}
