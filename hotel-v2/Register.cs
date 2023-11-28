using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_v2
{
    public partial class Register : Form
    {
        SqlCommand cmd;

        connect konn = new connect();

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || cbCountry.Text == null || tbUsername.Text == "" || tbPassword.Text == "")
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
                MessageBox.Show("Username sudah terdaftar!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmd = new SqlCommand("INSERT INTO tbl_Client VALUES (@ClientName, @ClientPhone, @ClientCountry, @ClientUsername, @ClientPassword)", conn);
            cmd.Parameters.AddWithValue("@ClientName", tbName.Text);
            cmd.Parameters.AddWithValue("@ClientPhone", tbPhone.Text);
            cmd.Parameters.AddWithValue("@ClientCountry", cbCountry.Text);
            cmd.Parameters.AddWithValue("@ClientUsername", tbUsername.Text);
            cmd.Parameters.AddWithValue("@ClientPassword", tbPassword.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Register berhasil!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login login = new Login();
            login.Show();
            this.Hide();


        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
