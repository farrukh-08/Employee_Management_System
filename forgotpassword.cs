using Oracle.ManagedDataAccess.Client;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VP_Project
{
    public partial class forgotpassword : Form
    {
        private string connectionString = "User Id=sys;Password=MyNewSecurePassword123;Data Source=//7ARRUKH:1521/orcl;DBA Privilege=SYSDBA";

        private OracleConnection GetOracleConnection() => new OracleConnection(this.connectionString);


        public forgotpassword()
        {
            InitializeComponent();
        }


        // This method sends the password update email to the employee
        private void SendPasswordUpdateEmail(string recipientEmail, string firstName, string lastName, string newPassword)
        {
            try
            {
                // Set up the SMTP client with Gmail settings
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // Port 587 for TLS
                    Credentials = new NetworkCredential("emscorporation.ltdpk@gmail.com", "zmjywbjivlzkceqe"), // Use your App Password
                    EnableSsl = true // Enable SSL/TLS for secure communication
                };

                // Create the email message for password update
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"), // Sender's email address
                    Subject = "Your Password Has Been Updated",
                    Body = $"Dear {firstName} {lastName},\n\n" +
                           "Your password has been successfully updated. Please find your new password below:\n\n" +
                           $"- **New Password**: {newPassword}\n\n" +
                           "Please use this new password to access your account. If you encounter any issues or have questions, feel free to reach out to the IT department.\n\n" +
                           "Best regards,\n" +
                           "EMS Corporation\n",
                    IsBodyHtml = false // Set to true if you want to use HTML in the email body
                };

                // Add the recipient's email address
                mailMessage.To.Add(recipientEmail);

                // Send the email
                smtpClient.Send(mailMessage);

                // Success message
                MessageBox.Show("Password update email has been sent successfully.");

                // Send a confirmation email to the admin
                var successfulMessage = new MailMessage
                {
                    From = new MailAddress("emscorporation.ltdpk@gmail.com"), // Sender's email address
                    Subject = "Password Update Notification",
                    Body = $"The password has been successfully updated for employee: {firstName} {lastName}.",
                    IsBodyHtml = false // Set to true if you want to use HTML in the email body
                };

                successfulMessage.To.Add("basitzahid0@gmail.com");
                successfulMessage.To.Add("emscorporation.ltdpk@gmail.com");

                // Send the confirmation email
                smtpClient.Send(successfulMessage);

                // Notify that the confirmation email has been sent
                MessageBox.Show("Confirmation Email has been sent to the Admin.");
            }
            catch (Exception ex)
            {
                // Display any errors
                MessageBox.Show($"Failed to send email: {ex.Message}");
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            using (var obj = new employeelogin())
            {
                this.Hide();
                obj.ShowDialog();
            }
        }

        private void UPpass_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input values from the textboxes
                string empId = SearchpayID.Text.Trim();
                string email = this.email.Text.Trim();
                string newPassword = this.password.Text.Trim();

                // Validate inputs
                if (string.IsNullOrWhiteSpace(empId) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Please fill in all required fields: Employee ID, Email, and New Password.");
                    return;
                }

                // Validate Employee ID
                if (!int.TryParse(empId, out int empIdParsed))
                {
                    MessageBox.Show("Employee ID must be a valid integer.");
                    return;
                }

                // Validate Email Format
                var emailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!emailRegex.IsMatch(email))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                using (OracleConnection con = this.GetOracleConnection())
                {
                    con.Open();

                    // Check if the employee exists and the email matches
                    using (OracleCommand checkCmd = new OracleCommand("SELECT first_name, last_name FROM Employee WHERE emp_id = :empId AND email = :email", con))
                    {
                        checkCmd.Parameters.Add(":empId", OracleDbType.Int32).Value = empIdParsed;
                        checkCmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;

                        using (OracleDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["first_name"].ToString();
                                string lastName = reader["last_name"].ToString();

                                // Update the password
                                using (OracleCommand updateCmd = new OracleCommand("UPDATE Employee SET emp_password = :newPassword WHERE emp_id = :empId AND email = :email", con))
                                {
                                    updateCmd.Parameters.Add(":newPassword", OracleDbType.Varchar2).Value = newPassword;
                                    updateCmd.Parameters.Add(":empId", OracleDbType.Int32).Value = empIdParsed;
                                    updateCmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;

                                    int rowsAffected = updateCmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        // Send password update email
                                        MessageBox.Show("Password updated successfully!");
                                        SendPasswordUpdateEmail(email, firstName, lastName, newPassword);
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update the password. Please try again.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No record found for the provided Employee ID and Email.");
                            }
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
    }
}
