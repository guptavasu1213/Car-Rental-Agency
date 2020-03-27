namespace CarRentalApp
{
    partial class AddNewCar
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
            this.insuranceIDTextBox = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.addNewCarLabel = new System.Windows.Forms.Label();
            this.enterCarDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.insuranceLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.VINTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.licensePlateLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.vinNumberLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.carNameLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.inServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.branchNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carTypeNameLabel = new System.Windows.Forms.Label();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.topPanel.SuspendLayout();
            this.enterCarDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // insuranceIDTextBox
            // 
            this.insuranceIDTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceIDTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insuranceIDTextBox.Location = new System.Drawing.Point(211, 299);
            this.insuranceIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.insuranceIDTextBox.Name = "insuranceIDTextBox";
            this.insuranceIDTextBox.Size = new System.Drawing.Size(259, 26);
            this.insuranceIDTextBox.TabIndex = 21;
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.addNewCarLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(819, 69);
            this.topPanel.TabIndex = 18;
            // 
            // addNewCarLabel
            // 
            this.addNewCarLabel.AutoSize = true;
            this.addNewCarLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCarLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addNewCarLabel.Location = new System.Drawing.Point(32, 19);
            this.addNewCarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewCarLabel.Name = "addNewCarLabel";
            this.addNewCarLabel.Size = new System.Drawing.Size(192, 40);
            this.addNewCarLabel.TabIndex = 0;
            this.addNewCarLabel.Text = "Add New Car";
            // 
            // enterCarDetailsGroupBox
            // 
            this.enterCarDetailsGroupBox.Controls.Add(this.carTypeNameLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.carTypeComboBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.label1);
            this.enterCarDetailsGroupBox.Controls.Add(this.branchNameComboBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.inServiceCheckBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.insuranceIDTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.birthDateLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.insuranceLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.resultLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.registrationTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.licensePlateTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.VINTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.yearTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.registrationLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.licensePlateLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.yearLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.vinNumberLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.submitButton);
            this.enterCarDetailsGroupBox.Controls.Add(this.modelTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.makeTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.carNameTextBox);
            this.enterCarDetailsGroupBox.Controls.Add(this.modelLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.carNameLabel);
            this.enterCarDetailsGroupBox.Controls.Add(this.makeLabel);
            this.enterCarDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCarDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterCarDetailsGroupBox.Location = new System.Drawing.Point(39, 73);
            this.enterCarDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.enterCarDetailsGroupBox.Name = "enterCarDetailsGroupBox";
            this.enterCarDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.enterCarDetailsGroupBox.Size = new System.Drawing.Size(530, 512);
            this.enterCarDetailsGroupBox.TabIndex = 19;
            this.enterCarDetailsGroupBox.TabStop = false;
            this.enterCarDetailsGroupBox.Text = "Enter Car details";
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.AutoSize = true;
            this.insuranceLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.insuranceLabel.Location = new System.Drawing.Point(14, 306);
            this.insuranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(86, 19);
            this.insuranceLabel.TabIndex = 19;
            this.insuranceLabel.Text = "Insurance ID";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultLabel.Location = new System.Drawing.Point(18, 459);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 19);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registrationTextBox.Location = new System.Drawing.Point(211, 259);
            this.registrationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(259, 26);
            this.registrationTextBox.TabIndex = 17;
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.licensePlateTextBox.Location = new System.Drawing.Point(211, 217);
            this.licensePlateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(259, 26);
            this.licensePlateTextBox.TabIndex = 16;
            // 
            // VINTextBox
            // 
            this.VINTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VINTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VINTextBox.Location = new System.Drawing.Point(211, 176);
            this.VINTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.VINTextBox.Name = "VINTextBox";
            this.VINTextBox.Size = new System.Drawing.Size(259, 26);
            this.VINTextBox.TabIndex = 15;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yearTextBox.Location = new System.Drawing.Point(211, 140);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(259, 26);
            this.yearTextBox.TabIndex = 14;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.registrationLabel.Location = new System.Drawing.Point(14, 266);
            this.registrationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(82, 19);
            this.registrationLabel.TabIndex = 13;
            this.registrationLabel.Text = "Registration";
            // 
            // licensePlateLabel
            // 
            this.licensePlateLabel.AutoSize = true;
            this.licensePlateLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.licensePlateLabel.Location = new System.Drawing.Point(14, 224);
            this.licensePlateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licensePlateLabel.Name = "licensePlateLabel";
            this.licensePlateLabel.Size = new System.Drawing.Size(141, 19);
            this.licensePlateLabel.TabIndex = 12;
            this.licensePlateLabel.Text = "Licence Plate Number";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.yearLabel.Location = new System.Drawing.Point(14, 147);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(36, 19);
            this.yearLabel.TabIndex = 11;
            this.yearLabel.Text = "Year";
            // 
            // vinNumberLabel
            // 
            this.vinNumberLabel.AutoSize = true;
            this.vinNumberLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.vinNumberLabel.Location = new System.Drawing.Point(14, 183);
            this.vinNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vinNumberLabel.Name = "vinNumberLabel";
            this.vinNumberLabel.Size = new System.Drawing.Size(86, 19);
            this.vinNumberLabel.TabIndex = 10;
            this.vinNumberLabel.Text = "VIN Number";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitButton.Location = new System.Drawing.Point(277, 459);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(132, 30);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modelTextBox.Location = new System.Drawing.Point(211, 105);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(259, 26);
            this.modelTextBox.TabIndex = 7;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.makeTextBox.Location = new System.Drawing.Point(211, 69);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(259, 26);
            this.makeTextBox.TabIndex = 6;
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carNameTextBox.Location = new System.Drawing.Point(211, 31);
            this.carNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(259, 26);
            this.carNameTextBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.modelLabel.Location = new System.Drawing.Point(14, 112);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(48, 19);
            this.modelLabel.TabIndex = 3;
            this.modelLabel.Text = "Model";
            // 
            // carNameLabel
            // 
            this.carNameLabel.AutoSize = true;
            this.carNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carNameLabel.Location = new System.Drawing.Point(14, 38);
            this.carNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carNameLabel.Name = "carNameLabel";
            this.carNameLabel.Size = new System.Drawing.Size(70, 19);
            this.carNameLabel.TabIndex = 2;
            this.carNameLabel.Text = "Car Name";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.makeLabel.Location = new System.Drawing.Point(14, 76);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(43, 19);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.birthDateLabel.Location = new System.Drawing.Point(18, 424);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(66, 19);
            this.birthDateLabel.TabIndex = 20;
            this.birthDateLabel.Text = "In service";
            // 
            // inServiceCheckBox
            // 
            this.inServiceCheckBox.AutoSize = true;
            this.inServiceCheckBox.Location = new System.Drawing.Point(211, 429);
            this.inServiceCheckBox.Name = "inServiceCheckBox";
            this.inServiceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.inServiceCheckBox.TabIndex = 22;
            this.inServiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // branchNameComboBox
            // 
            this.branchNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchNameComboBox.FormattingEnabled = true;
            this.branchNameComboBox.Location = new System.Drawing.Point(211, 344);
            this.branchNameComboBox.Name = "branchNameComboBox";
            this.branchNameComboBox.Size = new System.Drawing.Size(259, 27);
            this.branchNameComboBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(14, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Branch Name";
            // 
            // carTypeNameLabel
            // 
            this.carTypeNameLabel.AutoSize = true;
            this.carTypeNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTypeNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.carTypeNameLabel.Location = new System.Drawing.Point(14, 384);
            this.carTypeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carTypeNameLabel.Name = "carTypeNameLabel";
            this.carTypeNameLabel.Size = new System.Drawing.Size(78, 19);
            this.carTypeNameLabel.TabIndex = 26;
            this.carTypeNameLabel.Text = "Type Name";
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Location = new System.Drawing.Point(211, 384);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(259, 27);
            this.carTypeComboBox.TabIndex = 25;
            // 
            // AddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(819, 611);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.enterCarDetailsGroupBox);
            this.Name = "AddNewCar";
            this.Text = "AddNewCar";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.enterCarDetailsGroupBox.ResumeLayout(false);
            this.enterCarDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox insuranceIDTextBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label addNewCarLabel;
        private System.Windows.Forms.GroupBox enterCarDetailsGroupBox;
        private System.Windows.Forms.Label insuranceLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.TextBox VINTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label licensePlateLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label vinNumberLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox carNameTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label carNameLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox branchNameComboBox;
        private System.Windows.Forms.CheckBox inServiceCheckBox;
        private System.Windows.Forms.Label carTypeNameLabel;
        private System.Windows.Forms.ComboBox carTypeComboBox;
    }
}