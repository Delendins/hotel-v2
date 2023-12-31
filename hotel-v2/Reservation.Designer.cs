﻿namespace hotel_v2
{
    partial class Reservation
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
            this.dgReserve = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReserve)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1244, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            // 
            // btnTambah
            // 
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTambah.Location = new System.Drawing.Point(378, 296);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTambah.Size = new System.Drawing.Size(134, 39);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.TabStop = false;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.Location = new System.Drawing.Point(543, 296);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(134, 39);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // btnHapus
            // 
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHapus.Location = new System.Drawing.Point(708, 296);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHapus.Size = new System.Drawing.Size(134, 39);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.TabStop = false;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgReserve
            // 
            this.dgReserve.AllowUserToAddRows = false;
            this.dgReserve.AllowUserToDeleteRows = false;
            this.dgReserve.AllowUserToResizeColumns = false;
            this.dgReserve.AllowUserToResizeRows = false;
            this.dgReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReserve.Location = new System.Drawing.Point(12, 466);
            this.dgReserve.Name = "dgReserve";
            this.dgReserve.ReadOnly = true;
            this.dgReserve.RowHeadersVisible = false;
            this.dgReserve.RowHeadersWidth = 51;
            this.dgReserve.RowTemplate.Height = 24;
            this.dgReserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReserve.Size = new System.Drawing.Size(1196, 378);
            this.dgReserve.TabIndex = 4;
            this.dgReserve.TabStop = false;
            this.dgReserve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReserve_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date In";
            this.label5.Visible = false;
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
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.Location = new System.Drawing.Point(1074, 402);
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
            // dateIn
            // 
            this.dateIn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateIn.Location = new System.Drawing.Point(756, 189);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(242, 30);
            this.dateIn.TabIndex = 16;
            this.dateIn.TabStop = false;
            this.dateIn.Visible = false;
            // 
            // dateOut
            // 
            this.dateOut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOut.Location = new System.Drawing.Point(756, 247);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(242, 30);
            this.dateOut.TabIndex = 18;
            this.dateOut.TabStop = false;
            this.dateOut.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date Out";
            this.label6.Visible = false;
            // 
            // cbClient
            // 
            this.cbClient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(334, 185);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(242, 32);
            this.cbClient.TabIndex = 19;
            this.cbClient.TabStop = false;
            this.cbClient.Visible = false;
            // 
            // cbRoom
            // 
            this.cbRoom.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(334, 244);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(242, 32);
            this.cbRoom.TabIndex = 20;
            this.cbRoom.TabStop = false;
            this.cbRoom.Visible = false;
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCari.Location = new System.Drawing.Point(12, 411);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(450, 30);
            this.tbCari.TabIndex = 1;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomNumber.Location = new System.Drawing.Point(400, 98);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(242, 30);
            this.tbRoomNumber.TabIndex = 21;
            this.tbRoomNumber.TabStop = false;
            this.tbRoomNumber.Visible = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 856);
            this.Controls.Add(this.tbRoomNumber);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgReserve);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel1);
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Booking";
            this.Load += new System.EventHandler(this.pemesan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReserve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgReserve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.TextBox tbRoomNumber;
    }
}

