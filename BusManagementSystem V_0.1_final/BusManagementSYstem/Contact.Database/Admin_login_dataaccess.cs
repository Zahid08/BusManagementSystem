using Contact.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Database
{
    public class Admin_login_dataaccess
    {
        #region Getlogin_Method
        public List<Admin_entity> GetLogin()
        {
            string query = "SELECT  * FROM Admin_base";
            SqlDataReader reader = Connection_Database.GetData(query);
            Admin_entity adminlogin = null;
            List<Admin_entity> loginlist = new List<Admin_entity>();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                adminlogin.Username = reader["Username"].ToString();
 //               adminlogin.Username = reader["Username"].ToString();
                adminlogin.Pasword = reader["Password"].ToString();
               
                loginlist.Add(adminlogin);
            }
            return loginlist;


        }
        #endregion
    }
}
