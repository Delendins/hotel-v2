using System.Windows.Forms;
using static hotel_v2.VariableData;

namespace hotel_v2
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();

            Name.Text = UserInformation.ClientName;
        }

        private void Kembali_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
