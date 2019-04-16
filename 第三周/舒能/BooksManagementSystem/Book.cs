using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    public class Book
    {
        private string bookNo, bookName, bookAuthor,bookType;
        
        public Book(string no,string name,string author,string type)
        {
            this.bookNo = no;
            this.bookName = name;
            this.bookAuthor = author;
            this.bookType = type;
            
        }
        public string BookNo
        {
            get { return bookNo; }
            set { bookNo = value; }
        }
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        
    }
    
}
