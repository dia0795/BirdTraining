using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tushuguanli
{
    class Person
    {
        private string personnumber;
        private string personname;
        public Person(string number, string name)
        {
            this.personnumber = number;
            this.personname = name;
        }
        public string Personnumber
        {
            get { return personnumber; }
            set { personnumber = value; }
        }
        public string Personname
        {
            get { return personname; }
            set { personname = value; }
        }
        }
}
