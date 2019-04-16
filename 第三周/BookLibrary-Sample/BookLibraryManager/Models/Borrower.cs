using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryManager
{
    public class Borrower
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public bool UseFlag { get; set; }
    }
}
