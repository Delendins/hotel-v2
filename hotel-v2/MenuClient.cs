using System;
using System.Windows.Forms;

namespace hotel_v2
{
    public partial class MenuClient : Form
    {
        public MenuClient()
        {
            InitializeComponent();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RoomCheck roomCheck = new RoomCheck();
            roomCheck.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClientReserve clientReserve = new ClientReserve();
            clientReserve.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
        }
    }
}
