using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class empform : Form
    {
        private string connectionString = "User Id=sys;Password=MyNewSecurePassword123;Data Source=//7ARRUKH:1521/orcl;DBA Privilege=SYSDBA";

        public empform()
        {
            InitializeComponent();
            AdminAccessManager.LoadAdminIds(); // Load admin IDs from XML file when the form is loaded
        }

        public void SetEmployeeData(DataTable employeeData)
        {
            if (employeeData.Rows.Count > 0)
            {
                DataRow row = employeeData.Rows[0];

                your.Text = $"HEY {row["first_name"]} {row["last_name"]}, YOUR PROFILE:";
                First_Name.Text = $"First Name: {row["first_name"]}";
                Last_Name.Text = $"Last Name: {row["last_name"]}";
                Age.Text = $"Age: {row["age"]}";
                Gender.Text = $"Gender: {row["gender"]}";
                Hire_Date.Text = $"Hire Date: {Convert.ToDateTime(row["hire_date"]).ToShortDateString()}";
                Position.Text = $"Position ID: {row["position_id"]}";
                Department.Text = $"Department ID: {row["dept_id"]}";
                Salary.Text = $"Original Salary: {row["original_salary"]}";
                Adjusted_Salary.Text = $"Adjusted Salary: {row["adjusted_salary"]}";
                Phone_No.Text = $"Phone No: {row["phone"]}";
                Email.Text = $"Email: {row["email"]}";
                Employee_idd.Text = $"Employee ID: {row["emp_id"]}";
                Absence_Count.Text = $"Absence Count: {row["absence_count"]}";

                int empId = Convert.ToInt32(row["emp_id"]);
                LoadAttendanceData(empId); // Display attendance in the grid

                string paymentDate = GetPaymentDate(empId);
                Salarylbl.Text = $"Payment Date: {paymentDate}";

                bool isAdmin = AdminAccessManager.AdminIds.Contains(empId);
                Admin_Access_Button.Visible = isAdmin;
                Admin_Access_Button.Enabled = isAdmin;
            }
            else
            {
                MessageBox.Show("No employee data found.");
            }
        }

        private void LoadAttendanceData(int empId)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT 
                          
                            
                            a.holiday_date,
                            a.is_holiday,
                            NVL(ab.absence_count, 0) AS absence_count
                        FROM 
                            Attendance a
                        JOIN 
                            Employee e ON a.emp_id = e.emp_id
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
                        ) ab ON e.emp_id = ab.emp_id
                        WHERE 
                            a.emp_id = :emp_id
                        ORDER BY 
                            a.holiday_date";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.BindByName = true;
                        cmd.Parameters.Add(new OracleParameter(":emp_id", empId));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable attendanceData = new DataTable();
                                attendanceData.Load(reader);
                                dataG.DataSource = attendanceData; // Bind attendance data to the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No attendance records found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance data: {ex.Message}");
            }
        }

        private string GetPaymentDate(int empId)
        {
            string paymentDate = string.Empty;

            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            payment_date 
                        FROM 
                            Payroll 
                        WHERE 
                            emp_id = :emp_id 
                        ORDER BY 
                            payment_date DESC 
                        FETCH FIRST 1 ROWS ONLY";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.BindByName = true;
                        cmd.Parameters.Add(new OracleParameter(":emp_id", empId));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                paymentDate = Convert.ToDateTime(reader["payment_date"]).ToShortDateString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching payment date: {ex.Message}");
            }

            return paymentDate;
        }

        private void Admin_Access_Button_Click(object sender, EventArgs e)
        {
            Form1 adminPanel = new Form1();
            adminPanel.SetAdminStatus(Admin_Access_Button.Visible); // Pass the visibility status of admin
            adminPanel.Show();
        }

        private void Bck_Click(object sender, EventArgs e)
        {
            using (var obj = new employeelogin())
            {
                this.Hide();
                obj.ShowDialog();
            }
        }
    }
}
