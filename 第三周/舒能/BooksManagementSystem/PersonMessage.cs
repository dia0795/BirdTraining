using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    public class PersonMessage
    {
        public static List<Person> borrowerlist = new List<Person>();
        public static List<Person> managerlist = new List<Person>();

        public PersonMessage()
        {
            borrowerlist.Add(new Person("118097", "舒能", "学生"));
            borrowerlist.Add(new Person("118777", "七七七", "学生"));
            borrowerlist.Add(new Person("123456", "小明", "老师"));
            borrowerlist.Add(new Person("123456", "小花", "老师"));
            managerlist.Add(new Person("000000", "六零"));
            managerlist.Add(new Person("111111", "六一"));
        }
    }

}
