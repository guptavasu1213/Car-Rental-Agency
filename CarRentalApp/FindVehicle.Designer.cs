namespace CarRentalApp
{
    partial class FindVehicle
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
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.makeModelResultLabel = new System.Windows.Forms.Label();
            this.makeModelSearchButton = new System.Windows.Forms.Button();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.findExistingVehicleLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.licensePlateResultLabel = new System.Windows.Forms.Label();
            this.licensePlateSearchButton = new System.Windows.Forms.Button();
            this.licensePlateNumTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateNumLabel = new System.Windows.Forms.Label();
            this.carIDTextbox = new System.Windows.Forms.TextBox();
            this.employeeIDGroupBox = new System.Windows.Forms.GroupBox();
            this.carIDResultLabel = new System.Windows.Forms.Label();
            this.carIDSearchButton = new System.Windows.Forms.Button();
            this.carIDLabel = new System.Windows.Forms.Label();
            this.nameGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.employeeIDGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.makeModelResultLabel);
            this.nameGroupBox.Controls.Add(this.makeModelSearchButton);
            this.nameGroupBox.Controls.Add(this.modelTextBox);
            this.nameGroupBox.Controls.Add(this.makeTextBox);
            this.nameGroupBox.Controls.Add(this.makeLabel);
            this.nameGroupBox.Controls.Add(this.modelLabel);
            this.nameGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameGroupBox.Location = new System.Drawing.Point(11, 218);
            this.nameGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.nameGroupBox.Size = new System.Drawing.Size(342, 168);
            this.nameGroupBox.TabIndex = 37;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Look up by Make and Model";
            // 
            // makeModelResultLabel
            // 
            this.makeModelResultLabel.AutoSize = true;
            this.makeModelResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeModelResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.makeModelResultLabel.Location = new System.Drawing.Point(19, 114);
            this.makeModelResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeModelResultLabel.Name = "makeModelResultLabel";
            this.makeModelResultLabel.Size = new System.Drawing.Size(0, 19);
            this.makeModelResultLabel.TabIndex = 18;
            this.makeModelResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.makeModelResultLabel.Visible = false;
            // 
            // makeModelSearchButton
            // 
            this.makeModelSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.makeModelSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makeModelSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeModelSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.makeModelSearchButton.Location = new System.Drawing.Point(201, 121);
            this.makeModelSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.makeModelSearchButton.Name = "makeModelSearchButton";
            this.makeModelSearchButton.Size = new System.Drawing.Size(65, 30);
            this.makeModelSearchButton.TabIndex = 9;
            this.makeModelSearchButton.Text = "Search";
            this.makeModelSearchButton.UseVisualStyleBackColor = false;
            this.makeModelSearchButton.Click += new System.EventHandler(this.makeModelSearchButton_Click);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modelTextBox.Location = new System.Drawing.Point(134, 76);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(192, 26);
            this.modelTextBox.TabIndex = 6;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.makeTextBox.Location = new System.Drawing.Point(134, 38);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(192, 26);
            this.makeTextBox.TabIndex = 5;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.makeLabel.Location = new System.Drawing.Point(14, 38);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(43, 19);
            this.makeLabel.TabIndex = 2;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.modelLabel.Location = new System.Drawing.Point(14, 76);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(48, 19);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model";
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.findExistingVehicleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1057, 69);
            this.topPanel.TabIndex = 36;
            // 
            // findExistingVehicleLabel
            // 
            this.findExistingVehicleLabel.AutoSize = true;
            this.findExistingVehicleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findExistingVehicleLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findExistingVehicleLabel.Location = new System.Drawing.Point(32, 19);
            this.findExistingVehicleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findExistingVehicleLabel.Name = "findExistingVehicleLabel";
            this.findExistingVehicleLabel.Size = new System.Drawing.Size(327, 40);
            this.findExistingVehicleLabel.TabIndex = 0;
            this.findExistingVehicleLabel.Text = "Find an Existing Vehicle";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateButton.Location = new System.Drawing.Point(383, 81);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(182, 30);
            this.updateButton.TabIndex = 41;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(383, 128);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(622, 401);
            this.userDataGridView.TabIndex = 38;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteButton.Location = new System.Drawing.Point(823, 81);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(182, 30);
            this.deleteButton.TabIndex = 42;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.licensePlateResultLabel);
            this.groupBox2.Controls.Add(this.licensePlateSearchButton);
            this.groupBox2.Controls.Add(this.licensePlateNumTextBox);
            this.groupBox2.Controls.Add(this.licensePlateNumLabel);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(11, 402);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(345, 127);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up by License Plate";
            // 
            // licensePlateResultLabel
            // 
            this.licensePlateResultLabel.AutoSize = true;
            this.licensePlateResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.licensePlateResultLabel.Location = new System.Drawing.Point(22, 72);
            this.licensePlateResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licensePlateResultLabel.Name = "licensePlateResultLabel";
            this.licensePlateResultLabel.Size = new System.Drawing.Size(0, 19);
            this.licensePlateResultLabel.TabIndex = 26;
            this.licensePlateResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.licensePlateResultLabel.Visible = false;
            // 
            // licensePlateSearchButton
            // 
            this.licensePlateSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.licensePlateSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.licensePlateSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.licensePlateSearchButton.Location = new System.Drawing.Point(204, 79);
            this.licensePlateSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.licensePlateSearchButton.Name = "licensePlateSearchButton";
            this.licensePlateSearchButton.Size = new System.Drawing.Size(65, 30);
            this.licensePlateSearchButton.TabIndex = 25;
            this.licensePlateSearchButton.Text = "Search";
            this.licensePlateSearchButton.UseVisualStyleBackColor = false;
            this.licensePlateSearchButton.Click += new System.EventHandler(this.licensePlateSearchButton_Click);
            // 
            // licensePlateNumTextBox
            // 
            this.licensePlateNumTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateNumTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.licensePlateNumTextBox.Location = new System.Drawing.Point(137, 37);
            this.licensePlateNumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.licensePlateNumTextBox.Name = "licensePlateNumTextBox";
            this.licensePlateNumTextBox.Size = new System.Drawing.Size(192, 26);
            this.licensePlateNumTextBox.TabIndex = 24;
            // 
            // licensePlateNumLabel
            // 
            this.licensePlateNumLabel.AutoSize = true;
            this.licensePlateNumLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateNumLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.licensePlateNumLabel.Location = new System.Drawing.Point(17, 37);
            this.licensePlateNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licensePlateNumLabel.Name = "licensePlateNumLabel";
            this.licensePlateNumLabel.Size = new System.Drawing.Size(112, 19);
            this.licensePlateNumLabel.TabIndex = 23;
            this.licensePlateNumLabel.Text = "License Plate No.";
            // 
            // carIDTextbox
            // 
            this.carIDTextbox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carIDTextbox.Location = new System.Drawing.Point(137, 37);
            this.carIDTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.carIDTextbox.Name = "carIDTextbox";
            this.carIDTextbox.Size = new System.Drawing.Size(192, 26);
            this.carIDTextbox.TabIndex = 24;
            // 
            // employeeIDGroupBox
            // 
            this.employeeIDGroupBox.Controls.Add(this.carIDResultLabel);
            this.employeeIDGroupBox.Controls.Add(this.carIDSearchButton);
            this.employeeIDGroupBox.Controls.Add(this.carIDTextbox);
            this.employeeIDGroupBox.Controls.Add(this.carIDLabel);
            this.employeeIDGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeIDGroupBox.Location = new System.Drawing.Point(11, 81);
            this.employeeIDGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeIDGroupBox.Name = "employeeIDGroupBox";
            this.employeeIDGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.employeeIDGroupBox.Size = new System.Drawing.Size(345, 127);
            this.employeeIDGroupBox.TabIndex = 43;
            this.employeeIDGroupBox.TabStop = false;
            this.employeeIDGroupBox.Text = "Look up by Car ID";
            // 
            // carIDResultLabel
            // 
            this.carIDResultLabel.AutoSize = true;
            this.carIDResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carIDResultLabel.Location = new System.Drawing.Point(22, 72);
            this.carIDResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carIDResultLabel.Name = "carIDResultLabel";
            this.carIDResultLabel.Size = new System.Drawing.Size(0, 19);
            this.carIDResultLabel.TabIndex = 26;
            this.carIDResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carIDResultLabel.Visible = false;
            // 
            // carIDSearchButton
            // 
            this.carIDSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carIDSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carIDSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carIDSearchButton.Location = new System.Drawing.Point(204, 79);
            this.carIDSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.carIDSearchButton.Name = "carIDSearchButton";
            this.carIDSearchButton.Size = new System.Drawing.Size(65, 30);
            this.carIDSearchButton.TabIndex = 25;
            this.carIDSearchButton.Text = "Search";
            this.carIDSearchButton.UseVisualStyleBackColor = false;
            this.carIDSearchButton.Click += new System.EventHandler(this.carIDSearchButton_Click);
            // 
            // carIDLabel
            // 
            this.carIDLabel.AutoSize = true;
            this.carIDLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carIDLabel.Location = new System.Drawing.Point(17, 37);
            this.carIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(48, 19);
            this.carIDLabel.TabIndex = 23;
            this.carIDLabel.Text = "Car ID";
            // 
            // FindVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1057, 719);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.employeeIDGroupBox);
            this.Name = "FindVehicle";
            this.Text = "FindVehicle";
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.employeeIDGroupBox.ResumeLayout(false);
            this.employeeIDGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.Label makeModelResultLabel;
        private System.Windows.Forms.Button makeModelSearchButton;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label findExistingVehicleLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label licensePlateResultLabel;
        private System.Windows.Forms.Button licensePlateSearchButton;
        private System.Windows.Forms.TextBox licensePlateNumTextBox;
        private System.Windows.Forms.Label licensePlateNumLabel;
        private System.Windows.Forms.TextBox carIDTextbox;
        private System.Windows.Forms.GroupBox employeeIDGroupBox;
        private System.Windows.Forms.Label carIDResultLabel;
        private System.Windows.Forms.Button carIDSearchButton;
        private System.Windows.Forms.Label carIDLabel;
    }
}