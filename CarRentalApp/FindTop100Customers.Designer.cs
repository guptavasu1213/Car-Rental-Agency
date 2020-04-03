namespace CarRentalApp
{
    partial class FindTop100Customers
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
            this.branchRadio = new System.Windows.Forms.RadioButton();
            this.cityRadio = new System.Windows.Forms.RadioButton();
            this.provinceRadio = new System.Windows.Forms.RadioButton();
            this.countryRadio = new System.Windows.Forms.RadioButton();
            this.selectionFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.searchEveryButton = new System.Windows.Forms.Button();
            this.everySearchErrorLabel = new System.Windows.Forms.Label();
            this.specificParamGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topEmployeeDataGridView)).BeginInit();
            this.selectionFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // specificSearchErrorLabel
            // 
            this.specificSearchErrorLabel.AutoSize = true;
            this.specificSearchErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.specificSearchErrorLabel.Location = new System.Drawing.Point(19, 510);
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
            this.searchSpecificButton.Location = new System.Drawing.Point(109, 553);
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
            this.specificParamGroupBox.Location = new System.Drawing.Point(40, 289);
            this.specificParamGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specificParamGroupBox.Name = "specificParamGroupBox";
            this.specificParamGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specificParamGroupBox.Size = new System.Drawing.Size(311, 218);
            this.specificParamGroupBox.TabIndex = 2;
            this.specificParamGroupBox.TabStop = false;
            this.specificParamGroupBox.Text = "Searching by a specific parameter?";
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
            this.panel1.Controls.Add(this.everySearchErrorLabel);
            this.panel1.Controls.Add(this.searchSpecificButton);
            this.panel1.Controls.Add(this.searchEveryButton);
            this.panel1.Controls.Add(this.selectionFilterGroupBox);
            this.panel1.Controls.Add(this.specificParamGroupBox);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 647);
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
            // branchRadio
            // 
            this.branchRadio.AutoSize = true;
            this.branchRadio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchRadio.Location = new System.Drawing.Point(21, 33);
            this.branchRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.branchRadio.Name = "branchRadio";
            this.branchRadio.Size = new System.Drawing.Size(84, 26);
            this.branchRadio.TabIndex = 0;
            this.branchRadio.TabStop = true;
            this.branchRadio.Text = "Branch";
            this.branchRadio.UseVisualStyleBackColor = true;
            // 
            // cityRadio
            // 
            this.cityRadio.AutoSize = true;
            this.cityRadio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cityRadio.Location = new System.Drawing.Point(21, 62);
            this.cityRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityRadio.Name = "cityRadio";
            this.cityRadio.Size = new System.Drawing.Size(60, 26);
            this.cityRadio.TabIndex = 1;
            this.cityRadio.TabStop = true;
            this.cityRadio.Text = "City";
            this.cityRadio.UseVisualStyleBackColor = true;
            // 
            // provinceRadio
            // 
            this.provinceRadio.AutoSize = true;
            this.provinceRadio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.provinceRadio.Location = new System.Drawing.Point(21, 89);
            this.provinceRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provinceRadio.Name = "provinceRadio";
            this.provinceRadio.Size = new System.Drawing.Size(96, 26);
            this.provinceRadio.TabIndex = 2;
            this.provinceRadio.TabStop = true;
            this.provinceRadio.Text = "Province";
            this.provinceRadio.UseVisualStyleBackColor = true;
            // 
            // countryRadio
            // 
            this.countryRadio.AutoSize = true;
            this.countryRadio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.countryRadio.Location = new System.Drawing.Point(21, 117);
            this.countryRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryRadio.Name = "countryRadio";
            this.countryRadio.Size = new System.Drawing.Size(92, 26);
            this.countryRadio.TabIndex = 3;
            this.countryRadio.TabStop = true;
            this.countryRadio.Text = "Country";
            this.countryRadio.UseVisualStyleBackColor = true;
            // 
            // selectionFilterGroupBox
            // 
            this.selectionFilterGroupBox.Controls.Add(this.countryRadio);
            this.selectionFilterGroupBox.Controls.Add(this.provinceRadio);
            this.selectionFilterGroupBox.Controls.Add(this.cityRadio);
            this.selectionFilterGroupBox.Controls.Add(this.branchRadio);
            this.selectionFilterGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionFilterGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.selectionFilterGroupBox.Location = new System.Drawing.Point(40, 2);
            this.selectionFilterGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionFilterGroupBox.Name = "selectionFilterGroupBox";
            this.selectionFilterGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionFilterGroupBox.Size = new System.Drawing.Size(311, 170);
            this.selectionFilterGroupBox.TabIndex = 1;
            this.selectionFilterGroupBox.TabStop = false;
            this.selectionFilterGroupBox.Text = "For every:";
            // 
            // searchEveryButton
            // 
            this.searchEveryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchEveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchEveryButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEveryButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchEveryButton.Location = new System.Drawing.Point(109, 215);
            this.searchEveryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchEveryButton.Name = "searchEveryButton";
            this.searchEveryButton.Size = new System.Drawing.Size(172, 37);
            this.searchEveryButton.TabIndex = 7;
            this.searchEveryButton.Text = "Search";
            this.searchEveryButton.UseVisualStyleBackColor = false;
            this.searchEveryButton.Click += new System.EventHandler(this.searchEveryButton_Click);
            // 
            // everySearchErrorLabel
            // 
            this.everySearchErrorLabel.AutoSize = true;
            this.everySearchErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.everySearchErrorLabel.Location = new System.Drawing.Point(77, 176);
            this.everySearchErrorLabel.Name = "everySearchErrorLabel";
            this.everySearchErrorLabel.Size = new System.Drawing.Size(241, 22);
            this.everySearchErrorLabel.TabIndex = 9;
            this.everySearchErrorLabel.Text = "Error: Please select one option";
            this.everySearchErrorLabel.Visible = false;
            // 
            // FindTop100Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1624, 878);
            this.Controls.Add(this.topEmployeeDataGridView);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FindTop100Customers";
            this.Text = "FindTop100Customers";
            this.specificParamGroupBox.ResumeLayout(false);
            this.specificParamGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topEmployeeDataGridView)).EndInit();
            this.selectionFilterGroupBox.ResumeLayout(false);
            this.selectionFilterGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label everySearchErrorLabel;
        private System.Windows.Forms.Button searchEveryButton;
        private System.Windows.Forms.GroupBox selectionFilterGroupBox;
        private System.Windows.Forms.RadioButton countryRadio;
        private System.Windows.Forms.RadioButton provinceRadio;
        private System.Windows.Forms.RadioButton cityRadio;
        private System.Windows.Forms.RadioButton branchRadio;
        private System.Windows.Forms.DataGridView topEmployeeDataGridView;
    }
}