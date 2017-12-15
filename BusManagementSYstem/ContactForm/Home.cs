using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        public Home()
        {
            InitializeComponent();
        }
        #region Exit event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            const string message = "Are you sure that you would like to Exit the Application?";
            const string caption = "Exit Application";

            var result = MessageBox.Show(message, caption,
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }


        }
        #endregion

        #region others event
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookTicket bt = new BookTicket();
            bt.Show();

        }

        private void User_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login log = new Admin_login();
            log.Show();
        }
        #endregion

        #region  listview show Method
        private void getall()
        {
            string query = "select Choach_No,Register,Date_Time,Source,Destination,Total_Seat,No_Seat,Seat_available from Choach  where Destination LIKE '%" + textBox1.Text + "%'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read() == true)
            {
                ListViewItem lv = new ListViewItem(reader["Choach_No"].ToString());
                lv.SubItems.Add(reader["Register"].ToString());
                lv.SubItems.Add(reader["Date_Time"].ToString());
                lv.SubItems.Add(reader["Source"].ToString());
                lv.SubItems.Add(reader["Destination"].ToString());
                lv.SubItems.Add(reader["Total_Seat"].ToString());
                lv.SubItems.Add(reader["No_Seat"].ToString());
                lv.SubItems.Add(reader["Seat_available"].ToString());
                listView1.Items.Add(lv);
            }
            reader.Close();
            Refresh();
            conn.Close();
        }
        #endregion

        #region Listview Colum name
        private void Home_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Choach_no", 70);
            listView1.Columns.Add("Register", 100);
            listView1.Columns.Add("Date_Timme", 120);
            listView1.Columns.Add("Source", 60);
            listView1.Columns.Add("Destination", 80);
            listView1.Columns.Add("Total seat", 60);
            listView1.Columns.Add("No_Seat", 60);
            listView1.Columns.Add("Available", 60);
            getall();

        }
        #endregion

        #region others event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.Show();
            getall();

            if (textBox1.Text== "")
            {
                panel1.Visible = false;
            }
           

        }
        #endregion


    }
}
