using System;
using System.Windows.Forms;
using medicareApp.Controller;
using medicareApp.Validation;

namespace medicareApp.View
{
    public partial class AddObat : Form
    {
        PuskesmasController controller;
        public AddObat()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Validasi val = new Validasi();
            if(val.valId(txt_kode.Text) && val.valName(txt_jenis.Text) && val.valName(txt_nama.Text) && val.valStok(txt_stok.Text))
            {
                controller.insertObat(txt_kode.Text, txt_jenis.Text, txt_nama.Text, txt_stok.Text);

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
                MessageBox.Show("Data tidak dapat disimpan");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Apotek apotek = new Apotek();
            apotek.Show();
            this.Hide();
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
