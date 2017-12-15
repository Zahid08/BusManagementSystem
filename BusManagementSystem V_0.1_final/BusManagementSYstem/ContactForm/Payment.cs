using ContactForm.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Payment : Form
    {
        
        public Payment()
        {
            InitializeComponent();
            passengername.Text = User.passengername;
            journeydate.Text = User.date;
            busno.Text = User.bus_no;
            member.Text = User.seat_member;
            seatno.Text = User.No_of_seat;
            from.Text = User.source;
            to.Text = User.destination;
        }

        #region Others event
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void crospicturebox_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void paypicturebox_MouseLeave(object sender, EventArgs e)
        {
           // paypicturebox.Image = Resources.pay_now_button;
        }

        private void paypicturebox_MouseHover(object sender, EventArgs e)
        {
           // paypicturebox.Image = Resources.pay1_now_button;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.Image = Resources.back;
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            back.Image = Resources.back1;
        }

        private void back_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
            this.Hide();

        }

        private void crospicturebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        #region Payment method
        private void getamount() {


            string query = "select Amount from Choach ";
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                bill.Text = reader["Amount"].ToString();
            }
            reader.Close();

        }
        #endregion

        #region others event
        private void paypicturebox_Click(object sender, EventArgs e)
        {

         }

        private void Payment_Load(object sender, EventArgs e)
        {
            getamount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User back = new User();
            back.Show();
            this.Hide();
        }
        #endregion
    }


}

