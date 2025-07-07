using System;
using System.Drawing;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            // Load the image into the PictureBox
            try
            {
                loginImage.Image = Image.FromFile(@"C:\Users\HP\Downloads\ems.jpg");
                loginImage.SizeMode = PictureBoxSizeMode.StretchImage; // Ensure the image fits the PictureBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            using (var adminlogin = new Adminlogin())
            {
                this.Hide();
                adminlogin.ShowDialog();
            }
        }

        private void employeebutton_Click(object sender, EventArgs e)
        {
            using (var emplogin = new employeelogin())
            {
                this.Hide();
                emplogin.ShowDialog();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
