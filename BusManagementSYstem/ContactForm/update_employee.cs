using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class update_employee : Form
    {
        public update_employee()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Manage_employee back = new Manage_employee();
            back.Show();
            this.Hide();
        }

        private void update_employee_Load(object sender, EventArgs e)
        {

        }

        private void search_textfield_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,Name,Phone,Salary,Email from Employees where id LIKE '%" + search_textfield.Text + "%'";

            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
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
                employee_name_textBox.Text = reader["Name"].ToString();
                employee_id_textBox.Text = reader["id"].ToString();
                employee_phone_textBox.Text = reader["Phone"].ToString();
                employee_salary_textBox.Text = reader["Salary"].ToString();
                employee_email_textBox.Text = reader["Email"].ToString();

                dt.Rows.Add(reader["id"], reader["Name"], reader["Phone"], reader["Salary"], reader["Email"]);
            }
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {     
            int index = e.RowIndex;
            DataGridViewRow select = dataGridView1.Rows[index];
            employee_name_textBox.Text = select.Cells[1].Value.ToString();
            employee_id_textBox.Text = select.Cells[0].Value.ToString();
            employee_phone_textBox.Text = select.Cells[2].Value.ToString();
            employee_salary_textBox.Text = select.Cells[3].Value.ToString();
            employee_email_textBox.Text = select.Cells[4].Value.ToString();
        
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
           // SqlCommand cmd = new SqlCommand();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Employees SET Name='" + employee_name_textBox.Text + "',id='" + employee_id_textBox.Text + "',Phone='" + employee_phone_textBox.Text + "',Salary='" + employee_salary_textBox.Text + "',Email='" + employee_email_textBox.Text + "'  where id='" + employee_id_textBox.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();

            //IDtxt.Text = "";
            // Titletxt.Text = "";
            message.Text = "Succesfully Updated";
           // MessageBox.Show("Succesfully Updated");
        }

        private void employee_search_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
