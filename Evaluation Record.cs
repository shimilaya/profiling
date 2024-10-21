using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookMonitoring
{
    public partial class Evaluation_Record : Form
    {
        private MySqlConnection connection;
        private BindingSource evaluationBindingSource = new BindingSource();

        public Evaluation_Record()
        {
            InitializeComponent();
            string connectionString = "server=127.0.0.1;user=root;database=profiling;";
            connection = new MySqlConnection(connectionString);
        }

        private void Evaluation_Record_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM evaluation";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                evaluationBindingSource.DataSource = dataTable;
                dataGridView1.DataSource = evaluationBindingSource;
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
                evaluationBindingSource.RemoveFilter(); // Clear the filter if the search box is empty
            }
            else
            {
                string filterText = cmbSearch.Text.Replace("'", "''"); // Escape single quotes

                // Attempt to parse the input as an integer for Year or double for Evaluation_Grade_Percentage
                int yearFilterValue = TryParseInt(filterText);
                double numericFilterValue = TryParseDouble(filterText);

                // Build the filter
                string filter = $@"
                    Name_of_Evaluator LIKE '%{filterText}%'
                    OR Name_of_Prof LIKE '%{filterText}%'
                    OR Section LIKE '%{filterText}%'
                    OR Department LIKE '%{filterText}%'
                    OR Date_of_Evaluation LIKE '%{filterText}%'"; // For VARCHAR

                // Add condition for Year if the filter value is valid
                if (yearFilterValue != -1)
                {
                    filter += $" OR Year = {yearFilterValue}";
                }

                // Add condition for Evaluation_Grade_Percentage if the filter value is valid
                if (numericFilterValue != -1)
                {
                    filter += $" OR Evaluation_Grade_Percentage = {numericFilterValue}";
                }

                evaluationBindingSource.Filter = filter; // Apply the filter
            }
        }

        private double TryParseDouble(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return result; // Return the parsed number
            }
            return -1; // Return a value that won't match any data if parsing fails
        }

        private int TryParseInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result; // Return the parsed integer
            }
            return -1; // Return a value that won't match any data if parsing fails
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (evaluationBindingSource.Count == 0)
            {
                label1.Text = "No data to calculate."; // Use label1 here
                return;
            }

            double totalPercentage = 0;
            int count = 0;

            foreach (DataRowView row in evaluationBindingSource)
            {
                if (row["Evaluation_Grade_Percentage"] != DBNull.Value &&
                    double.TryParse(row["Evaluation_Grade_Percentage"].ToString(), out double percentage))
                {
                    totalPercentage += percentage;
                    count++;
                }
            }

            if (count > 0)
            {
                double averagePercentage = totalPercentage / count;
                label1.Text = $"Total Evaluation Grade Percentage: {averagePercentage:F2}%"; // Use label1 here
            }
            else
            {
                label1.Text = "No valid grades to calculate."; // Use label1 here
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
       
        }
    }
}
