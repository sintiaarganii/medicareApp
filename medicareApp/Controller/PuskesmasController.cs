using System;
using System.Data;
using System.Windows.Forms;
using medicareApp.Model;
using MySqlConnector;

namespace medicareApp.Controller
{
    internal class PuskesmasController : Model.Connection
    {
        private Connection conn = new Connection();

        public PuskesmasController()
        {
            conn = new Connection(); 
        }
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = conn.GetConn();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        public void signUp(string username, string password)
        {
            string add = "INSERT INTO signUp (userr, pass) VALUES (@userr, @pass)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, conn.GetConn());
                cmd.Parameters.Add("@userr", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pass", MySqlConnector.MySqlDbType.VarChar).Value = password;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Data Failed " + ex.Message);
            }
        }

        public DataTable tampilDokter(MySqlCommand cmd)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM dokter";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void insertDokter(string id, string nama, string spesialis, string alamat, string notlp, string jadwal)
        {
            string insert = "INSERT INTO dokter VALUES(" + "@id_dokter, @nama, @spesialisasi, @nomor_telepon, @alamat, @jadwal_praktik)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(insert, GetConn());
                cmd.Parameters.Add("@id_dokter", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@spesialisasi", MySqlConnector.MySqlDbType.VarChar).Value = spesialis;
                cmd.Parameters.Add("@nomor_telepon", MySqlConnector.MySqlDbType.VarChar).Value = notlp;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@jadwal_praktik", MySqlConnector.MySqlDbType.VarChar).Value = jadwal;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert data gagal" + ex.Message);
            }
        }

        public void updateDokter(string id, string nama, string spesialis, string alamat, string notlp, string jadwal)
        {
            string update = "UPDATE dokter SET nama=@nama, spesialisasi=@spesialisasi, nomor_telepon=@nomor_telepon, alamat=@alamat, jadwal_praktik=@jadwal_praktik WHERE id_dokter=@id_dokter";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_dokter", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@spesialisasi", MySqlConnector.MySqlDbType.VarChar).Value = spesialis;
                cmd.Parameters.Add("@nomor_telepon", MySqlConnector.MySqlDbType.VarChar).Value = notlp;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@jadwal_praktik", MySqlConnector.MySqlDbType.VarChar).Value = jadwal;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert data gagal" + ex.Message);
            }
        }

        public void deleteDokter(string id)
        {
            string delete = "DELETE FROM dokter WHERE id_dokter=@id_dokter";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_dokter", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }
        public void deletePasien(string id)
        {
            string delete = "DELETE FROM pasien WHERE id_pasien=@id_pasien";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_pasien", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }
        public void insertPasien(string id, string nama, DateTime tanggal, string jkel, string alamat, string notlp, string penyakit)
        {
            string insert = "INSERT INTO pasien VALUES(" + " @id_pasien, @nama, @tanggal_lahir, @jenis_kelamin, @alamat, @nomor_telepon, @riwayat_penyakit)";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(insert, GetConn());
                cmd.Parameters.Add("@id_pasien", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@tanggal_lahir", MySqlConnector.MySqlDbType.Date).Value = tanggal;
                cmd.Parameters.Add("@jenis_kelamin", MySqlConnector.MySqlDbType.VarChar).Value = jkel;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@nomor_telepon", MySqlConnector.MySqlDbType.VarChar).Value = notlp;
                cmd.Parameters.Add("@riwayat_penyakit", MySqlConnector.MySqlDbType.VarChar).Value = penyakit;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tambah data gagal" + ex.Message);
            }
        }

        public DataTable tampilPasien(MySqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM pasien";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void updatePasien(string id, string nama, DateTime tglLahir, string jkel, string alamat, string notlp, string riwayat)
        {
            string update = "UPDATE pasien SET nama=@nama, tanggal_lahir=@tanggal_lahir, jenis_kelamin=@jenis_kelamin, nomor_telepon=@nomor_telepon, alamat=@alamat, riwayat_penyakit=@riwayat_penyakit WHERE id_pasien=@id_pasien";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_pasien", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@tanggal_lahir", MySqlConnector.MySqlDbType.Date).Value = tglLahir;
                cmd.Parameters.Add("@jenis_kelamin", MySqlConnector.MySqlDbType.VarChar).Value = jkel;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@nomor_telepon", MySqlConnector.MySqlDbType.VarChar).Value = notlp;
                cmd.Parameters.Add("@riwayat_penyakit", MySqlConnector.MySqlDbType.VarChar).Value = riwayat;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data gagal" + ex.Message);
            }
        }

        public DataTable tampilObat(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM apotek";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void insertObat(string kode, string jenis, string nama, string stok)
        {
            string insert = "INSERT INTO apotek (kd_obat, jenis_obat, nama_obat, stock) VALUES (@kd_obat, @jenis_obat, @nama_obat, @stock)";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(insert, GetConn());
                cmd.Parameters.Add("@kd_obat", MySqlConnector.MySqlDbType.VarChar).Value = kode;
                cmd.Parameters.Add("@jenis_obat", MySqlConnector.MySqlDbType.VarChar).Value = jenis;
                cmd.Parameters.Add("@nama_obat", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@stock", MySqlConnector.MySqlDbType.VarChar).Value = stok;

                cmd.ExecuteNonQuery(); 
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal: " + ex.Message);
            }
        }

        public void deleteObat(string kode)
        {
            string delete = "DELETE FROM apotek WHERE kd_obat=@kd_obat";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@kd_obat", MySqlConnector.MySqlDbType.VarChar).Value = kode;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }
        public void addStock(string id, int additionalStock)
        {
            int currentStock = 0;
            string selectQuery = "SELECT stock FROM apotek WHERE kd_obat = @kd_obat";
            string updateQuery = "UPDATE apotek SET stock=@newStock WHERE kd_obat = @kd_obat";

            try
            {
                using (var conn = GetConn())
                {
                    var cmd = new MySqlCommand(selectQuery, conn);
                    cmd.Parameters.AddWithValue("@kd_obat", id);
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        currentStock = reader.GetInt32("stock");
                    }
                    reader.Close();

                    int newStock = currentStock + additionalStock;

                    cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@newStock", newStock);
                    cmd.Parameters.AddWithValue("@kd_obat", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Stock updated successfully. New stock: " + newStock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update stock: " + ex.Message);
            }
        }

        public DataTable tampilKunjungan(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM kunjungan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable tampilHistoryKunjungan(MySqlCommand command)
        {
            DataTable dataTable = new DataTable();

            try
            {
                command.Connection = GetConn(); 

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }


        public void insertKunjungan(string idkun, string idpas, string iddok, DateTime tgl, string keluhan, string diagnosa)
        {
            string insert = "INSERT INTO kunjungan VALUES(" + " @id_kunjungan, @id_pasien, @id_dokter, @tanggal_kunjungan, @keluhan, @diagnosa)";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(insert, GetConn());
                cmd.Parameters.Add("@id_kunjungan", MySqlConnector.MySqlDbType.VarChar).Value = idkun;
                cmd.Parameters.Add("@id_pasien", MySqlConnector.MySqlDbType.VarChar).Value = idpas;
                cmd.Parameters.Add("@id_dokter", MySqlConnector.MySqlDbType.VarChar).Value = iddok;
                cmd.Parameters.Add("@tanggal_kunjungan", MySqlConnector.MySqlDbType.Date).Value = tgl;
                cmd.Parameters.Add("@keluhan", MySqlConnector.MySqlDbType.VarChar).Value = keluhan;
                cmd.Parameters.Add("@diagnosa", MySqlConnector.MySqlDbType.VarChar).Value = diagnosa;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tambah data gagal" + ex.Message);
            }
        }
        public void updateKunjungan(string idkun, string idpas, string iddok, DateTime tgl, string keluhan, string diagnosa)
        {
            string update = "UPDATE kunjungan SET id_pasien=@id_pasien, id_dokter=@id_dokter, tanggal_kunjungan=@tanggal_kunjungan, keluhan=@keluhan, diagnosa=@diagnosa WHERE id_kunjungan=@id_kunjungan";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_kunjungan", MySqlConnector.MySqlDbType.VarChar).Value = idkun;
                cmd.Parameters.Add("@id_pasien", MySqlConnector.MySqlDbType.VarChar).Value = idpas;
                cmd.Parameters.Add("@id_dokter", MySqlConnector.MySqlDbType.VarChar).Value = iddok;
                cmd.Parameters.Add("@tanggal_kunjungan", MySqlConnector.MySqlDbType.Date).Value = tgl;
                cmd.Parameters.Add("@keluhan", MySqlConnector.MySqlDbType.VarChar).Value = keluhan;
                cmd.Parameters.Add("@diagnosa", MySqlConnector.MySqlDbType.VarChar).Value = diagnosa;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data gagal" + ex.Message);
            }
        }

        public void deleteKunjungan(string idkun)
        {
            string delete = "DELETE FROM kunjungan WHERE id_kunjungan=@id_kunjungan";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_kunjungan", MySqlConnector.MySqlDbType.VarChar).Value = idkun;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }

        public DataTable transaksiGaji(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM DokterGaji";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void deleteTransaksi(string id)
        {
            string delete = "DELETE FROM DokterGaji WHERE id=@id";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }
 
        internal DataTable SearchPasien(string search)
        {
            DataTable table = new DataTable();
            try
            {
                string query = @"SELECT * FROM pasien WHERE CONCAT(id_pasien, nama, tanggal_lahir, jenis_kelamin, alamat, nomor_telepon, riwayat_penyakit) LIKE @search";

                MySqlCommand command = new MySqlCommand(query, conn.GetConn());
                command.Parameters.AddWithValue("@search", "%" + search + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return table;
        }

        internal DataTable SearchKunjungan(string search)
        {
            DataTable table = new DataTable();
            try
            {
                string query = @"SELECT * FROM kunjungan WHERE CONCAT(id_kunjungan, id_pasien, id_dokter, tanggal_kunjungan, keluhan, diagnosa) LIKE @search";

                MySqlCommand command = new MySqlCommand(query, conn.GetConn());
                command.Parameters.AddWithValue("@search", "%" + search + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return table;
        }

        internal DataTable SearchObat(string search)
        {
            DataTable table = new DataTable();
            try
            {
                string query = @"SELECT * FROM apotek WHERE CONCAT(kd_obat, jenis_obat, nama_obat, stock) LIKE @search";

                MySqlCommand command = new MySqlCommand(query, conn.GetConn());
                command.Parameters.AddWithValue("@search", "%" + search + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return table;
        }

        public void inputGaji(string nama, string jenisDokter, int gajiBulanan, int tunjangan, long pajak)
        {
            try
            {
                string query = "INSERT INTO DokterGaji (nama, jenis_dokter, gaji_bulanan, tunjangan, pajak) " +
                               "VALUES (@nama, @jenis_dokter, @gaji_bulanan, @tunjangan, @pajak)";
                using (MySqlCommand cmd = new MySqlCommand(query, GetConn()))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@jenis_dokter", jenisDokter);
                    cmd.Parameters.AddWithValue("@gaji_bulanan", gajiBulanan);
                    cmd.Parameters.AddWithValue("@tunjangan", tunjangan);
                    cmd.Parameters.AddWithValue("@pajak", pajak);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
