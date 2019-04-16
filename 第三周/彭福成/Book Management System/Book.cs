using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Management_System
{
    public class Book
    {
        private string _serialNumbers;
        public string  SerialNumbers
        {
            get
            {
                return _serialNumbers;
            }

            set
            {
                _serialNumbers = value;
            }
        }

        private string _bookName;
        public string BookName
        {
            get
            {
                return _bookName;
            }

            set
            {
                _bookName = value;
            }
        }

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public Book(string serialNumbers,string bookName, double price)
        {
            this.SerialNumbers = serialNumbers;
            this.BookName = bookName;
            this.Price = price;
        }

        public Book()
        {
        }
    }
}
