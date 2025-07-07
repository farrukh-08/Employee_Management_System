namespace VP_Project
{
    partial class Adminchoice
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
            this.label6 = new System.Windows.Forms.Label();
            this.emppage = new System.Windows.Forms.Button();
            this.attendpage = new System.Windows.Forms.Button();
            this.paypage = new System.Windows.Forms.Button();
            this.prv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(173, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "WELCOME TO ADMIN PANEL";
            // 
            // emppage
            // 
            this.emppage.BackColor = System.Drawing.SystemColors.Info;
            this.emppage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emppage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.emppage.Location = new System.Drawing.Point(209, 135);
            this.emppage.Name = "emppage";
            this.emppage.Size = new System.Drawing.Size(372, 62);
            this.emppage.TabIndex = 31;
            this.emppage.Text = "Employee Managment Panel";
            this.emppage.UseVisualStyleBackColor = false;
            this.emppage.Click += new System.EventHandler(this.emppage_Click);
            // 
            // attendpage
            // 
            this.attendpage.BackColor = System.Drawing.SystemColors.Info;
            this.attendpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendpage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.attendpage.Location = new System.Drawing.Point(209, 218);
            this.attendpage.Name = "attendpage";
            this.attendpage.Size = new System.Drawing.Size(372, 62);
            this.attendpage.TabIndex = 32;
            this.attendpage.Text = "Attendance Panel";
            this.attendpage.UseVisualStyleBackColor = false;
            this.attendpage.Click += new System.EventHandler(this.attendpage_Click);
            // 
            // paypage
            // 
            this.paypage.BackColor = System.Drawing.SystemColors.Info;
            this.paypage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paypage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.paypage.Location = new System.Drawing.Point(209, 309);
            this.paypage.Name = "paypage";
            this.paypage.Size = new System.Drawing.Size(372, 62);
            this.paypage.TabIndex = 33;
            this.paypage.Text = "Payroll Panel";
            this.paypage.UseVisualStyleBackColor = false;
            this.paypage.Click += new System.EventHandler(this.paypage_Click);
            // 
            // prv
            // 
            this.prv.BackColor = System.Drawing.SystemColors.Info;
            this.prv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prv.Location = new System.Drawing.Point(308, 403);
            this.prv.Margin = new System.Windows.Forms.Padding(4);
            this.prv.Name = "prv";
            this.prv.Size = new System.Drawing.Size(173, 34);
            this.prv.TabIndex = 72;
            this.prv.Text = "BACK";
            this.prv.UseVisualStyleBackColor = false;
            this.prv.Click += new System.EventHandler(this.prv_Click);
            // 
            // Adminchoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prv);
            this.Controls.Add(this.paypage);
            this.Controls.Add(this.attendpage);
            this.Controls.Add(this.emppage);
            this.Controls.Add(this.label6);
            this.Name = "Adminchoice";
            this.Text = "Adminchoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button emppage;
        private System.Windows.Forms.Button attendpage;
        private System.Windows.Forms.Button paypage;
        private System.Windows.Forms.Button prv;
    }
}