using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryManager
{
    public class DestoryLog
    {
        public BookItem BookItem { get; set; }
        public string DestoryReason { get; set; }
        public string DestoryBy { get; set; }
        public DateTime? DestoryDate { get; set; }
    }
}
