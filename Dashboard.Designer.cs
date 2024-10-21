namespace BookMonitoring
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBookDetailsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(336, 72);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 2, 3);
            menuStrip1.Size = new Size(761, 50);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.OldLace;
            booksToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Padding = new Padding(25, 0, 4, 0);
            booksToolStripMenuItem.Size = new Size(146, 44);
            booksToolStripMenuItem.Text = "Attendance";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Padding = new Padding(25, 0, 4, 0);
            issueBooksToolStripMenuItem.Size = new Size(175, 44);
            issueBooksToolStripMenuItem.Text = "Evaluation Record";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.OldLace;
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Padding = new Padding(25, 0, 4, 0);
            returnBooksToolStripMenuItem.Size = new Size(147, 44);
            returnBooksToolStripMenuItem.Text = "CAF Records";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            completeBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailsToolStripMenuItem.Image");
            completeBookDetailsToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            completeBookDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            completeBookDetailsToolStripMenuItem.Padding = new Padding(25, 0, 4, 0);
            completeBookDetailsToolStripMenuItem.Size = new Size(137, 44);
            completeBookDetailsToolStripMenuItem.Text = "Promotion";
            completeBookDetailsToolStripMenuItem.Click += completeBookDetailsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.OldLace;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Padding = new Padding(25, 0, 4, 0);
            exitToolStripMenuItem.Size = new Size(104, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(61, 72);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1294, 50);
            panel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(13, 9);
            panel7.Name = "panel7";
            panel7.Size = new Size(2, 33);
            panel7.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(1280, 9);
            panel6.Name = "panel6";
            panel6.Size = new Size(2, 33);
            panel6.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(34, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(1352, 125);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(27, 113);
            panel5.Name = "panel5";
            panel5.Size = new Size(1294, 2);
            panel5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(27, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(1294, 2);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Rockwell", 25.75F, FontStyle.Bold);
            label2.Location = new Point(183, 39);
            label2.Name = "label2";
            label2.Size = new Size(209, 45);
            label2.TabIndex = 0;
            label2.Text = "Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(217, 20);
            label1.Name = "label1";
            label1.Size = new Size(1001, 39);
            label1.TabIndex = 0;
            label1.Text = "Comprehensive Staff Profiling and Promotion Analytics System";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.MistyRose;
            panel1.Location = new Point(34, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 494);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Gainsboro;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1410, 789);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Panel panel1;
    }
}