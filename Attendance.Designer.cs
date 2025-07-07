namespace VP_Project
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.dataG = new System.Windows.Forms.DataGridView();
            this.Attendence_Add_Button = new System.Windows.Forms.Button();
            this.Attendence_List_Button = new System.Windows.Forms.Button();
            this.Search_ID = new System.Windows.Forms.Button();
            this.eempid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            this.atendid = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.Attendence_Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(133, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(587, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(588, 386);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Absent";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Emp_ID
            // 
            this.Emp_ID.BackColor = System.Drawing.SystemColors.Info;
            this.Emp_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_ID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Emp_ID.Location = new System.Drawing.Point(278, 167);
            this.Emp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(250, 25);
            this.Emp_ID.TabIndex = 3;
            this.Emp_ID.TextChanged += new System.EventHandler(this.Emp_ID_TextChanged);
            // 
            // dataG
            // 
            this.dataG.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG.GridColor = System.Drawing.SystemColors.Info;
            this.dataG.Location = new System.Drawing.Point(136, 495);
            this.dataG.Margin = new System.Windows.Forms.Padding(4);
            this.dataG.Name = "dataG";
            this.dataG.RowHeadersWidth = 51;
            this.dataG.RowTemplate.Height = 24;
            this.dataG.Size = new System.Drawing.Size(759, 227);
            this.dataG.TabIndex = 6;
            this.dataG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataG_CellContentClick);
            // 
            // Attendence_Add_Button
            // 
            this.Attendence_Add_Button.BackColor = System.Drawing.SystemColors.Info;
            this.Attendence_Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendence_Add_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Attendence_Add_Button.Location = new System.Drawing.Point(440, 425);
            this.Attendence_Add_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Attendence_Add_Button.Name = "Attendence_Add_Button";
            this.Attendence_Add_Button.Size = new System.Drawing.Size(143, 42);
            this.Attendence_Add_Button.TabIndex = 7;
            this.Attendence_Add_Button.Text = "Add";
            this.Attendence_Add_Button.UseVisualStyleBackColor = false;
            this.Attendence_Add_Button.Click += new System.EventHandler(this.Attendence_Add_Button_Click);
            // 
            // Attendence_List_Button
            // 
            this.Attendence_List_Button.BackColor = System.Drawing.SystemColors.Info;
            this.Attendence_List_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendence_List_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Attendence_List_Button.Location = new System.Drawing.Point(696, 161);
            this.Attendence_List_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Attendence_List_Button.Name = "Attendence_List_Button";
            this.Attendence_List_Button.Size = new System.Drawing.Size(103, 35);
            this.Attendence_List_Button.TabIndex = 8;
            this.Attendence_List_Button.Text = "List All";
            this.Attendence_List_Button.UseVisualStyleBackColor = false;
            this.Attendence_List_Button.Click += new System.EventHandler(this.Attendence_List_Button_Click);
            // 
            // Search_ID
            // 
            this.Search_ID.BackColor = System.Drawing.SystemColors.Info;
            this.Search_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_ID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Search_ID.Location = new System.Drawing.Point(566, 161);
            this.Search_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Search_ID.Name = "Search_ID";
            this.Search_ID.Size = new System.Drawing.Size(103, 35);
            this.Search_ID.TabIndex = 9;
            this.Search_ID.Text = "ID";
            this.Search_ID.UseVisualStyleBackColor = false;
            this.Search_ID.Click += new System.EventHandler(this.Search_ID_Click);
            // 
            // eempid
            // 
            this.eempid.BackColor = System.Drawing.SystemColors.Info;
            this.eempid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eempid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.eempid.Location = new System.Drawing.Point(200, 382);
            this.eempid.Margin = new System.Windows.Forms.Padding(4);
            this.eempid.Name = "eempid";
            this.eempid.Size = new System.Drawing.Size(228, 25);
            this.eempid.TabIndex = 11;
            this.eempid.TextChanged += new System.EventHandler(this.eempid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(41, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employee ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(29, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Attendance ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.BackColor = System.Drawing.SystemColors.Info;
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.yes.Location = new System.Drawing.Point(691, 386);
            this.yes.Margin = new System.Windows.Forms.Padding(4);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(57, 22);
            this.yes.TabIndex = 14;
            this.yes.TabStop = true;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.CheckedChanged += new System.EventHandler(this.yes_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(339, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 39);
            this.label6.TabIndex = 17;
            this.label6.Text = "ATTENDANCE  PANEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(436, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Add Attendance ";
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.SystemColors.Info;
            this.previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous.ForeColor = System.Drawing.SystemColors.Highlight;
            this.previous.Location = new System.Drawing.Point(440, 760);
            this.previous.Margin = new System.Windows.Forms.Padding(4);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(143, 42);
            this.previous.TabIndex = 19;
            this.previous.Text = "BACK";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // atendid
            // 
            this.atendid.BackColor = System.Drawing.SystemColors.Info;
            this.atendid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atendid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.atendid.Location = new System.Drawing.Point(200, 338);
            this.atendid.Margin = new System.Windows.Forms.Padding(4);
            this.atendid.Name = "atendid";
            this.atendid.Size = new System.Drawing.Size(228, 25);
            this.atendid.TabIndex = 10;
            this.atendid.TextChanged += new System.EventHandler(this.atendid_TextChanged);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.BackColor = System.Drawing.SystemColors.Info;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.SystemColors.Highlight;
            this.no.Location = new System.Drawing.Point(773, 386);
            this.no.Margin = new System.Windows.Forms.Padding(4);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(51, 22);
            this.no.TabIndex = 20;
            this.no.TabStop = true;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = false;
            // 
            // Attendence_Date
            // 
            this.Attendence_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendence_Date.Location = new System.Drawing.Point(658, 339);
            this.Attendence_Date.Name = "Attendence_Date";
            this.Attendence_Date.Size = new System.Drawing.Size(259, 25);
            this.Attendence_Date.TabIndex = 21;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(999, 826);
            this.Controls.Add(this.Attendence_Date);
            this.Controls.Add(this.no);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eempid);
            this.Controls.Add(this.atendid);
            this.Controls.Add(this.Search_ID);
            this.Controls.Add(this.Attendence_List_Button);
            this.Controls.Add(this.Attendence_Add_Button);
            this.Controls.Add(this.dataG);
            this.Controls.Add(this.Emp_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.DataGridView dataG;
        private System.Windows.Forms.Button Attendence_Add_Button;
        private System.Windows.Forms.Button Attendence_List_Button;
        private System.Windows.Forms.Button Search_ID;
        private System.Windows.Forms.TextBox eempid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.TextBox atendid;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.DateTimePicker Attendence_Date;
    }
}