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
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();

        }
      
        private void ViewBooks_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from addbook";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            txtbookname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtbookauthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtbookpublication.Text = ds.Tables[0].Rows[0][3].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            txtbookprice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtbookquantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
          

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "delete from addbook where BookID=" + rowid + "";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
            String Bname = (txtbookname.Text);
            String Bauthor = (txtbookauthor.Text);
            String Bpub = (txtbookpublication.Text);
            String Bpurdate = (dateTimePicker1.Text);
            Int64 Bprice = Int64.Parse(txtbookprice.Text);
            Int64 Bquan = Int64.Parse(txtbookquantity.Text);

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "update addbook set Bname = '" + Bname + "'  ,Bauthor = '" + Bauthor + "', Bpub = '" + Bpub + "',Bpurdate = '" + Bpurdate + "', Bprice = '" + Bprice + "', Bquan = '" + Bquan + "'where BookID=" + rowid + "  ";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        int BookID;
        Int64 rowid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                BookID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel3.Visible = true;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from addbook where BookID= " + +BookID + "";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            dataGridView1.DataSource = ds.Tables[0];
            txtbookname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtbookauthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtbookpublication.Text = ds.Tables[0].Rows[0][3].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            txtbookprice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtbookquantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_2(object sender, ScrollEventArgs e)
        {

        }
       

        private void btnsearch_Click(object sender, EventArgs e)
        {
           

        }

        private void txtboxbookname_TextChanged(object sender, EventArgs e)
        {
            if (txtboxbookname.Text != "")
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "select * from addbook where Bname like '" + txtboxbookname.Text + "%'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "select * from addbook";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            
            }

        }
    
    }

}
