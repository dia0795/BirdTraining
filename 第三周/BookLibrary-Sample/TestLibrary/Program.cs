using BookLibraryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            BookLibrary bookLibrary = new BookLibrary("南昌大学图书馆");
            bookLibrary.InitLibrary();

            var master = bookLibrary.QueryBookMaster("机械设计").FirstOrDefault();
            if (master == null) return;

            bookLibrary.CreateBookItems(master, 100m, 10);
            //bookLibrary.CreateBookItems()
            bookLibrary.BuyBook();

            //登录
            //加载自己的借书记录，通过borrowerId
            //var borrowLogList = bookLibrary.GetBorrowLogByUserId("111");
            
        }

    }
}
