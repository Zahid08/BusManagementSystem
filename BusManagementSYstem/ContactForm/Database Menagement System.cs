using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Database_Menagement_System : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        public Database_Menagement_System()
        {
            InitializeComponent();
        }
        #region others event

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            choach_update update_choach = new choach_update();
            update_choach.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            delete_coach delet = new delete_coach();
            delet.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Add_Coach add = new Add_Coach();
            add.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin back = new Admin();
            back.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin back = new Admin();
            back.Show();

        }
        #endregion

        #region search event
        private void search_textfield_TextChanged(object sender, EventArgs e)
        {
            string query = "select Choach_No,Register,Date_Time,Source,Destination,Total_Seat,No_Seat,Seat_available from Choach  where Destination LIKE '%" + search_textfield.Text + "%'";    
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
                show.Visible = true;
            }
            show.DataSource = dt;

            Refresh();
            conn.Close();
        }
        #endregion

        #region others event
        private void search_label_Click(object sender, EventArgs e)
        {

        }

        private void Database_Menagement_System_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
