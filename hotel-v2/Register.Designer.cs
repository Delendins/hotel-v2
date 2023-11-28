namespace hotel_v2
{
    partial class Register
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
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.Location = new System.Drawing.Point(200, 673);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(45, 22);
            this.linkLogin.TabIndex = 21;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(155, 619);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegister.Size = new System.Drawing.Size(134, 39);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.TabStop = false;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(103, 542);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(242, 30);
            this.tbPassword.TabIndex = 5;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(104, 453);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(242, 30);
            this.tbUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(104, 281);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(242, 30);
            this.tbPhone.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(103, 197);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 30);
            this.tbName.TabIndex = 1;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Brunei Darussalam",
            "Kamboja",
            "Indonesia",
            "Laos",
            "Malaysia",
            "Myanmar",
            "Filipina",
            "Singapura",
            "Thailand",
            "Vietnam"});
            this.cbCountry.Location = new System.Drawing.Point(104, 371);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(241, 32);
            this.cbCountry.TabIndex = 3;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(104, 698);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(242, 30);
            this.tbId.TabIndex = 29;
            this.tbId.TabStop = false;
            this.tbId.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 733);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox tbId;
    }
}