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
            cmd = new SqlCommand("SELECT * FROM tbl_Reservation ORDER BY OrderAt DESC", conn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgReserve.DataSource = dt;

            if (dgReserve.CurrentCell != null && dgReserve.CurrentCell.Selected)
            {
                dgReserve.CurrentCell.Selected = false;
            }

            tbId.ReadOnly = false;
            clean();
        }

        private void dgReserve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.ReadOnly = true;

            tbId.Text = dgReserve.CurrentRow.Cells[0].Value.ToString();
            tbRoomNumber.Text = dgReserve.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnHapus_Click(object sender, System.EventArgs e)
        {
            if (dgReserve.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Hapus?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection conn = konn.GetConn())
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Reservation WHERE ResId = @ResId", conn))
                        {
                            cmd.Parameters.AddWithValue("@ResId", tbId.Text);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_Room SET RoomFree = 'Free' WHERE RoomNumber = @RoomNumber", conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@RoomNumber", tbRoomNumber.Text);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        conn.Close();
                    }

                    MessageBox.Show("Data berhasil dihapus dan diperbarui!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            cmd = new SqlCommand("SELECT * FROM tbl_Reservation WHERE ResId LIKE '%' + @Cari + '%' OR Name LIKE '%' + @Cari + '%' OR DateIn LIKE '%' + @Cari + '%' OR DateOut LIKE '%' + @Cari + '%' OR Day LIKE '%' + @Cari + '%' OR Category LIKE '%' + @Cari + '%' OR Price LIKE '%' + @Cari + '%' OR RoomNumber LIKE '%' + @Cari + '%' OR RoomPhone LIKE '%' + @Cari + '%' OR Total LIKE '%' + @Cari + '%' OR Payment LIKE '%' + @Cari + '%'", conn);
            cmd.Parameters.AddWithValue("@Cari", tbCari.Text);

            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgReserve.DataSource = dt;

            if (dgReserve.CurrentCell != null)
            {
                dgReserve.CurrentCell.Selected = false;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
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
