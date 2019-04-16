using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tushuguanlixitong
{
    public class Books
    {
        private int _id;
        private string _name;
        private string _category;
        //private int _number;
        //public int Number
        //{
        //    get { return _number; }
        //    set { _number = value; }
        //}
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public Books(int id, string name, string category)
        {
            this._id = id;
            this._name = name;
            this._category = category;
            //this._number = number;
        }
    }
}
