using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    public class BookLibrary
    {

        public static List<Book> booklist = new List<Book>();
        public static List<Book> booklist1 = new List<Book>();

        public BookLibrary()
        {
            booklist.Add(new Book("1001", "红楼梦的春秋", "曹雪芹", "文学"));
            booklist.Add(new Book("1002", "C#入门及应用", "清才华", "计算机"));
            booklist.Add(new Book("1003", "德语入门教程", "Sanpy",  "语言学"));
            booklist.Add(new Book("1004", "庄子之逍遥游", "北城达", "哲学"));
            booklist.Add(new Book("1005", "故宫横梁结构", "梁思成", "建筑科学"));
            booklist.Add(new Book("1006", "机械设计原理", "孙大桓", "机械工业"));
        }
        
        
    }
}
