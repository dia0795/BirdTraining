using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Management_System
{
    public abstract class Teacher : Borrower
    {
        public Teacher(string workerNumber, string workerName, int workerPassNumber) : base(workerNumber, workerName, workerPassNumber)
        {
        }
        public override  void BorrowBooksList()
        { 
            List<List<Book>> list = new List<List<Book>>();
            list[0].Add(new Literature(Guid.NewGuid().ToString(), "Literature",50));
            foreach (var item in list)
            {
                Console.WriteLine("老师图书馆可以" + item[0].BookName + "，数量是" + item.Count + "本," );
            }
         }
    
    }
}
