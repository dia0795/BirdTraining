using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlibraryManage
{
    class Book
    {
        public int id;
        public string name;
        public string sort;
        public string situation;
        public int renterID;

        public Book(int id, string name, string sort)
        {
            this.id = id;
            this.name = name;
            this.sort = sort;
            situation = "可借";
            renterID = -1;//默认可借
        }

        public bool Rent(int renterID)
        {
            if (this.renterID != -1)
            {
                Console.WriteLine("本书已借出！\n借书失败");
                return false;
            }
            else
            {
                this.renterID = renterID;
                situation = "借出";
                Console.WriteLine("借书成功！");
                return true;
            }
        }

        public void Return()
        {
            renterID = -1;
            situation = "可借";
            Console.WriteLine("还书成功！");
        }
    }
}
