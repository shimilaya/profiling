using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookMonitoring
{
    public partial class Attendance : Form
    {
        private MySqlConnection connection;
        private BindingSource attendanceBindingSource = new BindingSource();

        public Attendance()
        {
            InitializeComponent();
            string connectionString = "server=127.0.0.1;user=root;database=profiling;"; // Adjust your connection string as necessary
            connection = new MySqlConnection(connectionString);

            // Connect event handlers
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged); // For Employee and Department search
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged); // Add event handler for DateTimePicker
            btnCal.Click += new EventHandler(btnCal_Click); // Add event handler for overall calculation button
            btnSpe.Click += new EventHandler(btnSpe_Click); // Add event handler for specific calculation button
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            LoadData(); // Load initial data
        }

        private void LoadData(string searchValue = "", DateTime? selectedDate = null)
        {
            try
            {
                connection.Open();
                string query = "SELECT Employee, Department, Schedule, In_date, In_time, Out_date, Out_time, Absent, Hours_Worked FROM attendance";
                List<string> conditions = new List<string>();

                // Add search condition if a search value is provided
                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    string textBox1 = searchValue.Replace("'", "''"); // Escape single quotes
                    conditions.Add($@"
                        Employee LIKE '%{textBox1}%' OR 
                        Department LIKE '%{textBox1}%' OR 
                        Schedule LIKE '%{textBox1}%' OR 
                        In_date LIKE '%{textBox1}%' OR 
                        In_time LIKE '%{textBox1}%' OR 
                        Out_date LIKE '%{textBox1}%' OR 
                        Out_time LIKE '%{textBox1}%' OR 
                        Absent = {TryParseDouble(textBox1)} OR 
                        Hours_Worked = {TryParseDouble(textBox1)}");
                }

                // Add date condition if a date is selected
                if (selectedDate.HasValue)
                {
                    conditions.Add("DATE(In_date) = @selectedDate");
                }

                // Append conditions to query if they exist
                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                MySqlCommand command = new MySqlCommand(query, connection);

                // Add parameter for date if applicable
                if (selectedDate.HasValue)
                {
                    command.Parameters.AddWithValue("@selectedDate", selectedDate.Value.ToString("yyyy-MM-dd"));
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Set the DataSource of the DataGridView to the DataTable
                attendanceBindingSource.DataSource = dataTable;
                dataGridView1.DataSource = attendanceBindingSource;
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show($"MySQL error: {mysqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}");
            }
            finally
            {
                connection.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim(); // Get the text from the textbox
            DateTime? selectedDate = dateTimePicker1.Checked ? dateTimePicker1.Value.Date : (DateTime?)null; // Get the date if selected
            LoadData(searchValue, selectedDate); // Call LoadData with the search value and selected date
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim(); // Get the text from the textbox
            LoadData(searchValue, dateTimePicker1.Value.Date); // Call LoadData with the search value and selected date
        }

        private void CalculateAverage()
        {
            try
            {
                connection.Open();
                string query = @"
                    SELECT 
                        COALESCE(SUM(Absent), 0) AS TotalAbsent, 
                        COUNT(*) AS TotalDays, 
                        COALESCE(SUM(Hours_Worked), 0) AS TotalHoursWorked 
                    FROM attendance";

                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Safely retrieve the values from the database
                        double totalAbsent = reader.GetDouble("TotalAbsent");
                        double totalDays = reader.GetDouble("TotalDays");
                        double totalHoursWorked = reader.GetDouble("TotalHoursWorked");

                        // Calculate averages
                        double averageHoursWorked = totalDays > 0 ? totalHoursWorked / totalDays : 0;
                        double averageAbsentPercentage = totalDays > 0 ? (totalAbsent / totalDays) * 100 : 0;

                        // Display results
                        string message = "Overall Average Attendance Data:\n";
                        message += $"Total Absent Days: {totalAbsent}\n" +
                                   $"Total Days Worked: {totalDays}\n" +
                                   $"Total Hours Worked: {totalHoursWorked}\n" +
                                   $"Average Hours Worked per Day: {averageHoursWorked:F2}\n" +
                                   $"Average Absent Percentage: {averageAbsentPercentage:F2}%";

                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("No data found in the attendance records.");
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show($"MySQL error: {mysqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            // Directly call CalculateAverage without any parameters
            CalculateAverage();
        }

        private void btnSpe_Click(object sender, EventArgs e)
        {
            // Get input from textBox1
            string input = textBox1.Text.Trim();
            DateTime selectedDate = dateTimePicker1.Value.Date; // Get the date from DateTimePicker

            // Call CalculateSpecificAverage with the input and selected date
            CalculateSpecificAverage(input, selectedDate);
        }

        private void CalculateSpecificAverage(string input, DateTime selectedDate)
        {
            try
            {
                connection.Open();

                // Initialize the base query
                string query = @"
            SELECT 
                COALESCE(SUM(Absent), 0) AS TotalAbsent, 
                COUNT(*) AS TotalDays, 
                COALESCE(SUM(Hours_Worked), 0) AS TotalHoursWorked 
            FROM attendance
            WHERE DATE(In_date) = @selectedDate";

                // If the input is not empty, we can add filtering for Employee or Department
                if (!string.IsNullOrWhiteSpace(input))
                {
                    query += " AND (Employee LIKE @Employee OR Department LIKE @Department)";
                }

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@selectedDate", selectedDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Employee", $"%{input}%"); // Use LIKE to allow partial matches
                command.Parameters.AddWithValue("@Department", $"%{input}%"); // Use LIKE to allow partial matches

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        double totalAbsent = reader.GetDouble("TotalAbsent");
                        double totalDays = reader.GetDouble("TotalDays");
                        double totalHoursWorked = reader.GetDouble("TotalHoursWorked");

                        double averageHoursWorked = totalDays > 0 ? totalHoursWorked / totalDays : 0;
                        double averageAbsentPercentage = totalDays > 0 ? (totalAbsent / totalDays) * 100 : 0;

                        string message = $"Attendance Data for: {input} on {selectedDate.ToShortDateString()}:\n";
                        message += $"Total Absent Days: {totalAbsent}\n" +
                                   $"Total Days Worked: {totalDays}\n" +
                                   $"Total Hours Worked: {totalHoursWorked}\n" +
                                   $"Average Hours Worked per Day: {averageHoursWorked:F2}\n" +
                                   $"Average Absent Percentage: {averageAbsentPercentage:F2}%";

                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified Employee or Department on the selected date.");
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show($"MySQL error: {mysqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            // Get input from textBox1
            string input = textBox1.Text.Trim(); // Input is the selected employee

            // Ensure the input is not empty
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter an employee name.");
                return; // Exit if no employee name is provided
            }

            // Call CalculateSpecificAverage with the input (for specific employee)
            CalculateSpecificAverage(input);
        }


        private void CalculateSpecificAverage(string employeeName)
        {
            try
            {
                connection.Open();

                // Initialize the base query to get attendance for a specific employee
                string query = @"
            SELECT 
                COALESCE(SUM(Absent), 0) AS TotalAbsent, 
                COUNT(*) AS TotalDays, 
                COALESCE(SUM(Hours_Worked), 0) AS TotalHoursWorked 
            FROM attendance
            WHERE Employee LIKE @Employee"; // Filter by Employee name

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Employee", $"%{employeeName}%"); // Use LIKE for partial matches

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        double totalAbsent = reader.GetDouble("TotalAbsent");
                        double totalDays = reader.GetDouble("TotalDays");
                        double totalHoursWorked = reader.GetDouble("TotalHoursWorked");

                        double averageHoursWorked = totalDays > 0 ? totalHoursWorked / totalDays : 0;
                        double averageAbsentPercentage = totalDays > 0 ? (totalAbsent / totalDays) * 100 : 0;

                        string message = $"Attendance Data for: {employeeName}\n";
                        message += $"Total Absent Days: {totalAbsent}\n" +
                                   $"Total Days Worked: {totalDays}\n" +
                                   $"Total Hours Worked: {totalHoursWorked}\n" +
                                   $"Average Hours Worked per Day: {averageHoursWorked:F2}\n" +
                                   $"Average Absent Percentage: {averageAbsentPercentage:F2}%";

                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified Employee.");
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show($"MySQL error: {mysqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            // Get input from textBox1
            string input = textBox1.Text.Trim(); // Input is the selected department

            // Ensure the input is not empty
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a department name.");
                return; // Exit if no department name is provided
            }

            // Call CalculateDepartmentAverage with the input (for specific department)
            CalculateDepartmentAverage(input);
        }
        private void CalculateDepartmentAverage(string departmentName)
        {
            try
            {
                connection.Open();

                // Initialize the base query to get attendance for a specific department
                string query = @"
            SELECT 
                COALESCE(SUM(Absent), 0) AS TotalAbsent, 
                COUNT(*) AS TotalDays, 
                COALESCE(SUM(Hours_Worked), 0) AS TotalHoursWorked 
            FROM attendance
            WHERE Department LIKE @Department"; // Filter by Department name

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Department", $"%{departmentName}%"); // Use LIKE for partial matches

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        double totalAbsent = reader.GetDouble("TotalAbsent");
                        double totalDays = reader.GetDouble("TotalDays");
                        double totalHoursWorked = reader.GetDouble("TotalHoursWorked");

                        double averageHoursWorked = totalDays > 0 ? totalHoursWorked / totalDays : 0;
                        double averageAbsentPercentage = totalDays > 0 ? (totalAbsent / totalDays) * 100 : 0;

                        string message = $"Attendance Data for Department: {departmentName}\n";
                        message += $"Total Absent Days: {totalAbsent}\n" +
                                   $"Total Days Worked: {totalDays}\n" +
                                   $"Total Hours Worked: {totalHoursWorked}\n" +
                                   $"Average Hours Worked per Day: {averageHoursWorked:F2}\n" +
                                   $"Average Absent Percentage: {averageAbsentPercentage:F2}%";

                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified Department.");
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show($"MySQL error: {mysqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
