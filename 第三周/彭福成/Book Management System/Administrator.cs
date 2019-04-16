using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Management_System
{
    public class Administrator:Borrower
    {
        public Administrator(string workerNumber, string workerName, int workerPassNumber) : base(workerNumber, workerName, workerPassNumber)
        {

        }
    }
}
