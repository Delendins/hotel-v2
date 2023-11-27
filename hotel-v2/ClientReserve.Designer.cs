namespace hotel_v2
{
    partial class ClientReserve
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
            this.btnKembali = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.dgReserve = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReserve)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnKembali.Location = new System.Drawing.Point(12, 89);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKembali.Size = new System.Drawing.Size(134, 39);
            this.btnKembali.TabIndex = 17;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-12, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 100);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(538, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCari.Location = new System.Drawing.Point(532, 209);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(447, 30);
            this.tbCari.TabIndex = 19;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // dgReserve
            // 
            this.dgReserve.AllowUserToAddRows = false;
            this.dgReserve.AllowUserToDeleteRows = false;
            this.dgReserve.AllowUserToResizeColumns = false;
            this.dgReserve.AllowUserToResizeRows = false;
            this.dgReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReserve.Location = new System.Drawing.Point(12, 254);
            this.dgReserve.Name = "dgReserve";
            this.dgReserve.ReadOnly = true;
            this.dgReserve.RowHeadersVisible = false;
            this.dgReserve.RowHeadersWidth = 51;
            this.dgReserve.RowTemplate.Height = 24;
            this.dgReserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReserve.Size = new System.Drawing.Size(1487, 362);
            this.dgReserve.TabIndex = 18;
            // 
            // ClientReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 628);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.dgReserve);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.panel1);
            this.Name = "ClientReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Information";
            this.Load += new System.EventHandler(this.ClientReserve_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReserve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.DataGridView dgReserve;
    }
}