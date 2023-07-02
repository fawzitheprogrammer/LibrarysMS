using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClass;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace Authentication
{
    public class login
    {

        // Two  private variable to take userID & roleID value later on this code
        private static int userID;

        // Two  private variable to take name & role value later on this code
        private static string user,username, position;

        public static String User
        {

            get { return user; }
            set { user = value; }
        }



        // a static class to get ser ID
        public static int UserID
        {

            get { return userID; }
            set { userID = value; }
        }


        // a static class to get and set name for username 
        public static string Username
        {

            get { return username; }
            set { username = value; }
        }


        // a static class to get and set role for user
        public static string Position
        {

            get { return position; }
            set { position = value; }
        }


        // Implementaion of getting user from the database reading and then getting the value
        public static bool getLoginDetails(string proc,Hashtable ht)
        {

            bool isChecked = false;

            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // looping through hash table to get the data input from the user
                foreach(DictionaryEntry item in ht)
                {
                    // sending the data to the stored procedure that we have created
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                mainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    isChecked = true;
                    while (dr.Read())
                    {
                        UserID = Convert.ToInt32(dr[0].ToString());
                        
                        User = dr[1].ToString();
                        Position = dr[4].ToString();
                        Username = dr[2].ToString();

                        Console.WriteLine(Username + " " + Position);
                    }
                }
                else
                {
                    isChecked = false;
                    mainClass.showMessage("Username, password or use type is incorrect, please try again.", false);
                }
                mainClass.con.Close();
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.showMessage(ex.ToString(), false);
            }

            return isChecked;

        }
    }
}
