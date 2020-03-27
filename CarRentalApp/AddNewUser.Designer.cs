namespace CarRentalApp
{
    partial class AddNewUser
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.addNewUserLabel = new System.Windows.Forms.Label();
            this.enterUserDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.insuranceID = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.driverLicenseClassTypeLabel = new System.Windows.Forms.Label();
            this.driverLicenseNumberLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.insuranceIDTexBox = new System.Windows.Forms.TextBox();
            this.driverLicenseClassTypeTextBox = new System.Windows.Forms.TextBox();
            this.driverLicenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.enterUserDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.addNewUserLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(780, 69);
            this.topPanel.TabIndex = 14;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // addNewUserLabel
            // 
            this.addNewUserLabel.AutoSize = true;
            this.addNewUserLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addNewUserLabel.Location = new System.Drawing.Point(32, 19);
            this.addNewUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewUserLabel.Name = "addNewUserLabel";
            this.addNewUserLabel.Size = new System.Drawing.Size(208, 40);
            this.addNewUserLabel.TabIndex = 0;
            this.addNewUserLabel.Text = "Add New User";
            this.addNewUserLabel.Click += new System.EventHandler(this.addNewUserLabel_Click);
            // 
            // enterUserDetailsGroupBox
            // 
            this.enterUserDetailsGroupBox.Controls.Add(this.resultLabel);
            this.enterUserDetailsGroupBox.Controls.Add(this.driverLicenseNumberTextBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.driverLicenseClassTypeTextBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.insuranceIDTexBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.ageTextBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.driverLicenseNumberLabel);
            this.enterUserDetailsGroupBox.Controls.Add(this.driverLicenseClassTypeLabel);
            this.enterUserDetailsGroupBox.Controls.Add(this.ageLabel);
            this.enterUserDetailsGroupBox.Controls.Add(this.insuranceID);
            this.enterUserDetailsGroupBox.Controls.Add(this.submitButton);
            this.enterUserDetailsGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.lastNameTextBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.firstNameTextBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.phoneNumberLabel);
            this.enterUserDetailsGroupBox.Controls.Add(this.firstNameLabel);
            this.enterUserDetailsGroupBox.Controls.Add(this.LastNameLabel);
            this.enterUserDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUserDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterUserDetailsGroupBox.Location = new System.Drawing.Point(39, 99);
            this.enterUserDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.enterUserDetailsGroupBox.Name = "enterUserDetailsGroupBox";
            this.enterUserDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.enterUserDetailsGroupBox.Size = new System.Drawing.Size(546, 364);
            this.enterUserDetailsGroupBox.TabIndex = 15;
            this.enterUserDetailsGroupBox.TabStop = false;
            this.enterUserDetailsGroupBox.Text = "Enter user details";
            this.enterUserDetailsGroupBox.Enter += new System.EventHandler(this.enterUserDetailsGroupBox_Enter);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(211, 105);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(280, 26);
            this.phoneNumberTextBox.TabIndex = 7;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowOnlyNumericalValues);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNameTextBox.Location = new System.Drawing.Point(211, 69);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(280, 26);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNameTextBox.Location = new System.Drawing.Point(211, 31);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(280, 26);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumberLabel.Location = new System.Drawing.Point(14, 112);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(102, 19);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number";
            this.phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.firstNameLabel.Location = new System.Drawing.Point(14, 38);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(75, 19);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LastNameLabel.Location = new System.Drawing.Point(14, 76);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(74, 19);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitButton.Location = new System.Drawing.Point(281, 307);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(132, 30);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // insuranceID
            // 
            this.insuranceID.AutoSize = true;
            this.insuranceID.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceID.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.insuranceID.Location = new System.Drawing.Point(14, 183);
            this.insuranceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insuranceID.Name = "insuranceID";
            this.insuranceID.Size = new System.Drawing.Size(86, 19);
            this.insuranceID.TabIndex = 10;
            this.insuranceID.Text = "Insurance ID";
            this.insuranceID.Click += new System.EventHandler(this.insuranceID_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ageLabel.Location = new System.Drawing.Point(14, 147);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 19);
            this.ageLabel.TabIndex = 11;
            this.ageLabel.Text = "Age";
            this.ageLabel.Click += new System.EventHandler(this.ageLabel_Click);
            // 
            // driverLicenseClassTypeLabel
            // 
            this.driverLicenseClassTypeLabel.AutoSize = true;
            this.driverLicenseClassTypeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLicenseClassTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.driverLicenseClassTypeLabel.Location = new System.Drawing.Point(14, 224);
            this.driverLicenseClassTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.driverLicenseClassTypeLabel.Name = "driverLicenseClassTypeLabel";
            this.driverLicenseClassTypeLabel.Size = new System.Drawing.Size(162, 19);
            this.driverLicenseClassTypeLabel.TabIndex = 12;
            this.driverLicenseClassTypeLabel.Text = "Driver License Class Type";
            this.driverLicenseClassTypeLabel.Click += new System.EventHandler(this.driverLicenseClassTypeLabel_Click);
            // 
            // driverLicenseNumberLabel
            // 
            this.driverLicenseNumberLabel.AutoSize = true;
            this.driverLicenseNumberLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLicenseNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.driverLicenseNumberLabel.Location = new System.Drawing.Point(14, 266);
            this.driverLicenseNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.driverLicenseNumberLabel.Name = "driverLicenseNumberLabel";
            this.driverLicenseNumberLabel.Size = new System.Drawing.Size(148, 19);
            this.driverLicenseNumberLabel.TabIndex = 13;
            this.driverLicenseNumberLabel.Text = "Driver License Number";
            this.driverLicenseNumberLabel.Click += new System.EventHandler(this.driverLicenseNumberLabel_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ageTextBox.Location = new System.Drawing.Point(211, 140);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(280, 26);
            this.ageTextBox.TabIndex = 14;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowOnlyNumericalValues);
            // 
            // insuranceIDTexBox
            // 
            this.insuranceIDTexBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceIDTexBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insuranceIDTexBox.Location = new System.Drawing.Point(211, 176);
            this.insuranceIDTexBox.Margin = new System.Windows.Forms.Padding(2);
            this.insuranceIDTexBox.Name = "insuranceIDTexBox";
            this.insuranceIDTexBox.Size = new System.Drawing.Size(280, 26);
            this.insuranceIDTexBox.TabIndex = 15;
            this.insuranceIDTexBox.TextChanged += new System.EventHandler(this.insuranceIDTexBox_TextChanged);
            // 
            // driverLicenseClassTypeTextBox
            // 
            this.driverLicenseClassTypeTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLicenseClassTypeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.driverLicenseClassTypeTextBox.Location = new System.Drawing.Point(211, 217);
            this.driverLicenseClassTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.driverLicenseClassTypeTextBox.Name = "driverLicenseClassTypeTextBox";
            this.driverLicenseClassTypeTextBox.Size = new System.Drawing.Size(280, 26);
            this.driverLicenseClassTypeTextBox.TabIndex = 16;
            this.driverLicenseClassTypeTextBox.TextChanged += new System.EventHandler(this.driverLicenseClassTypeTextBox_TextChanged);
            // 
            // driverLicenseNumberTextBox
            // 
            this.driverLicenseNumberTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLicenseNumberTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.driverLicenseNumberTextBox.Location = new System.Drawing.Point(211, 259);
            this.driverLicenseNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.driverLicenseNumberTextBox.Name = "driverLicenseNumberTextBox";
            this.driverLicenseNumberTextBox.Size = new System.Drawing.Size(280, 26);
            this.driverLicenseNumberTextBox.TabIndex = 17;
            this.driverLicenseNumberTextBox.TextChanged += new System.EventHandler(this.driverLicenseNumberTextBox_TextChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultLabel.Location = new System.Drawing.Point(14, 307);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 19);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(780, 533);
            this.Controls.Add(this.enterUserDetailsGroupBox);
            this.Controls.Add(this.topPanel);
            this.Name = "AddNewUser";
            this.Text = "Add New User";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.enterUserDetailsGroupBox.ResumeLayout(false);
            this.enterUserDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label addNewUserLabel;
        private System.Windows.Forms.GroupBox enterUserDetailsGroupBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox driverLicenseNumberTextBox;
        private System.Windows.Forms.TextBox driverLicenseClassTypeTextBox;
        private System.Windows.Forms.TextBox insuranceIDTexBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label driverLicenseNumberLabel;
        private System.Windows.Forms.Label driverLicenseClassTypeLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label insuranceID;
    }
}