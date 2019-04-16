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

        public Book(string no, string name, string type)
        {
            this.bookNo = no;
            this.bookName = name;
            this.bookType = type;
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

    }

}
