using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace books_Manage
{
    enum Bookstate
    {
        增加图书 = 1, 删除图书 = 2, 修改图书 = 3, 查看图书 = 4, 退出系统 = 5
    }
    /// <summary>
    /// 图书的所有属性
    /// </summary>
    class Book
    {
        private string bookid;
        private string bookname;
        private int bookprice;
        private int bookcount;
        public string Bookid
        {
            get
            {
                return bookid;
            }
            set
            {
                bookid = value;
            }
        }
        public string Bookname
        {
            get
            {
                return bookname;
            }
            set
            {
                bookname = value;
            }
        }
        public int Bookprice
        {
            get
            {
                return bookprice;
            }
            set
            {
                bookprice = value;
            }
        }
        public int Bookcount
        {
            get
            {
                return bookcount;
            }
            set
            {
                bookcount = value;
            }
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {

            bool flag = false;
            List<Book> list = new List<Book>();
            Book b1 = new Book(); ;
            b1.Bookid = "1";
            b1.Bookname = "lanou";
            b1.Bookcount = 12;
            b1.Bookprice = 34;

            BookBean bookbean = new BookBean();
            while (true)
            {
                Console.WriteLine("         图书管理系统");
                Console.WriteLine("*********************************");
                Console.WriteLine("*         1.增加图书            *");
                Console.WriteLine("*         2.删除图书            *");
                Console.WriteLine("*         3.修改图书            *");
                Console.WriteLine("*         4.查看图书            *");
                Console.WriteLine("*         5.退出系统            *");
                Console.WriteLine("*********************************");
                Console.Write("请输入你要进行的操作:");
                int number = int.Parse(Console.ReadLine());
                Bookstate bookstate = (Bookstate)number;
                switch (bookstate)
                {
                    case Bookstate.修改图书:
                        bookbean.updateBook(list);
                        break;
                    case Bookstate.删除图书:
                        list = bookbean.delBook(list);
                        break;
                    case Bookstate.增加图书:
                        list = bookbean.AddBook(list);
                        break;
                    case Bookstate.查看图书:
                        bookbean.ShowBook(list);
                        break;
                    case Bookstate.退出系统:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("没有其对应的输入请重新输入!!!!!");
                        break;
                }
                //点击退出系统后所进行的操作
                if (flag)
                {
                    break;
                }
            }
            Console.WriteLine("退出图书管理系统成功!!!!!!");
        }
    }
    class BookBean
    {
        /// <summary>
        /// 进行图书的添加
        /// </summary>
        public List<Book> AddBook(List<Book> list)
        {
            int temp = list.Count;
            Console.Write("请输入要进行添加的图书的数目:");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("请输入第{0}本书的信息:", (i + 1));
                Console.Write("请输入要添加的图书的编号:");
                string bookid = Console.ReadLine();
                Console.Write("请输入要添加的图书的名称:");
                string bookname = Console.ReadLine();
                Console.Write("请输入要添加的图书的数量:");
                int bookcount = int.Parse(Console.ReadLine());
                Console.Write("请输入要添加的图书的价格:");
                int bookprice = int.Parse(Console.ReadLine());

                Book book = new Book();
                book.Bookid = bookid;
                book.Bookname = bookname;
                book.Bookcount = bookcount;
                book.Bookprice = bookprice;

                list.Add(book);

            }
            if (temp < list.Count)
            {
                Console.WriteLine("添加成功!!!!!");
            }
            else
            {
                Console.WriteLine("添加失败!!!!!");
            }
            return list;
        }
        /// <summary>
        /// 进行图书的查看
        /// </summary>
        /// <param name="list">List.</param>
        public void ShowBook(List<Book> list)
        {
            int counti = 1;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("       |   图书编号   |   图书名称   |  图书价格  |  图书数量   |");
            Console.WriteLine("-------|---------------------------------------------------------");
            foreach (var item in list)
            {
                Console.Write("   {0}   |      {1}       |      {2}      |     {3}       |     {4}       |", counti, item.Bookid, item.Bookname, item.Bookprice, item.Bookcount);
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");
                counti++;
            }

            Console.WriteLine();
            Console.WriteLine("一共{0}条数据!!!!", list.Count);
            Console.WriteLine();
        }
        /// <summary>
        /// 进行图书的删除
        /// </summary>
        /// <param name="list">List.</param>
        public List<Book> delBook(List<Book> list)
        {
            int temp = list.Count;
            Console.Write("请输入你要删除的图书的名字:");
            string strname = Console.ReadLine();
            int temp1 = 0;
            int column = 0;
            foreach (Book item in list)
            {
                if (item.Bookname == strname)
                {
                    temp1 = column;
                }
                column++;
            }
            list.RemoveAt(temp1);
            if (temp > list.Count)
            {
                Console.WriteLine("删除成功!!!!!");
                column = 0;
            }
            else
            {
                Console.WriteLine("删除失败!!!!!");
            }
            return list;
        }

        /// <summary>
        /// 进行图书的修改
        /// </summary>
        /// <returns>The book.</returns>
        /// <param name="list">List.</param>
        public void updateBook(List<Book> list)
        {
            bool flag = false;
            Console.Write("请输入要进行修改的学生的姓名:");
            string strname = Console.ReadLine();

            int temp1 = 0;
            int column = 0;
            foreach (Book item in list)
            {
                if (item.Bookname == strname)
                {
                    temp1 = column;
                }
                column++;
            }
            Console.WriteLine();
            Console.WriteLine("图书的信息为:");
            Console.WriteLine("图书的编号:{0}", list[temp1].Bookid);
            Console.WriteLine("图书的名称:{0}", list[temp1].Bookname);
            Console.WriteLine("图书的数量:{0}", list[temp1].Bookcount);
            Console.WriteLine("图书的价格:{0}", list[temp1].Bookprice);

            Console.WriteLine();

            Console.WriteLine("请选择要进行修改的信息:");
            Console.WriteLine("1.图书编号!!!");
            Console.WriteLine("2.图书名称!!!");
            Console.WriteLine("3.图书数量!!!");
            Console.WriteLine("4.图书价格!!!");
            Console.WriteLine("5.退出修改!!!");

            Console.Write("请选择:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Console.Write("请输入要修改成的图书编号:");
                        string strbookid = Console.ReadLine();
                        list[temp1].Bookid = strbookid;
                        //判断是否修改成功
                        if (list[temp1].Bookid == strbookid)
                        {
                            Console.WriteLine("修改成功!!!!!");
                        }
                        else
                        {
                            Console.WriteLine("修改失败!!!!!");
                        }
                    }
                    break;
                case 2:
                    {
                        Console.Write("请输入要修改成的图书名称:");
                        string strbookname = Console.ReadLine();
                        list[temp1].Bookname = strbookname;
                        //判断是否修改成功
                        if (list[temp1].Bookname == strbookname)
                        {
                            Console.WriteLine("修改成功!!!!!");
                        }
                        else
                        {
                            Console.WriteLine("修改失败!!!!!");
                        }
                    }
                    break;
                case 3:
                    {
                        Console.Write("请输入要修改成的图书价格:");
                        int strbookprice = int.Parse(Console.ReadLine());
                        list[temp1].Bookprice = strbookprice;
                        //判断是否修改成功
                        if (list[temp1].Bookprice == strbookprice)
                        {
                            Console.WriteLine("修改成功!!!!!");
                        }
                        else
                        {
                            Console.WriteLine("修改失败!!!!!");
                        }
                    }
                    break;
                case 4:
                    {
                        Console.Write("请输入要修改成的图书数量:");
                        int strbookcount = int.Parse(Console.ReadLine());
                        list[temp1].Bookcount = strbookcount;
                        //判断是否修改成功
                        if (list[temp1].Bookcount == strbookcount)
                        {
                            Console.WriteLine("修改成功!!!!!");
                        }
                        else
                        {
                            Console.WriteLine("修改失败!!!!!");
                        }
                    }
                    break;
                case 5:
                    flag = true;
                    break;
            }
            if (flag)
            {
                Console.WriteLine("退出修改成功!!!!");
            }

        }
    }

}
