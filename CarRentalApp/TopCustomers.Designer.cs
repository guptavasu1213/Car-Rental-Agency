namespace CarRentalApp
{
    partial class TopCustomers
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
            this.specificSearchErrorLabel = new System.Windows.Forms.Label();
            this.searchSpecificButton = new System.Windows.Forms.Button();
            this.findTopCustomersLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.branchLabel = new System.Windows.Forms.Label();
            this.specificParamGroupBox = new System.Windows.Forms.GroupBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topEmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.specificParamGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topEmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // specificSearchErrorLabel
            // 
            this.specificSearchErrorLabel.AutoSize = true;
            this.specificSearchErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.specificSearchErrorLabel.Location = new System.Drawing.Point(9, 249);
            this.specificSearchErrorLabel.Name = "specificSearchErrorLabel";
            this.specificSearchErrorLabel.Size = new System.Drawing.Size(336, 22);
            this.specificSearchErrorLabel.TabIndex = 10;
            this.specificSearchErrorLabel.Text = "Error: Please search by only one parameter";
            this.specificSearchErrorLabel.Visible = false;
            // 
            // searchSpecificButton
            // 
            this.searchSpecificButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchSpecificButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchSpecificButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSpecificButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchSpecificButton.Location = new System.Drawing.Point(99, 292);
            this.searchSpecificButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchSpecificButton.Name = "searchSpecificButton";
            this.searchSpecificButton.Size = new System.Drawing.Size(172, 37);
            this.searchSpecificButton.TabIndex = 8;
            this.searchSpecificButton.Text = "Search";
            this.searchSpecificButton.UseVisualStyleBackColor = false;
            this.searchSpecificButton.Click += new System.EventHandler(this.searchSpecificButton_Click);
            // 
            // findTopCustomersLabel
            // 
            this.findTopCustomersLabel.AutoSize = true;
            this.findTopCustomersLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTopCustomersLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findTopCustomersLabel.Location = new System.Drawing.Point(43, 23);
            this.findTopCustomersLabel.Name = "findTopCustomersLabel";
            this.findTopCustomersLabel.Size = new System.Drawing.Size(357, 51);
            this.findTopCustomersLabel.TabIndex = 0;
            this.findTopCustomersLabel.Text = "Find Top Customers";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cityTextBox.Location = new System.Drawing.Point(103, 80);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(175, 30);
            this.cityTextBox.TabIndex = 5;
            // 
            // branchTextBox
            // 
            this.branchTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.branchTextBox.Location = new System.Drawing.Point(103, 44);
            this.branchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(175, 30);
            this.branchTextBox.TabIndex = 4;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.countryLabel.Location = new System.Drawing.Point(19, 160);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(71, 22);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cityLabel.Location = new System.Drawing.Point(19, 82);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 22);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.provinceLabel.Location = new System.Drawing.Point(19, 124);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(75, 22);
            this.provinceLabel.TabIndex = 1;
            this.provinceLabel.Text = "Province";
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchLabel.Location = new System.Drawing.Point(19, 44);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(68, 22);
            this.branchLabel.TabIndex = 0;
            this.branchLabel.Text = "Branch ";
            // 
            // specificParamGroupBox
            // 
            this.specificParamGroupBox.Controls.Add(this.countryTextBox);
            this.specificParamGroupBox.Controls.Add(this.provinceTextBox);
            this.specificParamGroupBox.Controls.Add(this.cityTextBox);
            this.specificParamGroupBox.Controls.Add(this.branchTextBox);
            this.specificParamGroupBox.Controls.Add(this.countryLabel);
            this.specificParamGroupBox.Controls.Add(this.cityLabel);
            this.specificParamGroupBox.Controls.Add(this.provinceLabel);
            this.specificParamGroupBox.Controls.Add(this.branchLabel);
            this.specificParamGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificParamGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.specificParamGroupBox.Location = new System.Drawing.Point(30, 28);
            this.specificParamGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specificParamGroupBox.Name = "specificParamGroupBox";
            this.specificParamGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specificParamGroupBox.Size = new System.Drawing.Size(311, 218);
            this.specificParamGroupBox.TabIndex = 2;
            this.specificParamGroupBox.TabStop = false;
            this.specificParamGroupBox.Text = "Search by only one parameter";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.countryTextBox.Location = new System.Drawing.Point(103, 160);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(175, 30);
            this.countryTextBox.TabIndex = 7;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.provinceTextBox.Location = new System.Drawing.Point(103, 119);
            this.provinceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(175, 30);
            this.provinceTextBox.TabIndex = 6;
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.findTopCustomersLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1624, 85);
            this.topPanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.specificSearchErrorLabel);
            this.panel1.Controls.Add(this.searchSpecificButton);
            this.panel1.Controls.Add(this.specificParamGroupBox);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 363);
            this.panel1.TabIndex = 12;
            // 
            // topEmployeeDataGridView
            // 
            this.topEmployeeDataGridView.AllowUserToAddRows = false;
            this.topEmployeeDataGridView.AllowUserToDeleteRows = false;
            this.topEmployeeDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topEmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topEmployeeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.topEmployeeDataGridView.Location = new System.Drawing.Point(416, 91);
            this.topEmployeeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.topEmployeeDataGridView.Name = "topEmployeeDataGridView";
            this.topEmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.topEmployeeDataGridView.Size = new System.Drawing.Size(1099, 724);
            this.topEmployeeDataGridView.TabIndex = 31;
            // 
            // TopCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1624, 878);
            this.Controls.Add(this.topEmployeeDataGridView);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TopCustomers";
            this.Text = "FindTop100Customers";
            this.specificParamGroupBox.ResumeLayout(false);
            this.specificParamGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topEmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label specificSearchErrorLabel;
        private System.Windows.Forms.Button searchSpecificButton;
        private System.Windows.Forms.Label findTopCustomersLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.GroupBox specificParamGroupBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView topEmployeeDataGridView;
    }
}