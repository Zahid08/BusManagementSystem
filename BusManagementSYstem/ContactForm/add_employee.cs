using Contact.Entity;
using Contactto.Entity;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ContactForm
{
    public partial class add_employee : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        public add_employee()
        {
            InitializeComponent();
        }

        #region others event
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Manage_employee back = new Manage_employee();
            back.Show();
            this.Hide();
        }
        #endregion

        #region add employee event

        private void employee_submit_button_Click(object sender, EventArgs e)
        {
            Employees employ = new Employees();
            employ.Id = Convert.ToInt32( employee_id_textBox.Text);
            employ.Name = employee_name_textBox.Text;
            employ.Phone = employee_phone_textBox.Text;
            employ.Salary = employee_salary_textBox.Text;
            employ.Email = employee_salary_textBox.Text;
            User_service userservice = new User_service();
            if (userservice.Addemployee(employ) > 0)
            {   
                messagebox.Text = "Successfully Added";
            }

        }
        #endregion

        #region search employee
        private void search_textfield_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,Name,Phone,Salary,Email from Employees where id LIKE '%" + search_textfield.Text + "%'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Email");
            //dt.Columns.Add("Total_Seat");
            while (reader.Read() == true)
            {
                dt.Rows.Add(reader["id"], reader["Name"], reader["Phone"], reader["Salary"], reader["Email"]);
            }
            dataGridView1.DataSource = dt;

            conn.Close();
        }
        #endregion

        #region others event
        private void add_employee_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
