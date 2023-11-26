using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static hotel_v2.VariableData;

namespace hotel_v2
{
    public partial class Payment : Form
    {

        connect konn = new connect();

        public Payment()
        {
            InitializeComponent();

            lblName.Text = UserInformation.ClientName;
            lblDateIn.Text = DayInformation.DateIn.ToString("dd MMMM yyyy");
            lblDateOut.Text = DayInformation.DateOut.ToString("dd MMMM yyyy");
            lblDay.Text = int.Parse(DayInformation.Day).ToString("N0") + " Hari";
            lblCategory.Text = CategoryInformation.CategoryName;
            lblPrice.Text = "Rp. " + CategoryInformation.CategoryPrice;
            lblRoomNumber.Text = RoomInformation.RoomNumber;
            lblRoomPhone.Text = RoomInformation.RoomPhone;



            int days;
            if (int.TryParse(DayInformation.Day, out days))
            {
                decimal price;
                string categoryPrice = CategoryInformation.CategoryPrice.Replace(".", "");
                if (decimal.TryParse(categoryPrice, out price))
                {
                    decimal total = days * price;
                    lblTotal.Text = "Rp. " + total.ToString("#,##0");
                }
                else
                {
                    lblTotal.Text = "Category Price is not valid";
                }
            }
            else
            {
                lblTotal.Text = "Day is not valid";
            }


        }

        private void Kembali_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void Payment_Load(object sender, System.EventArgs e)
        {

        }

        private decimal CalculateTotal()
        {
            int days;
            if (int.TryParse(DayInformation.Day, out days))
            {
                decimal price;
                string categoryPrice = CategoryInformation.CategoryPrice.Replace(".", "");
                if (decimal.TryParse(categoryPrice, out price))
                {
                    decimal total = days * price;
                    return total;
                }
            }
            return 0;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPayment.Text == "")
                {
                    MessageBox.Show("Pilih metode pembayaran!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dateIn = DayInformation.DateIn;
                DateTime dateOut = DayInformation.DateOut;

                string formattedDateIn = dateIn.ToString("dd MMMM yyyy");
                string formattedDateOut = dateOut.ToString("dd MMMM yyyy");

                SqlConnection conn = konn.GetConn();
                conn.Open();

                decimal total = CalculateTotal();

                // Insert data ke dalam tabel tbl_Reservation
                SqlCommand insertCmd = new SqlCommand("INSERT INTO tbl_Reservation (Name, DateIn, DateOut, Day, Category, Price, RoomNumber, RoomPhone, Total, Payment) VALUES (@Name, @DateIn, @DateOut, @Day, @Category, @Price, @RoomNumber, @RoomPhone, @Total, @Payment)", conn);
                insertCmd.Parameters.AddWithValue("@Name", UserInformation.ClientName);
                insertCmd.Parameters.AddWithValue("@DateIn", formattedDateIn);
                insertCmd.Parameters.AddWithValue("@DateOut", formattedDateOut);
                insertCmd.Parameters.AddWithValue("@Day", DayInformation.Day);
                insertCmd.Parameters.AddWithValue("@Category", CategoryInformation.CategoryName);
                insertCmd.Parameters.AddWithValue("@Price", CategoryInformation.CategoryPrice);
                insertCmd.Parameters.AddWithValue("@RoomNumber", RoomInformation.RoomNumber);
                insertCmd.Parameters.AddWithValue("@RoomPhone", RoomInformation.RoomPhone);
                insertCmd.Parameters.AddWithValue("@Total", total.ToString("#,##0"));
                insertCmd.Parameters.AddWithValue("@Payment", cbPayment.Text);

                insertCmd.ExecuteNonQuery();

                SqlCommand updateCmd = new SqlCommand("UPDATE tbl_Room SET RoomFree = 'Busy' WHERE RoomNumber = @RoomNumber", conn);
                updateCmd.Parameters.AddWithValue("@RoomNumber", RoomInformation.RoomNumber);

                updateCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Pembayaran berhasil!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
