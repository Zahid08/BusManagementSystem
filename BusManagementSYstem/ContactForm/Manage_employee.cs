using Contactto.Entity;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Manage_employee : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");

        Employee_service employeeservice = new Employee_service();

        #region Not working properly searching
        public Manage_employee()
        {
            InitializeComponent();
        }
        private void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = employeeservice.GetAllSortedByName();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            this.PopulateDataGridView();
        }
        private void Search()
        {
            List<Employees> filteredPersonList = null;
            if (searc_textBox.Text != null)
            {
                filteredPersonList = employeeservice.GetByName(searc_textBox.Text);
            }
            if (filteredPersonList != null && filteredPersonList.Count != 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filteredPersonList;
            }
        }
        private void ShowDetailUi()
        {
            int personId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);
       //     new frmDetail(this.GetSelectedPerson()).ShowDialog();
        }
        #endregion

        #region Method  search
        private void search() {
            string query = "select id,Name,Phone,Salary,Email from Employees where id LIKE '%" + searc_textBox.Text + "%'";

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

        #region search event handeler
        private void searc_textBox_TextChanged(object sender, EventArgs e)
        {
            search(); 
        }
        #endregion


        #region others handeler
        private void update_picturBox_Click(object sender, EventArgs e)
        {
            update_employee update = new update_employee();
            update.Show();
            this.Hide();

        }

        private void add_employee_picturBox_Click(object sender, EventArgs e)
        {
            add_employee add = new add_employee();
            add.Show();
            this.Hide();
        }

        private void delete_picturBox_Click(object sender, EventArgs e)
        {
           
            delete_employee delete = new delete_employee();
            delete.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Admin back = new Admin();
            back.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin back = new Admin();
            back.Show();
        }

        private void Manage_employee_Load(object sender, EventArgs e)
        {
        }
    }
    #endregion

   
}
