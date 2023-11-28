using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static hotel_v2.VariableData;

namespace hotel_v2
{
    public partial class Account : Form
    {
        SqlCommand cmd;

        connect konn = new connect();

        public Account()
        {
            InitializeComponent();
        }

        private void Acount_Load(object sender, EventArgs e)
        {
            int clientId = UserInformation.ClientId;

            SqlConnection conn = konn.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Client WHERE ClientId = @ClientId", conn);
            cmd.Parameters.AddWithValue("@ClientId", clientId);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbId.Text = reader["ClientId"].ToString();
                tbName.Text = reader["ClientName"].ToString();
                tbPhone.Text = reader["ClientPhone"].ToString();
                cbCountry.Text = reader["ClientCountry"].ToString();
                tbUsername.Text = reader["ClientUsername"].ToString();
                tbPassword.Text = reader["ClientPassword"].ToString();
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPhone.Text == "" || cbCountry.Text == null || tbPassword.Text == "")
            {
                MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Rubah?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("UPDATE tbl_Client SET ClientPhone = @ClientPhone, ClientCountry = @ClientCountry, ClientPassword = @ClientPassword WHERE ClientId = @ClientId", conn);
                cmd.Parameters.AddWithValue("@ClientId", tbId.Text);
                cmd.Parameters.AddWithValue("@ClientPhone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@ClientCountry", cbCountry.Text);
                cmd.Parameters.AddWithValue("@ClientPassword", tbPassword.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil dirubah! silahkan login ulang!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Application.Restart();
        }


        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


    }
}
