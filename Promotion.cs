using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookMonitoring
{
    public partial class Promotion : Form
    {
        private string connectionString = "Server=localhost;Database=profiling;User ID=root;Password=;";
        private string currentDataset = "";
        private string selectedEmployee = ""; // To hold the selected employee name

        public Promotion()
        {
            InitializeComponent();
            cmbSearch.TextChanged += cmbSearch_TextChanged; // Add event handler for text changed event
        }

        private void Promotion_Load(object sender, EventArgs e)
        {
            // Optional: Load initial data or setup if needed
        }

        private void aTTENDANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDataset = "attendance";
            LoadAttendanceData();
        }

        private void eVALUATIONRECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDataset = "evaluation";
            LoadEvaluationData();
        }

        private void cAFRECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDataset = "caf_recordss";
            LoadCAFData();
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView(cmbSearch.Text);
            selectedEmployee = cmbSearch.Text; // Capture the selected employee name
        }

        private void LoadAttendanceData()
        {
            LoadData("SELECT * FROM attendance");
        }

        private void LoadEvaluationData()
        {
            LoadData("SELECT * FROM evaluation");
        }

        private void LoadCAFData()
        {
            LoadData("SELECT * FROM caf_recordss");
        }

        private void LoadData(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }

        private void FilterDataGridView(string filterText)
        {
            string query = "";

            if (currentDataset == "attendance")
            {
                query = @"
                    SELECT * FROM attendance 
                    WHERE Employee LIKE @filterText 
                    OR Department LIKE @filterText
                    OR Schedule LIKE @filterText
                    OR In_date LIKE @filterText
                    OR In_time LIKE @filterText
                    OR Out_date LIKE @filterText
                    OR Out_time LIKE @filterText
                    OR Absent LIKE @filterText
                    OR Hours_Worked LIKE @filterText";
            }
            else if (currentDataset == "evaluation")
            {
                query = @"
                    SELECT * FROM evaluation 
                    WHERE Name_of_Prof LIKE @filterText 
                    OR Year LIKE @filterText
                    OR Section LIKE @filterText
                    OR Department LIKE @filterText
                    OR Date_of_Evaluation LIKE @filterText
                    OR Evaluation_Grade_Percentage LIKE @filterText";
            }
            else if (currentDataset == "caf_recordss")
            {
                query = @"
                    SELECT * FROM caf_recordss 
                    WHERE Employee LIKE @filterText 
                    OR Department LIKE @filterText
                    OR Date_Issued LIKE @filterText
                    OR Remarks LIKE @filterText";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@filterText", "%" + filterText + "%");
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filtering data: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployee))
            {
                MessageBox.Show("Please select an employee to calculate.");
                return;
            }

            string query = "SELECT SUM(Absent) FROM attendance WHERE Employee = @employee";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employee", selectedEmployee);
                    var result = command.ExecuteScalar();
                    int totalAbsences = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    label1.Text = $"Total Absences: {totalAbsences}";
                    CheckPassFail(totalAbsences, -1, -1); // Call with dummy values for evaluation and CAF
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while calculating total absences: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployee))
            {
                MessageBox.Show("Please select an employee to calculate.");
                return;
            }

            string query = "SELECT AVG(Evaluation_Grade_Percentage) FROM evaluation WHERE Name_of_Prof = @employee";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employee", selectedEmployee);
                    var result = command.ExecuteScalar();
                    double averageEvaluationGrade = result != DBNull.Value ? Convert.ToDouble(result) : 0;

                    label4.Text = $"Average Evaluation Grade: {averageEvaluationGrade:F2}";
                    CheckPassFail(-1, averageEvaluationGrade, -1); // Call with dummy values for absences and CAF
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while calculating average evaluation grade: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployee))
            {
                MessageBox.Show("Please select an employee to calculate.");
                return;
            }

            string query = "SELECT COUNT(*) FROM caf_recordss WHERE Employee = @employee";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employee", selectedEmployee);
                    var result = command.ExecuteScalar();
                    int totalCAFRecords = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    label5.Text = $"Total CAF Records: {totalCAFRecords}";
                    CheckPassFail(-1, -1, totalCAFRecords); // Call with dummy values for absences and evaluation
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while calculating total CAF records: " + ex.Message);
                }
            }
        }

        private void CheckPassFail(int totalAbsences, double averageEvaluationGrade, int totalCAFRecords)
        {
            bool hasFailed = false;

            // Check each condition
            if (totalAbsences > 2)
            {
                label8.Text = "Status: Failed (Total Absences Exceeded)";
                hasFailed = true;
            }
            else
            {
                label8.Text = "Status: Passed";
            }

            if (averageEvaluationGrade < 85 && averageEvaluationGrade >= 0)
            {
                label6.Text = "Status: Failed (Average Evaluation Grade Below 85)";
                hasFailed = true;
            }
            else if (averageEvaluationGrade >= 0)
            {
                label6.Text = "Status: Passed";
            }

            if (totalCAFRecords != 0)
            {
                label7.Text = "Status: Failed ";
                hasFailed = true;
            }
            else
            {
                label7.Text = "Status: Passed";
            }

            // Determine overall status
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e)
        {
            // Implement any additional logic for button 4
            MessageBox.Show("Button 4 clicked - implement your logic here.");
        }

        private void labelOverallStatus_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
