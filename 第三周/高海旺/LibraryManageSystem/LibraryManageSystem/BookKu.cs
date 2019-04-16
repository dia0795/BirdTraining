using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    public class BookKu
    {
       public static List<Book> booklist = new List<Book>();

        private static BookKu bk = null;
        private BookKu()
        {
            booklist.Add(new Book("001", "西游记", "文学"));
            booklist.Add(new Book("002", "水浒传", "文学"));
            booklist.Add(new Book("003", "C#入典", "应用"));
            booklist.Add(new Book("004", "36讲", "教育"));
            booklist.Add(new Book("005", "养猪全", "农学"));
        }
        public static BookKu GetInstance()
        {
            if(bk==null)
            {
                bk = new BookKu();

            }
            return bk;
        }

    }
}
