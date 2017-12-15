using Contact.Entity;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    
    public partial class Admin_login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        Admin_entity adminlogin = new Admin_entity();
        public Admin_login()
        {
           // this.adminlogin = adminlogin;
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home back = new Home();
            back.Show();
        }

        #region Admin_login_event

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string query = "select * from Admin_base";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                Adminusername.Text = reader["Username"].ToString();
                Adminpassword.Text = reader["Password"].ToString();

                MessageBox.Show("Succesfully login");
            }
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
            reader.Close();
            Refresh();
            conn.Close();

            #region can not do
            //  Adminusername.Text = this.adminlogin.Username;
            //  Adminusername.Text = this.adminlogin.Pasword;
            //  Admin_services service = new Admin_services();
            //  service.Getlogin_admin();
            //  MessageBox.Show("Successfully login");
            //  Admin admin = new Admin();
            //  admin.Show();
            //  this.Hide();
            // // Application.Exit();
            ////  username = nameTextbox.Text;
            #endregion
        }
        #endregion

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }
    }
}
