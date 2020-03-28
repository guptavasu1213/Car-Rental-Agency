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
            this.carFuelTypeLabel = new System.Windows.Forms.Label();
            this.carFuelComboBox = new System.Windows.Forms.ComboBox();
            this.enterCarDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.makeComboCox = new System.Windows.Forms.ComboBox();
            this.dropoffDate = new System.Windows.Forms.DateTimePicker();
            this.carTransmissionComboBox = new System.Windows.Forms.ComboBox();
            this.carTransmissionLabel = new System.Windows.Forms.Label();
            this.pickUpDate = new System.Windows.Forms.DateTimePicker();
            this.dropoffDateLabel = new System.Windows.Forms.Label();
            this.pickupComboBox = new System.Windows.Forms.ComboBox();
            this.dropOffComboBox = new System.Windows.Forms.ComboBox();
            this.licensePlateLabel = new System.Windows.Forms.Label();
            this.dropoffBranchLabel = new System.Windows.Forms.Label();
            this.pickupBranchLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.addNewTransactionLabel = new System.Windows.Forms.Label();
            this.customerResultLabel = new System.Windows.Forms.Label();
            this.requiredLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorPickupBranch = new System.Windows.Forms.Label();
            this.errorDropoffBranch = new System.Windows.Forms.Label();
            this.errorMake = new System.Windows.Forms.Label();
            this.errorModel = new System.Windows.Forms.Label();
            this.enterCarDetailsGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // carFuelTypeLabel
            // 
            this.carFuelTypeLabel.AutoSize = true;
            this.carFuelTypeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carFuelTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carFuelTypeLabel.Location = new System.Drawing.Point(18, 238);
            this.carFuelTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carFuelTypeLabel.Name = "carFuelTypeLabel";
            this.carFuelTypeLabel.Size = new System.Drawing.Size(92, 19);
            this.carFuelTypeLabel.TabIndex = 24;
            this.carFuelTypeLabel.Text = "Car Fuel Type";
            // 
            // carFuelComboBox
            // 
            this.carFuelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carFuelComboBox.FormattingEnabled = true;
            this.carFuelComboBox.Location = new System.Drawing.Point(215, 238);
            this.carFuelComboBox.Name = "carFuelComboBox";
            this.carFuelComboBox.Size = new System.Drawing.Size(259, 27);
            this.carFuelComboBox.TabIndex = 23;
            // 
            // enterCarDetailsGroupBox
            // 
            this.enterCarDetailsGroupBox.Controls.Add(this.errorModel);
            this.enterCarDetailsGroupBox.Controls.Add(this.errorMake);
            this.enterCarDetailsGroupBox.Controls.Add(this.errorDropoffBranch);
            this.enterCarDetailsGroupBox.Controls.Add(this.errorPickupBranch);
            this.enterCarDetailsGroupBox.Controls.Add(this.label7);
            this.enterCarDetailsGroupBox.Controls.Add(this.label6);
            this.enterCarDetailsGroupBox.Controls.Add(this.label5);
            this.enterCarDetailsGroupBox.Controls.Add(this.label4);
            this.enterCarDetailsGroupBox.Controls.Add(this.label3);
            this.enterCarDetailsGroupBox.Controls.Add(this.label2);
            this.enterCarDetailsGroupBox.Controls.Add(this.label1);
            this.enterCarDetailsGroupBox.Controls.Add(this.requiredLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.customerResultLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.modelComboBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.makeComboCox);
            this.enterCarDetailsGroupBox.Controls.Add(this.dropoffDate);
            this.enterCarDetailsGroupBox.Controls.Add(this.carTransmissionComboBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.carTransmissionLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.pickUpDate);
            this.enterCarDetailsGroupBox.Controls.Add(this.dropoffDateLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.pickupComboBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.dropOffComboBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.licensePlateLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.carFuelComboBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.dropoffBranchLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.carFuelTypeLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.pickupBranchLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.resultLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.submitButton);
            this.enterCarDetailsGroupBox.Controls.Add(this.customerIDTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.modelLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.customerIDLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.makeLabel);
            this.enterCarDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCarDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterCarDetailsGroupBox.Location = new System.Drawing.Point(39, 75);
            this.enterCarDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.enterCarDetailsGroupBox.Name = "enterCarDetailsGroupBox";
            this.enterCarDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.enterCarDetailsGroupBox.Size = new System.Drawing.Size(737, 468);
            this.enterCarDetailsGroupBox.TabIndex = 21;
            this.enterCarDetailsGroupBox.TabStop = false;
            this.enterCarDetailsGroupBox.Text = "Enter Car details";
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(215, 359);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(259, 27);
            this.modelComboBox.TabIndex = 42;
            // 
            // makeComboCox
            // 
            this.makeComboCox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makeComboCox.FormattingEnabled = true;
            this.makeComboCox.Location = new System.Drawing.Point(215, 321);
            this.makeComboCox.Name = "makeComboCox";
            this.makeComboCox.Size = new System.Drawing.Size(259, 27);
            this.makeComboCox.TabIndex = 41;
            // 
            // dropoffDate
            // 
            this.dropoffDate.Location = new System.Drawing.Point(215, 116);
            this.dropoffDate.Name = "dropoffDate";
            this.dropoffDate.Size = new System.Drawing.Size(259, 26);
            this.dropoffDate.TabIndex = 40;
            // 
            // carTransmissionComboBox
            // 
            this.carTransmissionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carTransmissionComboBox.FormattingEnabled = true;
            this.carTransmissionComboBox.Location = new System.Drawing.Point(215, 280);
            this.carTransmissionComboBox.Name = "carTransmissionComboBox";
            this.carTransmissionComboBox.Size = new System.Drawing.Size(259, 27);
            this.carTransmissionComboBox.TabIndex = 33;
            // 
            // carTransmissionLabel
            // 
            this.carTransmissionLabel.AutoSize = true;
            this.carTransmissionLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTransmissionLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carTransmissionLabel.Location = new System.Drawing.Point(18, 280);
            this.carTransmissionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carTransmissionLabel.Name = "carTransmissionLabel";
            this.carTransmissionLabel.Size = new System.Drawing.Size(113, 19);
            this.carTransmissionLabel.TabIndex = 34;
            this.carTransmissionLabel.Text = "Car Transmission";
            // 
            // pickUpDate
            // 
            this.pickUpDate.Location = new System.Drawing.Point(215, 74);
            this.pickUpDate.Name = "pickUpDate";
            this.pickUpDate.Size = new System.Drawing.Size(259, 26);
            this.pickUpDate.TabIndex = 39;
            // 
            // dropoffDateLabel
            // 
            this.dropoffDateLabel.AutoSize = true;
            this.dropoffDateLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropoffDateLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dropoffDateLabel.Location = new System.Drawing.Point(18, 123);
            this.dropoffDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dropoffDateLabel.Name = "dropoffDateLabel";
            this.dropoffDateLabel.Size = new System.Drawing.Size(91, 19);
            this.dropoffDateLabel.TabIndex = 38;
            this.dropoffDateLabel.Text = "Drop off date";
            // 
            // pickupComboBox
            // 
            this.pickupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickupComboBox.FormattingEnabled = true;
            this.pickupComboBox.Location = new System.Drawing.Point(215, 157);
            this.pickupComboBox.Name = "pickupComboBox";
            this.pickupComboBox.Size = new System.Drawing.Size(259, 27);
            this.pickupComboBox.TabIndex = 32;
            // 
            // dropOffComboBox
            // 
            this.dropOffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropOffComboBox.FormattingEnabled = true;
            this.dropOffComboBox.Location = new System.Drawing.Point(215, 196);
            this.dropOffComboBox.Name = "dropOffComboBox";
            this.dropOffComboBox.Size = new System.Drawing.Size(259, 27);
            this.dropOffComboBox.TabIndex = 31;
            // 
            // licensePlateLabel
            // 
            this.licensePlateLabel.AutoSize = true;
            this.licensePlateLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.licensePlateLabel.Location = new System.Drawing.Point(18, 81);
            this.licensePlateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licensePlateLabel.Name = "licensePlateLabel";
            this.licensePlateLabel.Size = new System.Drawing.Size(84, 19);
            this.licensePlateLabel.TabIndex = 37;
            this.licensePlateLabel.Text = "Pick up date";
            // 
            // dropoffBranchLabel
            // 
            this.dropoffBranchLabel.AutoSize = true;
            this.dropoffBranchLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropoffBranchLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dropoffBranchLabel.Location = new System.Drawing.Point(18, 204);
            this.dropoffBranchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dropoffBranchLabel.Name = "dropoffBranchLabel";
            this.dropoffBranchLabel.Size = new System.Drawing.Size(102, 19);
            this.dropoffBranchLabel.TabIndex = 29;
            this.dropoffBranchLabel.Text = "Dropoff Branch";
            // 
            // pickupBranchLabel
            // 
            this.pickupBranchLabel.AutoSize = true;
            this.pickupBranchLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupBranchLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickupBranchLabel.Location = new System.Drawing.Point(18, 165);
            this.pickupBranchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickupBranchLabel.Name = "pickupBranchLabel";
            this.pickupBranchLabel.Size = new System.Drawing.Size(95, 19);
            this.pickupBranchLabel.TabIndex = 27;
            this.pickupBranchLabel.Text = "Pickup Branch";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultLabel.Location = new System.Drawing.Point(25, 407);
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
            this.submitButton.Location = new System.Drawing.Point(273, 407);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(259, 26);
            this.customerIDTextBox.TabIndex = 5;
            this.customerIDTextBox.Leave += new System.EventHandler(this.customerIDTextBox_Leave);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.modelLabel.Location = new System.Drawing.Point(18, 362);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(48, 19);
            this.modelLabel.TabIndex = 3;
            this.modelLabel.Text = "Model";
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
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.makeLabel.Location = new System.Drawing.Point(18, 321);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(43, 19);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.addNewTransactionLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
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
            this.addNewTransactionLabel.Size = new System.Drawing.Size(300, 40);
            this.addNewTransactionLabel.TabIndex = 0;
            this.addNewTransactionLabel.Text = "Add New Transaction";
            // 
            // customerResultLabel
            // 
            this.customerResultLabel.AutoSize = true;
            this.customerResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerResultLabel.Location = new System.Drawing.Point(502, 38);
            this.customerResultLabel.Name = "customerResultLabel";
            this.customerResultLabel.Size = new System.Drawing.Size(0, 19);
            this.customerResultLabel.TabIndex = 43;
            // 
            // requiredLabel
            // 
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.BackColor = System.Drawing.Color.Transparent;
            this.requiredLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.requiredLabel.ForeColor = System.Drawing.Color.Red;
            this.requiredLabel.Location = new System.Drawing.Point(109, 34);
            this.requiredLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(22, 30);
            this.requiredLabel.TabIndex = 44;
            this.requiredLabel.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(106, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 30);
            this.label1.TabIndex = 45;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(109, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 30);
            this.label2.TabIndex = 46;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(117, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 30);
            this.label3.TabIndex = 47;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(124, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 30);
            this.label4.TabIndex = 48;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(65, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 30);
            this.label5.TabIndex = 49;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(65, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 30);
            this.label6.TabIndex = 50;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(490, 438);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "All fields marked with * are mandatory\r\n";
            // 
            // errorPickupBranch
            // 
            this.errorPickupBranch.AutoSize = true;
            this.errorPickupBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorPickupBranch.Location = new System.Drawing.Point(502, 157);
            this.errorPickupBranch.Name = "errorPickupBranch";
            this.errorPickupBranch.Size = new System.Drawing.Size(0, 19);
            this.errorPickupBranch.TabIndex = 52;
            // 
            // errorDropoffBranch
            // 
            this.errorDropoffBranch.AutoSize = true;
            this.errorDropoffBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorDropoffBranch.Location = new System.Drawing.Point(502, 196);
            this.errorDropoffBranch.Name = "errorDropoffBranch";
            this.errorDropoffBranch.Size = new System.Drawing.Size(0, 19);
            this.errorDropoffBranch.TabIndex = 53;
            // 
            // errorMake
            // 
            this.errorMake.AutoSize = true;
            this.errorMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorMake.Location = new System.Drawing.Point(502, 321);
            this.errorMake.Name = "errorMake";
            this.errorMake.Size = new System.Drawing.Size(0, 19);
            this.errorMake.TabIndex = 54;
            // 
            // errorModel
            // 
            this.errorModel.AutoSize = true;
            this.errorModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorModel.Location = new System.Drawing.Point(502, 359);
            this.errorModel.Name = "errorModel";
            this.errorModel.Size = new System.Drawing.Size(0, 19);
            this.errorModel.TabIndex = 55;
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
        private System.Windows.Forms.Label carFuelTypeLabel;
        private System.Windows.Forms.ComboBox carFuelComboBox;
        private System.Windows.Forms.GroupBox enterCarDetailsGroupBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label addNewTransactionLabel;
        private System.Windows.Forms.ComboBox pickupComboBox;
        private System.Windows.Forms.ComboBox dropOffComboBox;
        private System.Windows.Forms.Label dropoffBranchLabel;
        private System.Windows.Forms.Label pickupBranchLabel;
        private System.Windows.Forms.ComboBox carTransmissionComboBox;
        private System.Windows.Forms.Label carTransmissionLabel;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox makeComboCox;
        private System.Windows.Forms.DateTimePicker dropoffDate;
        private System.Windows.Forms.DateTimePicker pickUpDate;
        private System.Windows.Forms.Label dropoffDateLabel;
        private System.Windows.Forms.Label licensePlateLabel;
        private System.Windows.Forms.Label customerResultLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label requiredLabel;
        private System.Windows.Forms.Label errorModel;
        private System.Windows.Forms.Label errorMake;
        private System.Windows.Forms.Label errorDropoffBranch;
        private System.Windows.Forms.Label errorPickupBranch;
    }
}