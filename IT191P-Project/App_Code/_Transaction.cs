using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT191P_Project.App_Code
{
    public class _Transaction
    {
        int ID, customerid;
        bool status;
        string trackingno, source, destination, type;
        decimal payment;

        public _Transaction (string tn, int cn, string sl, string dl, bool s, string t, decimal p)
        {
            trackingno = tn;
            customerid = cn;
            source = sl;
            destination = dl;
            status = s;
            type = t;
            payment = p;
        }

        public string TrackingNo
        {
            get { return trackingno; }
            set { trackingno = value; }
        }

        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int CustomerID
        {
            get { return customerid; }
            set { customerid = value; }
        }

        public int TransactionID
        {
            get { return ID; }
            set { ID = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public decimal Payment
        {
            get { return payment; }
            set { payment = value; }
        }



    }
}