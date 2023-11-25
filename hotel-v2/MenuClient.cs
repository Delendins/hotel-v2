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
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Hide();
        }
    }
}
