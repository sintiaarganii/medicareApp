using System;
using System.Data;
using System.Windows.Forms;
using medicareApp.Controller;
using MySqlConnector;

namespace medicareApp.View
{
    public partial class Pasien : Form
    {
        PuskesmasController controller;
        public Pasien()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }
        private void showTable()
        {
            dtg_pasien.DataSource = controller.tampilPasien(new MySqlCommand("SELECT * FROM pasien"));
            dtg_pasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_pasien.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btn_updateDok_Click(object sender, EventArgs e)
        {
            AddPasien add = new AddPasien();
            add.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void dtg_pasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_pasien.CurrentRow.Cells[0].Value.ToString();
            txt_nama.Text = dtg_pasien.CurrentRow.Cells[1].Value.ToString();
            txt_tanggal.Text = dtg_pasien.CurrentRow.Cells[2].Value.ToString();
            txt_jkel.Text = dtg_pasien.CurrentRow.Cells[3].Value.ToString();
            txt_alamat.Text = dtg_pasien.CurrentRow.Cells[4].Value.ToString();
            txt_notlp.Text = dtg_pasien.CurrentRow.Cells[5].Value.ToString();
            txt_riwayat.Text = dtg_pasien.CurrentRow.Cells[6].Value.ToString();
        }

        private void Pasien_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPasien add = new AddPasien();
            add.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdatePasien update = new UpdatePasien();
            update.Show();
            this.Hide();
        }

        bool verify()
        {
            if ((txt_id.Text == "") || (txt_nama.Text == "") || (txt_tanggal.Text == "") || (txt_jkel.Text == "") || (txt_notlp.Text == "") || (txt_alamat.Text == "") || (txt_riwayat.Text == ""))
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
                        controller.deletePasien(txt_id.Text);
                        showTable();
                        btn_clear.PerformClick();
                        MessageBox.Show("Deleted seccesfully", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_id.Focus();
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_nama.Clear();
            txt_tanggal.Clear();
            txt_jkel.Clear();
            txt_notlp.Clear();
            txt_alamat.Clear();
            txt_riwayat.Clear();
        }


        private void txt_search_TextChanged(object sender, EventArgs e)
        {
                string keyword = txt_search.Text.Trim();
                DataTable result = controller.SearchPasien(keyword);
                dtg_pasien.DataSource = result;
        }
    }
}
