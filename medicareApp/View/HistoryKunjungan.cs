using System;
using System.Data;
using System.Windows.Forms;
using medicareApp.Controller;
using MySqlConnector;

namespace medicareApp.View
{
    public partial class HistoryKunjungan : Form
    {
        PuskesmasController controller;
        public HistoryKunjungan()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void ShowTable()
        {
                string query = "SELECT * FROM history_kunjungan ORDER BY tanggal_hapus DESC";
                dtg_pengunjung.DataSource = controller.tampilHistoryKunjungan(new MySqlCommand(query));
                dtg_pengunjung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_pengunjung.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dtg_pengunjung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idkun.Text = dtg_pengunjung.CurrentRow.Cells[0].Value.ToString();
            txt_idpas.Text = dtg_pengunjung.CurrentRow.Cells[1].Value.ToString();
            txt_iddok.Text = dtg_pengunjung.CurrentRow.Cells[2].Value.ToString();
            txt_tanggal.Text = dtg_pengunjung.CurrentRow.Cells[3].Value.ToString();
            txt_diagnosa.Text = dtg_pengunjung.CurrentRow.Cells[4].Value.ToString();
            txt_riwayat.Text = dtg_pengunjung.CurrentRow.Cells[5].Value.ToString();

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim();
            DataTable result = controller.SearchKunjungan(keyword);
            dtg_pengunjung.DataSource = result;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Kunjungan kun = new Kunjungan();
            kun.Show();
            this.Hide();
        }

        private void HistoryKunjungan_Load(object sender, EventArgs e)
        {
            ShowTable();
        }
    }
}
