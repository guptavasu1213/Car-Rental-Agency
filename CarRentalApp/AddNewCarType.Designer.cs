namespace CarRentalApp
{
    partial class AddNewCarType
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
            this.addNewBranchLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.dailyFeeTextBox = new System.Windows.Forms.TextBox();
            this.dailyFeeLabel = new System.Windows.Forms.Label();
            this.enterBranchDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.monthlyFeeTextBox = new System.Windows.Forms.TextBox();
            this.weeklyFeeTextBox = new System.Windows.Forms.TextBox();
            this.carTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.monthlyFee = new System.Windows.Forms.Label();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.weeklyFeeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.enterBranchDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.addNewBranchLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(795, 69);
            this.topPanel.TabIndex = 18;
            // 
            // addNewBranchLabel
            // 
            this.addNewBranchLabel.AutoSize = true;
            this.addNewBranchLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBranchLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addNewBranchLabel.Location = new System.Drawing.Point(32, 19);
            this.addNewBranchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewBranchLabel.Name = "addNewBranchLabel";
            this.addNewBranchLabel.Size = new System.Drawing.Size(265, 40);
            this.addNewBranchLabel.TabIndex = 0;
            this.addNewBranchLabel.Text = "Add New Car Type";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultLabel.Location = new System.Drawing.Point(19, 190);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 19);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dailyFeeTextBox
            // 
            this.dailyFeeTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyFeeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dailyFeeTextBox.Location = new System.Drawing.Point(211, 70);
            this.dailyFeeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dailyFeeTextBox.Name = "dailyFeeTextBox";
            this.dailyFeeTextBox.Size = new System.Drawing.Size(280, 26);
            this.dailyFeeTextBox.TabIndex = 15;
            this.dailyFeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForANumber);
            // 
            // dailyFeeLabel
            // 
            this.dailyFeeLabel.AutoSize = true;
            this.dailyFeeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyFeeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dailyFeeLabel.Location = new System.Drawing.Point(14, 77);
            this.dailyFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dailyFeeLabel.Name = "dailyFeeLabel";
            this.dailyFeeLabel.Size = new System.Drawing.Size(64, 19);
            this.dailyFeeLabel.TabIndex = 10;
            this.dailyFeeLabel.Text = "Daily Fee";
            // 
            // enterBranchDetailsGroupBox
            // 
            this.enterBranchDetailsGroupBox.Controls.Add(this.resultLabel);
            this.enterBranchDetailsGroupBox.Controls.Add(this.dailyFeeTextBox);
            this.enterBranchDetailsGroupBox.Controls.Add(this.dailyFeeLabel);
            this.enterBranchDetailsGroupBox.Controls.Add(this.monthlyFeeTextBox);
            this.enterBranchDetailsGroupBox.Controls.Add(this.weeklyFeeTextBox);
            this.enterBranchDetailsGroupBox.Controls.Add(this.carTypeNameTextBox);
            this.enterBranchDetailsGroupBox.Controls.Add(this.monthlyFee);
            this.enterBranchDetailsGroupBox.Controls.Add(this.carTypeLabel);
            this.enterBranchDetailsGroupBox.Controls.Add(this.weeklyFeeLabel);
            this.enterBranchDetailsGroupBox.Controls.Add(this.submitButton);
            this.enterBranchDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBranchDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterBranchDetailsGroupBox.Location = new System.Drawing.Point(39, 108);
            this.enterBranchDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.enterBranchDetailsGroupBox.Name = "enterBranchDetailsGroupBox";
            this.enterBranchDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.enterBranchDetailsGroupBox.Size = new System.Drawing.Size(514, 247);
            this.enterBranchDetailsGroupBox.TabIndex = 19;
            this.enterBranchDetailsGroupBox.TabStop = false;
            this.enterBranchDetailsGroupBox.Text = "Enter type details";
            // 
            // monthlyFeeTextBox
            // 
            this.monthlyFeeTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyFeeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthlyFeeTextBox.Location = new System.Drawing.Point(211, 146);
            this.monthlyFeeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.monthlyFeeTextBox.Name = "monthlyFeeTextBox";
            this.monthlyFeeTextBox.Size = new System.Drawing.Size(280, 26);
            this.monthlyFeeTextBox.TabIndex = 7;
            this.monthlyFeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForANumber);
            // 
            // weeklyFeeTextBox
            // 
            this.weeklyFeeTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyFeeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weeklyFeeTextBox.Location = new System.Drawing.Point(211, 110);
            this.weeklyFeeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.weeklyFeeTextBox.Name = "weeklyFeeTextBox";
            this.weeklyFeeTextBox.Size = new System.Drawing.Size(280, 26);
            this.weeklyFeeTextBox.TabIndex = 6;
            this.weeklyFeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForANumber);
            // 
            // carTypeNameTextBox
            // 
            this.carTypeNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTypeNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carTypeNameTextBox.Location = new System.Drawing.Point(211, 31);
            this.carTypeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.carTypeNameTextBox.Name = "carTypeNameTextBox";
            this.carTypeNameTextBox.Size = new System.Drawing.Size(280, 26);
            this.carTypeNameTextBox.TabIndex = 5;
            // 
            // monthlyFee
            // 
            this.monthlyFee.AutoSize = true;
            this.monthlyFee.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyFee.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.monthlyFee.Location = new System.Drawing.Point(14, 153);
            this.monthlyFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthlyFee.Name = "monthlyFee";
            this.monthlyFee.Size = new System.Drawing.Size(86, 19);
            this.monthlyFee.TabIndex = 3;
            this.monthlyFee.Text = "Monthly Fee";
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carTypeLabel.Location = new System.Drawing.Point(14, 38);
            this.carTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(103, 19);
            this.carTypeLabel.TabIndex = 2;
            this.carTypeLabel.Text = "Car Type Name";
            // 
            // weeklyFeeLabel
            // 
            this.weeklyFeeLabel.AutoSize = true;
            this.weeklyFeeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyFeeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.weeklyFeeLabel.Location = new System.Drawing.Point(14, 117);
            this.weeklyFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weeklyFeeLabel.Name = "weeklyFeeLabel";
            this.weeklyFeeLabel.Size = new System.Drawing.Size(78, 19);
            this.weeklyFeeLabel.TabIndex = 1;
            this.weeklyFeeLabel.Text = "Weekly Fee";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitButton.Location = new System.Drawing.Point(286, 190);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(132, 30);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddNewCarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(795, 513);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.enterBranchDetailsGroupBox);
            this.Name = "AddNewCarType";
            this.Text = "AddNewVehicleType";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.enterBranchDetailsGroupBox.ResumeLayout(false);
            this.enterBranchDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label addNewBranchLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox dailyFeeTextBox;
        private System.Windows.Forms.Label dailyFeeLabel;
        private System.Windows.Forms.GroupBox enterBranchDetailsGroupBox;
        private System.Windows.Forms.TextBox monthlyFeeTextBox;
        private System.Windows.Forms.TextBox weeklyFeeTextBox;
        private System.Windows.Forms.TextBox carTypeNameTextBox;
        private System.Windows.Forms.Label monthlyFee;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.Label weeklyFeeLabel;
        private System.Windows.Forms.Button submitButton;
    }
}