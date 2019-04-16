using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Management_System
{
    public class Student : Borrower
    {
        public Student(string workerNumber, string workerName, int workerPassNumber):base(workerNumber, workerName, workerPassNumber)
            {

             }
    }
}
