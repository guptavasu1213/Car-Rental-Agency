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
            this.customerIDSearchButton = new System.Windows.Forms.Button();
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.nameResultLabel = new System.Windows.Forms.Label();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.findExistingEmployeeLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.employeeIDGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.nameGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIDResultLabel
            // 
            this.employeeIDResultLabel.AutoSize = true;
            this.employeeIDResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeIDResultLabel.Location = new System.Drawing.Point(22, 72);
            this.employeeIDResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeIDResultLabel.Name = "employeeIDResultLabel";
            this.employeeIDResultLabel.Size = new System.Drawing.Size(0, 19);
            this.employeeIDResultLabel.TabIndex = 26;
            this.employeeIDResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employeeIDResultLabel.Visible = false;
            // 
            // customerIDSearchButton
            // 
            this.customerIDSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerIDSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerIDSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerIDSearchButton.Location = new System.Drawing.Point(204, 79);
            this.customerIDSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDSearchButton.Name = "customerIDSearchButton";
            this.customerIDSearchButton.Size = new System.Drawing.Size(65, 30);
            this.customerIDSearchButton.TabIndex = 25;
            this.customerIDSearchButton.Text = "Search";
            this.customerIDSearchButton.UseVisualStyleBackColor = false;
            this.customerIDSearchButton.Click += new System.EventHandler(this.customerIDSearchButton_Click);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerIDLabel.Location = new System.Drawing.Point(17, 37);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(86, 19);
            this.customerIDLabel.TabIndex = 23;
            this.customerIDLabel.Text = "Employee ID";
            // 
            // employeeIDGroupBox
            // 
            this.employeeIDGroupBox.Controls.Add(this.employeeIDResultLabel);
            this.employeeIDGroupBox.Controls.Add(this.customerIDSearchButton);
            this.employeeIDGroupBox.Controls.Add(this.employeeIDTextbox);
            this.employeeIDGroupBox.Controls.Add(this.customerIDLabel);
            this.employeeIDGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeIDGroupBox.Location = new System.Drawing.Point(11, 98);
            this.employeeIDGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeIDGroupBox.Name = "employeeIDGroupBox";
            this.employeeIDGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.employeeIDGroupBox.Size = new System.Drawing.Size(345, 127);
            this.employeeIDGroupBox.TabIndex = 35;
            this.employeeIDGroupBox.TabStop = false;
            this.employeeIDGroupBox.Text = "Look up by Employee ID";
            // 
            // employeeIDTextbox
            // 
            this.employeeIDTextbox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeeIDTextbox.Location = new System.Drawing.Point(137, 37);
            this.employeeIDTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeIDTextbox.Name = "employeeIDTextbox";
            this.employeeIDTextbox.Size = new System.Drawing.Size(192, 26);
            this.employeeIDTextbox.TabIndex = 24;
            // 
            // sinResultLabel
            // 
            this.sinResultLabel.AutoSize = true;
            this.sinResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.sinResultLabel.Location = new System.Drawing.Point(22, 72);
            this.sinResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sinResultLabel.Name = "sinResultLabel";
            this.sinResultLabel.Size = new System.Drawing.Size(0, 19);
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
            this.sinSearchButton.Location = new System.Drawing.Point(204, 79);
            this.sinSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.sinSearchButton.Name = "sinSearchButton";
            this.sinSearchButton.Size = new System.Drawing.Size(65, 30);
            this.sinSearchButton.TabIndex = 25;
            this.sinSearchButton.Text = "Search";
            this.sinSearchButton.UseVisualStyleBackColor = false;
            this.sinSearchButton.Click += new System.EventHandler(this.sinSearchButton_Click);
            // 
            // sinTextBox
            // 
            this.sinTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sinTextBox.Location = new System.Drawing.Point(137, 37);
            this.sinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sinTextBox.Name = "sinTextBox";
            this.sinTextBox.Size = new System.Drawing.Size(192, 26);
            this.sinTextBox.TabIndex = 24;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.emailLabel.Location = new System.Drawing.Point(17, 37);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(30, 19);
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
            this.groupBox2.Location = new System.Drawing.Point(11, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(345, 127);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up by SIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(19, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 564);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(345, 133);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Look up by Phone Number";
            // 
            // phoneNumResultLabel
            // 
            this.phoneNumResultLabel.AutoSize = true;
            this.phoneNumResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumResultLabel.Location = new System.Drawing.Point(18, 73);
            this.phoneNumResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumResultLabel.Name = "phoneNumResultLabel";
            this.phoneNumResultLabel.Size = new System.Drawing.Size(0, 19);
            this.phoneNumResultLabel.TabIndex = 20;
            this.phoneNumResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.phoneNumResultLabel.Visible = false;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(133, 38);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(192, 26);
            this.phoneNumberTextBox.TabIndex = 7;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTextBox_KeyPress);
            // 
            // phoneNumSearchButton
            // 
            this.phoneNumSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneNumSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.phoneNumSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumSearchButton.Location = new System.Drawing.Point(200, 80);
            this.phoneNumSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumSearchButton.Name = "phoneNumSearchButton";
            this.phoneNumSearchButton.Size = new System.Drawing.Size(65, 30);
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
            this.phoneNumberLabel.Location = new System.Drawing.Point(13, 38);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(102, 19);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteButton.Location = new System.Drawing.Point(823, 98);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(182, 30);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateButton.Location = new System.Drawing.Point(383, 98);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(182, 30);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(383, 145);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(622, 552);
            this.userDataGridView.TabIndex = 30;
            // 
            // nameResultLabel
            // 
            this.nameResultLabel.AutoSize = true;
            this.nameResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameResultLabel.Location = new System.Drawing.Point(19, 114);
            this.nameResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameResultLabel.Name = "nameResultLabel";
            this.nameResultLabel.Size = new System.Drawing.Size(0, 19);
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
            this.nameSearchButton.Location = new System.Drawing.Point(201, 121);
            this.nameSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(65, 30);
            this.nameSearchButton.TabIndex = 9;
            this.nameSearchButton.Text = "Search";
            this.nameSearchButton.UseVisualStyleBackColor = false;
            this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNameTextBox.Location = new System.Drawing.Point(134, 76);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(192, 26);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNameTextBox.Location = new System.Drawing.Point(134, 38);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(192, 26);
            this.firstNameTextBox.TabIndex = 5;
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
            this.nameGroupBox.Location = new System.Drawing.Point(11, 235);
            this.nameGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.nameGroupBox.Size = new System.Drawing.Size(342, 168);
            this.nameGroupBox.TabIndex = 29;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Look up by Name";
            // 
            // findExistingEmployeeLabel
            // 
            this.findExistingEmployeeLabel.AutoSize = true;
            this.findExistingEmployeeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findExistingEmployeeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findExistingEmployeeLabel.Location = new System.Drawing.Point(32, 19);
            this.findExistingEmployeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findExistingEmployeeLabel.Name = "findExistingEmployeeLabel";
            this.findExistingEmployeeLabel.Size = new System.Drawing.Size(362, 40);
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
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1079, 69);
            this.topPanel.TabIndex = 28;
            // 
            // FindEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1079, 732);
            this.Controls.Add(this.employeeIDGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.topPanel);
            this.Name = "FindEmployee";
            this.Text = "FindEmployee";
            this.employeeIDGroupBox.ResumeLayout(false);
            this.employeeIDGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label employeeIDResultLabel;
        private System.Windows.Forms.Button customerIDSearchButton;
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
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Label nameResultLabel;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.Label findExistingEmployeeLabel;
        private System.Windows.Forms.Panel topPanel;
    }
}