using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static hotel_v2.VariableData;

namespace hotel_v2
{
    public partial class ClientReserve : Form
    {

        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;

        connect konn = new connect();

        public ClientReserve()
        {
            InitializeComponent();
        }

        private void ClientReserve_Load(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("SELECT * FROM tbl_Reservation WHERE Name = @Name", conn);
            cmd.Parameters.AddWithValue("@Name", UserInformation.ClientName);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dgReserve.DataSource = dt;

            if (dgReserve.CurrentCell != null)
            {
                dgReserve.CurrentCell.Selected = false;
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("SELECT * FROM tbl_Reservation WHERE (ResId LIKE '%' + @Cari + '%' OR Name LIKE '%' + @Cari + '%' OR DateIn LIKE '%' + @Cari + '%' OR DateOut LIKE '%' + @Cari + '%' OR Day LIKE '%' + @Cari + '%' OR Category LIKE '%' + @Cari + '%' OR Price LIKE '%' + @Cari + '%' OR RoomNumber LIKE '%' + @Cari + '%' OR RoomPhone LIKE '%' + @Cari + '%' OR Total LIKE '%' + @Cari + '%' OR Payment LIKE '%' + @Cari + '%') AND Name = @Name", conn);
            cmd.Parameters.AddWithValue("@Name", UserInformation.ClientName);
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
    }
}
