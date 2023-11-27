namespace hotel_v2
{
    partial class Staff
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgUser = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-12, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1551, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(610, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            // 
            // btnTambah
            // 
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTambah.Location = new System.Drawing.Point(28, 546);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTambah.Size = new System.Drawing.Size(134, 39);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.TabStop = false;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.Location = new System.Drawing.Point(193, 546);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(134, 39);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHapus.Location = new System.Drawing.Point(358, 546);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHapus.Size = new System.Drawing.Size(134, 39);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.TabStop = false;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgUser
            // 
            this.dgUser.AllowUserToAddRows = false;
            this.dgUser.AllowUserToDeleteRows = false;
            this.dgUser.AllowUserToResizeColumns = false;
            this.dgUser.AllowUserToResizeRows = false;
            this.dgUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Location = new System.Drawing.Point(522, 227);
            this.dgUser.Name = "dgUser";
            this.dgUser.ReadOnly = true;
            this.dgUser.RowHeadersVisible = false;
            this.dgUser.RowHeadersWidth = 51;
            this.dgUser.RowTemplate.Height = 24;
            this.dgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUser.Size = new System.Drawing.Size(993, 358);
            this.dgUser.TabIndex = 4;
            this.dgUser.TabStop = false;
            this.dgUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUser_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Staff Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Num";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(152, 98);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(242, 30);
            this.tbId.TabIndex = 9;
            this.tbId.TabStop = false;
            this.tbId.Visible = false;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(250, 227);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(242, 30);
            this.tbNama.TabIndex = 1;
            // 
            // tbNo
            // 
            this.tbNo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNo.Location = new System.Drawing.Point(250, 287);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(242, 30);
            this.tbNo.TabIndex = 2;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
            this.cbGender.Location = new System.Drawing.Point(250, 345);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(242, 32);
            this.cbGender.TabIndex = 3;
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCari.Location = new System.Drawing.Point(522, 182);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(228, 30);
            this.tbCari.TabIndex = 13;
            this.tbCari.TabStop = false;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.Location = new System.Drawing.Point(1381, 173);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefresh.Size = new System.Drawing.Size(134, 39);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(12, 89);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 15;
            this.button1.TabStop = false;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(250, 409);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(242, 30);
            this.tbUsername.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Staff Username";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(250, 473);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(242, 30);
            this.tbPassword.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Staff Password";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 621);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgUser);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel1);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Petugas";
            this.Load += new System.EventHandler(this.pemesan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label7;
    }
}

