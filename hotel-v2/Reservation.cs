using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_v2
{
    public partial class Reservation : Form
    {

        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        connect konn = new connect();

        public Reservation()
        {
            InitializeComponent();

            dateIn.CustomFormat = "dd MMMM yyyy";
            dateOut.CustomFormat = "dd MMMM yyyy";
        }

        private void pemesan_Load(object sender, System.EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("SELECT * FROM tbl_Reservation", conn);
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
            if (tbId.Text == "" || cbClient.Text == "" || cbRoom.Text == "" || dateIn.Text == "" || dateOut.Text == "")
            {
                MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_Reservation WHERE ResId = @ResId", conn);
            cmd.Parameters.AddWithValue("@ResId", tbId.Text);
            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("ID sudah terdaftar!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmd = new SqlCommand("INSERT INTO tbl_Reservation VALUES (@ResId, @Client, @RoomId, @DateIn, @DateOut)", conn);
            cmd.Parameters.AddWithValue("@ResId", tbId.Text);
            cmd.Parameters.AddWithValue("@Client", cbClient.Text);
            cmd.Parameters.AddWithValue("@RoomId", cbRoom.Text);
            cmd.Parameters.AddWithValue("@DateIn", dateIn.Value);
            cmd.Parameters.AddWithValue("@DateOut", dateOut.Value);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("User berhasil ditambah!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pemesan_Load(this, null);
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (dgUser.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Rubah?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conn = konn.GetConn();
                    cmd = new SqlCommand("UPDATE tbl_Reservation SET Client = @Client, RoomId = @RoomId, ClientCountry = @ClientCountry WHERE ResId = @ResId", conn);
                    cmd.Parameters.AddWithValue("@ResId", tbId.Text);
                    cmd.Parameters.AddWithValue("@Client", cbClient.Text);
                    cmd.Parameters.AddWithValue("@RoomId", cbRoom.Text);

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
            cbClient.Text = dgUser.CurrentRow.Cells[1].Value.ToString();
            cbRoom.Text = dgUser.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnHapus_Click(object sender, System.EventArgs e)
        {
            if (dgUser.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Hapus?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conn = konn.GetConn();
                    cmd = new SqlCommand("DELETE FROM tbl_Reservation WHERE ResId = @ResId", conn);
                    cmd.Parameters.AddWithValue("@ResId", tbId.Text);

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
            cmd = new SqlCommand("SELECT * FROM tbl_Reservation WHERE ResId LIKE '%' + @Cari + '%' OR Client LIKE '%' + @Cari + '%' OR RoomId LIKE '%' + @Cari + '%' OR ClientCountry LIKE '%' + @Cari + '%'", conn);
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
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        public void clean()
        {
            tbId.Text = "";
            cbClient.Text = "";
            cbRoom.Text = "";
            tbCari.Text = "";
        }
    }
}
