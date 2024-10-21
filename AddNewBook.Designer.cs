namespace BookMonitoring
{
    partial class AddNewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtdatetimepicker = new DateTimePicker();
            btncancel = new Button();
            btnsave = new Button();
            txtpublication = new TextBox();
            txtquantity = new TextBox();
            txtprice = new TextBox();
            txtbookauthor = new TextBox();
            txtbookname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 37);
            label1.Name = "label1";
            label1.Size = new Size(134, 36);
            label1.TabIndex = 1;
            label1.Text = "Add Book";
            label1.Click += label1_Click;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 158);
            panel2.Controls.Add(txtdatetimepicker);
            panel2.Controls.Add(btncancel);
            panel2.Controls.Add(btnsave);
            panel2.Controls.Add(txtpublication);
            panel2.Controls.Add(txtquantity);
            panel2.Controls.Add(txtprice);
            panel2.Controls.Add(txtbookauthor);
            panel2.Controls.Add(txtbookname);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(1209, 592);
            panel2.TabIndex = 1;
            // 
            // txtdatetimepicker
            // 
            txtdatetimepicker.Location = new Point(178, 248);
            txtdatetimepicker.Name = "txtdatetimepicker";
            txtdatetimepicker.Size = new Size(412, 23);
            txtdatetimepicker.TabIndex = 14;
            txtdatetimepicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancel.Location = new Point(416, 406);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(97, 42);
            btncancel.TabIndex = 13;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += button2_Click;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(213, 406);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(97, 42);
            btnsave.TabIndex = 12;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += button1_Click;
            // 
            // txtpublication
            // 
            txtpublication.Location = new Point(178, 193);
            txtpublication.Name = "txtpublication";
            txtpublication.Size = new Size(412, 23);
            txtpublication.TabIndex = 10;
            txtpublication.TextChanged += textBox6_TextChanged;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(178, 366);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(412, 23);
            txtquantity.TabIndex = 9;
            txtquantity.TextChanged += textBox3_TextChanged;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(178, 310);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(412, 23);
            txtprice.TabIndex = 8;
            txtprice.TextChanged += textBox4_TextChanged;
            // 
            // txtbookauthor
            // 
            txtbookauthor.Location = new Point(178, 131);
            txtbookauthor.Name = "txtbookauthor";
            txtbookauthor.Size = new Size(412, 23);
            txtbookauthor.TabIndex = 7;
            txtbookauthor.TextChanged += textBox2_TextChanged;
            // 
            // txtbookname
            // 
            txtbookname.Location = new Point(178, 70);
            txtbookname.Name = "txtbookname";
            txtbookname.Size = new Size(412, 23);
            txtbookname.TabIndex = 6;
            txtbookname.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(28, 368);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 5;
            label7.Text = "Book Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(27, 312);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(28, 250);
            label5.Name = "label5";
            label5.Size = new Size(148, 21);
            label5.TabIndex = 3;
            label5.Text = "Book Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(28, 195);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 2;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(28, 133);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 1;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 72);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // AddNewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1209, 599);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewBook";
            Text = "AddNewBook";
            WindowState = FormWindowState.Maximized;
            Load += AddNewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button btnsave;
        private TextBox txtpublication;
        private TextBox txtquantity;
        private TextBox txtprice;
        private TextBox txtbookauthor;
        private TextBox txtbookname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btncancel;
        private DateTimePicker txtdatetimepicker;
    }
}