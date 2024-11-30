using System;
using System.Windows.Forms;
using medicareApp.Validation;
using medicareApp.Controller;

namespace medicareApp.View
{
    public partial class AddDokter : Form 
    {
        PuskesmasController controller;
        public AddDokter()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Validasi val = new Validasi();

            if (val.valName(txt_namaDok.Text) && val.valTlp(txt_noTlp.Text) && val.valSps(txt_spesialisasi.Text) && val.valAlamat(txt_alamat.Text) && val.valId(txt_idDok.Text))
            {
                controller.insertDokter(txt_idDok.Text, txt_namaDok.Text, txt_spesialisasi.Text, txt_alamat.Text, txt_noTlp.Text, txt_jdwl.Text);

                this.Controls.Clear();
                this.InitializeComponent();
                txt_idDok.Focus();
                MessageBox.Show("Data berhasil disimpan");

               Dokter dokter = new Dokter();
                dokter.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Data tidak dapat disimpan");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dokter dok = new Dokter();
            dok.Show();
            this.Hide();
        }

        private void txt_idDok_TextChanged(object sender, EventArgs e)
        {
            if (txt_idDok.Text.Length > 3)
            {
                txt_idDok.Text = txt_idDok.Text.Substring(0, 3);
                txt_idDok.SelectionStart = txt_idDok.Text.Length;
            }
        }

        private void txt_noTlp_TextChanged(object sender, EventArgs e)
        {
            if (txt_noTlp.Text.Length > 13)
            {
                txt_noTlp.Text = txt_noTlp.Text.Substring(0, 13);
                txt_noTlp.SelectionStart = txt_noTlp.Text.Length;
            }
        }
    }
}
