using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT191P_Project.App_Code
{
    public class _MoneyTransaction
    {
        int ID, transactionid;
        decimal amount;

        public _MoneyTransaction(int ti, decimal a)
        {
            transactionid = ti;
            amount = a;
        }

        public int MoneyTransactionID
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
            get { return amount; }
            set { amount = value; }
        }
    }
}