namespace VP_Project
{
    partial class employeelogin
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
            this.Employeeloginformtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginemployeebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Employee_Password = new System.Windows.Forms.TextBox();
            this.forg = new System.Windows.Forms.LinkLabel();
            this.PERVV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employeeloginformtextbox
            // 
            this.Employeeloginformtextbox.BackColor = System.Drawing.SystemColors.Info;
            this.Employeeloginformtextbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Employeeloginformtextbox.Location = new System.Drawing.Point(249, 214);
            this.Employeeloginformtextbox.Name = "Employeeloginformtextbox";
            this.Employeeloginformtextbox.Size = new System.Drawing.Size(290, 22);
            this.Employeeloginformtextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(266, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTER YOUR EMPLOYEE ID";
            // 
            // Loginemployeebutton
            // 
            this.Loginemployeebutton.BackColor = System.Drawing.SystemColors.Info;
            this.Loginemployeebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginemployeebutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Loginemployeebutton.Location = new System.Drawing.Point(253, 327);
            this.Loginemployeebutton.Name = "Loginemployeebutton";
            this.Loginemployeebutton.Size = new System.Drawing.Size(106, 36);
            this.Loginemployeebutton.TabIndex = 4;
            this.Loginemployeebutton.Text = "Login";
            this.Loginemployeebutton.UseVisualStyleBackColor = false;
            this.Loginemployeebutton.Click += new System.EventHandler(this.Loginemployeebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(243, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = " EMPOLYEE PANEL\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(224, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ENTER YOUR EMPLOYEE PASSWORD";
            // 
            // Employee_Password
            // 
            this.Employee_Password.BackColor = System.Drawing.SystemColors.Info;
            this.Employee_Password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Employee_Password.Location = new System.Drawing.Point(253, 284);
            this.Employee_Password.Name = "Employee_Password";
            this.Employee_Password.PasswordChar = '*';
            this.Employee_Password.Size = new System.Drawing.Size(290, 22);
            this.Employee_Password.TabIndex = 7;
            // 
            // forg
            // 
            this.forg.AutoSize = true;
            this.forg.Location = new System.Drawing.Point(337, 388);
            this.forg.Name = "forg";
            this.forg.Size = new System.Drawing.Size(116, 16);
            this.forg.TabIndex = 8;
            this.forg.TabStop = true;
            this.forg.Text = "Forgot Password?";
            this.forg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forg_LinkClicked);
            // 
            // PERVV
            // 
            this.PERVV.BackColor = System.Drawing.SystemColors.Info;
            this.PERVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERVV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PERVV.Location = new System.Drawing.Point(437, 327);
            this.PERVV.Name = "PERVV";
            this.PERVV.Size = new System.Drawing.Size(106, 36);
            this.PERVV.TabIndex = 9;
            this.PERVV.Text = "BACK";
            this.PERVV.UseVisualStyleBackColor = false;
            this.PERVV.Click += new System.EventHandler(this.PERVV_Click);
            // 
            // employeelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PERVV);
            this.Controls.Add(this.forg);
            this.Controls.Add(this.Employee_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Loginemployeebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employeeloginformtextbox);
            this.Name = "employeelogin";
            this.Text = "employeelogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Employeeloginformtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginemployeebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Employee_Password;
        private System.Windows.Forms.LinkLabel forg;
        private System.Windows.Forms.Button PERVV;
    }
}