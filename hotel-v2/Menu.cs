using System;
using System.Windows.Forms;

namespace hotel_v2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }
    }
}
