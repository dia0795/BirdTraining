using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    public class Record
    {
        public static List<Record> booklist1 = new List<Record>();
        public static List<Record> booklist2 = new List<Record>();


        private string StrName;
        private string StrNo;
        private string StrBookNo;
        private string StrBookName;
        private string StrTime;
        public Record(string name,string no,string bookno,string bookname,string tm)
        {
            this.StrName = name;
            this.StrNo = no;
            this.StrBookNo = bookno;
            this.StrBookName = bookname;
            this.StrTime = tm;
        }
        public string Strname
        {
            get { return StrName; }
            set { StrName = value; }
        }
        public string Strno
        {
            get { return StrNo; }
            set { StrNo = value; }
        }
        public string Strbookname
        {
            get { return StrBookName; }
            set { StrBookName = value; }
        }
        public string Strbookno
        {
            get { return StrBookNo; }
            set { StrBookNo = value; }
        }
        public string Strtime
        {
            get { return StrTime; }
            set { Strtime = value; }
        }

    }
}
