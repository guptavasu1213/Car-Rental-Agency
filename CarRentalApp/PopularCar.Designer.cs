namespace CarRentalApp
{
    partial class PopularCar
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
            this.findMostPopularCarLabel = new System.Windows.Forms.Label();
            this.selectionFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.branchRadio = new System.Windows.Forms.RadioButton();
            this.cityRadio = new System.Windows.Forms.RadioButton();
            this.provinceRadio = new System.Windows.Forms.RadioButton();
            this.countryRadio = new System.Windows.Forms.RadioButton();
            this.specificParamGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.branchLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.resultsTable = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.selectionFilterGroupBox.SuspendLayout();
            this.specificParamGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // findMostPopularCarLabel
            // 
            this.findMostPopularCarLabel.AutoSize = true;
            this.findMostPopularCarLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findMostPopularCarLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findMostPopularCarLabel.Location = new System.Drawing.Point(43, 23);
            this.findMostPopularCarLabel.Name = "findMostPopularCarLabel";
            this.findMostPopularCarLabel.Size = new System.Drawing.Size(393, 51);
            this.findMostPopularCarLabel.TabIndex = 0;
            this.findMostPopularCarLabel.Text = "Find Most Popular Car";
            // 
            // selectionFilterGroupBox
            // 
            this.selectionFilterGroupBox.Controls.Add(this.countryRadio);
            this.selectionFilterGroupBox.Controls.Add(this.provinceRadio);
            this.selectionFilterGroupBox.Controls.Add(this.cityRadio);
            this.selectionFilterGroupBox.Controls.Add(this.branchRadio);
            this.selectionFilterGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionFilterGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.selectionFilterGroupBox.Location = new System.Drawing.Point(24, 29);
            this.selectionFilterGroupBox.Name = "selectionFilterGroupBox";
            this.selectionFilterGroupBox.Size = new System.Drawing.Size(311, 170);
            this.selectionFilterGroupBox.TabIndex = 1;
            this.selectionFilterGroupBox.TabStop = false;
            this.selectionFilterGroupBox.Text = "For every:";
            // 
            // branchRadio
            // 
            this.branchRadio.AutoSize = true;
            this.branchRadio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchRadio.Location = new System.Drawing.Point(21, 33);
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
            this.cityRadio.Location = new System.Drawing.Point(21, 61);
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
            this.countryRadio.Name = "countryRadio";
            this.countryRadio.Size = new System.Drawing.Size(92, 26);
            this.countryRadio.TabIndex = 3;
            this.countryRadio.TabStop = true;
            this.countryRadio.Text = "Country";
            this.countryRadio.UseVisualStyleBackColor = true;
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
            this.specificParamGroupBox.Location = new System.Drawing.Point(24, 261);
            this.specificParamGroupBox.Name = "specificParamGroupBox";
            this.specificParamGroupBox.Size = new System.Drawing.Size(311, 218);
            this.specificParamGroupBox.TabIndex = 2;
            this.specificParamGroupBox.TabStop = false;
            this.specificParamGroupBox.Text = "Searching by a specific parameter?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.orLabel);
            this.panel1.Controls.Add(this.selectionFilterGroupBox);
            this.panel1.Controls.Add(this.specificParamGroupBox);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(23, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 586);
            this.panel1.TabIndex = 3;
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.findMostPopularCarLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1171, 85);
            this.topPanel.TabIndex = 4;
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchLabel.Location = new System.Drawing.Point(18, 44);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(68, 22);
            this.branchLabel.TabIndex = 0;
            this.branchLabel.Text = "Branch ";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.provinceLabel.Location = new System.Drawing.Point(18, 124);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(75, 22);
            this.provinceLabel.TabIndex = 1;
            this.provinceLabel.Text = "Province";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cityLabel.Location = new System.Drawing.Point(18, 80);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 22);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.countryLabel.Location = new System.Drawing.Point(18, 160);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(71, 22);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Country";
            // 
            // branchTextBox
            // 
            this.branchTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.branchTextBox.Location = new System.Drawing.Point(103, 44);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(175, 30);
            this.branchTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cityTextBox.Location = new System.Drawing.Point(103, 80);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(175, 30);
            this.cityTextBox.TabIndex = 5;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.provinceTextBox.Location = new System.Drawing.Point(103, 119);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(175, 30);
            this.provinceTextBox.TabIndex = 6;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.countryTextBox.Location = new System.Drawing.Point(103, 160);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(175, 30);
            this.countryTextBox.TabIndex = 7;
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.orLabel.Location = new System.Drawing.Point(165, 213);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(33, 22);
            this.orLabel.TabIndex = 3;
            this.orLabel.Text = "OR";
            // 
            // resultsTable
            // 
            this.resultsTable.ColumnCount = 3;
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultsTable.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsTable.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultsTable.Location = new System.Drawing.Point(455, 121);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.RowCount = 2;
            this.resultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultsTable.Size = new System.Drawing.Size(694, 521);
            this.resultsTable.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchButton.Location = new System.Drawing.Point(64, 509);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(221, 48);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // PopularCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1171, 780);
            this.Controls.Add(this.resultsTable);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Name = "PopularCar";
            this.Text = "PopularCar";
            this.selectionFilterGroupBox.ResumeLayout(false);
            this.selectionFilterGroupBox.PerformLayout();
            this.specificParamGroupBox.ResumeLayout(false);
            this.specificParamGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label findMostPopularCarLabel;
        private System.Windows.Forms.GroupBox selectionFilterGroupBox;
        private System.Windows.Forms.RadioButton countryRadio;
        private System.Windows.Forms.RadioButton provinceRadio;
        private System.Windows.Forms.RadioButton cityRadio;
        private System.Windows.Forms.RadioButton branchRadio;
        private System.Windows.Forms.GroupBox specificParamGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.TableLayoutPanel resultsTable;
        private System.Windows.Forms.Button searchButton;
    }
}