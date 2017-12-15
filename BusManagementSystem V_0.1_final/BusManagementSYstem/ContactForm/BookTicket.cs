using ContactForm.Properties;
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
    public partial class BookTicket : Form
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        private void crospicturebox_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void loginbox_MouseLeave(object sender, EventArgs e)
        {
            loginbox.Image = Resources.lgin;
        }

        private void loginbox_MouseMove(object sender, MouseEventArgs e)
        {
            loginbox.Image = Resources.lgin1;
        }

        private void regbox_MouseLeave(object sender, EventArgs e)
        {
            regbox.Image = Resources.reg;
        }

        private void regbox_MouseMove(object sender, MouseEventArgs e)
        {
            regbox.Image = Resources.reg1;
        }

        private void loginbox_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void regbox_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void p1_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void p1_MouseHover(object sender, EventArgs e)
        {
          
           

        }
        private void ChangeImage(object sender, EventArgs e)
        {
            List<Bitmap> bt = new List<Bitmap>();
            bt.Add(Properties.Resources.bus5);
            bt.Add(Properties.Resources.inside1);
            bt.Add(Properties.Resources.bus4);
            bt.Add(Properties.Resources.inside1);
            bt.Add(Properties.Resources.bus3);
            bt.Add(Properties.Resources.inside2);
            bt.Add(Properties.Resources.bus2);

            int i = DateTime.Now.Second % bt.Count;
            panel2.BackgroundImage = bt[i];

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Properties.Resources.bus6;
            Timer tim = new Timer();
            tim.Interval = 1300;
            tim.Tick += new EventHandler(ChangeImage);
            tim.Start();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home back = new Home();
            back.Show();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
