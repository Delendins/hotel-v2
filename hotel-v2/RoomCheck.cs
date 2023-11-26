using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

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

            dateIn.CustomFormat = "dd-MMMM-yyyy";
            dateOut.CustomFormat = "dd-MMMM-yyyy";
        }

        private void RoomCheck_Load(object sender, System.EventArgs e)
        {
            SqlConnection conn = konn.GetConn();

            conn.Open();
            SqlCommand cmdCate = new SqlCommand("SELECT * FROM tbl_Category", conn);
            SqlDataReader drCate = cmdCate.ExecuteReader();
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

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoom.Items.Clear();

            cbRoom.Text = null;

            if (cbCategory.SelectedIndex >= 0 && cbCategory.SelectedIndex < Rooms.Count)
            {
                int id = Rooms[cbCategory.SelectedIndex].CategoryId;
                string[] roomNumbers = GetRoomById(id).Select(num => num.ToString()).ToArray();
                foreach (string roomNumber in roomNumbers)
                {
                    cbRoom.Items.Add(roomNumber);
                }
            }
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex >= 0 && cbRoom.SelectedIndex >= 0)
            {
                int categoryId = Categories[cbCategory.SelectedIndex].CategoryId;
                int roomNumber = int.Parse(cbRoom.SelectedItem.ToString());

                SqlConnection conn = konn.GetConn();

                string query = $"SELECT RoomFree FROM tbl_Room WHERE CategoryId = {categoryId} AND RoomNumber = {roomNumber}";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string roomFreeStatus = result.ToString();

                        if (roomFreeStatus.Equals("Free", StringComparison.OrdinalIgnoreCase))
                        {
                            if (MessageBox.Show("Kamar tersedia! Lanjutkan pembayaran?", "Info!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                Payment payment = new Payment();
                                payment.Show();
                                this.Hide();
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

        private void btnKembali_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
