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
            this.vehicleInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.nameGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.employeeIDGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleInfoDataGridView)).BeginInit();
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
            this.nameGroupBox.Location = new System.Drawing.Point(15, 268);
            this.nameGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameGroupBox.Size = new System.Drawing.Size(456, 207);
            this.nameGroupBox.TabIndex = 37;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Look up by Make and Model";
            // 
            // makeModelResultLabel
            // 
            this.makeModelResultLabel.AutoSize = true;
            this.makeModelResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeModelResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.makeModelResultLabel.Location = new System.Drawing.Point(25, 140);
            this.makeModelResultLabel.Name = "makeModelResultLabel";
            this.makeModelResultLabel.Size = new System.Drawing.Size(0, 22);
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
            this.makeModelSearchButton.Location = new System.Drawing.Point(268, 149);
            this.makeModelSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeModelSearchButton.Name = "makeModelSearchButton";
            this.makeModelSearchButton.Size = new System.Drawing.Size(87, 37);
            this.makeModelSearchButton.TabIndex = 9;
            this.makeModelSearchButton.Text = "Search";
            this.makeModelSearchButton.UseVisualStyleBackColor = false;
            this.makeModelSearchButton.Click += new System.EventHandler(this.makeModelSearchButton_Click);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modelTextBox.Location = new System.Drawing.Point(179, 94);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(255, 30);
            this.modelTextBox.TabIndex = 6;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.makeTextBox.Location = new System.Drawing.Point(179, 47);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(255, 30);
            this.makeTextBox.TabIndex = 5;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.makeLabel.Location = new System.Drawing.Point(19, 47);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(51, 22);
            this.makeLabel.TabIndex = 2;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.modelLabel.Location = new System.Drawing.Point(19, 94);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(58, 22);
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
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1409, 85);
            this.topPanel.TabIndex = 36;
            // 
            // findExistingVehicleLabel
            // 
            this.findExistingVehicleLabel.AutoSize = true;
            this.findExistingVehicleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findExistingVehicleLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findExistingVehicleLabel.Location = new System.Drawing.Point(43, 23);
            this.findExistingVehicleLabel.Name = "findExistingVehicleLabel";
            this.findExistingVehicleLabel.Size = new System.Drawing.Size(414, 51);
            this.findExistingVehicleLabel.TabIndex = 0;
            this.findExistingVehicleLabel.Text = "Find an Existing Vehicle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.licensePlateResultLabel);
            this.groupBox2.Controls.Add(this.licensePlateSearchButton);
            this.groupBox2.Controls.Add(this.licensePlateNumTextBox);
            this.groupBox2.Controls.Add(this.licensePlateNumLabel);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(15, 495);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(460, 156);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up by License Plate";
            // 
            // licensePlateResultLabel
            // 
            this.licensePlateResultLabel.AutoSize = true;
            this.licensePlateResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.licensePlateResultLabel.Location = new System.Drawing.Point(29, 89);
            this.licensePlateResultLabel.Name = "licensePlateResultLabel";
            this.licensePlateResultLabel.Size = new System.Drawing.Size(0, 22);
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
            this.licensePlateSearchButton.Location = new System.Drawing.Point(272, 97);
            this.licensePlateSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.licensePlateSearchButton.Name = "licensePlateSearchButton";
            this.licensePlateSearchButton.Size = new System.Drawing.Size(87, 37);
            this.licensePlateSearchButton.TabIndex = 25;
            this.licensePlateSearchButton.Text = "Search";
            this.licensePlateSearchButton.UseVisualStyleBackColor = false;
            this.licensePlateSearchButton.Click += new System.EventHandler(this.licensePlateSearchButton_Click);
            // 
            // licensePlateNumTextBox
            // 
            this.licensePlateNumTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateNumTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.licensePlateNumTextBox.Location = new System.Drawing.Point(183, 46);
            this.licensePlateNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.licensePlateNumTextBox.Name = "licensePlateNumTextBox";
            this.licensePlateNumTextBox.Size = new System.Drawing.Size(255, 30);
            this.licensePlateNumTextBox.TabIndex = 24;
            // 
            // licensePlateNumLabel
            // 
            this.licensePlateNumLabel.AutoSize = true;
            this.licensePlateNumLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateNumLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.licensePlateNumLabel.Location = new System.Drawing.Point(23, 46);
            this.licensePlateNumLabel.Name = "licensePlateNumLabel";
            this.licensePlateNumLabel.Size = new System.Drawing.Size(140, 22);
            this.licensePlateNumLabel.TabIndex = 23;
            this.licensePlateNumLabel.Text = "License Plate No.";
            // 
            // carIDTextbox
            // 
            this.carIDTextbox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carIDTextbox.Location = new System.Drawing.Point(183, 46);
            this.carIDTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carIDTextbox.Name = "carIDTextbox";
            this.carIDTextbox.Size = new System.Drawing.Size(255, 30);
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
            this.employeeIDGroupBox.Location = new System.Drawing.Point(15, 100);
            this.employeeIDGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeIDGroupBox.Name = "employeeIDGroupBox";
            this.employeeIDGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeIDGroupBox.Size = new System.Drawing.Size(460, 156);
            this.employeeIDGroupBox.TabIndex = 43;
            this.employeeIDGroupBox.TabStop = false;
            this.employeeIDGroupBox.Text = "Look up by Car ID";
            // 
            // carIDResultLabel
            // 
            this.carIDResultLabel.AutoSize = true;
            this.carIDResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carIDResultLabel.Location = new System.Drawing.Point(29, 89);
            this.carIDResultLabel.Name = "carIDResultLabel";
            this.carIDResultLabel.Size = new System.Drawing.Size(0, 22);
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
            this.carIDSearchButton.Location = new System.Drawing.Point(272, 97);
            this.carIDSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carIDSearchButton.Name = "carIDSearchButton";
            this.carIDSearchButton.Size = new System.Drawing.Size(87, 37);
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
            this.carIDLabel.Location = new System.Drawing.Point(23, 46);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(58, 22);
            this.carIDLabel.TabIndex = 23;
            this.carIDLabel.Text = "Car ID";
            // 
            // vehicleInfoDataGridView
            // 
            this.vehicleInfoDataGridView.AllowUserToAddRows = false;
            this.vehicleInfoDataGridView.AllowUserToDeleteRows = false;
            this.vehicleInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vehicleInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleInfoDataGridView.Location = new System.Drawing.Point(499, 111);
            this.vehicleInfoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleInfoDataGridView.Name = "vehicleInfoDataGridView";
            this.vehicleInfoDataGridView.RowHeadersVisible = false;
            this.vehicleInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.vehicleInfoDataGridView.Size = new System.Drawing.Size(1099, 724);
            this.vehicleInfoDataGridView.TabIndex = 44;
            this.vehicleInfoDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleInfoDataGridView_CellValueChanged);
            this.vehicleInfoDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.vehicleInfoDataGridView_EditingControlShowing);
            // 
            // FindVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1409, 885);
            this.Controls.Add(this.vehicleInfoDataGridView);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.employeeIDGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FindVehicle";
            this.Text = "FindVehicle";
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.employeeIDGroupBox.ResumeLayout(false);
            this.employeeIDGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleInfoDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView vehicleInfoDataGridView;
    }
}