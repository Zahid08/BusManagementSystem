namespace ContactForm
{
    partial class add_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.employee_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_phone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employee_id_textBox = new System.Windows.Forms.TextBox();
            this.employee_phone_textBox = new System.Windows.Forms.TextBox();
            this.employee_salary_textBox = new System.Windows.Forms.TextBox();
            this.employee_email_textBox = new System.Windows.Forms.TextBox();
            this.employee_submit_button = new System.Windows.Forms.Button();
            this.messagebox = new System.Windows.Forms.Label();
            this.employee_information_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employee_name_textBox = new System.Windows.Forms.TextBox();
            this.employee_search = new System.Windows.Forms.PictureBox();
            this.search_textfield = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 36);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 37);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // employee_id
            // 
            this.employee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_id.Location = new System.Drawing.Point(13, 58);
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(90, 29);
            this.employee_id.TabIndex = 18;
            this.employee_id.Text = "Name     :";
            this.employee_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID          :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Salary    :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // employee_phone
            // 
            this.employee_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_phone.Location = new System.Drawing.Point(12, 135);
            this.employee_phone.Name = "employee_phone";
            this.employee_phone.Size = new System.Drawing.Size(91, 29);
            this.employee_phone.TabIndex = 21;
            this.employee_phone.Text = "Phone    :";
            this.employee_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email     :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // employee_id_textBox
            // 
            this.employee_id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_id_textBox.Location = new System.Drawing.Point(123, 90);
            this.employee_id_textBox.Name = "employee_id_textBox";
            this.employee_id_textBox.Size = new System.Drawing.Size(335, 26);
            this.employee_id_textBox.TabIndex = 24;
            // 
            // employee_phone_textBox
            // 
            this.employee_phone_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_phone_textBox.Location = new System.Drawing.Point(123, 135);
            this.employee_phone_textBox.Name = "employee_phone_textBox";
            this.employee_phone_textBox.Size = new System.Drawing.Size(335, 26);
            this.employee_phone_textBox.TabIndex = 25;
            // 
            // employee_salary_textBox
            // 
            this.employee_salary_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_salary_textBox.Location = new System.Drawing.Point(123, 182);
            this.employee_salary_textBox.Name = "employee_salary_textBox";
            this.employee_salary_textBox.Size = new System.Drawing.Size(335, 26);
            this.employee_salary_textBox.TabIndex = 26;
            // 
            // employee_email_textBox
            // 
            this.employee_email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_email_textBox.Location = new System.Drawing.Point(123, 224);
            this.employee_email_textBox.Name = "employee_email_textBox";
            this.employee_email_textBox.Size = new System.Drawing.Size(335, 26);
            this.employee_email_textBox.TabIndex = 27;
            // 
            // employee_submit_button
            // 
            this.employee_submit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_submit_button.Location = new System.Drawing.Point(123, 256);
            this.employee_submit_button.Name = "employee_submit_button";
            this.employee_submit_button.Size = new System.Drawing.Size(104, 41);
            this.employee_submit_button.TabIndex = 29;
            this.employee_submit_button.Text = "SUBMIT";
            this.employee_submit_button.UseVisualStyleBackColor = true;
            this.employee_submit_button.Click += new System.EventHandler(this.employee_submit_button_Click);
            // 
            // messagebox
            // 
            this.messagebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagebox.Location = new System.Drawing.Point(701, 48);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(431, 147);
            this.messagebox.TabIndex = 30;
            this.messagebox.Text = "Message";
            // 
            // employee_information_label
            // 
            this.employee_information_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_information_label.Location = new System.Drawing.Point(477, 318);
            this.employee_information_label.Name = "employee_information_label";
            this.employee_information_label.Size = new System.Drawing.Size(244, 23);
            this.employee_information_label.TabIndex = 31;
            this.employee_information_label.Text = "Check Employee Information";
            this.employee_information_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 333);
            this.dataGridView1.TabIndex = 32;
            // 
            // employee_name_textBox
            // 
            this.employee_name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name_textBox.Location = new System.Drawing.Point(123, 58);
            this.employee_name_textBox.Name = "employee_name_textBox";
            this.employee_name_textBox.Size = new System.Drawing.Size(335, 26);
            this.employee_name_textBox.TabIndex = 23;
            // 
            // employee_search
            // 
            this.employee_search.Image = ((System.Drawing.Image)(resources.GetObject("employee_search.Image")));
            this.employee_search.Location = new System.Drawing.Point(472, 353);
            this.employee_search.Name = "employee_search";
            this.employee_search.Size = new System.Drawing.Size(217, 29);
            this.employee_search.TabIndex = 48;
            this.employee_search.TabStop = false;
            // 
            // search_textfield
            // 
            this.search_textfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textfield.Location = new System.Drawing.Point(686, 353);
            this.search_textfield.Name = "search_textfield";
            this.search_textfield.Size = new System.Drawing.Size(352, 29);
            this.search_textfield.TabIndex = 47;
            this.search_textfield.Text = "Enter Employee ID";
            this.search_textfield.TextChanged += new System.EventHandler(this.search_textfield_TextChanged);
            // 
            // add_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 733);
            this.Controls.Add(this.employee_search);
            this.Controls.Add(this.search_textfield);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.employee_information_label);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.employee_submit_button);
            this.Controls.Add(this.employee_email_textBox);
            this.Controls.Add(this.employee_salary_textBox);
            this.Controls.Add(this.employee_phone_textBox);
            this.Controls.Add(this.employee_id_textBox);
            this.Controls.Add(this.employee_name_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employee_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee_id);
            this.Controls.Add(this.panel1);
            this.Name = "add_employee";
            this.Text = "Add Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.add_employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label employee_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label employee_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employee_id_textBox;
        private System.Windows.Forms.TextBox employee_phone_textBox;
        private System.Windows.Forms.TextBox employee_salary_textBox;
        private System.Windows.Forms.TextBox employee_email_textBox;
        private System.Windows.Forms.Button employee_submit_button;
        private System.Windows.Forms.Label messagebox;
        private System.Windows.Forms.Label employee_information_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox employee_name_textBox;
        private System.Windows.Forms.PictureBox employee_search;
        private System.Windows.Forms.TextBox search_textfield;
    }
}