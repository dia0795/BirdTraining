using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tushuguanlixitong
{
   public  class Count
    {
        private  int _count;
        private int _bookid;
        public int count
        {
            get { return _count; }
            set { _count = value; }
        }
        public int Bookid
        {
            get { return _bookid; }
            set { _bookid = value; }
        }
        public  Count ( int bookid ,int count1)
        {
            this._count = count1;
            this._bookid = bookid;
        }

    }
}
