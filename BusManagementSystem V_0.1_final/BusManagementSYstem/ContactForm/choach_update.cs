using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class choach_update : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        public choach_update()
        {
            InitializeComponent();
        }
        #region others event
        private void choach_update_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Database_Menagement_System back = new Database_Menagement_System();
            back.Show();
            this.Hide();
        }
        #endregion

        #region Search choach
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
                show.Visible = true;
            }
            show.DataSource = dt;

            Refresh();
            conn.Close();
        }
        #endregion

        #region Datagridview cell clik event

        private void show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow select = show.Rows[index];
            choch_no_textfield.Text = select.Cells[0].Value.ToString();
            registration_no_textfield.Text = select.Cells[1].Value.ToString();
            date_time_textfield.Text = select.Cells[2].Value.ToString();
            source_textfield.Text = select.Cells[3].Value.ToString();
            destination_textfield.Text = select.Cells[4].Value.ToString();
            total_ticket_textfield.Text= select.Cells[5].Value.ToString();
        }
        #endregion

        #region Update event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Choach SET Choach_No='" + choch_no_textfield.Text.ToString()+ "',Register='" + registration_no_textfield.Text.ToString() + "',Date_Time='" + date_time_textfield.Text.ToString() + "',Source='" + source_textfield.Text.ToString() + "',Destination='" + destination_textfield.Text.ToString() + "',No_Seat='" + Convert.ToInt32(total_ticket_textfield.Text) + "' where Choach_No='" + choch_no_textfield.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
             MessageBox.Show("Succesfully Updated");
        }
        #endregion
    }
}
