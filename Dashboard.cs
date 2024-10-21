using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BookMonitoring
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }
        public void loadform(object Form)
        {
            if (Form != null && Form is Form form)
            {
                // Remove any existing controls from panel1
                if (this.panel1.Controls.Count > 0)
                    this.panel1.Controls.RemoveAt(0);

                // Set up the new form
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;

                // Add the form to panel1
                this.panel1.Controls.Add(form);
                this.panel1.Tag = form;
                form.Show();
            }
            else
            {
                // Handle the case where Form is null or not of expected type
                MessageBox.Show("Invalid form object provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new AddNewBook());
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new CAF_Record());
            //ReturnBooks returnbooks = new ReturnBooks();
            //returnbooks.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Attendance());
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ViewBooks());
            //ViewBooks viewbooks = new ViewBooks();
            //viewbooks.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Evaluation_Record());
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Promotion());
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure You want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new AddStudent());

        }

        private void viewStudentsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ViewStudentsInfo());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
