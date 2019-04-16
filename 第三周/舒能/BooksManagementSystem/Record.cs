using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    public class Record
    {
        public static List<Record> booklist = new List<Record>();
        public static List<Record> booklist1 = new List<Record>();


        private string borrowerName;
        private string borrowerNo;
        private string borrowBookNo;
        private string borrowBookName;
        private string borrowTime;
        public Record(string name, string no, string bookno, string bookname, string time)
        {
            this.borrowerName = name;
            this.borrowerNo = no;
            this.borrowBookNo = bookno;
            this.borrowBookName = bookname;
            this.borrowTime = time;
        }
        public string BorrowerName
        {
            get { return borrowerName; }
            set { borrowerName = value; }
        }
        public string BorrowerNo
        {
            get { return borrowerNo; }
            set { borrowerNo = value; }
        }
        public string BorrowBookNo
        {
            get { return borrowBookNo; }
            set { borrowBookNo = value; }
        }
        public string BorrowBookName
        {
            get { return borrowBookName; }
            set { borrowBookName = value; }
        }
        public string BorrowTime
        {
            get { return borrowTime; }
            set { borrowTime = value; }
        }

    }
}
