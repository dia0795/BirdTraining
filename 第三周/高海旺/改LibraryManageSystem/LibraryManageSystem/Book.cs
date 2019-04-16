using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    public class Book
    {
        private string bookNo;
        private string bookName;
        private string bookType;
        private string bookOnlyno;
        private string bookStatus;

        public Book(string no, string name, string type,string onlyno,string status)
        {
            this.bookNo = no;
            this.bookName = name;
            this.bookType = type;
            this.bookOnlyno = onlyno;
            this.bookStatus = status;
        }

        public string BookNo
        {
            get { return bookNo; }
            set { bookNo = value; }
        }
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        public string BookOnlyno
        {
            get { return bookOnlyno; }
            set { bookOnlyno = value; }
        }
        public string BookStatus
        {
            get { return bookStatus; }
            set { bookStatus = value; }
        }

    }

}
