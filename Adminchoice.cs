using System;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class Adminchoice : Form
    {
        public Adminchoice()
        {
            InitializeComponent();
        }

        
        private void emppage_Click(object sender, EventArgs e)
        {
            using(var ob = new Form1())
            { this.Hide();
                ob.ShowDialog();
            }

        }

        private void attendpage_Click(object sender, EventArgs e)
        {
            using (var obj = new Attendance())
            {
                this.Hide();
                obj.ShowDialog();
            }

        }

        private void paypage_Click(object sender, EventArgs e)
        {
            using (var obj = new payroll())
            {
                this.Hide();
                obj.ShowDialog();
            }

        }

        private void prv_Click(object sender, EventArgs e)
        {
            using (var obj = new Adminlogin())
            {    this.Hide();
                obj.ShowDialog();
            }
        }
    }
}
