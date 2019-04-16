using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建管理员对象
            Management M = new Management();
            //创建流动库对象
            BookLibrary bl = new BookLibrary(); 
            M.SetLibrary(bl);
            
            //展示书籍
            bl.Books();
            M.AddBook();
            M.ShowBook();
            //跟借阅者交互
            Borrowers B = new Borrowers();
            B.BorrowerPeople(bl);
            //借书
            B.Borrow(bl);
            //还书
            B.Return(bl);
            Console.ReadKey();
         
        }
    }
}
