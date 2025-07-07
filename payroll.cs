using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class payroll : Form
    {
        private string connectionString = "User Id=sys;Password=MyNewSecurePassword123;Data Source=//7ARRUKH:1521/orcl;DBA Privilege=SYSDBA";
        public payroll()
        {
            InitializeComponent();
        }

        private void SearchId_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                SELECT 
                    p.payroll_id, 
                    e.emp_id, 
                    e.first_name || ' ' || e.last_name AS emp_name, 
                    p.salary_paid, 
                    p.payment_date
                FROM 
                    Payroll p
                JOIN 
                    Employee e ON p.emp_id = e.emp_id
                WHERE 
                    p.emp_id = :emp_id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":emp_id", OracleDbType.Int32).Value = int.Parse(SearchpayID.Text);

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                dataGird.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No payroll records found for the given Employee ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ListAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                SELECT 
                    p.payroll_id, 
                    e.emp_id, 
                    e.first_name || ' ' || e.last_name AS emp_name, 
                    p.salary_paid, 
                    p.payment_date
                FROM 
                    Payroll p
                JOIN 
                    Employee e ON p.emp_id = e.emp_id
                ORDER BY 
                    e.emp_id, p.payment_date";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                           dataGird.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void UPDATEPAY_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(EmpIDbox.Text) || string.IsNullOrWhiteSpace(Salarybox.Text))
                {
                    MessageBox.Show("Employee ID and Salary Paid fields cannot be empty.");
                    return;
                }

                int empId;
                decimal salaryPaid;

                // Validate numeric inputs
                if (!int.TryParse(EmpIDbox.Text, out empId))
                {
                    MessageBox.Show("Employee ID must be a valid integer.");
                    return;
                }

                if (!decimal.TryParse(Salarybox.Text, out salaryPaid))
                {
                    MessageBox.Show("Salary Paid must be a valid decimal number.");
                    return;
                }

                // Get the payment date from the DateTimePicker
                DateTime paymentDate = Payroll_Date.Value;

                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    // Update Payroll table
                    string payrollQuery = @"
            UPDATE Payroll 
            SET salary_paid = :salary_paid, payment_date = TO_DATE(:payment_date, 'YYYY-MM-DD')
            WHERE emp_id = :emp_id";

                    using (OracleCommand payrollCmd = new OracleCommand(payrollQuery, con))
                    {
                        payrollCmd.Parameters.Add(":salary_paid", OracleDbType.Decimal).Value = salaryPaid;
                        payrollCmd.Parameters.Add(":payment_date", OracleDbType.Varchar2).Value = paymentDate.ToString("yyyy-MM-dd");
                        payrollCmd.Parameters.Add(":emp_id", OracleDbType.Int32).Value = empId;

                        int rowsAffected = payrollCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Update original_salary in Employee table
                            string updateEmployeeQuery = @"
                    UPDATE Employee 
                    SET salary = :salary_paid 
                    WHERE emp_id = :emp_id";

                            using (OracleCommand empCmd = new OracleCommand(updateEmployeeQuery, con))
                            {
                                empCmd.Parameters.Add(":salary_paid", OracleDbType.Decimal).Value = salaryPaid;
                                empCmd.Parameters.Add(":emp_id", OracleDbType.Int32).Value = empId;

                                empCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Payroll record and original salary updated successfully.");

                            // Fetch employee details for email
                            string empQuery = @"
                    SELECT first_name, last_name, email 
                    FROM Employee 
                    WHERE emp_id = :emp_id";

                            using (OracleCommand empDetailsCmd = new OracleCommand(empQuery, con))
                            {
                                empDetailsCmd.Parameters.Add(":emp_id", OracleDbType.Int32).Value = empId;

                                using (OracleDataReader reader = empDetailsCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string firstName = reader.GetString(0);
                                        string lastName = reader.GetString(1);
                                        string email = reader.GetString(2);

                                        // Send email notification
                                        SendPayrollEmail(email, firstName, lastName, salaryPaid, paymentDate.ToString("yyyy-MM-dd"));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Employee not found. No email sent.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No payroll record found to update for the given Employee ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }





        private void SendPayrollEmail(string recipientEmail, string firstName, string lastName, decimal salaryPaid, String paymentDate)
        {
            try
            {
                // Set up the SMTP client with Gmail settings
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // Port 587 for TLS
                    Credentials = new NetworkCredential("emscorporation.ltdpk@gmail.com", "zmjywbjivlzkceqe"), // App Password
                    EnableSsl = true // Enable SSL/TLS for secure communication
                };

                // Create the email message
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"), // Sender's email address
                    Subject = "Payroll Update Notification",
                    Body = $"Dear {firstName} {lastName},\n\n" +
                           $"We are pleased to inform you that your salary payment of ${salaryPaid:F2} has been processed successfully on {paymentDate:MMMM dd, yyyy}.\n\n" +
                           "If you have any questions regarding your payroll or payment, please contact the HR department.\n\n" +
                           "Thank you for your dedication and hard work.\n\n" +
                           "Best regards,\n" +
                           "EMS Corporation",
                    IsBodyHtml = false // Set to true if you want to use HTML in the email body
                };

                // Add the recipient's email address
                mailMessage.To.Add(recipientEmail);

                // Send the email
                smtpClient.Send(mailMessage);

                // Success message
                MessageBox.Show("Payroll email notification sent successfully.");
            }
            catch (Exception ex)
            {
                // Display any errors
                MessageBox.Show($"Failed to send payroll email: {ex.Message}");
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            using(var obj = new Adminchoice())
            {
                this.Hide();
                obj.ShowDialog();
            }
        }

        private void dataGird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the currently selected row
                DataGridViewRow selectedRow = dataGird.Rows[e.RowIndex];

                try
                {

                    // Get the payment date from the DateTimePicker
                    DateTime paymentDate = Payroll_Date.Value;

                    // Set the values for other controls from the selected row
                    this.EmpIDbox.Text = selectedRow.Cells["emp_id"].Value?.ToString().Trim();
                    this.Salarybox.Text = selectedRow.Cells["salary_paid"].Value?.ToString().Trim();
                    this.payrollIDbox.Text = selectedRow.Cells["payroll_id"].Value?.ToString();
                    this.Payroll_Date.Value = Convert.ToDateTime(selectedRow.Cells["payment_date"].Value?.ToString());


                }
                catch (Exception ex)
                {
                    // Handle any unexpected errors
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        }
    }
}
