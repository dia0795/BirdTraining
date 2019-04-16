using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageSystem
{

        public class Person
        {
            private string personNo;
            private string personName;
            private string personId;
            public Person(string no, string name,string id)
            {
                this.personNo = no;
                this.personName = name;
                this.personId = id;
            }
        public Person(string no, string name)
        {
            this.personNo = no;
            this.personName = name;
        }

        public string PersonNo
            {
                get { return personNo; }
                set { personNo = value; }
            }
            public string PersonName
            {
                get { return personName; }
                set { personName = value; }
            }

        public string PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

    }
}

