using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMonitoring
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtboxstud.Text != "" && txtboxenrollment.Text != "" && txtboxdept.Text != "" && comboxsem.Text != "" && txtboxcontact.Text != "" && txtboxemail.Text != "")
            {


                string StudName = txtboxstud.Text;
                Int64 EnrollNum = Int64.Parse(txtboxenrollment.Text);
                string Department = txtboxdept.Text;
                string StudSem = comboxsem.Text;
                Int64 StudContact = Int64.Parse(txtboxcontact.Text);
                string StudEmail = txtboxemail.Text;



                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server =127.0.0.1;user=root;database=bookmonitor;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into newstudent ( StudName, EnrollNum, Department, StudSem, StudContact, StudEmail ) values ('" + @StudName + "','" + @EnrollNum + "','" + @Department + "','" + @StudSem + "','" + @StudContact + "','" + @StudEmail + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtboxstud.Clear();
                txtboxenrollment.Clear();
                txtboxdept.Clear();
               
                txtboxcontact.Clear();
                txtboxemail.Clear();
            }
            else
            {

                MessageBox.Show("Empty field NOT Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

        }

        private void txtboxemail_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void comboxyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboxsem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
