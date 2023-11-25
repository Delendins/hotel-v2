using System.Data.SqlClient;

namespace hotel_v2
{
    internal class connect
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection("Data Source=FPC-03\\SQLEXPRESS;Initial Catalog=hotel-v2;Integrated Security=True");
            return conn;
        }
    }
}
