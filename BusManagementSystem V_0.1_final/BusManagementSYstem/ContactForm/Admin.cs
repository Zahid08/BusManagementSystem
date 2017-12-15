using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        #region others event
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void crospicturebox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Database_Menagement_System().Show();
            this.Hide();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Manage_employee().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home back = new Home();
            back.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home back = new Home();
            back.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
