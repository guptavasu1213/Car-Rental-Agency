namespace CarRentalApp
{
    partial class Form1
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
            this.result = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(158, 371);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(258, 29);
            this.result.TabIndex = 0;
            this.result.Text = "[Gets replaced by your text]";
            this.result.UseCompatibleTextRendering = true;
            this.result.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputName
            // 
            this.inputName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputName.Location = new System.Drawing.Point(158, 153);
            this.inputName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(343, 30);
            this.inputName.TabIndex = 1;
            this.inputName.Text = "Enter your name";
            this.inputName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputName.Enter += new System.EventHandler(this.nameTextBoxEnter);
            this.inputName.Leave += new System.EventHandler(this.nameTextBoxLeave);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(158, 259);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(345, 36);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Click Me!";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.result);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox inputName;
    }
}

