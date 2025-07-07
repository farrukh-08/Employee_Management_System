namespace VP_Project
{
    partial class login
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
            this.adminbutton = new System.Windows.Forms.Button();
            this.employeebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginImage = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.SystemColors.Info;
            this.adminbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.adminbutton.Location = new System.Drawing.Point(282, 292);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(378, 49);
            this.adminbutton.TabIndex = 0;
            this.adminbutton.Text = "Sign As Admin";
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // employeebutton
            // 
            this.employeebutton.BackColor = System.Drawing.SystemColors.Info;
            this.employeebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeebutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.employeebutton.Location = new System.Drawing.Point(282, 370);
            this.employeebutton.Name = "employeebutton";
            this.employeebutton.Size = new System.Drawing.Size(378, 47);
            this.employeebutton.TabIndex = 1;
            this.employeebutton.Text = "Sign As Employee";
            this.employeebutton.UseVisualStyleBackColor = false;
            this.employeebutton.Click += new System.EventHandler(this.employeebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(94, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO THE EMPOYEE MANAGMENT SYSTEM";
            // 
            // loginImage
            // 
            this.loginImage.BackColor = System.Drawing.SystemColors.Info;
            this.loginImage.Location = new System.Drawing.Point(390, 142);
            this.loginImage.Name = "loginImage";
            this.loginImage.Size = new System.Drawing.Size(159, 112);
            this.loginImage.TabIndex = 3;
            this.loginImage.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Info;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(390, 437);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(159, 37);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(918, 530);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.loginImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeebutton);
            this.Controls.Add(this.adminbutton);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Button employeebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox loginImage;
        private System.Windows.Forms.Button Exit;
    }
}