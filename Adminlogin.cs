using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class Adminlogin : Form
    {
        // List of admin names
        private List<string> admins = new List<string> { "Farrukh", "Basit" };
        // Default password
        private string password = "password";

        public Adminlogin()
        {
            InitializeComponent();
        }

        private void adminloginbutton_Click(object sender, EventArgs e)
        {
            // Retrieve input from textboxes
            string enteredUsername = usernameTextBox.Text.Trim(); // Replace 'usernameTextBox' with your actual TextBox name
            string enteredPassword = passwordTextBox.Text.Trim(); // Replace 'passwordTextBox' with your actual TextBox name

            // Check if the username is in the list and the password matches
            if (admins.Contains(enteredUsername) && enteredPassword == password)
            {
                using (var admin = new Adminchoice())
                {
                    this.Hide();
                    admin.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BKK_Click(object sender, EventArgs e)
        {
            using (var admin = new login())
            {
                this.Hide();
                admin.ShowDialog();
            }
        }
    }
}
