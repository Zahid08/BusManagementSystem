using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{

    public partial class Ticket1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        public static string ticket = string.Empty;
        public static string seat = string.Empty;
        public static string choach_no = string.Empty;
        public Ticket1()
        {
            InitializeComponent();
            busnumber.Text = User.bus_no;

        }
        #region Others event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User back = new User();
            back.Show();
            this.Hide();
        }
        #endregion

        #region Checkbox check event short way

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            int flag = 0;

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;

                    if (chk.Checked)
                    {

                        s = chk.Text + "" + s;
                        flag++;
                        // flag = 1+flag;
                        label1.Text = s;
                        label3.Text = flag.ToString();
                    }
                }
                
            }
            int x = Convert.ToInt32(label3.Text);
            if (x > 4)
            {
                MessageBox.Show("Maximum Selection occur");
                flag--;
                label3.Text = flag.ToString();
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Ticket_select (Choach_no,Seat_name) values ('"+textBox1.Text+"','"+s+"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region Others event
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void Ticket1_Load(object sender, EventArgs e)
        {
         /*   A1.Checked = false;
            A2.Checked = false;
            //A3.Checked = false;
            B1.Checked = false;
            B2.Checked = false;
            C1.Checked = false;
            C2.Checked = false;
            conn.Open();
            // string query = ("select Seat_name,Choach_no from Passenger where Choach_no ='" + textBox1.Text + "'",conn);

            SqlCommand cmd = new SqlCommand("select Choach_no,Seat_name from Ticket_select where Choach_no ='" + textBox1.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string seat = reader["Seat_name"].ToString();
                string[] a = seat.Split(' ');
                foreach (Control cc in this.Controls)
                {
                    if (cc is CheckBox)
                    {
                        CheckBox check = new CheckBox();
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j] == check.Text)
                            {
                                check.Checked = true;
                            }
                        }
                    }
                }

            }
            MessageBox.Show("Succesfully loaded");
            conn.Close();
            this.passengerTableAdapter.Fill(this.online_bus_ticketDataSet3.Passenger);
    */    
    }

        private void button2_Click(object sender, EventArgs e)
        {
            ticket = label1.Text;
            seat = label3.Text;
            choach_no = busnumber.Text;
            User back = new User();
            back.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A1.Checked = false;
            A2.Checked = false;
            //A3.Checked = false;
            B1.Checked = false;
            B2.Checked =false;
            C1.Checked = false;
            C2.Checked = false;
            conn.Open();
           // string query = ("select Seat_name,Choach_no from Passenger where Choach_no ='" + textBox1.Text + "'",conn);
            
            SqlCommand cmd = new SqlCommand("select Choach_no,Seat_name from Ticket_select where Choach_no ='" + textBox1.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string seat = reader["Seat_name"].ToString();
                string[] a = seat.Split(' ');
               foreach (Control cc in Controls) {
                CheckBox check = new CheckBox();
                if (cc is CheckBox) {
                        for (int j = 0; j < a.Length; j++) {
                            string x = check.Text;
                            if (a[j] == check.Text) {
                                check  .Checked = true;
                              //  check.Text = seat;
                            }
                        }
                    }
                }
                   
            }
            MessageBox.Show("Succesfully loaded");
            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBox1.Text = comboBox2.SelectedValue.ToString();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.passengerTableAdapter.FillBy(this.online_bus_ticketDataSet3.Passenger);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
#endregion
    }

}
    

