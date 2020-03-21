namespace CarRentalApp
{
    partial class CustomerLogin
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
            this.header = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.newCxLabel = new System.Windows.Forms.Label();
            this.existingCxLabel = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.vSeparator1 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.insuranceBox = new System.Windows.Forms.TextBox();
            this.driversBox = new System.Windows.Forms.TextBox();
            this.existingCxButton = new System.Windows.Forms.Button();
            this.newCxButton = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(278, 29);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(229, 32);
            this.header.TabIndex = 1;
            this.header.Text = "Customer Login";
            // 
            // inputEmail
            // 
            this.inputEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputEmail.Location = new System.Drawing.Point(53, 134);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(4);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(202, 26);
            this.inputEmail.TabIndex = 2;
            this.inputEmail.Text = "Email";
            this.inputEmail.Enter += new System.EventHandler(this.inputEmail_Enter);
            this.inputEmail.Leave += new System.EventHandler(this.inputEmail_Leave);
            // 
            // inputPassword
            // 
            this.inputPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputPassword.Location = new System.Drawing.Point(53, 180);
            this.inputPassword.Margin = new System.Windows.Forms.Padding(4);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(202, 26);
            this.inputPassword.TabIndex = 3;
            this.inputPassword.Text = "Password";
            this.inputPassword.MaxLength = 20;
            this.inputPassword.Enter += new System.EventHandler(this.inputPassword_Enter);
            this.inputPassword.Leave += new System.EventHandler(this.inputPassword_Leave);
            // 
            // newCxLabel
            // 
            this.newCxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCxLabel.AutoSize = true;
            this.newCxLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCxLabel.Location = new System.Drawing.Point(460, 85);
            this.newCxLabel.Name = "newCxLabel";
            this.newCxLabel.Size = new System.Drawing.Size(156, 24);
            this.newCxLabel.TabIndex = 5;
            this.newCxLabel.Text = "New Customer";
            // 
            // existingCxLabel
            // 
            this.existingCxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existingCxLabel.AutoSize = true;
            this.existingCxLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingCxLabel.Location = new System.Drawing.Point(59, 85);
            this.existingCxLabel.Name = "existingCxLabel";
            this.existingCxLabel.Size = new System.Drawing.Size(196, 24);
            this.existingCxLabel.TabIndex = 6;
            this.existingCxLabel.Text = "Existing Customer";
            // 
            // fNameBox
            // 
            this.fNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.fNameBox.Location = new System.Drawing.Point(325, 134);
            this.fNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(207, 26);
            this.fNameBox.TabIndex = 7;
            this.fNameBox.Text = "First Name";
            this.fNameBox.Enter += new System.EventHandler(this.fNameBox_Enter);
            this.fNameBox.Leave += new System.EventHandler(this.fNameBox_Leave);
            // 
            // lNameBox
            // 
            this.lNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lNameBox.Location = new System.Drawing.Point(540, 134);
            this.lNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(207, 26);
            this.lNameBox.TabIndex = 8;
            this.lNameBox.Text = "Last Name";
            this.lNameBox.Enter += new System.EventHandler(this.lNameBox_Enter);
            this.lNameBox.Leave += new System.EventHandler(this.lNameBox_Leave);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailBox.Location = new System.Drawing.Point(325, 276);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(207, 26);
            this.EmailBox.TabIndex = 9;
            this.EmailBox.Text = "Email";
            this.EmailBox.Enter += new System.EventHandler(this.EmailBox_Enter);
            this.EmailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // vSeparator1
            // 
            this.vSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vSeparator1.Location = new System.Drawing.Point(284, 85);
            this.vSeparator1.Name = "vSeparator1";
            this.vSeparator1.Size = new System.Drawing.Size(2, 350);
            this.vSeparator1.TabIndex = 10;
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneBox.Location = new System.Drawing.Point(325, 180);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(207, 26);
            this.phoneBox.TabIndex = 11;
            this.phoneBox.Text = "Phone Number";
            this.phoneBox.Enter += new System.EventHandler(this.phoneBox_Enter);
            this.phoneBox.Leave += new System.EventHandler(this.phoneBox_Leave);
            // 
            // insuranceBox
            // 
            this.insuranceBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.insuranceBox.Location = new System.Drawing.Point(325, 227);
            this.insuranceBox.Margin = new System.Windows.Forms.Padding(4);
            this.insuranceBox.Name = "insuranceBox";
            this.insuranceBox.Size = new System.Drawing.Size(207, 26);
            this.insuranceBox.TabIndex = 12;
            this.insuranceBox.Text = "Insurance Number";
            this.insuranceBox.Enter += new System.EventHandler(this.insuranceBox_Enter);
            this.insuranceBox.Leave += new System.EventHandler(this.insuranceBox_Leave);
            // 
            // driversBox
            // 
            this.driversBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.driversBox.Location = new System.Drawing.Point(540, 227);
            this.driversBox.Margin = new System.Windows.Forms.Padding(4);
            this.driversBox.Name = "driversBox";
            this.driversBox.Size = new System.Drawing.Size(207, 26);
            this.driversBox.TabIndex = 13;
            this.driversBox.Text = "Driver\'s License Class";
            this.driversBox.Enter += new System.EventHandler(this.driversBox_Enter);
            this.driversBox.Leave += new System.EventHandler(this.driversBox_Leave);
            // 
            // existingCxButton
            // 
            this.existingCxButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingCxButton.Location = new System.Drawing.Point(89, 243);
            this.existingCxButton.Name = "existingCxButton";
            this.existingCxButton.Size = new System.Drawing.Size(125, 40);
            this.existingCxButton.TabIndex = 14;
            this.existingCxButton.Text = "Login";
            this.existingCxButton.UseVisualStyleBackColor = true;
            this.existingCxButton.Click += new System.EventHandler(this.existingCxButton_Click);
            // 
            // newCxButton
            // 
            this.newCxButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCxButton.Location = new System.Drawing.Point(470, 378);
            this.newCxButton.Name = "newCxButton";
            this.newCxButton.Size = new System.Drawing.Size(125, 40);
            this.newCxButton.TabIndex = 15;
            this.newCxButton.Text = "Submit";
            this.newCxButton.UseVisualStyleBackColor = true;
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ageBox.Location = new System.Drawing.Point(540, 180);
            this.ageBox.Margin = new System.Windows.Forms.Padding(4);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(207, 26);
            this.ageBox.TabIndex = 16;
            this.ageBox.Text = "Age";
            this.ageBox.Enter += new System.EventHandler(this.ageBox_Enter);
            this.ageBox.Leave += new System.EventHandler(this.ageBox_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordBox.Location = new System.Drawing.Point(540, 276);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(207, 26);
            this.passwordBox.TabIndex = 17;
            this.passwordBox.Text = "New Password";
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // confirmBox
            // 
            this.confirmBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.confirmBox.Location = new System.Drawing.Point(540, 323);
            this.confirmBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(207, 26);
            this.confirmBox.TabIndex = 18;
            this.confirmBox.Text = "Confirm Password";
            this.confirmBox.Enter += new System.EventHandler(this.confirmBox_Enter);
            this.confirmBox.Leave += new System.EventHandler(this.confirmBox_Leave);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.newCxButton);
            this.Controls.Add(this.existingCxButton);
            this.Controls.Add(this.driversBox);
            this.Controls.Add(this.insuranceBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.vSeparator1);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.existingCxLabel);
            this.Controls.Add(this.newCxLabel);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.header);
            this.Name = "CustomerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label newCxLabel;
        private System.Windows.Forms.Label existingCxLabel;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label vSeparator1;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox insuranceBox;
        private System.Windows.Forms.TextBox driversBox;
        private System.Windows.Forms.Button existingCxButton;
        private System.Windows.Forms.Button newCxButton;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox confirmBox;
    }
}