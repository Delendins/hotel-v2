using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_v2
{
    public partial class RoomCheck : Form
    {

        connect konn = new connect();

        public RoomCheck()
        {
            InitializeComponent();

            dateIn.CustomFormat = "dd-MMMM-yyyy";
            dateOut.CustomFormat = "dd-MMMM-yyyy";
        }

        private void RoomCheck_Load(object sender, System.EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Category", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
        }

        private void btnKembali_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void cbCategory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            label3.Text = cbCategory.SelectedValue.ToString();
        }
    }
}
