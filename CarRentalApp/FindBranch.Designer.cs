namespace CarRentalApp
{
    partial class FindBranch
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
            this.branchIDResultLabel = new System.Windows.Forms.Label();
            this.branchIDTextbox = new System.Windows.Forms.TextBox();
            this.carIDLabel = new System.Windows.Forms.Label();
            this.branchNameResultLabel = new System.Windows.Forms.Label();
            this.branchNameSearchButton = new System.Windows.Forms.Button();
            this.branchNameTextBox = new System.Windows.Forms.TextBox();
            this.branchNameLabel = new System.Windows.Forms.Label();
            this.branchIDSearchButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.findExistingVehicleLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employeeIDGroupBox = new System.Windows.Forms.GroupBox();
            this.branchInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.employeeIDGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // branchIDResultLabel
            // 
            this.branchIDResultLabel.AutoSize = true;
            this.branchIDResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchIDResultLabel.Location = new System.Drawing.Point(22, 72);
            this.branchIDResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branchIDResultLabel.Name = "branchIDResultLabel";
            this.branchIDResultLabel.Size = new System.Drawing.Size(0, 19);
            this.branchIDResultLabel.TabIndex = 26;
            this.branchIDResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.branchIDResultLabel.Visible = false;
            // 
            // branchIDTextbox
            // 
            this.branchIDTextbox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.branchIDTextbox.Location = new System.Drawing.Point(137, 37);
            this.branchIDTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.branchIDTextbox.Name = "branchIDTextbox";
            this.branchIDTextbox.Size = new System.Drawing.Size(192, 26);
            this.branchIDTextbox.TabIndex = 24;
            this.branchIDTextbox.TextChanged += new System.EventHandler(this.branchIDTextbox_TextChanged);
            this.branchIDTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // carIDLabel
            // 
            this.carIDLabel.AutoSize = true;
            this.carIDLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carIDLabel.Location = new System.Drawing.Point(17, 37);
            this.carIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(69, 19);
            this.carIDLabel.TabIndex = 23;
            this.carIDLabel.Text = "Branch ID";
            // 
            // branchNameResultLabel
            // 
            this.branchNameResultLabel.AutoSize = true;
            this.branchNameResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNameResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchNameResultLabel.Location = new System.Drawing.Point(22, 72);
            this.branchNameResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branchNameResultLabel.Name = "branchNameResultLabel";
            this.branchNameResultLabel.Size = new System.Drawing.Size(0, 19);
            this.branchNameResultLabel.TabIndex = 26;
            this.branchNameResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.branchNameResultLabel.Visible = false;
            // 
            // branchNameSearchButton
            // 
            this.branchNameSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.branchNameSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.branchNameSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNameSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchNameSearchButton.Location = new System.Drawing.Point(204, 79);
            this.branchNameSearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.branchNameSearchButton.Name = "branchNameSearchButton";
            this.branchNameSearchButton.Size = new System.Drawing.Size(65, 30);
            this.branchNameSearchButton.TabIndex = 25;
            this.branchNameSearchButton.Text = "Search";
            this.branchNameSearchButton.UseVisualStyleBackColor = false;
            this.branchNameSearchButton.Click += new System.EventHandler(this.branchNameSearchButton_Click);
            // 
            // branchNameTextBox
            // 
            this.branchNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.branchNameTextBox.Location = new System.Drawing.Point(137, 37);
            this.branchNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.branchNameTextBox.Name = "branchNameTextBox";
            this.branchNameTextBox.Size = new System.Drawing.Size(192, 26);
            this.branchNameTextBox.TabIndex = 24;
            // 
            // branchNameLabel
            // 
            this.branchNameLabel.AutoSize = true;
            this.branchNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchNameLabel.Location = new System.Drawing.Point(17, 37);
            this.branchNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branchNameLabel.Name = "branchNameLabel";
            this.branchNameLabel.Size = new System.Drawing.Size(91, 19);
            this.branchNameLabel.TabIndex = 23;
            this.branchNameLabel.Text = "Branch Name";
            // 
            // branchIDSearchButton
            // 
            this.branchIDSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.branchIDSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.branchIDSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchIDSearchButton.Location = new System.Drawing.Point(204, 79);
            this.branchIDSearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.branchIDSearchButton.Name = "branchIDSearchButton";
            this.branchIDSearchButton.Size = new System.Drawing.Size(65, 30);
            this.branchIDSearchButton.TabIndex = 25;
            this.branchIDSearchButton.Text = "Search";
            this.branchIDSearchButton.UseVisualStyleBackColor = false;
            this.branchIDSearchButton.Click += new System.EventHandler(this.branchIDSearchButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.findExistingVehicleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1330, 69);
            this.topPanel.TabIndex = 44;
            // 
            // findExistingVehicleLabel
            // 
            this.findExistingVehicleLabel.AutoSize = true;
            this.findExistingVehicleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findExistingVehicleLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findExistingVehicleLabel.Location = new System.Drawing.Point(32, 19);
            this.findExistingVehicleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findExistingVehicleLabel.Name = "findExistingVehicleLabel";
            this.findExistingVehicleLabel.Size = new System.Drawing.Size(173, 40);
            this.findExistingVehicleLabel.TabIndex = 0;
            this.findExistingVehicleLabel.Text = "Find branch";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.branchNameResultLabel);
            this.groupBox2.Controls.Add(this.branchNameSearchButton);
            this.groupBox2.Controls.Add(this.branchNameTextBox);
            this.groupBox2.Controls.Add(this.branchNameLabel);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(11, 226);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(345, 127);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up by Name";
            // 
            // employeeIDGroupBox
            // 
            this.employeeIDGroupBox.Controls.Add(this.branchIDResultLabel);
            this.employeeIDGroupBox.Controls.Add(this.branchIDSearchButton);
            this.employeeIDGroupBox.Controls.Add(this.branchIDTextbox);
            this.employeeIDGroupBox.Controls.Add(this.carIDLabel);
            this.employeeIDGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeIDGroupBox.Location = new System.Drawing.Point(11, 73);
            this.employeeIDGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeIDGroupBox.Name = "employeeIDGroupBox";
            this.employeeIDGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeIDGroupBox.Size = new System.Drawing.Size(345, 127);
            this.employeeIDGroupBox.TabIndex = 50;
            this.employeeIDGroupBox.TabStop = false;
            this.employeeIDGroupBox.Text = "Look up by Branch ID";
            // 
            // branchInfoDataGridView
            // 
            this.branchInfoDataGridView.AllowUserToAddRows = false;
            this.branchInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.branchInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchInfoDataGridView.Location = new System.Drawing.Point(371, 82);
            this.branchInfoDataGridView.Name = "branchInfoDataGridView";
            this.branchInfoDataGridView.Size = new System.Drawing.Size(824, 588);
            this.branchInfoDataGridView.TabIndex = 51;
            this.branchInfoDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.branchInfoDataGridView_CellValueChanged);
            this.branchInfoDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.branchInfoDataGridView_EditingControlShowing);
            // 
            // FindBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1330, 739);
            this.Controls.Add(this.branchInfoDataGridView);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.employeeIDGroupBox);
            this.Name = "FindBranch";
            this.Text = "FindBranch";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.employeeIDGroupBox.ResumeLayout(false);
            this.employeeIDGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label branchIDResultLabel;
        private System.Windows.Forms.TextBox branchIDTextbox;
        private System.Windows.Forms.Label carIDLabel;
        private System.Windows.Forms.Label branchNameResultLabel;
        private System.Windows.Forms.Button branchNameSearchButton;
        private System.Windows.Forms.TextBox branchNameTextBox;
        private System.Windows.Forms.Label branchNameLabel;
        private System.Windows.Forms.Button branchIDSearchButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label findExistingVehicleLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox employeeIDGroupBox;
        private System.Windows.Forms.DataGridView branchInfoDataGridView;
    }
}