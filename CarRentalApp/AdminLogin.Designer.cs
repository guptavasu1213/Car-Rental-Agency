namespace CarRentalApp
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_field = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.admin_login_result_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.Black;
            this.username_label.Location = new System.Drawing.Point(372, 132);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(147, 35);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.password_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.password_label.Font = new System.Drawing.Font("Calisto MT", 18F);
            this.password_label.Location = new System.Drawing.Point(372, 200);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(138, 35);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            this.password_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // username_field
            // 
            this.username_field.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_field.Location = new System.Drawing.Point(561, 125);
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(201, 42);
            this.username_field.TabIndex = 2;
            // 
            // password_field
            // 
            this.password_field.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_field.Location = new System.Drawing.Point(561, 197);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(201, 42);
            this.password_field.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Submit.Location = new System.Drawing.Point(561, 268);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(199, 42);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // admin_login_result_label
            // 
            this.admin_login_result_label.AutoSize = true;
            this.admin_login_result_label.Location = new System.Drawing.Point(558, 340);
            this.admin_login_result_label.Name = "admin_login_result_label";
            this.admin_login_result_label.Size = new System.Drawing.Size(0, 17);
            this.admin_login_result_label.TabIndex = 6;
            this.admin_login_result_label.Visible = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(4, 115);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(324, 184);
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correct Username: 291\r\nCorrect Pass: Win";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(864, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.admin_login_result_label);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.username_field);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "AdminLogin";
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_field;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label admin_login_result_label;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
    }
}