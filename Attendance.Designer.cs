namespace BookMonitoring
{
    partial class Attendance
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
            saveFileDialog1 = new SaveFileDialog();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnCal = new Button();
            btnSpe = new Button();
            button2 = new Button();
            btnEmp = new Button();
            btnDept = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 117);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1319, 291);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleTurquoise;
            textBox1.Location = new Point(1143, 77);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(336, 20);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 49);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 0;
            label1.Text = "ATTENDANCE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(1076, 78);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 13;
            label3.Text = "Search";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(848, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.PaleTurquoise;
            btnCal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCal.Location = new Point(449, 422);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(163, 35);
            btnCal.TabIndex = 15;
            btnCal.Text = "Calculate Overall";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // btnSpe
            // 
            btnSpe.BackColor = Color.PaleTurquoise;
            btnSpe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSpe.Location = new Point(618, 422);
            btnSpe.Name = "btnSpe";
            btnSpe.Size = new Size(196, 35);
            btnSpe.TabIndex = 16;
            btnSpe.Text = "Calculate Specific Date";
            btnSpe.UseVisualStyleBackColor = false;
            btnSpe.Click += btnSpe_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1290, 528);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 17;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnEmp
            // 
            btnEmp.BackColor = Color.PaleTurquoise;
            btnEmp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEmp.Location = new Point(820, 422);
            btnEmp.Name = "btnEmp";
            btnEmp.Size = new Size(246, 35);
            btnEmp.TabIndex = 18;
            btnEmp.Text = "Calculate Specific Employee";
            btnEmp.UseVisualStyleBackColor = false;
            btnEmp.Click += btnEmp_Click;
            // 
            // btnDept
            // 
            btnDept.BackColor = Color.PaleTurquoise;
            btnDept.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDept.Location = new Point(1072, 422);
            btnDept.Name = "btnDept";
            btnDept.Size = new Size(257, 35);
            btnDept.TabIndex = 19;
            btnDept.Text = "Calculate Specific Department";
            btnDept.UseVisualStyleBackColor = false;
            btnDept.Click += btnDept_Click;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1352, 602);
            Controls.Add(btnDept);
            Controls.Add(btnEmp);
            Controls.Add(button2);
            Controls.Add(btnSpe);
            Controls.Add(btnCal);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Attendance";
            Text = "Attendance";
            Load += Attendance_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnCal;
        private Button btnSpe;
        private Button button2;
        private Button btnEmp;
        private Button btnDept;
    }
}