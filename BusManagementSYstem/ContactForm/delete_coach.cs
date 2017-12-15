using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class delete_coach : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\AIUB_AFTER_2\\Sarmad_update_final\\C#_fianl\\C#_fianl\\datamanagement\\online_bus_ticket.mdf;Integrated Security=True;Connect Timeout=30");
        public delete_coach()
        {
            InitializeComponent();
        }
        #region others event
        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Database_Menagement_System back = new Database_Menagement_System();
            back.Show();
            this.Hide();
        }

        private void delete_coach_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region delete event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select Choach_No,Register,Date_Time,Source,Destination,Total_Seat,No_Seat,Seat_available from Choach  where Choach_No LIKE '%" + textBox1.Text + "%'";
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

        #region datagrideview cell clik event
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int index = e.RowIndex;
            DataGridViewRow select = dataGridView1.Rows[index];
            cmd.CommandText = "delete from Choach where Choach_No='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);
            conn.Close();
            message_label.Text = "Delete Succesfully Done";

        }
        #endregion
    }
}
