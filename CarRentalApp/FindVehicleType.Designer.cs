namespace CarRentalApp
{
    partial class FindVehicleType
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
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeResultLabel = new System.Windows.Forms.Label();
            this.typeTextbox = new System.Windows.Forms.TextBox();
            this.branchNameResultLabel = new System.Windows.Forms.Label();
            this.branchNameSearchButton = new System.Windows.Forms.Button();
            this.branchNameLabel = new System.Windows.Forms.Label();
            this.typeSearchButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.findExistingVehicleLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.branchNameTextBox = new System.Windows.Forms.TextBox();
            this.typeIDGroupBox = new System.Windows.Forms.GroupBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.typeIDGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.typeLabel.Location = new System.Drawing.Point(17, 37);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(78, 19);
            this.typeLabel.TabIndex = 23;
            this.typeLabel.Text = "Type Name";
            // 
            // typeResultLabel
            // 
            this.typeResultLabel.AutoSize = true;
            this.typeResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.typeResultLabel.Location = new System.Drawing.Point(22, 72);
            this.typeResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeResultLabel.Name = "typeResultLabel";
            this.typeResultLabel.Size = new System.Drawing.Size(0, 19);
            this.typeResultLabel.TabIndex = 26;
            this.typeResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.typeResultLabel.Visible = false;
            // 
            // typeTextbox
            // 
            this.typeTextbox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.typeTextbox.Location = new System.Drawing.Point(137, 37);
            this.typeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.typeTextbox.Name = "typeTextbox";
            this.typeTextbox.Size = new System.Drawing.Size(192, 26);
            this.typeTextbox.TabIndex = 24;
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
            this.branchNameSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.branchNameSearchButton.Name = "branchNameSearchButton";
            this.branchNameSearchButton.Size = new System.Drawing.Size(65, 30);
            this.branchNameSearchButton.TabIndex = 25;
            this.branchNameSearchButton.Text = "Search";
            this.branchNameSearchButton.UseVisualStyleBackColor = false;
            this.branchNameSearchButton.Click += new System.EventHandler(this.branchNameSearchButton_Click);
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
            // typeSearchButton
            // 
            this.typeSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typeSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.typeSearchButton.Location = new System.Drawing.Point(204, 79);
            this.typeSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.typeSearchButton.Name = "typeSearchButton";
            this.typeSearchButton.Size = new System.Drawing.Size(65, 30);
            this.typeSearchButton.TabIndex = 25;
            this.typeSearchButton.Text = "Search";
            this.typeSearchButton.UseVisualStyleBackColor = false;
            this.typeSearchButton.Click += new System.EventHandler(this.typeSearchButton_Click);
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
            this.topPanel.Size = new System.Drawing.Size(1112, 69);
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
            this.findExistingVehicleLabel.Size = new System.Drawing.Size(400, 40);
            this.findExistingVehicleLabel.TabIndex = 0;
            this.findExistingVehicleLabel.Text = "Find an Existing Vehicle Type";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateButton.Location = new System.Drawing.Point(383, 120);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(182, 30);
            this.updateButton.TabIndex = 48;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(383, 167);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(622, 401);
            this.userDataGridView.TabIndex = 46;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteButton.Location = new System.Drawing.Point(823, 120);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(182, 30);
            this.deleteButton.TabIndex = 49;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.branchNameResultLabel);
            this.groupBox2.Controls.Add(this.branchNameSearchButton);
            this.groupBox2.Controls.Add(this.branchNameTextBox);
            this.groupBox2.Controls.Add(this.branchNameLabel);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(11, 271);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(345, 127);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up by Branch";
            // 
            // branchNameTextBox
            // 
            this.branchNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.branchNameTextBox.Location = new System.Drawing.Point(137, 37);
            this.branchNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.branchNameTextBox.Name = "branchNameTextBox";
            this.branchNameTextBox.Size = new System.Drawing.Size(192, 26);
            this.branchNameTextBox.TabIndex = 24;
            // 
            // typeIDGroupBox
            // 
            this.typeIDGroupBox.Controls.Add(this.typeResultLabel);
            this.typeIDGroupBox.Controls.Add(this.typeSearchButton);
            this.typeIDGroupBox.Controls.Add(this.typeTextbox);
            this.typeIDGroupBox.Controls.Add(this.typeLabel);
            this.typeIDGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeIDGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.typeIDGroupBox.Location = new System.Drawing.Point(11, 120);
            this.typeIDGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeIDGroupBox.Name = "typeIDGroupBox";
            this.typeIDGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.typeIDGroupBox.Size = new System.Drawing.Size(345, 127);
            this.typeIDGroupBox.TabIndex = 50;
            this.typeIDGroupBox.TabStop = false;
            this.typeIDGroupBox.Text = "Look up by Type Name";
            // 
            // FindVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1112, 607);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.typeIDGroupBox);
            this.Name = "FindVehicleType";
            this.Text = "FindVehicleType";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.typeIDGroupBox.ResumeLayout(false);
            this.typeIDGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label typeResultLabel;
        private System.Windows.Forms.TextBox typeTextbox;
        private System.Windows.Forms.Label branchNameResultLabel;
        private System.Windows.Forms.Button branchNameSearchButton;
        private System.Windows.Forms.Label branchNameLabel;
        private System.Windows.Forms.Button typeSearchButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label findExistingVehicleLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox branchNameTextBox;
        private System.Windows.Forms.GroupBox typeIDGroupBox;
    }
}