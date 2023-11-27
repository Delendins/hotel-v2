namespace hotel_v2
{
    partial class Room
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(1209, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(433, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            // 
            // btnTambah
            // 
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTambah.Location = new System.Drawing.Point(28, 430);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTambah.Size = new System.Drawing.Size(134, 39);
            this.btnTambah.TabIndex = 1;
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
            this.btnEdit.Location = new System.Drawing.Point(193, 430);
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
            this.btnHapus.Location = new System.Drawing.Point(358, 430);
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
            this.dgUser.Size = new System.Drawing.Size(651, 308);
            this.dgUser.TabIndex = 4;
            this.dgUser.TabStop = false;
            this.dgUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUser_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Free";
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
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(250, 277);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(242, 30);
            this.tbPhone.TabIndex = 2;
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
            this.btnRefresh.Location = new System.Drawing.Point(1039, 173);
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
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesRadio.Location = new System.Drawing.Point(252, 380);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(59, 28);
            this.yesRadio.TabIndex = 16;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRadio.Location = new System.Drawing.Point(344, 380);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(52, 28);
            this.noRadio.TabIndex = 17;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(250, 227);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(242, 30);
            this.tbNumber.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(250, 324);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(240, 32);
            this.cbCategory.TabIndex = 3;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 566);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noRadio);
            this.Controls.Add(this.yesRadio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgUser);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel1);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Kamar";
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
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}

