using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT191P_Project.App_Code
{
    public class _Branch
    {
        int ID, branchownerid, branchmanagerid;
        string location;

        public _Branch(string l, int boi, int bmi)
        {
            location = l;
            branchownerid = boi;
            branchmanagerid = bmi;
        }

        public int FranchiseID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public int BranchOwnerID
        {
            get { return branchownerid; }
            set { branchownerid = value; }
        }
        public int BranchManagerID
        {
            get { return branchmanagerid; }
            set { branchmanagerid = value; }
        }
    }
}