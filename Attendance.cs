using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VP_Project
{
    public partial class Attendance : Form

    {
        private string connectionString = "User Id=sys;Password=MyNewSecurePassword123;Data Source=//7ARRUKH:1521/orcl;DBA Privilege=SYSDBA";
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }

        private void Attendence_Add_Button_Click(object sender, EventArgs e)
        {
            // Fetch input values from the textboxes and other controls
            string empIdText = eempid.Text.Trim();
            string attendanceIdText = atendid.Text.Trim();
            DateTime attendanceDate = Attendence_Date.Value; // Use DateTimePicker's Value
            char isHoliday = yes.Checked ? 'Y' : 'N'; // 'Y' if Yes radio button is checked, else 'N'

            // Validate inputs
            if (string.IsNullOrEmpty(empIdText) || string.IsNullOrEmpty(attendanceIdText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Validate integer fields (Employee ID, Attendance ID)
            if (!int.TryParse(empIdText, out int empId))
            {
                MessageBox.Show("Employee ID must be a valid integer.");
                return;
            }

            if (!int.TryParse(attendanceIdText, out int attendanceId))
            {
                MessageBox.Show("Attendance ID must be a valid integer.");
                return;
            }

            // SQL query to check if the attendance ID already exists
            string checkAttendanceIdQuery = @"
SELECT COUNT(*)
FROM Attendance
WHERE attendance_id = :attendanceId";

            // SQL query to check if the attendance record for the same date exists
            string checkAttendanceDateQuery = @"
SELECT COUNT(*)
FROM Attendance
WHERE emp_id = :empId AND holiday_date = :holidayDate";

            // SQL query to insert the attendance record
            string insertQuery = @"
INSERT INTO Attendance (attendance_id, emp_id, holiday_date, is_holiday)
VALUES (:attendanceId, :empId, :holidayDate, :isHoliday)";

            // Establish database connection
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the attendance ID already exists
                    using (OracleCommand checkIdCommand = new OracleCommand(checkAttendanceIdQuery, connection))
                    {
                        checkIdCommand.Parameters.Add(new OracleParameter("attendanceId", attendanceId));

                        int idCount = Convert.ToInt32(checkIdCommand.ExecuteScalar());
                        if (idCount > 0)
                        {
                            MessageBox.Show("Attendance ID already exists.");
                            return;
                        }
                    }

                    // Check if the attendance record for the same date exists
                    using (OracleCommand checkDateCommand = new OracleCommand(checkAttendanceDateQuery, connection))
                    {
                        checkDateCommand.Parameters.Add(new OracleParameter("empId", empId));
                        checkDateCommand.Parameters.Add(new OracleParameter("holidayDate", attendanceDate)); // Use DateTimePicker value

                        int recordCount = Convert.ToInt32(checkDateCommand.ExecuteScalar());
                        if (recordCount > 0)
                        {
                            MessageBox.Show("Attendance for this employee on the selected date already exists.");
                            return;
                        }
                    }

                    // Insert the attendance record
                    using (OracleCommand insertCommand = new OracleCommand(insertQuery, connection))
                    {
                        // Bind parameters to prevent SQL injection
                        insertCommand.Parameters.Add(new OracleParameter("attendanceId", attendanceId));
                        insertCommand.Parameters.Add(new OracleParameter("empId", empId));
                        insertCommand.Parameters.Add(new OracleParameter("holidayDate", attendanceDate)); // Use DateTimePicker value
                        insertCommand.Parameters.Add(new OracleParameter("isHoliday", isHoliday));

                        // Execute the query
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Attendance record added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add attendance record.");
                        }
                    }
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 904) // ORA-00904: Invalid identifier
                    {
                        MessageBox.Show("Database schema error: 'holiday_date' column not found. Verify the table schema.");
                    }
                    else
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }



private void Attendence_List_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT 
    a.attendance_id,
    e.emp_id,
    e.first_name || ' ' || e.last_name AS emp_name,  -- String concatenation in Oracle
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
ORDER BY 
    e.emp_id, a.holiday_date";


                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataG.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Search_ID_Click(object sender, EventArgs e)
        {
            // Validate Employee ID input
            if (string.IsNullOrWhiteSpace(Emp_ID.Text))
            {
                MessageBox.Show("Please enter an Employee ID.");
                return;
            }

            if (!int.TryParse(Emp_ID.Text, out int empId))
            {
                MessageBox.Show("Employee ID must be a valid integer.");
                return;
            }

            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query = @"
            SELECT 
                a.attendance_id,
                e.emp_id,
                e.first_name || ' ' || e.last_name AS emp_name,
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
                        // Bind the validated employee ID to the query parameter
                        cmd.Parameters.Add(":emp_id", OracleDbType.Int32).Value = empId;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                dataG.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No attendance records found for the given Employee ID.");
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

        private void yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void previous_Click(object sender, EventArgs e)
        {
            using (var obj = new Adminchoice())
            {
                this.Hide();
                obj.ShowDialog();
            }
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void atendid_TextChanged(object sender, EventArgs e)
        {

        }

        private void eempid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the currently selected row
                DataGridViewRow selectedRow = dataG.Rows[e.RowIndex];

                // Assign values from the row to the textboxes and other controls
                string empIdText = selectedRow.Cells["emp_id"].Value?.ToString().Trim();
                string attendanceIdText = selectedRow.Cells["attendance_id"].Value?.ToString().Trim();
                this.eempid.Text = empIdText; // Set emp_id to eempid textbox
                this.atendid.Text = attendanceIdText; // Set attendance_id to atendid textbox

                // Handle DateTimePicker for Attendance Date
                if (DateTime.TryParse(selectedRow.Cells["holiday_date"].Value?.ToString(), out DateTime attendanceDate))
                {
                    this.Attendence_Date.Value = attendanceDate; // Set date
                }
                else
                {
                    this.Attendence_Date.Value = DateTime.Now; // Default value if parsing fails
                }

                // Handle Holiday status (Yes/No radio button)
                char isHoliday = selectedRow.Cells["is_holiday"].Value?.ToString().Trim() == "Y" ? 'Y' : 'N';
                if (isHoliday == 'Y')
                {
                    this.yes.Checked = true;
                }
                else
                {
                    this.no.Checked = true;
                }
            }
        }
    }
}
