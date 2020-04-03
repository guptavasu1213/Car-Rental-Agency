namespace CarRentalApp
{
    partial class PopularBranch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.specificSearchErrorLabel = new System.Windows.Forms.Label();
            this.searchSpecificButton = new System.Windows.Forms.Button();
            this.specificParamGroupBox = new System.Windows.Forms.GroupBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.findPopularBranchCustomersLabel = new System.Windows.Forms.Label();
            this.popularBranchesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.specificParamGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularBranchesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(409, 330);
            this.panel1.TabIndex = 15;
            // 
            // specificSearchErrorLabel
            // 
            this.specificSearchErrorLabel.AutoSize = true;
            this.specificSearchErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.specificSearchErrorLabel.Location = new System.Drawing.Point(26, 214);
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
            this.searchSpecificButton.Location = new System.Drawing.Point(116, 258);
            this.searchSpecificButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchSpecificButton.Name = "searchSpecificButton";
            this.searchSpecificButton.Size = new System.Drawing.Size(172, 37);
            this.searchSpecificButton.TabIndex = 8;
            this.searchSpecificButton.Text = "Search";
            this.searchSpecificButton.UseVisualStyleBackColor = false;
            this.searchSpecificButton.Click += new System.EventHandler(this.searchSpecificButton_Click);
            // 
            // specificParamGroupBox
            // 
            this.specificParamGroupBox.Controls.Add(this.countryTextBox);
            this.specificParamGroupBox.Controls.Add(this.provinceTextBox);
            this.specificParamGroupBox.Controls.Add(this.cityTextBox);
            this.specificParamGroupBox.Controls.Add(this.countryLabel);
            this.specificParamGroupBox.Controls.Add(this.cityLabel);
            this.specificParamGroupBox.Controls.Add(this.provinceLabel);
            this.specificParamGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificParamGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.specificParamGroupBox.Location = new System.Drawing.Point(52, 26);
            this.specificParamGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specificParamGroupBox.Name = "specificParamGroupBox";
            this.specificParamGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specificParamGroupBox.Size = new System.Drawing.Size(311, 175);
            this.specificParamGroupBox.TabIndex = 2;
            this.specificParamGroupBox.TabStop = false;
            this.specificParamGroupBox.Text = "Search by only one parameter";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.countryTextBox.Location = new System.Drawing.Point(103, 124);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(175, 30);
            this.countryTextBox.TabIndex = 7;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.provinceTextBox.Location = new System.Drawing.Point(103, 84);
            this.provinceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(175, 30);
            this.provinceTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cityTextBox.Location = new System.Drawing.Point(103, 44);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(175, 30);
            this.cityTextBox.TabIndex = 5;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.countryLabel.Location = new System.Drawing.Point(19, 124);
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
            this.cityLabel.Location = new System.Drawing.Point(19, 47);
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
            this.provinceLabel.Location = new System.Drawing.Point(19, 89);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(75, 22);
            this.provinceLabel.TabIndex = 1;
            this.provinceLabel.Text = "Province";
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.findPopularBranchCustomersLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1924, 85);
            this.topPanel.TabIndex = 16;
            // 
            // findPopularBranchCustomersLabel
            // 
            this.findPopularBranchCustomersLabel.AutoSize = true;
            this.findPopularBranchCustomersLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPopularBranchCustomersLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findPopularBranchCustomersLabel.Location = new System.Drawing.Point(43, 23);
            this.findPopularBranchCustomersLabel.Name = "findPopularBranchCustomersLabel";
            this.findPopularBranchCustomersLabel.Size = new System.Drawing.Size(489, 51);
            this.findPopularBranchCustomersLabel.TabIndex = 0;
            this.findPopularBranchCustomersLabel.Text = "Find Most Popular Branches";
            // 
            // popularBranchesDataGridView
            // 
            this.popularBranchesDataGridView.AllowUserToAddRows = false;
            this.popularBranchesDataGridView.AllowUserToDeleteRows = false;
            this.popularBranchesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.popularBranchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popularBranchesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.popularBranchesDataGridView.Location = new System.Drawing.Point(416, 91);
            this.popularBranchesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.popularBranchesDataGridView.Name = "popularBranchesDataGridView";
            this.popularBranchesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.popularBranchesDataGridView.Size = new System.Drawing.Size(1099, 724);
            this.popularBranchesDataGridView.TabIndex = 28;
            // 
            // PopularBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 880);
            this.Controls.Add(this.popularBranchesDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PopularBranch";
            this.Text = "PopularBranch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.specificParamGroupBox.ResumeLayout(false);
            this.specificParamGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularBranchesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label specificSearchErrorLabel;
        private System.Windows.Forms.Button searchSpecificButton;
        private System.Windows.Forms.GroupBox specificParamGroupBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label findPopularBranchCustomersLabel;
        private System.Windows.Forms.DataGridView popularBranchesDataGridView;
    }
}