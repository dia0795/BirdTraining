using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryManager
{
    public class BookItem
    {
        public BookMaster BookMaster { get; set; }
        public decimal? Price { get; set; }
        public DateTime? BuyDate { get; set; }
        public string CurrentState { get; set; }
        public string BookId { get; set; }
    }
}
