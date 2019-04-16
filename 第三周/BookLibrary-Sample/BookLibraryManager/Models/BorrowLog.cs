using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryManager
{
    public class BorrowLog
    {
        public BookItem BookItem { get; set; }
        public BookManager BookManager { get; set; }
        public Borrower Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string CurrentState { get; set; }
    }
}
