namespace BookMonitoring
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            comboxsem = new ComboBox();
            comboxyear = new ComboBox();
            txtboxemail = new TextBox();
            txtboxcontact = new TextBox();
            txtboxdept = new TextBox();
            txtboxenrollment = new TextBox();
            lblemail = new Label();
            lblcontact = new Label();
            lblsem = new Label();
            lblDept = new Label();
            lblenrollment = new Label();
            btncancel = new Button();
            btnsave = new Button();
            btnrefresh = new Button();
            lblstudent = new Label();
            txtboxstud = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 110);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 37);
            label1.Name = "label1";
            label1.Size = new Size(169, 36);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 158);
            panel3.Controls.Add(comboxsem);
            panel3.Controls.Add(comboxyear);
            panel3.Controls.Add(txtboxemail);
            panel3.Controls.Add(txtboxcontact);
            panel3.Controls.Add(txtboxdept);
            panel3.Controls.Add(txtboxenrollment);
            panel3.Controls.Add(lblemail);
            panel3.Controls.Add(lblcontact);
            panel3.Controls.Add(lblsem);
            panel3.Controls.Add(lblDept);
            panel3.Controls.Add(lblenrollment);
            panel3.Controls.Add(btncancel);
            panel3.Controls.Add(btnsave);
            panel3.Controls.Add(btnrefresh);
            panel3.Controls.Add(lblstudent);
            panel3.Controls.Add(txtboxstud);
            panel3.Location = new Point(0, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(1209, 592);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // comboxsem
            // 
            comboxsem.AccessibleRole = AccessibleRole.None;
            comboxsem.FormattingEnabled = true;
            comboxsem.Items.AddRange(new object[] { "First Sem", "Second Sem" });
            comboxsem.Location = new Point(178, 248);
            comboxsem.Name = "comboxsem";
            comboxsem.Size = new Size(159, 23);
            comboxsem.TabIndex = 17;
            comboxsem.Text = "First Sem";
            comboxsem.SelectedIndexChanged += comboxsem_SelectedIndexChanged;
            // 
            // comboxyear
            // 
            comboxyear.FormattingEnabled = true;
            comboxyear.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year", "other..." });
            comboxyear.Location = new Point(431, 249);
            comboxyear.Name = "comboxyear";
            comboxyear.Size = new Size(159, 23);
            comboxyear.TabIndex = 16;
            comboxyear.Text = "1st Year";
            comboxyear.SelectedIndexChanged += comboxyear_SelectedIndexChanged;
            // 
            // txtboxemail
            // 
            txtboxemail.Location = new Point(178, 366);
            txtboxemail.Name = "txtboxemail";
            txtboxemail.Size = new Size(412, 23);
            txtboxemail.TabIndex = 14;
            txtboxemail.TextChanged += txtboxemail_TextChanged;
            // 
            // txtboxcontact
            // 
            txtboxcontact.Location = new Point(178, 310);
            txtboxcontact.Name = "txtboxcontact";
            txtboxcontact.Size = new Size(412, 23);
            txtboxcontact.TabIndex = 13;
            // 
            // txtboxdept
            // 
            txtboxdept.Location = new Point(178, 193);
            txtboxdept.Name = "txtboxdept";
            txtboxdept.Size = new Size(412, 23);
            txtboxdept.TabIndex = 11;
            // 
            // txtboxenrollment
            // 
            txtboxenrollment.Location = new Point(178, 131);
            txtboxenrollment.Name = "txtboxenrollment";
            txtboxenrollment.Size = new Size(412, 23);
            txtboxenrollment.TabIndex = 10;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 12F);
            lblemail.Location = new Point(28, 368);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(105, 21);
            lblemail.TabIndex = 9;
            lblemail.Text = "Student Email";
            // 
            // lblcontact
            // 
            lblcontact.AutoSize = true;
            lblcontact.Font = new Font("Segoe UI", 12F);
            lblcontact.Location = new Point(27, 312);
            lblcontact.Name = "lblcontact";
            lblcontact.Size = new Size(120, 21);
            lblcontact.TabIndex = 8;
            lblcontact.Text = "Student Contact";
            // 
            // lblsem
            // 
            lblsem.AutoSize = true;
            lblsem.Font = new Font("Segoe UI", 12F);
            lblsem.Location = new Point(28, 250);
            lblsem.Name = "lblsem";
            lblsem.Size = new Size(132, 21);
            lblsem.TabIndex = 7;
            lblsem.Text = "Student Semester";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Font = new Font("Segoe UI", 12F);
            lblDept.Location = new Point(28, 195);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(93, 21);
            lblDept.TabIndex = 6;
            lblDept.Text = "Department";
            // 
            // lblenrollment
            // 
            lblenrollment.AutoSize = true;
            lblenrollment.Font = new Font("Segoe UI", 12F);
            lblenrollment.Location = new Point(28, 133);
            lblenrollment.Name = "lblenrollment";
            lblenrollment.Size = new Size(148, 21);
            lblenrollment.TabIndex = 5;
            lblenrollment.Text = "Enrollment Number";
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btncancel.Location = new Point(493, 440);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(97, 42);
            btncancel.TabIndex = 4;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnsave.Location = new Point(328, 440);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(97, 42);
            btnsave.TabIndex = 3;
            btnsave.Text = "Save Info";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnrefresh.Location = new Point(178, 440);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(97, 42);
            btnrefresh.TabIndex = 2;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // lblstudent
            // 
            lblstudent.AutoSize = true;
            lblstudent.Font = new Font("Segoe UI", 12F);
            lblstudent.Location = new Point(28, 72);
            lblstudent.Name = "lblstudent";
            lblstudent.Size = new Size(109, 21);
            lblstudent.TabIndex = 1;
            lblstudent.Text = "Student Name";
            // 
            // txtboxstud
            // 
            txtboxstud.Location = new Point(178, 70);
            txtboxstud.Name = "txtboxstud";
            txtboxstud.Size = new Size(412, 23);
            txtboxstud.TabIndex = 0;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 696);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox txtboxemail;
        private TextBox txtboxcontact;
        private TextBox txtboxdept;
        private TextBox txtboxenrollment;
        private Label lblemail;
        private Label lblcontact;
        private Label lblsem;
        private Label lblDept;
        private Label lblenrollment;
        private Button btncancel;
        private Button btnsave;
        private Button btnrefresh;
        private Label lblstudent;
        private TextBox txtboxstud;
        private TextBox txtboxsem;
        private ComboBox comboBox1;
        private ComboBox comboxyear;
        private ComboBox comboxsem;
    }
}