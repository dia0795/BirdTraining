using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryManager
{
    public class BuyLog
    {
        public BookItem BookItem { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Purchaser { get; set; }
        public string PurchaseFrom { get; set; }
    }
}
