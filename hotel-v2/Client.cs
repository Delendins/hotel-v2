﻿using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_v2
{
    public partial class Client : Form
    {

        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        connect konn = new connect();

        public Client()
        {
            InitializeComponent();
        }

        private void pemesan_Load(object sender, System.EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("SELECT * FROM tbl_Client", conn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgUser.DataSource = dt;

            if (dgUser.CurrentCell != null && dgUser.CurrentCell.Selected)
            {
                dgUser.CurrentCell.Selected = false;
            }

            tbId.ReadOnly = false;
            clean();
        }

        private void btnTambah_Click(object sender, System.EventArgs e)
        {
            if (tbNama.Text == "" || tbNo.Text == "" || cbAlamat.Text == null || tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_Client WHERE ClientId = @ClientId OR ClientUsername = @ClientUsername", conn);
            cmd.Parameters.AddWithValue("@ClientId", tbId.Text);
            cmd.Parameters.AddWithValue("@ClientUsername", tbUsername.Text);
            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("ID atau Username sudah terdaftar!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmd = new SqlCommand("INSERT INTO tbl_Client VALUES (@ClientName, @ClientPhone, @ClientCountry, @ClientUsername, @ClientPassword)", conn);
            cmd.Parameters.AddWithValue("@ClientName", tbNama.Text);
            cmd.Parameters.AddWithValue("@ClientPhone", tbNo.Text);
            cmd.Parameters.AddWithValue("@ClientCountry", cbAlamat.Text);
            cmd.Parameters.AddWithValue("@ClientUsername", tbUsername.Text);
            cmd.Parameters.AddWithValue("@ClientPassword", tbPassword.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Client berhasil ditambah!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pemesan_Load(this, null);
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (dgUser.SelectedCells.Count > 0)
            {
                if (tbNama.Text == "" || tbNo.Text == "" || cbAlamat.Text == null || tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Rubah?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conn = konn.GetConn();
                    cmd = new SqlCommand("UPDATE tbl_Client SET ClientName = @ClientName, ClientPhone = @ClientPhone, ClientCountry = @ClientCountry, ClientUsername = @ClientUsername, ClientPassword = @ClientPassword WHERE ClientId = @ClientId", conn);
                    cmd.Parameters.AddWithValue("@ClientId", tbId.Text);
                    cmd.Parameters.AddWithValue("@ClientName", tbNama.Text);
                    cmd.Parameters.AddWithValue("@ClientPhone", tbNo.Text);
                    cmd.Parameters.AddWithValue("@ClientCountry", cbAlamat.Text);
                    cmd.Parameters.AddWithValue("@ClientUsername", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@ClientPassword", tbPassword.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data berhasil dirubah!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pemesan_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diubah terlebih dahulu.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.ReadOnly = true;

            tbId.Text = dgUser.CurrentRow.Cells[0].Value.ToString();
            tbNama.Text = dgUser.CurrentRow.Cells[1].Value.ToString();
            tbNo.Text = dgUser.CurrentRow.Cells[2].Value.ToString();
            cbAlamat.Text = dgUser.CurrentRow.Cells[3].Value.ToString();
            tbUsername.Text = dgUser.CurrentRow.Cells[4].Value.ToString();
            tbPassword.Text = dgUser.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnHapus_Click(object sender, System.EventArgs e)
        {
            if (dgUser.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Hapus?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conn = konn.GetConn();
                    cmd = new SqlCommand("DELETE FROM tbl_Client WHERE ClientId = @ClientId", conn);
                    cmd.Parameters.AddWithValue("@ClientId", tbId.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data berhasil dihapus!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pemesan_Load(this, null);
                }

            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            pemesan_Load(this, null);
        }

        private void tbCari_TextChanged(object sender, System.EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("SELECT * FROM tbl_Client WHERE ClientId LIKE '%' + @Cari + '%' OR ClientName LIKE '%' + @Cari + '%' OR ClientPhone LIKE '%' + @Cari + '%' OR ClientCountry LIKE '%' + @Cari + '%' OR ClientUsername LIKE '%' + @Cari + '%' OR ClientPassword LIKE '%' + @Cari + '%'", conn);
            cmd.Parameters.AddWithValue("@Cari", tbCari.Text);

            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgUser.DataSource = dt;

            if (dgUser.CurrentCell != null)
            {
                dgUser.CurrentCell.Selected = false;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        public void clean()
        {
            tbId.Text = "";
            tbNama.Text = "";
            tbNo.Text = "";
            cbAlamat.Text = null;
            tbCari.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
}
