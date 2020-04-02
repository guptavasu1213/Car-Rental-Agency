namespace CarRentalApp
{
    partial class FindEmployee
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
            this.employeeIDResultLabel = new System.Windows.Forms.Label();
            this.employeeIDSearchButton = new System.Windows.Forms.Button();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.employeeIDGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeIDTextbox = new System.Windows.Forms.TextBox();
            this.sinResultLabel = new System.Windows.Forms.Label();
            this.sinSearchButton = new System.Windows.Forms.Button();
            this.sinTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneNumResultLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumSearchButton = new System.Windows.Forms.Button();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.nameResultLabel = new System.Windows.Forms.Label();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.findExistingEmployeeLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.employeeInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeIDGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDResultLabel
            // 
            this.employeeIDResultLabel.AutoSize = true;
            this.employeeIDResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeIDResultLabel.Location = new System.Drawing.Point(29, 89);
            this.employeeIDResultLabel.Name = "employeeIDResultLabel";
            this.employeeIDResultLabel.Size = new System.Drawing.Size(0, 22);
            this.employeeIDResultLabel.TabIndex = 26;
            this.employeeIDResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employeeIDResultLabel.Visible = false;
            // 
            // employeeIDSearchButton
            // 
            this.employeeIDSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.employeeIDSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeeIDSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeIDSearchButton.Location = new System.Drawing.Point(272, 97);
            this.employeeIDSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeIDSearchButton.Name = "employeeIDSearchButton";
            this.employeeIDSearchButton.Size = new System.Drawing.Size(87, 37);
            this.employeeIDSearchButton.TabIndex = 25;
            this.employeeIDSearchButton.Text = "Search";
            this.employeeIDSearchButton.UseVisualStyleBackColor = false;
            this.employeeIDSearchButton.Click += new System.EventHandler(this.employeeIDSearchButton_Click);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerIDLabel.Location = new System.Drawing.Point(23, 46);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(106, 22);
            this.customerIDLabel.TabIndex = 23;
            this.customerIDLabel.Text = "Employee ID";
            // 
            // employeeIDGroupBox
            // 
            this.employeeIDGroupBox.Controls.Add(this.employeeIDResultLabel);
            this.employeeIDGroupBox.Controls.Add(this.employeeIDSearchButton);
            this.employeeIDGroupBox.Controls.Add(this.employeeIDTextbox);
            this.employeeIDGroupBox.Controls.Add(this.customerIDLabel);
            this.employeeIDGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeIDGroupBox.Location = new System.Drawing.Point(15, 121);
            this.employeeIDGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeIDGroupBox.Name = "employeeIDGroupBox";
            this.employeeIDGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeIDGroupBox.Size = new System.Drawing.Size(460, 156);
            this.employeeIDGroupBox.TabIndex = 35;
            this.employeeIDGroupBox.TabStop = false;
            this.employeeIDGroupBox.Text = "Look up by Employee ID";
            // 
            // employeeIDTextbox
            // 
            this.employeeIDTextbox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeeIDTextbox.Location = new System.Drawing.Point(183, 46);
            this.employeeIDTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeIDTextbox.Name = "employeeIDTextbox";
            this.employeeIDTextbox.Size = new System.Drawing.Size(255, 30);
            this.employeeIDTextbox.TabIndex = 24;
            // 
            // sinResultLabel
            // 
            this.sinResultLabel.AutoSize = true;
            this.sinResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.sinResultLabel.Location = new System.Drawing.Point(29, 89);
            this.sinResultLabel.Name = "sinResultLabel";
            this.sinResultLabel.Size = new System.Drawing.Size(0, 22);
            this.sinResultLabel.TabIndex = 26;
            this.sinResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sinResultLabel.Visible = false;
            // 
            // sinSearchButton
            // 
            this.sinSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sinSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sinSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.sinSearchButton.Location = new System.Drawing.Point(272, 97);
            this.sinSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sinSearchButton.Name = "sinSearchButton";
            this.sinSearchButton.Size = new System.Drawing.Size(87, 37);
            this.sinSearchButton.TabIndex = 25;
            this.sinSearchButton.Text = "Search";
            this.sinSearchButton.UseVisualStyleBackColor = false;
            this.sinSearchButton.Click += new System.EventHandler(this.sinSearchButton_Click);
            // 
            // sinTextBox
            // 
            this.sinTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sinTextBox.Location = new System.Drawing.Point(183, 46);
            this.sinTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sinTextBox.Name = "sinTextBox";
            this.sinTextBox.Size = new System.Drawing.Size(255, 30);
            this.sinTextBox.TabIndex = 24;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.emailLabel.Location = new System.Drawing.Point(23, 46);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(37, 22);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "SIN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sinResultLabel);
            this.groupBox2.Controls.Add(this.sinSearchButton);
            this.groupBox2.Controls.Add(this.sinTextBox);
            this.groupBox2.Controls.Add(this.emailLabel);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(15, 516);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(460, 156);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up by SIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(25, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 20;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phoneNumResultLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.phoneNumSearchButton);
            this.groupBox1.Controls.Add(this.phoneNumberLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(15, 694);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(460, 164);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Look up by Phone Number";
            // 
            // phoneNumResultLabel
            // 
            this.phoneNumResultLabel.AutoSize = true;
            this.phoneNumResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumResultLabel.Location = new System.Drawing.Point(24, 90);
            this.phoneNumResultLabel.Name = "phoneNumResultLabel";
            this.phoneNumResultLabel.Size = new System.Drawing.Size(0, 22);
            this.phoneNumResultLabel.TabIndex = 20;
            this.phoneNumResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.phoneNumResultLabel.Visible = false;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(177, 47);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(255, 30);
            this.phoneNumberTextBox.TabIndex = 7;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // phoneNumSearchButton
            // 
            this.phoneNumSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneNumSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.phoneNumSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumSearchButton.Location = new System.Drawing.Point(267, 98);
            this.phoneNumSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumSearchButton.Name = "phoneNumSearchButton";
            this.phoneNumSearchButton.Size = new System.Drawing.Size(87, 37);
            this.phoneNumSearchButton.TabIndex = 19;
            this.phoneNumSearchButton.Text = "Search";
            this.phoneNumSearchButton.UseVisualStyleBackColor = false;
            this.phoneNumSearchButton.Click += new System.EventHandler(this.phoneNumSearchButton_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumberLabel.Location = new System.Drawing.Point(17, 47);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(127, 22);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // nameResultLabel
            // 
            this.nameResultLabel.AutoSize = true;
            this.nameResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameResultLabel.Location = new System.Drawing.Point(25, 140);
            this.nameResultLabel.Name = "nameResultLabel";
            this.nameResultLabel.Size = new System.Drawing.Size(0, 22);
            this.nameResultLabel.TabIndex = 18;
            this.nameResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameResultLabel.Visible = false;
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nameSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameSearchButton.Location = new System.Drawing.Point(268, 149);
            this.nameSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(87, 37);
            this.nameSearchButton.TabIndex = 9;
            this.nameSearchButton.Text = "Search";
            this.nameSearchButton.UseVisualStyleBackColor = false;
            this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNameTextBox.Location = new System.Drawing.Point(179, 94);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(255, 30);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNameTextBox.Location = new System.Drawing.Point(179, 47);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(255, 30);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.firstNameLabel.Location = new System.Drawing.Point(19, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(92, 22);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LastNameLabel.Location = new System.Drawing.Point(19, 94);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(91, 22);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.nameResultLabel);
            this.nameGroupBox.Controls.Add(this.nameSearchButton);
            this.nameGroupBox.Controls.Add(this.lastNameTextBox);
            this.nameGroupBox.Controls.Add(this.firstNameTextBox);
            this.nameGroupBox.Controls.Add(this.firstNameLabel);
            this.nameGroupBox.Controls.Add(this.LastNameLabel);
            this.nameGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameGroupBox.Location = new System.Drawing.Point(15, 289);
            this.nameGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameGroupBox.Size = new System.Drawing.Size(456, 207);
            this.nameGroupBox.TabIndex = 29;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Look up by Name";
            // 
            // findExistingEmployeeLabel
            // 
            this.findExistingEmployeeLabel.AutoSize = true;
            this.findExistingEmployeeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findExistingEmployeeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findExistingEmployeeLabel.Location = new System.Drawing.Point(43, 23);
            this.findExistingEmployeeLabel.Name = "findExistingEmployeeLabel";
            this.findExistingEmployeeLabel.Size = new System.Drawing.Size(455, 51);
            this.findExistingEmployeeLabel.TabIndex = 0;
            this.findExistingEmployeeLabel.Text = "Find an Existing Employee";
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.findExistingEmployeeLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1439, 85);
            this.topPanel.TabIndex = 28;
            // 
            // employeeInfoDataGridView
            // 
            this.employeeInfoDataGridView.AllowUserToAddRows = false;
            this.employeeInfoDataGridView.AllowUserToDeleteRows = false;
            this.employeeInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeeInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeInfoDataGridView.Location = new System.Drawing.Point(505, 134);
            this.employeeInfoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.employeeInfoDataGridView.Name = "employeeInfoDataGridView";
            this.employeeInfoDataGridView.Size = new System.Drawing.Size(1099, 724);
            this.employeeInfoDataGridView.TabIndex = 27;
            this.employeeInfoDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeInfoDataGridView_CellValueChanged);
            this.employeeInfoDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.employeeInfoDataGridView_EditingControlShowing);
            // 
            // FindEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1439, 901);
            this.Controls.Add(this.employeeInfoDataGridView);
            this.Controls.Add(this.employeeIDGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindEmployee";
            this.Text = "FindEmployee";
            this.employeeIDGroupBox.ResumeLayout(false);
            this.employeeIDGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label employeeIDResultLabel;
        private System.Windows.Forms.Button employeeIDSearchButton;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.GroupBox employeeIDGroupBox;
        private System.Windows.Forms.TextBox employeeIDTextbox;
        private System.Windows.Forms.Label sinResultLabel;
        private System.Windows.Forms.Button sinSearchButton;
        private System.Windows.Forms.TextBox sinTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label phoneNumResultLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button phoneNumSearchButton;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label nameResultLabel;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.Label findExistingEmployeeLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.DataGridView employeeInfoDataGridView;
    }
}