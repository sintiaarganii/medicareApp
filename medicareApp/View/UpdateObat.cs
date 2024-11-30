using System;
using System.Windows.Forms;
using medicareApp.Controller;
using medicareApp.Validation;

namespace medicareApp.View
{
    public partial class UpdateObat : Form
    {
        PuskesmasController controller;
        public UpdateObat()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Validasi validasi = new Validasi();
            if (validasi.valId(txt_kode.Text) && validasi.valStok(txt_stok.Text))
            {
                int stock;

                if (!int.TryParse(txt_stok.Text, out stock))
                {
                    MessageBox.Show("Stok harus berupa angka.");
                    txt_stok.Focus();
                    return;
                }

                controller.addStock(txt_kode.Text, stock);

                this.Controls.Clear();
                this.InitializeComponent();
                txt_kode.Focus();
                MessageBox.Show("Data berhasil disimpan");

                Apotek apotek = new Apotek();
                apotek.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Terjadi kesalahan ");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Apotek apotek = new Apotek();
            apotek.Show();
            this.Hide();
        }

        private void txt_stok_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kode_TextChanged(object sender, EventArgs e)
        {
            if (txt_kode.Text.Length > 3)
            {
                txt_kode.Text = txt_kode.Text.Substring(0, 3);
                txt_kode.SelectionStart = txt_kode.Text.Length;
            }
        }
    }
}
