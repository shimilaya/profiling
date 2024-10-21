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
    public partial class ViewStudentsInfo : Form
    {
        public ViewStudentsInfo()
        {
            InitializeComponent();
        }

        private void ViewStudentsInfo_Load(object sender, EventArgs e)
        {
           
            panel3.Visible = true;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from newstudent";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            //txtboxstud.Text = ds.Tables[0].Rows[0][1].ToString();
            //txtboxenrollment.Text = ds.Tables[0].Rows[0][2].ToString();
            //txtboxdept.Text = ds.Tables[0].Rows[0][3].ToString();
            //comboxsem.Text = ds.Tables[0].Rows[0][4].ToString();
            //txtboxcontact.Text = ds.Tables[0].Rows[0][5].ToString();
            //txtboxemail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
    }

