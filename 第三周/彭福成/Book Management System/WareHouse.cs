using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Management_System
{
    class WareHouse
    {
        List<List<Book>> list = new List<List<Book>>();
        /// <summary>
        /// 仓库书籍展示方法
        /// </summary>
        public void ShowBooks()
        {
            foreach (var item in list)
            {
                Console.WriteLine("图书馆有"+item[0].BookName+"，数量是"+item.Count+"本,"+"每本价格是"+item[0].Price+"元。");
            }
        }
        /// <summary>
        /// 存储书籍
        /// list[0]存Literature书籍
        /// list[1]存Engineer书籍
        /// list[2]存Art类书籍
        /// list[3]存OldBook书籍
        /// list[4]存Magine书籍
        /// </summary>
        public WareHouse()
        {
            list.Add(new List<Book>());
            list.Add(new List<Book>());
            list.Add(new List<Book>());
            list.Add(new List<Book>());
            list.Add(new List<Book>());

        }
        /// <summary>
        /// 进书
        /// </summary>
        /// <param name="bookTyper">书的类型</param>
        /// <param name="count">进书的数量</param>
        public void JinBook(string bookTyper,int count)
        {
            for (int i = 0; i<count; i++)
            {
                switch (bookTyper)
                {
                    case "Literature":list[0].Add(new Literature(Guid.NewGuid().ToString(), "Literature", 50)); break;
                    case "Engineering": list[1].Add(new Engineering(Guid.NewGuid().ToString(), "Engineering", 69)); break;
                    case "Art": list[2].Add(new Art(Guid.NewGuid().ToString(), "Art", 35)); break;
                    case "OldBook": list[3].Add(new OldBook(Guid.NewGuid().ToString(), "OldBook", 20)); break;
                    case "Magazine": list[4].Add(new Magazine(Guid.NewGuid().ToString(), "Magazine", 28)); break;

                }
            }
        }
        /// <summary>
        /// 从仓库中取出书籍
        /// </summary>
        /// <param name="bookTyper">取出书籍的类型</param>
        /// <param name="count">取出书籍的数量</param>
        /// <returns></returns>
        public Book[] LoanBook(string bookTyper, int count)
        {
            Book[] books = new Book[count];
            for (int i = 0; i < count; i++)
            {
                switch (bookTyper)
                {
                    case "Literature":books[i] = list[0][0];list[0].RemoveAt(0) ;break;
                    case "Engineering":books[i]= list[1][0]; list[1].RemoveAt(0); break;
                    case "Art": books[i]=list[2][0]; list[2].RemoveAt(0); break;
                }
            }
            return books;
        }
        public Book[] ReturnBook(string bookTyper,int count)
        {
            Book[] books = new Book[count];
            for (int i = 0; i < count; i++)
            {
                switch (bookTyper)
                {
                    case "Literature": books[i] = list[0][0]; list[0].Add (books[i]); break;
                    case "Engineering": books[i] = list[1][0]; list[1].Add(books[i]); break;
                    case "Art": books[i] = list[2][0]; list[2].Add(books[i]); break;
                }
            }
            return books;
        }

    }
}
