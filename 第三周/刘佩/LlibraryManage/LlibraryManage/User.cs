using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlibraryManage
{
    class User
    {
        public int id;
        public string name;
        public string sort;

        public User(int vid,string vname,string vsort)
        {
            id = vid;
            name = vname;
            sort = vsort;
        }
    }
}
