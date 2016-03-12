using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT191P_Project.App_Code
{
    public class _PackageTransaction 
    {
        int ID, transactionid;
        decimal weight;

        public _PackageTransaction(int ti, decimal w)
        {
            transactionid = ti;
            weight = w;
        }

        public int PackageTransactionID
        {
            get { return ID; }
            set { ID = value; }
        }

        public int TransactionID
        {
            get { return transactionid; }
            set { transactionid = value; }
        }

        public decimal Weight  
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}