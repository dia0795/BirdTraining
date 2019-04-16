using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    class ReturnBook
    {
        public string ID
        {
            get;
            set;
        }
        public void Return(string id)
        {
            this.ID = id;
        
        }
    }
}
