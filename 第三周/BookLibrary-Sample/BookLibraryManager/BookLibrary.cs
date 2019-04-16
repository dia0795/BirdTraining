using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryManager
{
    public partial class BookLibrary
    {
        public BookLibrary(string libraryName)
        {
            this.LibraryName = libraryName;
            BookList = new List<BookItem>();
            BorrowLogList = new List<BorrowLog>();
            Borrowers = new List<Borrower>();
            Managers = new List<BookManager>();
            BuyLogList = new List<BuyLog>();
            DestoryLogList = new List<DestoryLog>();
            BookMasters = new List<BookMaster>();
        }
        public void InitLibrary()
        {
            //预先注入图书信息，借用者信息，管理员信息
        }
        List<BookItem> BookList;
        List<BorrowLog> BorrowLogList;
        List<Borrower> Borrowers;
        List<BookManager> Managers;
        List<BuyLog> BuyLogList;
        List<DestoryLog> DestoryLogList;
        List<BookMaster> BookMasters;
        public string LibraryName;

        public readonly int MaxLeanCount = 5;
    }
}
