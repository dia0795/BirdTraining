using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tushuguanli
{
    public class Book
    {
        private string bookno;
        private string bookname;
        private string booktype;
        public Book(string no, string name, string type)
        {
            this.bookno = no;
            this.bookname = name;
            this.booktype = type;
        }
        public string Bookno
        {
            get { return bookno; }
            set { bookno = value; }
        }
        public string Bookname
        {
            get { return bookname; }
            set { bookname = value; }
        }
        public string Booktype
        {
            get { return booktype; }
            set { booktype = value; }
        }

    }
}
