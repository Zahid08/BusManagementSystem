using Contact.Entity;
using Contactto.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Database
{
   public class User_Dataaccess
    {
        public int Add(User_Entity user)
        {
            string query = string.Format("INSERT INTO User_base(Name,Email,Username,Phone,Password) VALUES('{0}', '{1}','{2}','{3}','{4}')", user.Name,user.Email,user.Username,user.Phone,user.Password);
            return Connection_Database.ExecuteQuery(query);
        }
        public int Addemployee(Employees emp)
        {
            string query = string.Format("INSERT INTO Employees (id,Name,Phone,Salary,Email) VALUES ('{0}', '{1}','{2}','{3}','{4}')", emp.Id, emp.Name,emp.Phone, emp.Salary, emp.Email);
            return Connection_Database.ExecuteQuery(query);
        }
        public List<User_Entity> GetLogin()
        {
            string query = "SELECT  Username,Password FROM User_base";
            SqlDataReader reader = Connection_Database.GetData(query);
            User_Entity login = null;
            List<User_Entity> loginlist = new List<User_Entity>();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                login.Username = reader["Username"].ToString();
                login.Password = reader["Password"].ToString();
                loginlist.Add(login);
            }
            return loginlist;


        }
       
        //add passenger
        public int Add_passenger(User_Entity passenger)
        {
            string query = string.Format("INSERT INTO Passenger(Name,Phone,Choach_no,Seat_name) VALUES('{0}', '{1}','{2}','{3}')", passenger.Name, passenger.Phone, passenger.Choch_No,passenger.Seat_no);
            return Connection_Database.ExecuteQuery(query);
        }

        public int Edit_seat(Choch seat)
        {
             string query= "UPDATE Choach SET No_Seat=No_Seat+'" + seat.Seat_no + "'  WHERE Choach_No=" + seat.Choch_No;
            return Connection_Database.ExecuteQuery(query);
        }
       



        public int Delete(string serach)
        {
            string query = "DELETE FROM Employees WHERE id=" + serach;
            return Connection_Database.ExecuteQuery(query);
        }

       
    }
}
