using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    class Library
    {
        private static Library lb = null;
        public static List<Person> userlist = new List<Person>();
        public static List<Book> booklist = new List<Book>();
        public static List<Record> recordlist = new List<Record>();

        public Library()
        {
            booklist.Add(new Book("001", "西游记", "文学","201901","正常"));
            booklist.Add(new Book("001", "西游记", "文学", "201902", "正常"));
            booklist.Add(new Book("002", "水浒传", "文学", "201903", "正常"));
            booklist.Add(new Book("002", "水浒传", "文学", "201904", "正常"));
            booklist.Add(new Book("003", "C#入典", "应用", "201905", "正常"));
            booklist.Add(new Book("003", "C#入典", "应用", "201906", "正常"));
            booklist.Add(new Book("004", "36讲", "教育", "201907", "正常"));
            booklist.Add(new Book("005", "养猪全", "农学", "201908", "正常"));

            userlist.Add(new Person("123321", "高海旺", "学生"));
            userlist.Add(new Person("001002", "张无忌", "老师"));
            userlist.Add(new Person("666666", "六个六","管理员"));
        }
        public static Library GetInstance()
        {
            if (lb == null)
            {
               Library lb = new Library();

            }
            return lb;
        }
    }
}
