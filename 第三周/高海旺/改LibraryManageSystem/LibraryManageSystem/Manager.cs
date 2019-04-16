using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    class Manager 
    {
       public static string x = "";

        public Manager() 
        {
        
          
        }
        #region(登陆)
        public static void Login(string name,string no)
        {
            var y = Library.userlist.Where(s => s.PersonName == name).FirstOrDefault();
            if (y != null)
            {
                if (y.PersonNo != no)
                {
                    x = "不正确";
                }
                else { x = "正确"; }
            }
            else
            {
                 x = "没注册";
            }
        }
        #endregion
        #region(查找)
        public static void BookSeek()
        {
        }
        #endregion
        #region(采购)
        public static void BookBuy(string l1,string l2,string l3,string l4,string l5)
        {
            Book b6 = new Book(l1, l2, l3,l4,l5);

            Library.booklist.Add(b6);
            Console.WriteLine();
        }
        #endregion
        #region(销毁)
        public static void BookXiaoHui(string bkonlyno)
        {

            var  p = Library.booklist.Where(s => s.BookOnlyno == bkonlyno).FirstOrDefault();
            if (p != null)
            {                                            
                string n1 = "管理员";
                string n2 = "666666";
                string n3 = p.BookOnlyno;
                string n4 = p.BookName;          
                string n6 = Convert.ToString( DateTime.Now);
                if (p.BookStatus == "正常")
                {
                    p.BookStatus = "销毁";
                    string n5 = "销毁";
                    Library.recordlist.Add(new Record(n1, n2, n3, n4, n5, n6));
                    x = "销毁";                  
                }
                else
                {
                    string n5 = p.BookStatus;
                    x = "借出";
                }

            }
            else
            {
                x = "没书";          
            }
        }
        #endregion
        #region(丢失)
        public static void  BookLose(string bkonlyno)
        {
            var p = Library.booklist.Where(s => s.BookOnlyno == bkonlyno).FirstOrDefault();
            if (p != null)
            {
                string n1 = "管理员";
                string n2 = "666666";
                string n3 = p.BookOnlyno;
                string n4 = p.BookName;
                string n6 = Convert.ToString(DateTime.Now);
                if (p.BookStatus == "正常")
                {
                    p.BookStatus = "丢失";
                    string n5 = "丢失";
                    Library.recordlist.Add(new Record(n1, n2, n3, n4, n5, n6));
                    x = "已丢失";
                }
                else
                {
                    string n5 = p.BookStatus;
                    x = "已借出";                  
                }
            }
            else
            {
                x = "没书";
            }
        }
        #endregion
        #region(借书管理)
        public static void BookBorrow(string bookno,string borrowerno)
        {
            var p = Library.userlist.Where(s => s.PersonNo == borrowerno).FirstOrDefault();
            if(p!=null)
            {
                var q = Library.booklist.Where(s => s.BookOnlyno == bookno).FirstOrDefault();
                if(q!=null)
                {
                    if (q.BookStatus != "销毁" && q.BookStatus != "丢失")
                    {
                        x = "借书成功";
                        q.BookStatus = "已借出";
                        string b1 = "借出";

                        string b2 = Convert.ToString(DateTime.Now);
                        Library.recordlist.Add(new Record(p.PersonId, p.PersonNo, q.BookOnlyno, q.BookName, b1, b2));
                    }
                }               
            }



        }
            
        #endregion
        #region(历史记录查询)
        public static void RecordHistory()
        {


        }
        #endregion

    }
}

