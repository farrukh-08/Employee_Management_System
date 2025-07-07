using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class employeelogin : Form
    {
        private string connectionString = "User Id=sys;Password=MyNewSecurePassword123;Data Source=//7ARRUKH:1521/orcl;DBA Privilege=SYSDBA";

        public employeelogin()
        {
            InitializeComponent();
        }

        private OracleConnection GetOracleConnection()
        {
            return new OracleConnection(connectionString);
        }

        private void Loginemployeebutton_Click(object sender, EventArgs e)
        {
            string empId = Employeeloginformtextbox.Text;
            string empPassword = Employee_Password.Text;

            if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(empPassword))
            {
                MessageBox.Show("Please enter both Employee ID and Employee Password.");
                return;
            }

            using (var connection = GetOracleConnection())
            {
                try
                {
                    // Query to fetch the employee password
                    string query = "SELECT emp_password FROM Employee WHERE emp_id = :empId";
                    var command = new OracleCommand(query, connection);
                    command.Parameters.Add(new OracleParameter("empId", empId));

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // Read the first row of the result
                            string storedPassword = reader.GetString(reader.GetOrdinal("emp_password")); // Assuming the password is stored in emp_password column

                            // Check if the entered password matches the stored password
                            if (storedPassword == empPassword)
                            {
                                // Password matches, proceed to fetch employee details
                                string detailQuery = @"
                                SELECT 
                                    e.emp_id,
                                    e.first_name,
                                    e.last_name,
                                    e.age,
                                    e.gender,
                                    e.email,
                                    e.phone,
                                    e.hire_date,
                                    e.dept_id,
                                    e.position_id,
                                    e.salary AS original_salary,
                                    CASE 
                                        WHEN NVL(a.absence_count, 0) > 2 THEN e.salary * 0.95  
                                        ELSE e.salary  
                                    END AS adjusted_salary,
                                    NVL(a.absence_count, 0) AS absence_count
                                FROM 
                                    Employee e
                                LEFT JOIN (
                                    SELECT 
                                        emp_id,
                                        COUNT(*) AS absence_count
                                    FROM 
                                        Attendance
                                    WHERE 
                                        is_holiday = 'Y'
                                    GROUP BY 
                                        emp_id
                                ) a ON e.emp_id = a.emp_id
                                WHERE 
                                    e.emp_id = :empId
                                ORDER BY 
                                    e.emp_id ASC";

                                var detailCommand = new OracleCommand(detailQuery, connection);
                                detailCommand.Parameters.Add(new OracleParameter("empId", empId));

                                using (var detailReader = detailCommand.ExecuteReader())
                                {
                                    DataTable employeeData = new DataTable();
                                    employeeData.Load(detailReader);

                                    // Show employee form
                                    var empF = new empform();
                                    empF.SetEmployeeData(employeeData); // Set the data for the DataGridView
                                    this.Hide();
                                    empF.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error: Incorrect password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Employee ID not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void forg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var obj = new forgotpassword())
            {
                this.Hide();
                obj.ShowDialog();
            }
        }

        private void PERVV_Click(object sender, EventArgs e)
        {
            using (var obj = new login())
            {
                this.Hide();
                obj.ShowDialog();
            }

        }
    }
}