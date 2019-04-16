using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tushuguanli
{
    class Personroom
    {
        public static List<Person> newpersonlist = new List<Person>();
        public static List<Person> Administrators = new List<Person>();
        public Personroom()
        {
            Person s1 = new Person("410914118081", "白峰云");
            newpersonlist.Add(s1);
            newpersonlist.Add(new Person("410914118083", "钟伟"));
            Administrators.Add(new Person("001", "管理员"));
        }
    }
}
