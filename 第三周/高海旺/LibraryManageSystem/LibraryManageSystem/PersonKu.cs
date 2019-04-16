using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{
    public class PersonKu
    {
        public static List<Person> borrowerlist = new List<Person>();
        public static List<Person> managerlist = new List<Person>();

        public  PersonKu()
        {
            borrowerlist.Add(new Person("410914118084","高海旺","学生"));
            borrowerlist.Add(new Person("410914118085", "张无忌","老师"));
            managerlist.Add(new Person("666666","六个六"));
        }
    }
}
