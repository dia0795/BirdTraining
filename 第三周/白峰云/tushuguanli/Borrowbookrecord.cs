using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tushuguanli
{
    public class BoorrowbookRecord
    {
        public static List<BoorrowbookRecord> jieyuebooklist = new List<BoorrowbookRecord>();

        private string Strname;
        private string Strbookno;
        private string Strbookname;
        private string Strtime;
        public BoorrowbookRecord(string name, string bookno, string bookname, string tm)
        {
            this.Strname = name;
            this.Strbookno = bookno;
            this.Strbookname = bookname;
            this.Strtime = tm;
        }
        public string StrName
        {
            get { return Strname; }
            set { Strname = value; }
        }
        public string StrBookname
        {
            get { return Strbookname; }
            set { Strbookname = value; }
        }
        public string StrBookno
        {
            get { return Strbookno; }
            set { Strbookno = value; }
        }
        public string StrTime
        {
            get { return Strtime; }
            set { Strtime = value; }

        }
    }
}
