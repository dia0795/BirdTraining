using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    public enum strtype
    {
        astronomy,
        geography,
        enginery,
        philosophy
    }
    public class BookFather
    {
        public string ID
        {
            get;
            set;
        }
        public double price
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
      
        public BookFather(string id,double price, string Name)
        {
            this.ID = id;
            this.price = price;
            this.Name = Name;
        }
        public BookFather(string id, string Name)
        {
            this.ID = id;
            this.Name = Name;
        }
    }
}
