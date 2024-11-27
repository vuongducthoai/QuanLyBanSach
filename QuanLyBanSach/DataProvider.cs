using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach
{
    internal class DataProvider
    {
        private string connectionString = @"Data Source=VUONGDUCTHOAI;User ID=sa;Password=Thoai12309@;Connect Timeout=30;Encrypt=True;Initial Catalog=QLBS;TrustServerCertificate=True";

        public DataTable execQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public int execNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }

        public object execScaler(string query)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                data = cmd.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
