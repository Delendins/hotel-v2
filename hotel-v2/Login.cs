using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static hotel_v2.VariableData;

namespace hotel_v2
{
    public partial class Login : Form
    {
        connect konn = new connect();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password wajib di isi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = konn.GetConn();
            conn.Open();

            SqlCommand cmdAdmin = new SqlCommand("SELECT * FROM tbl_Staff WHERE StaffUsername = @Username AND StaffPassword = @Password", conn);
            cmdAdmin.Parameters.AddWithValue("@Username", tbUsername.Text);
            cmdAdmin.Parameters.AddWithValue("@Password", tbPassword.Text);

            SqlCommand cmdClient = new SqlCommand("SELECT * FROM tbl_Client WHERE ClientUsername = @Username AND ClientPassword = @Password", conn);
            cmdClient.Parameters.AddWithValue("@Username", tbUsername.Text);
            cmdClient.Parameters.AddWithValue("@Password", tbPassword.Text);

            DataTable dtAdmin = new DataTable();
            DataTable dtClient = new DataTable();

            using (SqlDataAdapter daAdmin = new SqlDataAdapter(cmdAdmin))
            {
                daAdmin.Fill(dtAdmin);
            }

            using (SqlDataAdapter daClient = new SqlDataAdapter(cmdClient))
            {
                daClient.Fill(dtClient);
            }

            string userType = "";

            if (dtAdmin.Rows.Count > 0)
            {
                userType = "Staff";
            }
            else if (dtClient.Rows.Count > 0)
            {
                userType = "Client";
            }

            if (userType == "Staff")
            {
                MessageBox.Show("Login berhasil sebagai Admin", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else if (userType == "Client")
            {
                MessageBox.Show("Login berhasil sebagai Client!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string clientIdString = dtClient.Rows[0]["ClientId"].ToString();
                int clientId;

                if (int.TryParse(clientIdString, out clientId))
                {
                    UserInformation.ClientId = clientId;
                }

                UserInformation.ClientName = dtClient.Rows[0]["ClientName"].ToString();

                MenuClient menuClient = new MenuClient();
                menuClient.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal. Periksa kembali username dan password Anda.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
