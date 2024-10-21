using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookMonitoring
{
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();


        }
       
        private void AddNewBook_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtbookname.Text != "" && txtbookauthor.Text != "" && txtpublication.Text != "" && txtprice.Text != "" && txtquantity.Text != "")
            {
                
                string bname = txtbookname.Text;
                string bauthor = txtbookauthor.Text;
                string publication = txtpublication.Text;
                string pdate = txtdatetimepicker.Text;
                Int64 price = Int64.Parse(txtprice.Text);
                Int64 quan = Int64.Parse(txtquantity.Text);

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into addbook ( Bname, Bauthor, Bpub, Bpurdate, Bprice, Bquan ) values ('" + @bname + "','" + @bauthor + "','" + @publication + "','" + @pdate + "','" + @price + "','" + @quan + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                txtbookname.Clear();
                txtbookauthor.Clear();
                txtpublication.Clear();
                txtprice.Clear();
                txtquantity.Clear();
            }
       else
            {

                MessageBox.Show("Empty field NOT Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This will DELETE all your unsaved data.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                this.Close();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }



        }

        private void txtbookid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
