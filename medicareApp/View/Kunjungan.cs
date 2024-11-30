using System;
using System.Data;
using System.Windows.Forms;
using medicareApp.Controller;
using MySqlConnector;

namespace medicareApp.View
{
    public partial class Kunjungan : Form
    {
        PuskesmasController controller;
        public Kunjungan()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateKunjungan update = new UpdateKunjungan();
            update.Show();
            this.Hide();
        }
        private void showTable()
         {
            dtg_pengunjung.DataSource = controller.tampilKunjungan(new MySqlCommand("SELECT * FROM kunjungan"));
            dtg_pengunjung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_pengunjung.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dtg_pengunjung_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_idkun.Text = dtg_pengunjung.CurrentRow.Cells[0].Value.ToString();
            txt_idpas.Text = dtg_pengunjung.CurrentRow.Cells[1].Value.ToString();
            txt_iddok.Text = dtg_pengunjung.CurrentRow.Cells[2].Value.ToString();
            txt_tanggal.Text = dtg_pengunjung.CurrentRow.Cells[3].Value.ToString();
            txt_diagnosa.Text = dtg_pengunjung.CurrentRow.Cells[4].Value.ToString();
            txt_riwayat.Text = dtg_pengunjung.CurrentRow.Cells[5].Value.ToString();
        }

        private void Kunjungan_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddKunjungan add = new AddKunjungan();
            add.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_idkun.Clear();
            txt_idpas.Clear();
            txt_iddok.Clear();
            txt_tanggal.Clear();
            txt_diagnosa.Clear();
            txt_riwayat.Clear();
        }

        bool verify()
        {
            if ((txt_idkun.Text == "") || (txt_idpas.Text == "") || (txt_iddok.Text == "") || (txt_tanggal.Text == "") || (txt_riwayat.Text == "") || (txt_diagnosa.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    var result = MessageBox.Show("are you sure want to delete?", "deleted", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        controller.deleteKunjungan(txt_idkun.Text);
                        showTable();
                        btn_clear.PerformClick();
                        MessageBox.Show("Deleted seccesfully", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_idkun.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eror pasien not delete", "Delete pasien gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dtg_pengunjung.DataSource = controller.SearchKunjungan(txt_search.Text);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim();
            DataTable result = controller.SearchKunjungan(keyword);
            dtg_pengunjung.DataSource = result;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
           HistoryKunjungan historyKunjungan = new HistoryKunjungan();
           historyKunjungan.Show();
           this.Hide();
        }

        private void dtg_pengunjung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
