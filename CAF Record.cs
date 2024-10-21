using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookMonitoring
{
    public partial class CAF_Record : Form
    {
        private MySqlConnection connection;
        private BindingSource cafBindingSource = new BindingSource();

        public CAF_Record()
        {
            InitializeComponent();
            string connectionString = "server=127.0.0.1;user=root;database=profiling;";
            connection = new MySqlConnection(connectionString);
        }

        private void CAF_Record_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM caf_recordss";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                // Set the BindingSource data
                cafBindingSource.DataSource = dataTable;

                // Bind the BindingSource to the DataGridView
                dataGridView1.DataSource = cafBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSearch.Text))
            {
                cafBindingSource.RemoveFilter(); // Clear the filter if the search box is empty
            }
            else
            {
                string filterText = cmbSearch.Text.Replace("'", "''"); // Escape single quotes

                // Define the filter string
                string filter = $@"
                    Employee LIKE '%{filterText}%'
                    OR Date_Issued LIKE '%{filterText}%'
                    OR Department LIKE '%{filterText}%'
                    OR Remarks LIKE '%{filterText}%'";

                cafBindingSource.Filter = filter; // Apply the filter
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }
    }
}
