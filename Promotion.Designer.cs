namespace BookMonitoring
{
    partial class Promotion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cmbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aTTENDANCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eVALUATIONRECORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAFRECORDToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            cmbSearch = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            aTTENDANCEToolStripMenuItem = new ToolStripMenuItem();
            eVALUATIONRECORDToolStripMenuItem = new ToolStripMenuItem();
            cAFRECORDToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 113);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1319, 291);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbSearch
            // 
            cmbSearch.BackColor = Color.PaleTurquoise;
            cmbSearch.Location = new Point(1143, 77);
            cmbSearch.Margin = new Padding(3, 2, 3, 2);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(179, 23);
            cmbSearch.TabIndex = 16;
            cmbSearch.TextChanged += cmbSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1076, 78);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 14;
            label3.Text = "Search";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(336, 20);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 49);
            panel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 12);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 0;
            label2.Text = "Promotion";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aTTENDANCEToolStripMenuItem, eVALUATIONRECORDToolStripMenuItem, cAFRECORDToolStripMenuItem });
            menuStrip1.Location = new Point(3, 78);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(324, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // aTTENDANCEToolStripMenuItem
            // 
            aTTENDANCEToolStripMenuItem.Name = "aTTENDANCEToolStripMenuItem";
            aTTENDANCEToolStripMenuItem.Size = new Size(92, 20);
            aTTENDANCEToolStripMenuItem.Text = "ATTENDANCE";
            aTTENDANCEToolStripMenuItem.Click += aTTENDANCEToolStripMenuItem_Click;
            // 
            // eVALUATIONRECORDToolStripMenuItem
            // 
            eVALUATIONRECORDToolStripMenuItem.Name = "eVALUATIONRECORDToolStripMenuItem";
            eVALUATIONRECORDToolStripMenuItem.Size = new Size(135, 20);
            eVALUATIONRECORDToolStripMenuItem.Text = "EVALUATION RECORD";
            eVALUATIONRECORDToolStripMenuItem.Click += eVALUATIONRECORDToolStripMenuItem_Click;
            // 
            // cAFRECORDToolStripMenuItem
            // 
            cAFRECORDToolStripMenuItem.Name = "cAFRECORDToolStripMenuItem";
            cAFRECORDToolStripMenuItem.Size = new Size(89, 20);
            cAFRECORDToolStripMenuItem.Text = "CAF RECORD";
            cAFRECORDToolStripMenuItem.Click += cAFRECORDToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 415);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 18;
            button1.Text = "TOTAL ABSENT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(159, 419);
            label1.Name = "label1";
            label1.Size = new Size(267, 17);
            label1.TabIndex = 19;
            label1.Text = "                                                                                      ";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(461, 415);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 20;
            button2.Text = "EVALUATION";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(590, 419);
            label4.Name = "label4";
            label4.Size = new Size(267, 17);
            label4.TabIndex = 21;
            label4.Text = "                                                                                      ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Location = new Point(1021, 421);
            label5.Name = "label5";
            label5.Size = new Size(267, 17);
            label5.TabIndex = 22;
            label5.Text = "                                                                                      ";
            label5.Click += label5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(891, 417);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 23;
            button3.Text = "TOTAL CAF";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(590, 455);
            label6.Name = "label6";
            label6.Size = new Size(267, 17);
            label6.TabIndex = 25;
            label6.Text = "                                                                                      ";
            label6.Click += label6_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Location = new Point(1021, 455);
            label7.Name = "label7";
            label7.Size = new Size(267, 17);
            label7.TabIndex = 26;
            label7.Text = "                                                                                      ";
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(159, 467);
            label8.Name = "label8";
            label8.Size = new Size(267, 17);
            label8.TabIndex = 27;
            label8.Text = "                                                                                      ";
            // 
            // Promotion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1336, 586);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(cmbSearch);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Promotion";
            Load += Promotion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button2;
        private Label label4;
        private Label label5;
        private Button button3;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
