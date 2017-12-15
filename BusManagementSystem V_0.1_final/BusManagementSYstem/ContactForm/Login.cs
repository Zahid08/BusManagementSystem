using ContactForm.Properties;
using Contact.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Services;
using System.Data.SqlClient;

namespace ContactForm
{
    public partial class Login : Form
    {
        public static string username = string.Empty;
        User_Entity login = new User_Entity();
    
        public Login()
        {
            InitializeComponent();
            //this.login = login;
           // this.adminlogin = adminlogin;
        }
        #region Others event
        private void crospicturebox_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //mouse event image
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.log;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

          //  pictureBox2.Image = Resources.log2;
        }

        private void paswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                paswordTextbox.UseSystemPasswordChar = true;
            }
            else
            {
                paswordTextbox.UseSystemPasswordChar = false;
            }
        
        }

        private void minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
#endregion

        #region Login event
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nameTextbox.Text = this.login.Username;
            paswordTextbox.Text = this.login.Password;
            User_service service = new User_service();
            service.Getlogin();
            MessageBox.Show("Successfully login");
            username = nameTextbox.Text;
            User user = new User();
            user.Show();
            this.Hide();
            // Application.Exit();
            //Dispose();

            //conn.Close();
        }
        #endregion

        #region others event
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookTicket back = new BookTicket();
            back.Show();
        }

        private void homePicturebox_MouseLeave(object sender, EventArgs e)
        {
            homePicturebox.Image = Resources.hom1;
        }

        private void homePicturebox_MouseHover(object sender, EventArgs e)
        {
            homePicturebox.Image = Resources.hom2;
        }

        private void homePicturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hom = new Home();
            hom.Show();
        }
    
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


        }
        #endregion
    }
}
