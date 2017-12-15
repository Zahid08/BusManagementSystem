namespace ContactForm
{
    partial class BookTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTicket));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.loginbox = new System.Windows.Forms.PictureBox();
            this.regbox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1289, 34);
            this.panel4.TabIndex = 25;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::ContactForm.Properties.Resources.back3;
            this.pictureBox5.Location = new System.Drawing.Point(0, -4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 37);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // loginbox
            // 
            this.loginbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbox.Image = ((System.Drawing.Image)(resources.GetObject("loginbox.Image")));
            this.loginbox.Location = new System.Drawing.Point(1033, 309);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(175, 65);
            this.loginbox.TabIndex = 28;
            this.loginbox.TabStop = false;
            this.loginbox.Click += new System.EventHandler(this.loginbox_Click);
            this.loginbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loginbox_MouseClick);
            this.loginbox.MouseLeave += new System.EventHandler(this.loginbox_MouseLeave);
            this.loginbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginbox_MouseMove);
            // 
            // regbox
            // 
            this.regbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbox.Image = ((System.Drawing.Image)(resources.GetObject("regbox.Image")));
            this.regbox.Location = new System.Drawing.Point(1033, 394);
            this.regbox.Name = "regbox";
            this.regbox.Size = new System.Drawing.Size(175, 71);
            this.regbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regbox.TabIndex = 29;
            this.regbox.TabStop = false;
            this.regbox.Click += new System.EventHandler(this.regbox_Click);
            this.regbox.MouseLeave += new System.EventHandler(this.regbox_MouseLeave);
            this.regbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.regbox_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 579);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1289, 28);
            this.panel3.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Image = global::ContactForm.Properties.Resources.pay1_now_button;
            this.label1.Location = new System.Drawing.Point(405, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Demo Bus";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(141, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 427);
            this.panel2.TabIndex = 35;
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.regbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.panel4);
            this.Name = "BookTicket";
            this.Text = "BookTicket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookTicket_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox loginbox;
        private System.Windows.Forms.PictureBox regbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}