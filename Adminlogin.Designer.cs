namespace VP_Project
{
    partial class Adminlogin
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminloginbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BKK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.usernameTextBox.Location = new System.Drawing.Point(253, 201);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(288, 22);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordTextBox.Location = new System.Drawing.Point(253, 258);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(288, 22);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(317, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Admin Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(297, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Admin Password";
            // 
            // adminloginbutton
            // 
            this.adminloginbutton.BackColor = System.Drawing.SystemColors.Info;
            this.adminloginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminloginbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminloginbutton.Location = new System.Drawing.Point(332, 302);
            this.adminloginbutton.Name = "adminloginbutton";
            this.adminloginbutton.Size = new System.Drawing.Size(135, 43);
            this.adminloginbutton.TabIndex = 4;
            this.adminloginbutton.Text = "Login";
            this.adminloginbutton.UseVisualStyleBackColor = false;
            this.adminloginbutton.Click += new System.EventHandler(this.adminloginbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(295, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADMIN PANEL";
            // 
            // BKK
            // 
            this.BKK.BackColor = System.Drawing.SystemColors.Info;
            this.BKK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BKK.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BKK.Location = new System.Drawing.Point(332, 361);
            this.BKK.Name = "BKK";
            this.BKK.Size = new System.Drawing.Size(135, 43);
            this.BKK.TabIndex = 6;
            this.BKK.Text = "BACK";
            this.BKK.UseVisualStyleBackColor = false;
            this.BKK.Click += new System.EventHandler(this.BKK_Click);
            // 
            // Adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BKK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminloginbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "Adminlogin";
            this.Text = "Adminlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adminloginbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BKK;
    }
}