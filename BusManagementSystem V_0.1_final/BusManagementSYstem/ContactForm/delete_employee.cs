using Contactto.Entity;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class delete_employee : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        User_service empservice = new User_service();
        Employees employ = new Employees();
        public delete_employee()
        {
            InitializeComponent();
        }
        #region Delete employee method
        private void Deleteemploy()
        {

            string query = "select id,Name,Phone,Salary,Email from Employees where id LIKE '%" + search_textfield.Text + "%'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                if (search_textfield.Text == reader["id"].ToString())
                {
                    MessageBox.Show("Record Deleted Successfully!");
                }
            }
            conn.Close();

        }
        #endregion

        #region Others event
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Manage_employee back = new Manage_employee();
            back.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Manage_employee back = new Manage_employee();
            back.Show();
            this.Hide();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
          
            Deleteemploy();
           
        }
        #endregion

        #region search Event

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
            while (reader.Read() == true)
            {
                dt.Rows.Add(reader["id"], reader["Name"], reader["Phone"], reader["Salary"], reader["Email"]);
            }
            dataGridView1.DataSource = dt;

            conn.Close();
        }
        #endregion

        #region others event
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Data grideview cell clik event

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int index = e.RowIndex;
            DataGridViewRow select = dataGridView1.Rows[index];
            cmd.CommandText = "delete from Employees where id='" + search_textfield.Text + "'";
             cmd.ExecuteNonQuery();
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);
            conn.Close();
            // displaydata();
            message_label.Text = "Delete Succesfully Done";
            
        }
        #endregion

        #region others
        private void delete_employee_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
