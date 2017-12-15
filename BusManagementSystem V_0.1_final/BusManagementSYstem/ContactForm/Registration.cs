using Contact.Entity;
using ContactForm.Properties;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void crospicturebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (nameTextbox.Text == "Name") {
                label1.Visible = true;
                nameTextbox.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "") {
                label1.Visible = false;
                nameTextbox.Text = "Name";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void EmailTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (EmailTextbox.Text == "Your Email Address....")
            {

                emlbl.Visible = true;
                EmailTextbox.Text = "";
            }

        }

        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == "")
            {

                emlbl.Visible =false;
                EmailTextbox.Text ="Email";
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernametextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (usernametextbox.Text == "Create User Name...........")
            {
                usernametextbox.Text = "";
            }
        }

        private void usernametextbox_Leave(object sender, EventArgs e)
        {
            if (usernametextbox.Text == "")
            {
                usernametextbox.Text = "Create User Name...........";
            }
        }

        private void phntextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (phntextbox.Text == "Phone Number") {
                phntextbox.Text = "";
            }
        }

        private void phntextbox_Leave(object sender, EventArgs e)
        {

            if (phntextbox.Text == "")
            {
                phntextbox.Text = "Phone Number";
            }

        }

        private void paswrdtextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (paswrdtextbox.Text == "Password")
            {
                paswrdtextbox.Text = "";
            }

        }

        private void paswrdtextbox_Leave(object sender, EventArgs e)
        {
            if (paswrdtextbox.Text == "")
            {
                paswrdtextbox.Text = "Password";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fbpicturebox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void fbpicturebox_MouseLeave(object sender, EventArgs e)
        {
            fbpicturebox.Image = Resources.f;
        }

        private void fbpicturebox_MouseHover(object sender, EventArgs e)
        {
            fbpicturebox.Image = Resources.f2;
        }

        private void googlepicturebox_MouseLeave(object sender, EventArgs e)
        {
            googlepicturebox.Image = Resources.google1;
        }

        private void googlepicturebox_MouseHover(object sender, EventArgs e)
        {
            googlepicturebox.Image = Resources.google2;
        }

        private void googlepicturebox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/");
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Resources.singup1;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = Resources.singup2;

        }

        private void minimize_Click(object sender, EventArgs e)
        {
           
        }

        private void minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookTicket back = new BookTicket();
            back.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            User_Entity user = new User_Entity();
            user.Name = nameTextbox.Text;
            user.Email = EmailTextbox.Text;
            user.Username = usernametextbox.Text;
            user.Phone = phntextbox.Text;
            user.Password = paswrdtextbox.Text;
            User_service userservice = new User_service();
            if (userservice.Add(user) > 0)
            {
                MessageBox.Show("Registration successfully");
            }
            User go = new User();
            go.Show();
            this.Hide();


        }
    }
}
