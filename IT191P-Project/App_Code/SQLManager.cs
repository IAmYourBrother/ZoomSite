using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
/*
 *Collection of SQL Commands 
 * made easier through classes
 */
namespace IT191P_Project.App_Code
{
    public class SQLManager
    {
        //=========ADD========//
        public static void SQLAdd(_User U)
        {
            var cs = ConfigurationManager.ConnectionStrings["ZoomDB"];
            string connection = cs.ConnectionString;

            SqlConnection sqlconnect = new SqlConnection(connection);
            SqlCommand add = new SqlCommand("INSERT INTO [USER] VALUES(@LNAME, @FNAME, @MNAME, @SEX, @MOBILENO, @PASSWORD, @USERNAME, @TYPE, @EMAIL)", sqlconnect);

            add.Parameters.AddWithValue("LNAME", U.Lname);
            add.Parameters.AddWithValue("FNAME", U.Fname);
            add.Parameters.AddWithValue("MNAME", U.Mname);
            add.Parameters.AddWithValue("SEX", U.Sex);
            add.Parameters.AddWithValue("MOBILENO", U.MobileNo);
            add.Parameters.AddWithValue("PASSWORD", U.Password);
            add.Parameters.AddWithValue("USERNAME", U.Username);
            add.Parameters.AddWithValue("TYPE", U.Type);
            add.Parameters.AddWithValue("EMAIL", U.Email);

            sqlconnect.Open();

            add.ExecuteNonQuery();

            sqlconnect.Close();

        }
        //=========END_ADD========//


        //=========EDIT========//
        public static void SQLEdit(_User u)
        {
            var cs = ConfigurationManager.ConnectionStrings["ZoomDB"];
            string connection = cs.ConnectionString;

            SqlConnection sqlconnect = new SqlConnection(connection);
            SqlCommand edit = new SqlCommand("UPDATE [USER] SET [LNAME]=@LNAME, [FNAME]=@FNAME, [MNAME]=@MNAME, [SEX]=@SEX, [EMAIL_ADD]=@EMAIL, [MOBILE_NO]=@MOBILE, [USERNAME]=@USERNAME, [PASSWORD]=@PASS WHERE [ID] = @ID", sqlconnect);

            edit.Parameters.AddWithValue("LNAME", u.Lname);
            edit.Parameters.AddWithValue("FNAME", u.Fname);
            edit.Parameters.AddWithValue("MNAME", u.Mname);
            edit.Parameters.AddWithValue("SEX", u.Sex);
            edit.Parameters.AddWithValue("EMAIL", u.Email);
            edit.Parameters.AddWithValue("MOBILE", u.MobileNo);
            edit.Parameters.AddWithValue("USERNAME", u.Username);
            edit.Parameters.AddWithValue("PASS", u.Password);
            edit.Parameters.AddWithValue("ID", u.UserID);

            sqlconnect.Open();

            edit.ExecuteNonQuery();

            sqlconnect.Close();


        }
        //=========END_EDIT========//


        //=========VIEW========//

        
        //RETRIEVE USERDATA THROUGH SESSION LOGIN ID
        public static _User SQLRetrieveUserData(int id)
        {
            _User u;
            var cs = ConfigurationManager.ConnectionStrings["ZoomDB"];
            string connection = cs.ConnectionString;

            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(connection);

            SqlCommand com = new SqlCommand("SELECT * FROM [USER] WHERE ID=@ID", con);

            com.Parameters.AddWithValue("ID", id);

            con.Open();

            reader = com.ExecuteReader();
            reader.Read();

            string ln = reader["LNAME"].ToString();
            string fn = reader["FNAME"].ToString();
            string mn = reader["MNAME"].ToString();
            string mobile = reader["MOBILE_NO"].ToString();
            string email = reader["EMAIL_ADD"].ToString();
            string user = reader["USERNAME"].ToString();
            string pass = reader["PASSWORD"].ToString();
            string type = reader["USERTYPE"].ToString();
            char sex = Convert.ToChar(reader["SEX"].ToString());


            u = new _User(ln, fn, mn, mobile, email, user, pass, type, sex);


            con.Close();

            return u;
        }

        //FOR USER CHECKING ONLY, IMPROVE CODE WHEN POSSIBLE (SECURITY)
        public static List<string[]> SQLUserVerification()
        {
            List <string[]> user=new List<string[]>();
            

            var cs = ConfigurationManager.ConnectionStrings["ZoomDB"];
            string connection = cs.ConnectionString;

            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(connection);

            SqlCommand com = new SqlCommand("SELECT [USER].ID, [USER].[USERNAME], [USER].[PASSWORD] FROM [USER]", con);


            con.Open();

            reader = com.ExecuteReader();
            while(reader.Read())
            {
                string[] info = new string[3];

                info[0] = reader["ID"].ToString();
                info[1] = reader["USERNAME"].ToString();
                info[2] = reader["PASSWORD"].ToString();
                user.Add(info);
            }

            con.Close();

            return user;
        }


        //=========END_VIEW========//


        //=========DELETE========//
        public static void SQLDelete()
        {

        }
        //=========END_DELETE========//
    }
}