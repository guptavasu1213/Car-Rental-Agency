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
            this.everySearchErrorLabel = new System.Windows.Forms.Label();
            this.searchSpecificButton = new System.Windows.Forms.Button();
            this.searchEveryButton = new System.Windows.Forms.Button();
            this.selectionFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.countryRadio = new System.Windows.Forms.RadioButton();
            this.provinceRadio = new System.Windows.Forms.RadioButton();
            this.cityRadio = new System.Windows.Forms.RadioButton();
            this.specificParamGroupBox = new System.Windows.Forms.GroupBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.findPopularBranchCustomersLabel = new System.Windows.Forms.Label();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.selectionFilterGroupBox.SuspendLayout();
            this.specificParamGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 526);
            this.panel1.TabIndex = 15;
            // 
            // specificSearchErrorLabel
            // 
            this.specificSearchErrorLabel.AutoSize = true;
            this.specificSearchErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.specificSearchErrorLabel.Location = new System.Drawing.Point(11, 366);
            this.specificSearchErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specificSearchErrorLabel.Name = "specificSearchErrorLabel";
            this.specificSearchErrorLabel.Size = new System.Drawing.Size(270, 19);
            this.specificSearchErrorLabel.TabIndex = 10;
            this.specificSearchErrorLabel.Text = "Error: Please search by only one parameter";
            this.specificSearchErrorLabel.Visible = false;
            // 
            // everySearchErrorLabel
            // 
            this.everySearchErrorLabel.AutoSize = true;
            this.everySearchErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.everySearchErrorLabel.Location = new System.Drawing.Point(59, 121);
            this.everySearchErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.everySearchErrorLabel.Name = "everySearchErrorLabel";
            this.everySearchErrorLabel.Size = new System.Drawing.Size(193, 19);
            this.everySearchErrorLabel.TabIndex = 9;
            this.everySearchErrorLabel.Text = "Error: Please select one option";
            this.everySearchErrorLabel.Visible = false;
            // 
            // searchSpecificButton
            // 
            this.searchSpecificButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchSpecificButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchSpecificButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSpecificButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchSpecificButton.Location = new System.Drawing.Point(79, 401);
            this.searchSpecificButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchSpecificButton.Name = "searchSpecificButton";
            this.searchSpecificButton.Size = new System.Drawing.Size(129, 30);
            this.searchSpecificButton.TabIndex = 8;
            this.searchSpecificButton.Text = "Search";
            this.searchSpecificButton.UseVisualStyleBackColor = false;
            this.searchSpecificButton.Click += new System.EventHandler(this.searchSpecificButton_Click);
            // 
            // searchEveryButton
            // 
            this.searchEveryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchEveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchEveryButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEveryButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchEveryButton.Location = new System.Drawing.Point(83, 153);
            this.searchEveryButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchEveryButton.Name = "searchEveryButton";
            this.searchEveryButton.Size = new System.Drawing.Size(129, 30);
            this.searchEveryButton.TabIndex = 7;
            this.searchEveryButton.Text = "Search";
            this.searchEveryButton.UseVisualStyleBackColor = false;
            this.searchEveryButton.Click += new System.EventHandler(this.searchEveryButton_Click);
            // 
            // selectionFilterGroupBox
            // 
            this.selectionFilterGroupBox.Controls.Add(this.countryRadio);
            this.selectionFilterGroupBox.Controls.Add(this.provinceRadio);
            this.selectionFilterGroupBox.Controls.Add(this.cityRadio);
            this.selectionFilterGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionFilterGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.selectionFilterGroupBox.Location = new System.Drawing.Point(30, 2);
            this.selectionFilterGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectionFilterGroupBox.Name = "selectionFilterGroupBox";
            this.selectionFilterGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.selectionFilterGroupBox.Size = new System.Drawing.Size(233, 109);
            this.selectionFilterGroupBox.TabIndex = 1;
            this.selectionFilterGroupBox.TabStop = false;
            this.selectionFilterGroupBox.Text = "For every:";
            // 
            // countryRadio
            // 
            this.countryRadio.AutoSize = true;
            this.countryRadio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.countryRadio.Location = new System.Drawing.Point(18, 72);
            this.countryRadio.Margin = new System.Windows.Forms.Padding(2);
            this.countryRadio.Name = "countryRadio";
            this.countryRadio.Size = new System.Drawing.Size(77, 23);
            this.countryRadio.TabIndex = 3;
            this.countryRadio.TabStop = true;
            this.countryRadio.Text = "Country";
            this.countryRadio.UseVisualStyleBackColor = true;
            // 
            // provinceRadio
            // 
            this.provinceRadio.AutoSize = true;
            this.provinceRadio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.provinceRadio.Location = new System.Drawing.Point(18, 49);
            this.provinceRadio.Margin = new System.Windows.Forms.Padding(2);
            this.provinceRadio.Name = "provinceRadio";
            this.provinceRadio.Size = new System.Drawing.Size(79, 23);
            this.provinceRadio.TabIndex = 2;
            this.provinceRadio.TabStop = true;
            this.provinceRadio.Text = "Province";
            this.provinceRadio.UseVisualStyleBackColor = true;
            // 
            // cityRadio
            // 
            this.cityRadio.AutoSize = true;
            this.cityRadio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cityRadio.Location = new System.Drawing.Point(18, 27);
            this.cityRadio.Margin = new System.Windows.Forms.Padding(2);
            this.cityRadio.Name = "cityRadio";
            this.cityRadio.Size = new System.Drawing.Size(51, 23);
            this.cityRadio.TabIndex = 1;
            this.cityRadio.TabStop = true;
            this.cityRadio.Text = "City";
            this.cityRadio.UseVisualStyleBackColor = true;
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
            this.specificParamGroupBox.Location = new System.Drawing.Point(31, 213);
            this.specificParamGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.specificParamGroupBox.Name = "specificParamGroupBox";
            this.specificParamGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.specificParamGroupBox.Size = new System.Drawing.Size(233, 142);
            this.specificParamGroupBox.TabIndex = 2;
            this.specificParamGroupBox.TabStop = false;
            this.specificParamGroupBox.Text = "Searching by a specific parameter?";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.countryTextBox.Location = new System.Drawing.Point(77, 101);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(132, 26);
            this.countryTextBox.TabIndex = 7;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.provinceTextBox.Location = new System.Drawing.Point(77, 68);
            this.provinceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(132, 26);
            this.provinceTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cityTextBox.Location = new System.Drawing.Point(77, 36);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(132, 26);
            this.cityTextBox.TabIndex = 5;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.countryLabel.Location = new System.Drawing.Point(14, 101);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(59, 19);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cityLabel.Location = new System.Drawing.Point(14, 38);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(33, 19);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.provinceLabel.Location = new System.Drawing.Point(14, 72);
            this.provinceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(61, 19);
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
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(930, 69);
            this.topPanel.TabIndex = 16;
            // 
            // findPopularBranchCustomersLabel
            // 
            this.findPopularBranchCustomersLabel.AutoSize = true;
            this.findPopularBranchCustomersLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPopularBranchCustomersLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findPopularBranchCustomersLabel.Location = new System.Drawing.Point(32, 19);
            this.findPopularBranchCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findPopularBranchCustomersLabel.Name = "findPopularBranchCustomersLabel";
            this.findPopularBranchCustomersLabel.Size = new System.Drawing.Size(387, 40);
            this.findPopularBranchCustomersLabel.TabIndex = 0;
            this.findPopularBranchCustomersLabel.Text = "Find Most Popular Branches";
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(321, 64);
            this.resultsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowTemplate.Height = 24;
            this.resultsDataGridView.Size = new System.Drawing.Size(542, 526);
            this.resultsDataGridView.TabIndex = 17;
            // 
            // PopularBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(930, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.resultsDataGridView);
            this.Name = "PopularBranch";
            this.Text = "PopularBranch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.selectionFilterGroupBox.ResumeLayout(false);
            this.selectionFilterGroupBox.PerformLayout();
            this.specificParamGroupBox.ResumeLayout(false);
            this.specificParamGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label specificSearchErrorLabel;
        private System.Windows.Forms.Label everySearchErrorLabel;
        private System.Windows.Forms.Button searchSpecificButton;
        private System.Windows.Forms.Button searchEveryButton;
        private System.Windows.Forms.GroupBox selectionFilterGroupBox;
        private System.Windows.Forms.RadioButton countryRadio;
        private System.Windows.Forms.RadioButton provinceRadio;
        private System.Windows.Forms.RadioButton cityRadio;
        private System.Windows.Forms.GroupBox specificParamGroupBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label findPopularBranchCustomersLabel;
        private System.Windows.Forms.DataGridView resultsDataGridView;
    }
}