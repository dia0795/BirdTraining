using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    public class Record
    {
        private string StrHandlerID;
        private string StrHandlerNo;
        private string StrBookOnlyNo;
        private string StrBookName;
        private string StrHandlerName;
        private string StrTime;
        public Record(string handlerid,string handlererno,string bookonlyno,string bookname, string handldername, string tm)
        {
            this.StrHandlerID = handlerid;
            this.StrHandlerNo = handlererno;
            this.StrBookOnlyNo = bookonlyno;
            this.StrBookName = bookname;
            this.StrHandlerName = handldername;
            this.StrTime = tm;
        }
        public string Strhandlerid
        {
            get { return StrHandlerID; }
            set { StrHandlerID = value; }
        }
        public string Strhandlername
        {
            get { return StrHandlerName; }
            set { StrHandlerName = value; }
        }
        public string Strhandlerno
        {
            get { return StrHandlerNo; }
            set { StrHandlerNo = value; }
        }
        public string Strbookname
        {
            get { return StrBookName; }
            set { StrBookName = value; }
        }
        public string Strbookno
        {
            get { return StrBookOnlyNo; }
            set { StrBookOnlyNo = value; }
        }
        public string Strtime
        {
            get { return StrTime; }
            set { Strtime = value; }
        }

    }
}
