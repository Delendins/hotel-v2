using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static hotel_v2.VariableData;

namespace hotel_v2
{
    public partial class RoomCheck : Form
    {

        connect konn = new connect();

        List<Category> Categories = new List<Category>();
        List<Room> Rooms = new List<Room>();

        public RoomCheck()
        {
            InitializeComponent();

            dateInPicker.CustomFormat = "dd MMMM yyyy";
            dateOutPicker.CustomFormat = "dd MMMM yyyy";

            dateInPicker.Value = DateTime.Today;
            dateOutPicker.Value = DateTime.Today.AddDays(1);

            dateInPicker.ValueChanged += dateInPicker_ValueChanged;
            dateOutPicker.ValueChanged += dateOutPicker_ValueChanged;
        }

        private void RoomCheck_Load(object sender, System.EventArgs e)
        {
            SqlConnection conn = konn.GetConn();

            conn.Open();
            SqlCommand cmdCate = new SqlCommand("SELECT * FROM tbl_Category", conn);
            SqlDataReader drCate = cmdCate.ExecuteReader();
            cbCategory.Items.Clear();
            while (drCate.Read())
            {
                cbCategory.Items.Add(drCate["CategoryName"]);
                Categories.Add(new Category()
                {
                    CategoryId = ((int)drCate["CategoryId"]),
                    CategoryName = drCate["CategoryName"] as string
                });
            }
            conn.Close();
            conn.Open();
            SqlCommand cmdRoom = new SqlCommand("SELECT * FROM tbl_Room", conn);
            SqlDataReader drRoom = cmdRoom.ExecuteReader();
            cbRoom.Items.Clear();
            while (drRoom.Read())
            {
                Rooms.Add(new Room()
                {
                    RoomId = ((int)drRoom["RoomId"]),
                    RoomNumber = ((int)drRoom["RoomNumber"]),
                    CategoryId = ((int)drRoom["CategoryId"])
                });
            }
            conn.Close();

            lblPrice.Text = "";

            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;

        }

        private bool IsDateValid(DateTime dateIn, DateTime dateOut)
        {
            DateTime currentDate = DateTime.Today;

            if (dateOutPicker.Checked && dateOut <= dateIn)
            {
                MessageBox.Show("Tanggal Check-Out harus setelah Tanggal Check-In.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateOutPicker.Value = currentDate.AddDays(1);
                dateInPicker.Value = currentDate;
                return false;
            }

            if (dateIn < currentDate)
            {
                MessageBox.Show("Tanggal Check-In tidak bisa sebelum tanggal hari ini.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateOutPicker.Value = currentDate.AddDays(1);
                dateInPicker.Value = currentDate;
                return false;
            }

            return true;
        }


        private void YourDateInValueChangedFunction()
        {
            DateTime dateIn = dateInPicker.Value;
            DateTime dateOut = dateOutPicker.Value;
            DayInformation.DateIn = dateIn;
            DayInformation.DateOut = dateOut;

            if (IsDateValid(dateIn, dateOut))
            {
                TimeSpan duration = dateOut - dateIn;

                int daysDifference = (int)duration.TotalDays;

                DayInformation.Day = daysDifference.ToString();
                lblDay.Text = $"Durasi: {daysDifference:N0} hari";
            }
        }

        private void dateInPicker_ValueChanged(object sender, EventArgs e)
        {
            YourDateInValueChangedFunction();
        }

        private void dateOutPicker_ValueChanged(object sender, EventArgs e)
        {
            YourDateInValueChangedFunction();
        }


        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoom.Items.Clear();
            cbRoom.Text = null;

            lblPrice.Text = "";

            if (cbCategory.SelectedIndex >= 0 && cbCategory.SelectedIndex < Categories.Count)
            {

                int categoryId = Categories[cbCategory.SelectedIndex].CategoryId;
                string categoryName = Categories[cbCategory.SelectedIndex].CategoryName;

                int id = Categories[cbCategory.SelectedIndex].CategoryId;

                string price = GetPriceByCategoryId(id);

                lblPrice.Text = $"*Harga: {price} per Day";

                string[] roomNumbers = GetRoomById(id).Select(num => num.ToString()).ToArray();
                foreach (string roomNumber in roomNumbers)
                {
                    cbRoom.Items.Add(roomNumber);
                }

                CategoryInformation.CategoryId = categoryId.ToString();
                CategoryInformation.CategoryName = categoryName;
                CategoryInformation.CategoryPrice = price;
            }
        }

        private string GetPriceByCategoryId(int categoryId)
        {
            string price = "";

            SqlConnection conn = konn.GetConn();
            conn.Open();

            string query = $"SELECT CategoryPrice FROM tbl_Category WHERE CategoryId = {categoryId}";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    price = result.ToString();
                }
            }

            conn.Close();

            return price;
        }


        private void btnCek_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex >= 0 && cbRoom.SelectedIndex >= 0)
            {
                int categoryId = Categories[cbCategory.SelectedIndex].CategoryId;
                int roomNumber = int.Parse(cbRoom.SelectedItem.ToString());
                RoomInformation.RoomNumber = roomNumber.ToString();

                SqlConnection conn = konn.GetConn();

                string query = $"SELECT RoomFree, RoomPhone FROM tbl_Room WHERE CategoryId = {categoryId} AND RoomNumber = {roomNumber}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string roomFreeStatus = reader["RoomFree"].ToString();

                        string roomPhone = reader["RoomPhone"].ToString();
                        RoomInformation.RoomPhone = roomPhone;

                        if (roomFreeStatus.Equals("Free", StringComparison.OrdinalIgnoreCase))
                        {
                            DateTime dateIn = dateInPicker.Value;
                            DateTime dateOut = dateOutPicker.Value;

                            TimeSpan duration = dateOut - dateIn;
                            int daysDifference = (int)duration.TotalDays;

                            if (daysDifference == 0)
                            {
                                MessageBox.Show("Rentang waktu antara Check-In dan Check-Out adalah 0 hari. Silakan pilih tanggal yang berbeda.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (MessageBox.Show("Kamar tersedia! Lanjutkan pembayaran?", "Info!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    Payment payment = new Payment();
                                    payment.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kamar tidak tersedia", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Silahkan pilih category dan room terlebih dahulu!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int[] GetRoomById(int id)
        {
            return Rooms.Where(line => line.CategoryId == id).Select(r => r.RoomNumber).ToArray();
        }


        [Serializable]
        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }

        [Serializable]
        class Room
        {
            public int RoomId { get; set; }
            public int RoomNumber { get; set; }
            public int CategoryId { get; set; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnKembali_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void ResetForm()
        {
            dateInPicker.Value = DateTime.Today;
            dateOutPicker.Value = DateTime.Today.AddDays(1);


            cbCategory.SelectedIndex = -1;
            cbRoom.Items.Clear();
            lblPrice.Text = "";

            dateInPicker.Focus();
        }
    }
}
