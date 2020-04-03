namespace CarRentalApp
{
    partial class AddNewBooking
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.enterCarDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.addNewTransactionLabel = new System.Windows.Forms.Label();
            this.enterCarDetailsGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterCarDetailsGroupBox
            // 
            this.enterCarDetailsGroupBox.Controls.Add(this.resultLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.submitButton);
            this.enterCarDetailsGroupBox.Controls.Add(this.customerIDTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.customerIDLabel);
            this.enterCarDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCarDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterCarDetailsGroupBox.Location = new System.Drawing.Point(39, 75);
            this.enterCarDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterCarDetailsGroupBox.Name = "enterCarDetailsGroupBox";
            this.enterCarDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterCarDetailsGroupBox.Size = new System.Drawing.Size(512, 150);
            this.enterCarDetailsGroupBox.TabIndex = 21;
            this.enterCarDetailsGroupBox.TabStop = false;
            this.enterCarDetailsGroupBox.Text = "Enter Customer Detail";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultLabel.Location = new System.Drawing.Point(18, 80);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 19);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitButton.Location = new System.Drawing.Point(277, 80);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(132, 30);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerIDTextBox.Location = new System.Drawing.Point(215, 35);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(259, 26);
            this.customerIDTextBox.TabIndex = 5;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.customerIDTextBox_TextChanged);
            this.customerIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerIDLabel.Location = new System.Drawing.Point(18, 42);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(87, 19);
            this.customerIDLabel.TabIndex = 2;
            this.customerIDLabel.Text = "Customer ID";
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.addNewTransactionLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(968, 69);
            this.topPanel.TabIndex = 20;
            // 
            // addNewTransactionLabel
            // 
            this.addNewTransactionLabel.AutoSize = true;
            this.addNewTransactionLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTransactionLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addNewTransactionLabel.Location = new System.Drawing.Point(32, 19);
            this.addNewTransactionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewTransactionLabel.Name = "addNewTransactionLabel";
            this.addNewTransactionLabel.Size = new System.Drawing.Size(258, 40);
            this.addNewTransactionLabel.TabIndex = 0;
            this.addNewTransactionLabel.Text = "Add New Booking";
            // 
            // AddNewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(968, 646);
            this.Controls.Add(this.enterCarDetailsGroupBox);
            this.Controls.Add(this.topPanel);
            this.Name = "AddNewBooking";
            this.Text = "AddNewBooking";
            this.enterCarDetailsGroupBox.ResumeLayout(false);
            this.enterCarDetailsGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox enterCarDetailsGroupBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label addNewTransactionLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}