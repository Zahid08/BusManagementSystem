using Contactto.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Database
{
   public  class Employee_dataaccess
    {
        #region Delete_employee
        public int  Delete_employee(int id)
        {
            //"delete from Employees where id='" + search_textfield.Text + "'";

            string query = "DELETE FROM Employees WHERE id=" + id;
            return Connection_Database.ExecuteQuery(query);
        }
        #endregion

        #region Updae_employee
        public int Update_employee(Employees employee)
        {
            string query = "UPDATE Employees SET Name='" + employee.Name + "', Phone='" + employee.Phone + "', Salary='" + employee.Salary + "', Email='" + employee.Email + "' WHERE id=" + employee.Id;
            return Connection_Database.ExecuteQuery(query);
        }
        #endregion

        #region Get_all_employee
        public List<Employees> GetAll_employee()
        {
            string query = "SELECT * FROM Employees";
            SqlDataReader reader = Connection_Database.GetData(query);

            Employees employee = null;
            List<Employees> employeelist = new List<Employees>();
            while (reader.Read())
            {
                employee = new Employees();
                employee.Id = Convert.ToInt32(reader["id"]);
                employee.Name = reader["Name"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.Salary = reader["Salary"].ToString();
                employee.Email= reader["Email"].ToString();


                employeelist.Add(employee);
            }
            return employeelist;
        }
        #endregion

        #region Get_employee_id
        public Employees Get_employee_id(int id)
        {
            //select id,Name,Phone,Salary,Email from Employees where id LIKE '%" + searc_textBox.Text + "%'";

            string query = "select id,Name,Phone,Salary,Email from Employees  WHERE id=" + id;
            SqlDataReader reader = Connection_Database.GetData(query);
            reader.Read();

            Employees emoply = null;
            if (reader.HasRows)
            {
                emoply = new Employees();
                emoply.Id = Convert.ToInt32(reader["Id"]);
                emoply.Name = reader["Name"].ToString();
                emoply.Phone = reader["Phone"].ToString();
            }
            return emoply;
        }
        #endregion
    }
}
