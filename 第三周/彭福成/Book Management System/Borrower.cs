using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Book_Management_System
{
    public abstract class Borrower
    {


        private string _workerNumber;
        public string WorkerNumber
        {
            get
            {
                return _workerNumber;
            }

            set
            {
                _workerNumber = value;
            }
        }
        private string _workerName;
        public string WorkerName
        {
            get
            {
                return _workerName;
            }

            set
            {
                _workerName = value;
            }
        }
        private int _workerPassNumber;
        public int WorkerPassNumber
        {
            get
            {
                return _workerPassNumber;
            }

            set
            {
                _workerPassNumber = value;
            }
        }

        public Borrower(string workerNumber, string workerName, int workerPassNumber)
        {
            this.WorkerNumber = workerNumber;
            this.WorkerName = workerName;
            this.WorkerPassNumber = workerPassNumber;
        }

        public Borrower()
        {
        }

        public abstract void BorrowBooksList();
        




    }
