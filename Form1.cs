
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace VP_Project
{
    public partial class Form1 : Form
    {
        private string connectionString = "User Id=sys;Password=MyNewSecurePassword123;Data Source=//7ARRUKH:1521/orcl;DBA Privilege=SYSDBA";


        public Form1()
        {
            InitializeComponent();
            AdminAccessManager.LoadAdminIds();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadDepartments();
            this.LoadPositions();
            Department_combo_box.Items.AddRange(departmentMapping.Keys.ToArray());
            Position_combo_box.Items.AddRange(positionMapping.Keys.ToArray());
        }

        public void SetAdminStatus(bool isAdmin)
        {
            if (isAdmin)
            {
                this.Admin_Panel_Label.Text = "Temporary Admin Panel";
                this.Remove_Admin_Access_Label.Visible = false;
                this.Remove_Admin_Access_txtArea.Visible = false;
                this.Remove_Admin_Access_Button.Visible = false;
            }
            else
            {
                this.Remove_Admin_Access_Label.Visible = true;
                this.Remove_Admin_Access_txtArea.Visible = true;
                this.Remove_Admin_Access_Button.Visible = true;
            }
        }

        private void LoadPositions()
        {
            using (OracleConnection oracleConnection = this.GetOracleConnection())
            {
                try
                {
                    OracleCommand oracleCommand = new OracleCommand("SELECT position_id, position_title FROM Position", oracleConnection);
                    oracleConnection.Open();
                    using (OracleDataReader oracleDataReader = oracleCommand.ExecuteReader())
                    {
                        List<KeyValuePair<int, string>> keyValuePairList = new List<KeyValuePair<int, string>>();
                        while (oracleDataReader.Read())
                        {
                            int int32 = oracleDataReader.GetInt32(0);
                            string str = oracleDataReader.GetString(1);
                            keyValuePairList.Add(new KeyValuePair<int, string>(int32, str));
                        }
                        if (keyValuePairList.Count > 0)
                        {
                            this.list_BY_Position.DataSource = (object)keyValuePairList;
                            this.list_BY_Position.DisplayMember = "Value";
                            this.list_BY_Position.ValueMember = "Key";
                        }
                        else
                        {
                            int num = (int)MessageBox.Show("No positions found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Error loading positions: " + ex.Message);
                }
            }
        }

        private void LoadDepartments()
        {
            using (OracleConnection oracleConnection = this.GetOracleConnection())
            {
                OracleCommand oracleCommand = new OracleCommand("SELECT dept_name FROM Department", oracleConnection);
                oracleConnection.Open();
                using (OracleDataReader oracleDataReader = oracleCommand.ExecuteReader())
                {
                    this.List_Type_combo_box.Items.Clear();
                    while (oracleDataReader.Read())
                    {
                        this.List_Type_combo_box.Items.Add((object)oracleDataReader.GetString(0));
                    }
                }
            }
        }

        private readonly Dictionary<string, int> departmentMapping = new Dictionary<string, int>
    {
            { "HR", 1 },
            { "Engineering", 2 },
            { "Finance", 3 },
            { "Sales", 4 }
    };

        private readonly Dictionary<string, int> positionMapping = new Dictionary<string, int>
    {
            { "Manager", 1 },
            { "Engineer", 2 },
            { "Accountant", 3 },
            { "Sales Rep", 4 }
    };


        private OracleConnection GetOracleConnection() => new OracleConnection(this.connectionString);

        private void ADD_EMP_Click(object sender, EventArgs e)
        {
            string s1 = this.Add_Employee_ID.Text.Trim();
            string empPassword = this.employee_password.Text.Trim();
            string firstName = this.Add_Employee_FirstName.Text.Trim();
            string lastName = this.Add_Employee_LastName.Text.Trim();
            string str1 = this.gendertextarea.Text.Trim().ToLower();
            string recipientEmail = this.Add_Employee_Email.Text.Trim();
            string str2 = this.Add_Employee_PhoneNO.Text.Trim();
            DateTime result6 = this.HireDate.Value;
            string selectedDept = Department_combo_box.SelectedItem?.ToString();
            string selectedPos = Position_combo_box.SelectedItem?.ToString();
            string s5 = this.addsalary.Text.Trim();
            string s6 = this.agetextarea.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(s6) ||
                string.IsNullOrEmpty(selectedDept) || string.IsNullOrEmpty(selectedPos))
            {
                MessageBox.Show("Please fill all required fields (Employee ID, First Name, Last Name, Age, Department, and Position).");
                return;
            }

            // Validate gender (must be either "Male" or "Female")
            if (string.IsNullOrEmpty(str1) || (str1 != "male" && str1 != "female"))
            {
                MessageBox.Show("Gender must be either 'Male' or 'Female'.");
                return;
            }

            // Validate Employee ID (must be a valid non-negative integer)
            if (!int.TryParse(s1, out int result1) || result1 < 0)
            {
                MessageBox.Show("Employee ID must be a valid non-negative integer.");
                return;
            }

            // Validate Age (must be a valid positive integer)
            if (!int.TryParse(s6, out int result4) || result4 <= 17)
            {
                MessageBox.Show("Age must be a valid positive integer.");
                return;
            }

            // Validate Salary (must be a valid decimal number)
            if (!decimal.TryParse(s5, out decimal result5))
            {
                MessageBox.Show("Salary must be a valid decimal number.");
                return;
            }

            // Validate Phone Number (allow dashes, but must be digits only)
            string phoneWithoutDashes = str2.Replace("-", "");
            if (str2.Contains("-"))
            {
                // Validate format like xxx-xxx-xxxx
                string[] phoneParts = str2.Split('-');
                if (phoneParts.Length != 3 || phoneParts[0].Length != 3 || phoneParts[1].Length != 3 || phoneParts[2].Length != 4 ||
                    !phoneParts.All(part => part.All(char.IsDigit)))
                {
                    MessageBox.Show("Phone number with dashes must be in the format xxx-xxx-xxxx.");
                    return;
                }
            }
            else
            {
                // Validate format like xxxxxxxxxx
                if (phoneWithoutDashes.Length > 17 || !phoneWithoutDashes.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must be a valid number with at least 10 digits.");
                    return;
                }
            }

            // Validate Email (must contain '@' symbol)
            if (!recipientEmail.Contains("@"))
            {
                MessageBox.Show("Email must be a valid format (must contain '@').");
                return;
            }

            // Validate Department
            if (!departmentMapping.TryGetValue(selectedDept, out int deptId))
            {
                MessageBox.Show("Invalid department selected.");
                return;
            }

            // Validate Position
            if (!positionMapping.TryGetValue(selectedPos, out int posId))
            {
                MessageBox.Show("Invalid position selected.");
                return;
            }

            try
            {
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    oracleConnection.Open();

                    // Check if the Employee ID already exists
                    using (OracleCommand checkCommand = new OracleCommand(
                        "SELECT COUNT(*) FROM Employee WHERE emp_id = :empId", oracleConnection))
                    {
                        checkCommand.Parameters.Add(new OracleParameter("empId", result1));
                        if (Convert.ToInt32(checkCommand.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Employee ID already exists.");
                            return;
                        }
                    }

                    // Proceed to insert the new employee
                    using (OracleCommand oracleCommand = new OracleCommand(
                        "INSERT INTO Employee (emp_id, emp_password, first_name, last_name, gender, email, phone, hire_date, dept_id, position_id, salary, age) " +
                        "VALUES (:empId, :empPassword, :firstName, :lastName, :gender, :email, :phone, :hireDate, :deptId, :posId, :salary, :age)",
                        oracleConnection))
                    {
                        // Add parameters for the query
                        oracleCommand.Parameters.Add(new OracleParameter("empId", result1));
                        oracleCommand.Parameters.Add(new OracleParameter("empPassword", empPassword));
                        oracleCommand.Parameters.Add(new OracleParameter("firstName", firstName));
                        oracleCommand.Parameters.Add(new OracleParameter("lastName", lastName));
                        oracleCommand.Parameters.Add(new OracleParameter("gender", str1));
                        oracleCommand.Parameters.Add(new OracleParameter("email", recipientEmail));
                        oracleCommand.Parameters.Add(new OracleParameter("phone", str2)); // Store phone with dashes
                        oracleCommand.Parameters.Add(new OracleParameter("hireDate", result6));
                        oracleCommand.Parameters.Add(new OracleParameter("deptId", deptId));
                        oracleCommand.Parameters.Add(new OracleParameter("posId", posId));
                        oracleCommand.Parameters.Add(new OracleParameter("salary", result5));
                        oracleCommand.Parameters.Add(new OracleParameter("age", result4));

                        // Execute the command
                        if (oracleCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Employee added successfully.");
                            this.SendWelcomeEmail(recipientEmail, firstName, lastName, result1, empPassword);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void SendWelcomeEmail(
          string recipientEmail,
          string firstName,
          string lastName,
          int empId,
          string empPassword)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = (ICredentialsByHost)new NetworkCredential("emscorporation.ltdpk@gmail.com", "zmjywbjivlzkceqe"),
                    EnableSsl = true
                };
                MailMessage message1 = new MailMessage()
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"),
                    Subject = "Welcome to the Company!",
                    Body = "Dear " + firstName + " " + lastName + ",\n\nWelcome to EMS Corporation! We are thrilled to have you join our team and are confident that your skills and talents will be a valuable addition to our company.\n\nHere are your login details:\n" + string.Format("- **Employee ID**: {0}\n", (object)empId) + "- **Password**: " + empPassword + "\n\nPlease use these credentials to access our internal systems and resources. If you encounter any issues or have questions, feel free to reach out to the IT department.\n\nWe look forward to working with you and helping you succeed in your role. Welcome aboard!\n\nBest regards,\nEMS Corporation\n",
                    IsBodyHtml = false
                };
                MailMessage message2 = new MailMessage()
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"),
                    Subject = "Message delievered For Hiring a New Employee",
                    Body = string.Format("Message has been successfully delivered to {0} {1} and their email is: {2}and their Employee Id is {3}", (object)firstName, (object)lastName, (object)recipientEmail, (object)empId),
                    IsBodyHtml = false
                };
                message1.To.Add(recipientEmail);
                smtpClient.Send(message1);
                int num1 = (int)MessageBox.Show("The email has been sent successfully.");
                message2.To.Add("basitzahid0@gmail.com");
                message2.To.Add("emscorporation.ltdpk@gmail.com");
                smtpClient.Send(message2);
                int num2 = (int)MessageBox.Show("Confirmation Email has been sent ");
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }

        private void SendRemoveEmail(string recipientEmail, string firstName, string lastName)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = (ICredentialsByHost)new NetworkCredential("emscorporation.ltdpk@gmail.com", "zmjywbjivlzkceqe"),
                    EnableSsl = true
                };
                MailMessage message1 = new MailMessage()
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"),
                    Subject = "Suspension Notice",
                    Body = "Dear " + firstName + " " + lastName + ",\n\nWe regret to inform you that your employment with EMS Corporation has been terminated, effective immediately.\n\nIf you have any questions or need further information, please do not hesitate to contact us.\n\nSincerely,\nEMS Corporation",
                    IsBodyHtml = false
                };
                MailMessage message2 = new MailMessage()
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"),
                    Subject = "Message delievered For Removal",
                    Body = firstName + " " + lastName + " got fired from the company and their email is: " + recipientEmail,
                    IsBodyHtml = false
                };
                message1.To.Add(recipientEmail);
                smtpClient.Send(message1);
                int num1 = (int)MessageBox.Show("The email has been sent successfully.");
                message2.To.Add("basitzahid0@gmail.com");
                message2.To.Add("emscorporation.ltdpk@gmail.com");
                smtpClient.Send(message2);
                int num2 = (int)MessageBox.Show("Confrimation email has been sent");
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }

        private void List_By_Department_Click(object sender, EventArgs e)
        {
            if (this.List_Type_combo_box.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("Please select a department.");
            }
            else
            {
                string str = this.List_Type_combo_box.SelectedItem.ToString();
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    OracleCommand oracleCommand = new OracleCommand("SELECT * FROM Employee WHERE dept_id = (SELECT dept_id FROM Department WHERE dept_name = :deptName)", oracleConnection);
                    oracleCommand.Parameters.Add(new OracleParameter("deptName", (object)str));
                    oracleConnection.Open();
                    using (OracleDataReader reader = oracleCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load((IDataReader)reader);
                        this.dataGridView1.DataSource = (object)dataTable;
                    }
                }
            }
        }

        private void Search_By_ID_Click(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(this.Search_Employee_Text_Area.Text.Trim(), out result))
            {
                int num1 = (int)MessageBox.Show("Please enter a valid Employee ID (numbers only).");
            }
            else
            {
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    using (OracleCommand oracleCommand = new OracleCommand("\r\n        SELECT \r\n            e.emp_id,\r\n            e.emp_password,\r\n            e.first_name,\r\n            e.last_name,\r\n            e.age,\r\n            e.gender,\r\n            e.email,\r\n            e.phone,\r\n            e.hire_date,\r\n            e.dept_id,\r\n            e.position_id,\r\n            e.salary AS original_salary,\r\n            CASE \r\n                WHEN NVL(a.absence_count, 0) > 2 THEN e.salary * 0.95  \r\n                ELSE e.salary  \r\n            END AS adjusted_salary,\r\n            NVL(a.absence_count, 0) AS absence_count\r\n        FROM \r\n            Employee e\r\n        LEFT JOIN (\r\n            SELECT \r\n                emp_id,\r\n                COUNT(*) AS absence_count\r\n            FROM \r\n                Attendance\r\n            WHERE \r\n                is_holiday = 'Y'\r\n            GROUP BY \r\n                emp_id\r\n        ) a ON e.emp_id = a.emp_id\r\n        WHERE\r\n            e.emp_id = :empId\r\n        ORDER BY \r\n            e.emp_id ASC", oracleConnection))
                    {
                        oracleCommand.Parameters.Add(new OracleParameter("empId", (object)result));
                        try
                        {
                            oracleConnection.Open();
                            using (OracleDataReader reader = oracleCommand.ExecuteReader())
                            {
                                DataTable dataTable = new DataTable();
                                dataTable.Load((IDataReader)reader);
                                this.dataGridView1.DataSource = (object)dataTable;
                                if (dataTable.Rows.Count != 0)
                                    return;
                                int num2 = (int)MessageBox.Show("No employees found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            int num3 = (int)MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void List_All_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    OracleCommand oracleCommand = new OracleCommand("\r\n            SELECT \r\n                e.emp_id,\r\n                e.emp_password,\r\n                e.first_name,\r\n                e.last_name,\r\n                e.age,\r\n                e.gender,\r\n                e.email,\r\n                e.phone,\r\n                e.hire_date,\r\n                e.dept_id,\r\n                e.position_id,\r\n                e.salary AS original_salary,\r\n                CASE \r\n                WHEN NVL(a.absence_count, 0) > 2 THEN e.salary * 0.95  \r\n                ELSE e.salary  \r\n                END AS adjusted_salary,\r\n                NVL(a.absence_count, 0) AS absence_count\r\n                FROM \r\n                    Employee e\r\n                LEFT JOIN (\r\n                    SELECT \r\n                    emp_id,\r\n                COUNT(*) AS absence_count\r\n                FROM \r\n                    Attendance\r\n                WHERE \r\n                    is_holiday = 'Y'\r\n                GROUP BY \r\n                        emp_id\r\n                ) a ON e.emp_id = a.emp_id\r\n                ORDER BY \r\n                e.emp_id ASC", oracleConnection);
                    oracleConnection.Open();
                    using (OracleDataReader reader = oracleCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load((IDataReader)reader);
                        this.dataGridView1.DataSource = (object)dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                int num = (int)MessageBox.Show("Oracle Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("General Error: " + ex.Message);
            }
        }

        private void Remove_By_id_Click(object sender, EventArgs e)
        {
            string text = this.Remove_Employee_Text_Area.Text;
            if (string.IsNullOrEmpty(text))
            {
                int num1 = (int)MessageBox.Show("Please enter an Employee ID.");
            }
            else
            {
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    try
                    {
                        oracleConnection.Open();
                        using (OracleTransaction oracleTransaction = oracleConnection.BeginTransaction())
                        {
                            using (OracleDataReader oracleDataReader = new OracleCommand("SELECT first_name, last_name, email FROM Employee WHERE emp_id = :empId", oracleConnection)
                            {
                                Parameters = {
                  new OracleParameter("empId", (object) Convert.ToInt32(text))
                },
                                Transaction = oracleTransaction
                            }.ExecuteReader())
                            {
                                if (!oracleDataReader.Read())
                                {
                                    int num2 = (int)MessageBox.Show("Employee not found.");
                                    oracleTransaction.Rollback();
                                }
                                else
                                {
                                    string firstName = oracleDataReader.GetString(0);
                                    string lastName = oracleDataReader.GetString(1);
                                    string recipientEmail = oracleDataReader.GetString(2);
                                    new OracleCommand("DELETE FROM Attendance WHERE emp_id = :empId", oracleConnection)
                                    {
                                        Parameters = {
                      new OracleParameter("empId", (object) Convert.ToInt32(text))
                    },
                                        Transaction = oracleTransaction
                                    }.ExecuteNonQuery();
                                    new OracleCommand("DELETE FROM Payroll WHERE emp_id = :empId", oracleConnection)
                                    {
                                        Parameters = {
                      new OracleParameter("empId", (object) Convert.ToInt32(text))
                    },
                                        Transaction = oracleTransaction
                                    }.ExecuteNonQuery();
                                    int num3 = new OracleCommand("DELETE FROM Employee WHERE emp_id = :empId", oracleConnection)
                                    {
                                        Parameters = {
                      new OracleParameter("empId", (object) Convert.ToInt32(text))
                    },
                                        Transaction = oracleTransaction
                                    }.ExecuteNonQuery();
                                    oracleTransaction.Commit();
                                    if (num3 > 0)
                                    {
                                        this.SendRemoveEmail(recipientEmail, firstName, lastName);
                                        int num4 = (int)MessageBox.Show("Employee removed successfully.");
                                    }
                                    else
                                    {
                                        int num5 = (int)MessageBox.Show("Employee not found.");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        int num6 = (int)MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void Sortpostion_Click(object sender, EventArgs e)
        {
            if (this.list_BY_Position.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("Please select a position.");
            }
            else
            {
                int key = ((KeyValuePair<int, string>)this.list_BY_Position.SelectedItem).Key;
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    OracleCommand oracleCommand = new OracleCommand("SELECT * FROM Employee WHERE position_id = :positionId", oracleConnection);
                    oracleCommand.Parameters.Add(new OracleParameter("positionId", (object)key));
                    oracleConnection.Open();
                    using (OracleDataReader reader = oracleCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load((IDataReader)reader);
                        this.dataGridView1.DataSource = (object)dataTable;
                    }
                }
            }
        }

        private void Search_By_Name_Click(object sender, EventArgs e)
        {
            string s = this.Search_Employee_Text_Area.Text.Trim();
            if (string.IsNullOrEmpty(s) || int.TryParse(s, out int _))
            {
                int num1 = (int)MessageBox.Show("Please enter a valid name (letters only).");
            }
            else
            {
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    using (OracleCommand oracleCommand = new OracleCommand("\r\n        SELECT \r\n            e.emp_id,\r\n            e.emp_password,\r\n            e.first_name,\r\n            e.last_name,\r\n            e.age,\r\n            e.gender,\r\n            e.email,\r\n            e.phone,\r\n            e.hire_date,\r\n            e.dept_id,\r\n            e.position_id,\r\n            e.salary AS original_salary,\r\n            CASE \r\n                WHEN NVL(a.absence_count, 0) > 2 THEN e.salary * 0.95  \r\n                ELSE e.salary  \r\n            END AS adjusted_salary,\r\n            NVL(a.absence_count, 0) AS absence_count\r\n        FROM \r\n            Employee e\r\n        LEFT JOIN (\r\n            SELECT \r\n                emp_id,\r\n                COUNT(*) AS absence_count\r\n            FROM \r\n                Attendance\r\n            WHERE \r\n                is_holiday = 'Y'\r\n            GROUP BY \r\n                emp_id\r\n        ) a ON e.emp_id = a.emp_id\r\n        WHERE \r\n            UPPER(e.first_name) = UPPER(:empName)\r\n        ORDER BY \r\n            e.emp_id ASC", oracleConnection))
                    {
                        oracleCommand.Parameters.Add(new OracleParameter("empName", (object)s));
                        try
                        {
                            oracleConnection.Open();
                            using (OracleDataReader reader = oracleCommand.ExecuteReader())
                            {
                                DataTable dataTable = new DataTable();
                                dataTable.Load((IDataReader)reader);
                                this.dataGridView1.DataSource = (object)dataTable;
                                if (dataTable.Rows.Count != 0)
                                    return;
                                int num2 = (int)MessageBox.Show("No employees found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            int num3 = (int)MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void Search_Employee_Text_Area_TextChanged(object sender, EventArgs e)
        {
        }

        private void List_Type_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Remove_Employee_Text_Area_TextChanged(object sender, EventArgs e)
        {
        }

        private void Search_Employee_label_Click(object sender, EventArgs e)
        {
        }

        private void Remove_Employee_Click(object sender, EventArgs e)
        {
        }

        private void Employee_id_Click(object sender, EventArgs e)
        {
        }

        private void firstname_Click(object sender, EventArgs e)
        {
        }

        private void lastname_Click(object sender, EventArgs e)
        {
        }

        private void email_Click(object sender, EventArgs e)
        {
        }

        private void phoneno_Click(object sender, EventArgs e)
        {
        }

        private void hiredate_Click(object sender, EventArgs e)
        {
        }

        private void departmentid_Click(object sender, EventArgs e)
        {
        }

        private void positionid_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the currently selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Assign values from the row to the textboxes and other controls
                this.Add_Employee_ID.Text = selectedRow.Cells["emp_id"].Value?.ToString().Trim();
                this.employee_password.Text = selectedRow.Cells["emp_password"].Value?.ToString().Trim();
                this.Add_Employee_FirstName.Text = selectedRow.Cells["first_name"].Value?.ToString().Trim();
                this.Add_Employee_LastName.Text = selectedRow.Cells["last_name"].Value?.ToString().Trim();
                this.gendertextarea.Text = selectedRow.Cells["gender"].Value?.ToString().Trim();
                this.Add_Employee_Email.Text = selectedRow.Cells["email"].Value?.ToString().Trim();
                this.Add_Employee_PhoneNO.Text = selectedRow.Cells["phone"].Value?.ToString().Trim();

                // Handle DateTimePicker
                if (DateTime.TryParse(selectedRow.Cells["hire_date"].Value?.ToString(), out DateTime hireDate))
                {
                    this.HireDate.Value = hireDate;
                }
                else
                {
                    this.HireDate.Value = DateTime.Now; // Default value if parsing fails
                }

                // Get the department ID and set the Department_combo_box selection
                int deptId = Convert.ToInt32(selectedRow.Cells["dept_id"].Value?.ToString().Trim());
                foreach (var department in departmentMapping)
                {
                    if (department.Value == deptId)
                    {
                        this.Department_combo_box.SelectedItem = department.Key;
                        break;
                    }
                }

                // Get the position ID and set the Position_combo_box selection
                int posId = Convert.ToInt32(selectedRow.Cells["position_id"].Value?.ToString().Trim());
                foreach (var position in positionMapping)
                {
                    if (position.Value == posId)
                    {
                        this.Position_combo_box.SelectedItem = position.Key;
                        break;
                    }
                }

                this.agetextarea.Text = selectedRow.Cells["age"].Value?.ToString().Trim();

                try
                {
                    this.addsalary.Text = selectedRow.Cells["original_salary"].Value?.ToString().Trim();
                }
                catch (Exception)
                {
                    this.addsalary.Text = selectedRow.Cells["salary"].Value?.ToString().Trim();
                }
            }
        }

        private void Add_Employee_ID_TextChanged(object sender, EventArgs e)
        {
        }

        private void Add_Employee_FirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Add_Employee_LastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Add_Employee_Email_TextChanged(object sender, EventArgs e)
        {
        }

        private void Add_Employee_PhoneNO_TextChanged(object sender, EventArgs e)
        {
        }

        private void adddHiredate_TextChanged(object sender, EventArgs e)
        {
        }

        private void deptaddid_TextChanged(object sender, EventArgs e)
        {
        }

        private void postaddid_TextChanged(object sender, EventArgs e)
        {
        }

        private void addsalary_TextChanged(object sender, EventArgs e)
        {
        }

        private void query_TextChanged(object sender, EventArgs e)
        {
        }

        private void run_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    string text = this.query.Text;
                    text.ToUpper();
                    OracleCommand oracleCommand = new OracleCommand(text, oracleConnection);
                    oracleConnection.Open();
                    using (OracleDataReader reader = oracleCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load((IDataReader)reader);
                        this.dataGridView1.DataSource = (object)dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                int num = (int)MessageBox.Show("Oracle Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("General Error: " + ex.Message);
            }
        }

        private void Grant_Admin_Access_Button_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(this.Grant_Admin_Acess_txtArea.Text, out result))
            {
                if (!AdminAccessManager.AdminIds.Contains(result))
                {
                    AdminAccessManager.AdminIds.Add(result);
                    AdminAccessManager.SaveAdminIds();
                    int num = (int)MessageBox.Show(string.Format("Admin access granted to Employee ID {0}.", (object)result));
                }
                else
                {
                    int num1 = (int)MessageBox.Show(string.Format("Employee ID {0} already has admin access.", (object)result));
                }
            }
            else
            {
                int num2 = (int)MessageBox.Show("Please enter a valid Employee ID.");
            }
        }

        private void Remove_Admin_Access_Button_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(this.Remove_Admin_Access_txtArea.Text, out result))
            {
                if (AdminAccessManager.AdminIds.Contains(result))
                {
                    AdminAccessManager.AdminIds.Remove(result);
                    AdminAccessManager.SaveAdminIds();
                    int num = (int)MessageBox.Show(string.Format("Admin access removed for Employee ID {0}.", (object)result));
                }
                else
                {
                    int num1 = (int)MessageBox.Show(string.Format("Employee ID {0} does not have admin access.", (object)result));
                }
            }
            else
            {
                int num2 = (int)MessageBox.Show("Please enter a valid Employee ID.");
            }
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            if (AdminAccessManager.AdminIds.Count == 0)
            {
                int num1 = (int)MessageBox.Show("No admin IDs found.");
            }
            else
            {
                string cmdText = "SELECT * FROM Employee WHERE emp_id = :empId";
                DataTable dataTable = new DataTable();
                using (OracleConnection conn = new OracleConnection(this.connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (OracleCommand oracleCommand = new OracleCommand(cmdText, conn))
                        {
                            OracleParameter oracleParameter = new OracleParameter(":empId", OracleDbType.Int32);
                            oracleCommand.Parameters.Add(oracleParameter);
                            foreach (int adminId in AdminAccessManager.AdminIds)
                            {
                                oracleParameter.Value = (object)adminId;
                                using (OracleDataReader reader = oracleCommand.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        dataTable.Load((IDataReader)reader);
                                    }
                                    else
                                    {
                                        int num2 = (int)MessageBox.Show(string.Format("No employee found with ID {0}.", (object)adminId));
                                    }
                                }
                            }
                        }
                        this.dataGridView1.DataSource = (object)dataTable;
                    }
                    catch (Exception ex)
                    {
                        int num3 = (int)MessageBox.Show("Error retrieving admin data: " + ex.Message);
                    }
                }
            }
        }

        private void ShortAttendanceNotice_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = "\r\n            SELECT \r\n                e.emp_id,\r\n                e.first_name,\r\n                e.last_name,\r\n                e.email,\r\n                NVL(a.absence_count, 0) AS absence_count\r\n            FROM \r\n                Employee e\r\n            LEFT JOIN (\r\n                SELECT \r\n                    emp_id,\r\n                    COUNT(*) AS absence_count\r\n                FROM \r\n                    Attendance\r\n                WHERE \r\n                    is_holiday = 'Y'\r\n                GROUP BY \r\n                    emp_id\r\n            ) a ON e.emp_id = a.emp_id\r\n            WHERE \r\n                NVL(a.absence_count, 0) > 3\r\n            ORDER BY \r\n                e.emp_id ASC";
                using (OracleConnection conn = new OracleConnection(this.connectionString))
                {
                    conn.Open();
                    using (OracleCommand oracleCommand = new OracleCommand(cmdText, conn))
                    {
                        using (OracleDataReader oracleDataReader = oracleCommand.ExecuteReader())
                        {
                            while (oracleDataReader.Read())
                            {
                                string firstName = oracleDataReader["first_name"].ToString();
                                string lastName = oracleDataReader["last_name"].ToString();
                                string recipientEmail = oracleDataReader["email"].ToString();
                                int int32 = Convert.ToInt32(oracleDataReader["absence_count"]);
                                this.SendAttendanceNotice(recipientEmail, firstName, lastName, int32);
                            }
                        }
                    }
                }
                int num = (int)MessageBox.Show("Notices sent to employees with excessive absences.");
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SendAttendanceNotice(
          string recipientEmail,
          string firstName,
          string lastName,
          int absenceCount)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = (ICredentialsByHost)new NetworkCredential("farrukhzia775@gmail.com", "hrwsiewunsqwzpfd"),
                    EnableSsl = true
                };
                MailMessage message = new MailMessage()
                {
                    From = new MailAddress("farrukhzia775@gmail.com"),
                    Subject = "Attendance Notice",
                    Body = string.Format("Dear {0} {1},\n\nOur records indicate that you have been absent {2} times recently. Please ensure to adhere to the attendance policy.\n\nBest regards,\nEMS", (object)firstName, (object)lastName, (object)absenceCount),
                    IsBodyHtml = false
                };
                message.To.Add(recipientEmail);
                smtpClient.Send(message);
                int num = (int)MessageBox.Show("Notice sent successfully to " + firstName + " " + lastName + " (" + recipientEmail + ").");
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Failed to send notice to " + firstName + " " + lastName + ": " + ex.Message);
            }
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            string s1 = this.Add_Employee_ID.Text.Trim();
            string empPassword = this.employee_password.Text.Trim();
            string firstName = this.Add_Employee_FirstName.Text.Trim();
            string lastName = this.Add_Employee_LastName.Text.Trim();
            string gender = this.gendertextarea.Text.Trim().ToLower(); // Normalize gender input to lowercase
            string recipientEmail = this.Add_Employee_Email.Text.Trim();
            string phone = this.Add_Employee_PhoneNO.Text.Trim();
            DateTime hireDate = this.HireDate.Value; // Using DateTimePicker value
            string selectedDept = Department_combo_box.SelectedItem?.ToString();
            string selectedPos = Position_combo_box.SelectedItem?.ToString();
            string salaryText = this.addsalary.Text.Trim();
            string ageText = this.agetextarea.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(ageText) || string.IsNullOrEmpty(selectedDept) || string.IsNullOrEmpty(selectedPos))
            {
                MessageBox.Show("Please fill all required fields (Employee ID, First Name, Last Name, Age, Department, and Position).");
                return;
            }

            // Validate gender (must be either "male" or "female", case-insensitive)
            if (string.IsNullOrEmpty(gender) || (gender != "male" && gender != "female"))
            {
                MessageBox.Show("Gender must be either 'Male' or 'Female'.");
                return;
            }

            // Validate Employee ID (must be a valid integer and non-negative)
            if (!int.TryParse(s1, out int empId) || empId < 0)
            {
                MessageBox.Show("Employee ID must be a valid non-negative integer.");
                return;
            }

            // Validate Salary (must be a valid decimal number)
            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Salary must be a valid decimal number.");
                return;
            }

            // Validate Age (must be a valid positive integer and more than 17)
            if (!int.TryParse(ageText, out int age) || age <= 0 || age <= 17)
            {
                MessageBox.Show("Age must be a valid positive integer greater than 17.");
                return;
            }

            // Validate Phone Number (allow dashes, but must be digits only and match one of the valid patterns)
            string phoneWithoutDashes = phone.Replace("-", "");
            if (phone.Contains("-"))
            {
                // Validate format like xxx-xxx-xxxx
                string[] phoneParts = phone.Split('-');
                if (phoneParts.Length != 3 || phoneParts[0].Length != 3 || phoneParts[1].Length != 3 || phoneParts[2].Length != 4 ||
                    !phoneParts.All(part => part.All(char.IsDigit)))
                {
                    MessageBox.Show("Phone number with dashes must be in the format xxx-xxx-xxxx.");
                    return;
                }
            }
            else
            {
                // Validate format like xxxxxxxxxx
                if (phoneWithoutDashes.Length > 17 || !phoneWithoutDashes.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must be a valid number with at least 10 digits.");
                    return;
                }
            }

            // Validate Email (must contain '@' symbol)
            if (!recipientEmail.Contains("@"))
            {
                MessageBox.Show("Email must be a valid format (must contain '@').");
                return;
            }

            // Validate department selection
            if (!departmentMapping.TryGetValue(selectedDept, out int deptId))
            {
                MessageBox.Show("Invalid department selected.");
                return;
            }

            // Validate position selection
            if (!positionMapping.TryGetValue(selectedPos, out int posId))
            {
                MessageBox.Show("Invalid position selected.");
                return;
            }

            try
            {
                using (OracleConnection oracleConnection = this.GetOracleConnection())
                {
                    oracleConnection.Open();

                    // Check if the employee exists for update
                    using (OracleCommand checkCommand = new OracleCommand(
                        "SELECT COUNT(*) FROM Employee WHERE emp_id = :empId", oracleConnection))
                    {
                        checkCommand.Parameters.Add(new OracleParameter("empId", empId));
                        if (Convert.ToInt32(checkCommand.ExecuteScalar()) == 0)
                        {
                            MessageBox.Show("No such employee found.");
                            return;
                        }
                    }

                    // Update employee details
                    using (OracleCommand updateCommand = new OracleCommand(
                        "UPDATE Employee SET emp_password = :empPassword, first_name = :firstName, last_name = :lastName, gender = :gender, " +
                        "email = :email, phone = :phone, hire_date = :hireDate, dept_id = :deptId, position_id = :posId, salary = :salary, age = :age " +
                        "WHERE emp_id = :empId", oracleConnection))
                    {
                        updateCommand.Parameters.Add(new OracleParameter("empPassword", empPassword));
                        updateCommand.Parameters.Add(new OracleParameter("firstName", firstName));
                        updateCommand.Parameters.Add(new OracleParameter("lastName", lastName));
                        updateCommand.Parameters.Add(new OracleParameter("gender", gender));
                        updateCommand.Parameters.Add(new OracleParameter("email", recipientEmail));
                        updateCommand.Parameters.Add(new OracleParameter("phone", phone)); // Store phone with dashes
                        updateCommand.Parameters.Add(new OracleParameter("hireDate", hireDate));
                        updateCommand.Parameters.Add(new OracleParameter("deptId", deptId));
                        updateCommand.Parameters.Add(new OracleParameter("posId", posId));
                        updateCommand.Parameters.Add(new OracleParameter("salary", salary));
                        updateCommand.Parameters.Add(new OracleParameter("age", age));
                        updateCommand.Parameters.Add(new OracleParameter("empId", empId));

                        if (updateCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Employee details updated successfully.");
                            this.SendUpdateEmail(recipientEmail, firstName, lastName, empId, empPassword);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update employee details.");
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void SendUpdateEmail(
          string recipientEmail,
          string firstName,
          string lastName,
          int empId,
          string empPassword)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = (ICredentialsByHost)new NetworkCredential("emscorporation.ltdpk@gmail.com", "zmjywbjivlzkceqe"),
                    EnableSsl = true
                };
                MailMessage message1 = new MailMessage()
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"),
                    Subject = "Update Confirmation",
                    Body = "Dear " + firstName + " " + lastName + ",\n\nYour employee details have been successfully updated. Please find your updated credentials below:\n\n" + string.Format("Employee ID: {0}\n", (object)empId) + "Password: " + empPassword + "\n\nKindly log in to your portal to review your updated information.\n\nSincerely,\n Regards EMS",
                    IsBodyHtml = false
                };
                MailMessage message2 = new MailMessage()
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"),
                    Subject = "Employee Update Notification",
                    Body = "Employee details for " + firstName + " " + lastName + " (Email: " + recipientEmail + ") have been updated.\n\nPlease verify the changes in the system.",
                    IsBodyHtml = false
                };
                message1.To.Add(recipientEmail);
                smtpClient.Send(message1);
                int num1 = (int)MessageBox.Show("Update confirmation email sent to the employee successfully.");
                message2.To.Add("basitzahid0@gmail.com");
                message2.To.Add("emscorporation.ltdpk@gmail.com");
                smtpClient.Send(message2);
                int num2 = (int)MessageBox.Show("Confirmation email sent to HR/admin team successfully.");
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            using (Adminchoice adminchoice = new Adminchoice())
            {
                this.Hide();
                int num = (int)adminchoice.ShowDialog();
            }
        }
    }
}
