using Contactto.Entity;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Add_Coach : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");

        public Add_Coach()
        {
            InitializeComponent();
        }
        #region others event

        private void Add_Coach_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Database_Menagement_System back = new Database_Menagement_System();
            back.Show();
            this.Hide();
        }
        #endregion

        #region Add event
        private void submit_pictureBox_Click(object sender, EventArgs e)
        {
            Choch choach = new Choch();
            choach.Choch_No = choch_no_textfield.Text.ToString();
            choach.Registration = registration_no_textfield.Text.ToString();
            choach.Date_Time = date_time_textfield.Text.ToString();
            choach.Source = source_textfield.Text.ToString();
            choach.Destination =destination_textfield.Text.ToString();
            choach.Total_Seat = total_ticket_textfield.Text.ToString();
            choach.Seat_no = No_of_seat_textbox.Text.ToString();
            choach.Available_Seat = seat_available_text.Text.ToString();
            choach.Amount = Amount_text.Text.ToString();
            Choach_service service1 = new Choach_service();
            if (service1.Add_chaoach(choach) > 0)
            {
                MessageBox.Show("Succesfully added");

            }
        }
        #endregion

        #region search event
        private void search_textfield_TextChanged(object sender, EventArgs e)
        {
            string query = "select Choach_No,Register,Date_Time,Source,Destination,Total_Seat,No_Seat,Seat_available from Choach  where Choach_No LIKE '%" + search_textfield.Text + "%'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Choach_No");
            dt.Columns.Add("Register");
            dt.Columns.Add("Date_Time");
            dt.Columns.Add("Source");
            dt.Columns.Add("Destination");
            dt.Columns.Add("Total_Seat");
            dt.Columns.Add("No_Seat");
            dt.Columns.Add("Seat_available");
            while (reader.Read() == true)
            {
                dt.Rows.Add(reader["Choach_No"], reader["Register"], reader["Date_Time"], reader["Source"], reader["Destination"], reader["Total_Seat"], reader["No_Seat"].ToString(), reader["Seat_available"].ToString());
                dataGridView1.Visible = true;
            }
            dataGridView1.DataSource = dt;
            Refresh();
            conn.Close();
        }
        #endregion
    }
}
