using System;
using System.Windows.Forms;
using medicareApp.Controller;
using medicareApp.Validation;

namespace medicareApp.View
{
    public partial class UpdateDokter : Form
    {
        PuskesmasController controller;
        public UpdateDokter()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dokter dokter = new Dokter();
            dokter.Show();
            this.Hide();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            Validasi val = new Validasi();
            if (val.valId(txt_idDok.Text) && val.valName(txt_namaDok.Text) && val.valSps(txt_spesialisasi.Text) && val.valTlp(txt_noTlp.Text) && val.valAlamat(txt_alamat.Text)) {
                controller.updateDokter(txt_idDok.Text, txt_namaDok.Text, txt_spesialisasi.Text, txt_noTlp.Text, txt_alamat.Text, txt_jdwl.Text);
                this.Controls.Clear();
                this.InitializeComponent();
                txt_idDok.Focus();

                MessageBox.Show("Update Successfully");
                Dokter dokter = new Dokter();
                dokter.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
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
