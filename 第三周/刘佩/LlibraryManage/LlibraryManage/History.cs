using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlibraryManage
{
    class History
    {
        public int bookID;
        public int userID;
        public string rentTime;
        public string returnTime;

        public History(int bookid, int userid)
        {
            bookID = bookid;
            userID = userid;
            rentTime = DateTime.Now.ToString();
        }
    }
}
