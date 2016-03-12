using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IT191P_Project.App_Code;

namespace IT191P_Project.Business_Site
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            CheckCredentials();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        void CheckCredentials()
        {
            if((!string.IsNullOrEmpty(txtUsername.Text))&&(!string.IsNullOrEmpty(txtPassword.Text)))
            {
                int id = retrieveUser();
                
                //Login to the system if there are a match
                if(id!=0)
                {
                    Session["ID"] = id;
                    Response.Redirect("/Admin Site/Dashboard.aspx");
                }

                //ADMIN LOGIN (IMPROVE WHEN POSSIBLE FOR SECURITY!)
                if(txtUsername.Text.Equals("Admin") && txtPassword.Text.Equals("Admin"))
                {
                    Session["ID"] = -1;
                    Response.Redirect("/Admin Site/Dashboard.aspx");
                }
                cvUserExist.IsValid = false;
            }
        }


        //Retrieve the User function
        int retrieveUser()
        {
            List <string[]> user = SQLManager.SQLUserVerification();

            foreach(string[] s in user)
            {
                if(s[1]==txtUsername.Text)
                {
                    //Check if password matches with input password
                    if(s[2]==txtPassword.Text)
                    {
                        //If it matches return the User ID
                        return Convert.ToInt32(s[0]);
                    }
                }
            }
            // no ID found
            return 0;
        }
    }
}