namespace CarRentalApp
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_field = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.admin_login_result_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.username_label.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.username_label.Location = new System.Drawing.Point(15, 44);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(75, 20);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.password_label.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.password_label.Location = new System.Drawing.Point(15, 99);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(70, 20);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // username_field
            // 
            this.username_field.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.username_field.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.username_field.Location = new System.Drawing.Point(152, 37);
            this.username_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(152, 27);
            this.username_field.TabIndex = 2;
            // 
            // password_field
            // 
            this.password_field.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.password_field.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.password_field.Location = new System.Drawing.Point(152, 96);
            this.password_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(152, 27);
            this.password_field.TabIndex = 3;
            // 
            // admin_login_result_label
            // 
            this.admin_login_result_label.AutoSize = true;
            this.admin_login_result_label.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.admin_login_result_label.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.admin_login_result_label.Location = new System.Drawing.Point(149, 212);
            this.admin_login_result_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.admin_login_result_label.Name = "admin_login_result_label";
            this.admin_login_result_label.Size = new System.Drawing.Size(0, 20);
            this.admin_login_result_label.TabIndex = 6;
            this.admin_login_result_label.Visible = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 93);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(243, 150);
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(418, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hit submit for admin access";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.submitButton);
            this.loginGroupBox.Controls.Add(this.admin_login_result_label);
            this.loginGroupBox.Controls.Add(this.password_field);
            this.loginGroupBox.Controls.Add(this.username_field);
            this.loginGroupBox.Controls.Add(this.password_label);
            this.loginGroupBox.Controls.Add(this.username_label);
            this.loginGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.loginGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginGroupBox.Location = new System.Drawing.Point(279, 64);
            this.loginGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginGroupBox.Size = new System.Drawing.Size(349, 232);
            this.loginGroupBox.TabIndex = 9;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Enter your credentials here";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.submitButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitButton.Location = new System.Drawing.Point(152, 149);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(132, 30);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(654, 425);
            this.Controls.Add(this.loginGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminLogin";
            this.Text = "Admin Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_field;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label admin_login_result_label;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Button submitButton;
    }
}