using System;
using System.Data;
using MySqlConnector;
using System.Windows.Forms;

namespace medicareApp.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;

        public MySqlConnection GetConn()
        {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=puskesmas";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("koneksi gagal " + ex.Message);
            }
            return conn;
        }
    }
}
