using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_v2
{
    public partial class Room : Form
    {

        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        connect konn = new connect();

        public Room()
        {
            InitializeComponent();
        }

        private void pemesan_Load(object sender, System.EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT R.RoomId, R.RoomNumber, R.RoomPhone, C.CategoryName, R.RoomFree FROM tbl_Room R INNER JOIN tbl_Category C ON R.CategoryId = C.CategoryId ORDER BY R.RoomId, R.RoomNumber, R.RoomPhone, R.CategoryId, R.RoomFree", conn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgUser.DataSource = dt;

            cmd = new SqlCommand("SELECT CategoryId, CategoryName FROM tbl_Category", conn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            cbCategory.DataSource = dt;

            if (dgUser.CurrentCell != null && dgUser.CurrentCell.Selected)
            {
                dgUser.CurrentCell.Selected = false;
            }

            tbId.ReadOnly = false;
            clean();
        }


        private void btnTambah_Click(object sender, System.EventArgs e)
        {
            if (cbCategory.Text == "" || tbNumber.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string isfree = yesRadio.Checked ? "Free" : "Busy";
            if (!yesRadio.Checked && !noRadio.Checked)
            {
                isfree = "Free";
            }

            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_Room WHERE RoomId = @RoomId OR RoomNumber = @RoomNumber OR RoomPhone = @RoomPhone", conn);
            cmd.Parameters.AddWithValue("@RoomId", tbId.Text);
            cmd.Parameters.AddWithValue("@RoomNumber", tbNumber.Text);
            cmd.Parameters.AddWithValue("@RoomPhone", tbPhone.Text);
            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("ID atau Room Number atau Room Phone sudah terdaftar!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCategoryId = Convert.ToInt32(cbCategory.SelectedValue);

            cmd = new SqlCommand("INSERT INTO tbl_Room VALUES (@RoomNumber, @RoomPhone, @Category, @Status)", conn);
            cmd.Parameters.AddWithValue("@RoomNumber", tbNumber.Text);
            cmd.Parameters.AddWithValue("@RoomPhone", tbPhone.Text);
            cmd.Parameters.AddWithValue("@Category", selectedCategoryId);
            cmd.Parameters.AddWithValue("@Status", isfree);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Room berhasil ditambah!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pemesan_Load(this, null);
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (dgUser.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Rubah?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string isfree = yesRadio.Checked ? "Free" : "Busy";
                    int selectedCategoryId = Convert.ToInt32(cbCategory.SelectedValue);

                    SqlConnection conn = konn.GetConn();
                    cmd = new SqlCommand("UPDATE tbl_Room SET RoomNumber = @RoomNumber, RoomPhone = @RoomPhone, CategoryId = @Category, RoomFree = @Status WHERE RoomId = @RoomId", conn);
                    cmd.Parameters.AddWithValue("@RoomId", tbId.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber", tbNumber.Text);
                    cmd.Parameters.AddWithValue("@RoomPhone", tbPhone.Text);
                    cmd.Parameters.AddWithValue("@Category", selectedCategoryId);
                    cmd.Parameters.AddWithValue("@Status", isfree);

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
            tbNumber.Text = dgUser.CurrentRow.Cells[1].Value.ToString();
            tbPhone.Text = dgUser.CurrentRow.Cells[2].Value.ToString();
            string categoryName = dgUser.CurrentRow.Cells[3].Value.ToString();

            int index = cbCategory.FindStringExact(categoryName);
            if (index != -1)
            {
                cbCategory.SelectedIndex = index;
            }

            string status = dgUser.CurrentRow.Cells[4].Value.ToString();

            if (status == "Free")
            {
                yesRadio.Checked = true;
                noRadio.Checked = false;
            }
            else if (status == "Busy")
            {
                yesRadio.Checked = false;
                noRadio.Checked = true;
            }
            else
            {
                yesRadio.Checked = false;
                noRadio.Checked = false;
            }
        }

        private void btnHapus_Click(object sender, System.EventArgs e)
        {
            if (dgUser.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Hapus?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conn = konn.GetConn();
                    cmd = new SqlCommand("DELETE FROM tbl_Room WHERE RoomId = @RoomId", conn);
                    cmd.Parameters.AddWithValue("@RoomId", tbId.Text);

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
            cmd = new SqlCommand("SELECT * FROM tbl_Room WHERE RoomId LIKE '%' + @Cari + '%' OR RoomPhone LIKE '%' + @Cari + '%' OR RoomFree LIKE '%' + @Cari + '%'", conn);
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
            cbCategory.Text = "";
            tbNumber.Text = "";
            tbPhone.Text = "";
            tbCari.Text = "";
            yesRadio.Checked = false;
            noRadio.Checked = false;
        }
    }
}
