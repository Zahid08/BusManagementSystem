using Contact.Database;
using Contact.Entity;
using ContactForm.Properties;
using Contactto.Entity;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class User : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        public static string passengername = string.Empty;
        public static string No_of_seat = string.Empty;
        public static string seat_member = string.Empty;
        public static string date = string.Empty;
        public static string bus_no = string.Empty;
        public static string source = string.Empty;
        public static string destination = string.Empty;

        public User()
        {
            InitializeComponent();
            seatnotextbox.Text = Ticket1.seat;   
            membertextbox.Text = Ticket1.ticket;
            //Coach.Visible = true;
            Coach.Text = Ticket1.choach_no;
            namelbl.Text = Login.username;
          
        }
        #region Others event
        private void crospicturebox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bokkticketbox_MouseLeave(object sender, EventArgs e)
        {
        }
        #endregion

        #region Form Loading event
        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_bus_ticketDataSet2.Choach' table. You can move, or remove it, as needed.
            this.choachTableAdapter1.Fill(this.online_bus_ticketDataSet2.Choach);
            // TODO: This line of code loads data into the 'online_bus_ticketDataSet1.Choach' table. You can move, or remove it, as needed.
            this.choachTableAdapter.Fill(this.online_bus_ticketDataSet1.Choach);
            getname();
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

        #region others
        private void bokkticketbox_MouseClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region method
        private void getname()
        {
            string query = "SELECT Name,Phone,Password,Email FROM User_base ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            { 
                lblname.Text = reader["Name"].ToString();
                lblemail.Text = reader["Email"].ToString();
            }
            conn.Close();
        }
        public void getall()
        {
            string query = "select Choach_No,Register,Date_Time,Source,Destination,Total_Seat,No_Seat,Seat_available from Choach  where Destination LIKE '%" + searchText.Text + "%'";
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
                Coach.Text = reader["Choach_No"].ToString();        
            }
            reader.Close();
            Refresh();
            conn.Close();
        }
        #endregion

        #region add passenger, update seat no event
        private void submit_Click(object sender, EventArgs e)
        {
            User_service service = new User_service();
            User_Entity passenger = new User_Entity();
            Choch set = new Choch();
            passenger.Name = nametextbox.Text;
            passenger.Phone = phntextbox.Text;
            passenger.Choch_No = Coach.Text;
            passenger.Seat_no = membertextbox.Text;
            User_service userservice = new User_service();
            if (userservice.Add_passrnger(passenger) > 0)
            {
                MessageBox.Show("passenger add successfully");
            }
            set.Seat_no = seatnotextbox.Text;    
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Choach SET No_Seat=No_Seat+'" + seatnotextbox.Text + "'  where Choach_No='" + Coach.Text + "'";
            cmd.ExecuteNonQuery();         
            conn.Close();
            MessageBox.Show("Succesfully submitted");
            passengername = nametextbox.Text;
            date = dateTimePicker.Text;
            bus_no = Coach.Text;
            seat_member = seatnotextbox.Text;
            No_of_seat = membertextbox.Text;
            source = fromComboBox.SelectedValue.ToString();
            destination = toComboBox.SelectedValue.ToString();
            Payment pay = new Payment();
            pay.Show();
            this.Hide();


        }
        #endregion

        #region others event
        private void button1_Click(object sender, EventArgs e)
        { 

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
        }
        private void homePicturebox_MouseLeave(object sender, EventArgs e)
        {
            homePicturebox.Image = Resources.hom1;
        }

        private void homePicturebox_MouseHover(object sender, EventArgs e)
        {
            homePicturebox.Image = Resources.hom2;
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.Image = Resources.log1;

        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            logout.Image = Resources.log2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookTicket back = new BookTicket();
            back.Show();
        }

        private void homePicturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            getall();
            this.Hide();
            Home back = new Home();
            back.Show();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            getall();
            listView1.Visible = true;
        }

        private void searchText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            bus_no = Coach.Text;
            Ticket1 ticket = new Ticket1();
            ticket.Show();

        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblemail.Text = fromComboBox.SelectedValue.ToString();
            //// lblemail.Text = fromComboBox.SelectedIndex.ToString();
        }
        #endregion
    }
}

