namespace CarRentalApp
{
    partial class PopularCarType
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.findMostPopularCarTypeLabel = new System.Windows.Forms.Label();
            this.popularCarTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.specificSearchErrorLabel = new System.Windows.Forms.Label();
            this.searchSpecificButton = new System.Windows.Forms.Button();
            this.specificParamGroupBox = new System.Windows.Forms.GroupBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.branchLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularCarTypeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.specificParamGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.findMostPopularCarTypeLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1737, 85);
            this.topPanel.TabIndex = 7;
            // 
            // findMostPopularCarTypeLabel
            // 
            this.findMostPopularCarTypeLabel.AutoSize = true;
            this.findMostPopularCarTypeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findMostPopularCarTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findMostPopularCarTypeLabel.Location = new System.Drawing.Point(43, 23);
            this.findMostPopularCarTypeLabel.Name = "findMostPopularCarTypeLabel";
            this.findMostPopularCarTypeLabel.Size = new System.Drawing.Size(483, 51);
            this.findMostPopularCarTypeLabel.TabIndex = 0;
            this.findMostPopularCarTypeLabel.Text = "Find Most Popular Car Type";
            // 
            // popularCarTypeDataGridView
            // 
            this.popularCarTypeDataGridView.AllowUserToAddRows = false;
            this.popularCarTypeDataGridView.AllowUserToDeleteRows = false;
            this.popularCarTypeDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.popularCarTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popularCarTypeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.popularCarTypeDataGridView.Location = new System.Drawing.Point(451, 113);
            this.popularCarTypeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.popularCarTypeDataGridView.Name = "popularCarTypeDataGridView";
            this.popularCarTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.popularCarTypeDataGridView.Size = new System.Drawing.Size(1099, 724);
            this.popularCarTypeDataGridView.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.specificSearchErrorLabel);
            this.panel1.Controls.Add(this.searchSpecificButton);
            this.panel1.Controls.Add(this.specificParamGroupBox);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(12, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 363);
            this.panel1.TabIndex = 30;
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
            // PopularCarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1737, 879);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.popularCarTypeDataGridView);
            this.Controls.Add(this.topPanel);
            this.Name = "PopularCarType";
            this.Text = "PopularCarType";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularCarTypeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.specificParamGroupBox.ResumeLayout(false);
            this.specificParamGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label findMostPopularCarTypeLabel;
        private System.Windows.Forms.DataGridView popularCarTypeDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label specificSearchErrorLabel;
        private System.Windows.Forms.Button searchSpecificButton;
        private System.Windows.Forms.GroupBox specificParamGroupBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label branchLabel;
    }
}