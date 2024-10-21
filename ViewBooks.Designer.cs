namespace BookMonitoring
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            panel1 = new Panel();
            btnrefresh = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtboxbookname = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnupdate = new Button();
            txtbookquantity = new TextBox();
            btndelete = new Button();
            txtbookname = new TextBox();
            btncancel = new Button();
            txtbookpublication = new TextBox();
            txtbookprice = new TextBox();
            txtbookauthor = new TextBox();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(btnrefresh);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtboxbookname);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 115);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.Silver;
            btnrefresh.FlatStyle = FlatStyle.Flat;
            btnrefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrefresh.Location = new Point(826, 80);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(91, 29);
            btnrefresh.TabIndex = 2;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnsearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold);
            label1.Location = new Point(183, 36);
            label1.Name = "label1";
            label1.Size = new Size(157, 36);
            label1.TabIndex = 0;
            label1.Text = "View Books";
            label1.Click += label1_Click;
            // 
            // txtboxbookname
            // 
            txtboxbookname.Location = new Point(591, 85);
            txtboxbookname.Name = "txtboxbookname";
            txtboxbookname.Size = new Size(229, 23);
            txtboxbookname.TabIndex = 1;
            txtboxbookname.TextChanged += txtboxbookname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(475, 80);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 0;
            label2.Text = "Book name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 158);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-1, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(1217, 624);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(836, 327);
            dataGridView1.TabIndex = 3;
            dataGridView1.TabStop = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Enter += dataGridView1_Enter;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(btnupdate);
            panel3.Controls.Add(txtbookquantity);
            panel3.Controls.Add(btndelete);
            panel3.Controls.Add(txtbookname);
            panel3.Controls.Add(btncancel);
            panel3.Controls.Add(txtbookpublication);
            panel3.Controls.Add(txtbookprice);
            panel3.Controls.Add(txtbookauthor);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(10, 349);
            panel3.Name = "panel3";
            panel3.Size = new Size(836, 252);
            panel3.TabIndex = 21;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(21, 27);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 9;
            label3.Text = "Book Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(580, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnupdate
            // 
            btnupdate.FlatStyle = FlatStyle.Popup;
            btnupdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(520, 186);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(79, 34);
            btnupdate.TabIndex = 5;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += button1_Click;
            // 
            // txtbookquantity
            // 
            txtbookquantity.Location = new Point(580, 139);
            txtbookquantity.Name = "txtbookquantity";
            txtbookquantity.Size = new Size(220, 23);
            txtbookquantity.TabIndex = 19;
            txtbookquantity.TextChanged += textBox7_TextChanged;
            // 
            // btndelete
            // 
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Segoe UI", 12F);
            btndelete.Location = new Point(620, 186);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(79, 34);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += button2_Click;
            // 
            // txtbookname
            // 
            txtbookname.Location = new Point(164, 22);
            txtbookname.Name = "txtbookname";
            txtbookname.Size = new Size(207, 23);
            txtbookname.TabIndex = 18;
            txtbookname.TextChanged += textBox6_TextChanged;
            // 
            // btncancel
            // 
            btncancel.BackgroundImageLayout = ImageLayout.None;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Font = new Font("Segoe UI", 12F);
            btncancel.Location = new Point(719, 186);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(79, 34);
            btncancel.TabIndex = 7;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += button3_Click;
            // 
            // txtbookpublication
            // 
            txtbookpublication.Location = new Point(159, 138);
            txtbookpublication.Name = "txtbookpublication";
            txtbookpublication.Size = new Size(212, 23);
            txtbookpublication.TabIndex = 16;
            txtbookpublication.TextChanged += textBox4_TextChanged;
            // 
            // txtbookprice
            // 
            txtbookprice.Location = new Point(580, 79);
            txtbookprice.Name = "txtbookprice";
            txtbookprice.Size = new Size(220, 23);
            txtbookprice.TabIndex = 8;
            txtbookprice.TextChanged += textBox2_TextChanged;
            // 
            // txtbookauthor
            // 
            txtbookauthor.Location = new Point(164, 81);
            txtbookauthor.Name = "txtbookauthor";
            txtbookauthor.Size = new Size(207, 23);
            txtbookauthor.TabIndex = 15;
            txtbookauthor.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(9, 81);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 10;
            label4.Text = "Book Author Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveBorder;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(409, 142);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 14;
            label8.Text = "Book Quantity";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(9, 142);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 11;
            label5.Text = "Book Publication";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveBorder;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(409, 81);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 13;
            label7.Text = "Book Price";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveBorder;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(409, 24);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 12;
            label6.Text = "Book Purchase Date";
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 696);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBooks";
            Text = "ViewBooks";
            Load += ViewBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtboxbookname;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtbookprice;
        private Button btncancel;
        private Button btndelete;
        private Button btnupdate;
        private DateTimePicker dateTimePicker1;
        private TextBox txtbookquantity;
        private TextBox txtbookname;
        private TextBox txtbookpublication;
        private TextBox txtbookauthor;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Button btnrefresh;
    }
}