using Contactto.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Database
{
   public class Choach_dataaccess
    {
        // Choch person = new Choch();
        #region Get_destination_method
        public Choch GetBydestination(string destination)
        {
           string query= "select Choach_No,Register,Date_Time,Source,Destination,Total_Seat,No_Seat,Seat_available from Choach  where Destination =" + destination;
            SqlDataReader reader = Connection_Database.GetData(query);
            reader.Read();
            Choch chach = null;
            if (reader.HasRows)
            {
                chach = new Choch();
                chach.Choch_No = reader["Choach_No"].ToString();
                chach.Registration= reader["Register"].ToString();
                chach.Date_Time = reader["Date_Time"].ToString();
                chach.Source = reader["Source"].ToString();
                chach.Destination = reader["Destination"].ToString();
                chach.Total_Seat= reader["Total_Seat"].ToString();

                chach.Seat_no= reader["No_Seat"].ToString();
                chach.Available_Seat= reader["Seat_available"].ToString();

            }
            return chach;
        }
        #endregion
        public int Add_Choach(Choch choach)
        {
            string query = string.Format("INSERT INTO Choach(Choach_No,Register,Date_Time,Source,Destination,Total_Seat,No_Seat,Seat_available,Amount) VALUES('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", choach.Choch_No, choach.Registration,choach.Date_Time,choach.Source,choach.Destination,choach.Total_Seat,Convert.ToInt32(choach.Seat_no) ,Convert.ToInt32( choach.Available_Seat),Convert.ToInt32(choach.Amount));
            return Connection_Database.ExecuteQuery(query);
        }

    }
}
