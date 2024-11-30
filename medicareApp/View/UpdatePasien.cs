using System;
using System.Windows.Forms;
using medicareApp.Controller;
using medicareApp.Validation;

namespace medicareApp.View
{
    public partial class UpdatePasien : Form
    {
        PuskesmasController controller;
        public UpdatePasien()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Validasi val = new Validasi();

            if (val.valId(txt_idPas.Text) && val.valName(txt_namaPas.Text) && val.valTlp(txt_noTlpPas.Text) && val.valAlamat(txt_alamatPas.Text) && val.valkeluhan(txt_keluhan.Text)) 
            {
                controller.updatePasien(txt_idPas.Text, txt_namaPas.Text, date_pas.Value, txt_jkel.Text, txt_noTlpPas.Text, txt_alamatPas.Text, txt_keluhan.Text);

                this.Controls.Clear();
                this.InitializeComponent();
                txt_idPas.Focus();
                MessageBox.Show("Data berhasil disimpan");

                Pasien pasien = new Pasien();
                pasien.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Data tidak dapat disimpan");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Pasien pasien = new Pasien();
            pasien.Show();
            this.Hide();
        }

        private void txt_idPas_TextChanged(object sender, EventArgs e)
        {
                if (txt_idPas.Text.Length > 3)
                {
                    txt_idPas.Text = txt_idPas.Text.Substring(0, 3);
                    txt_idPas.SelectionStart = txt_idPas.Text.Length;
                }
        }

        private void txt_noTlpPas_TextChanged(object sender, EventArgs e)
        {
            if (txt_noTlpPas.Text.Length > 13)
            {
                txt_noTlpPas.Text = txt_noTlpPas.Text.Substring(0, 13);
                txt_noTlpPas.SelectionStart = txt_noTlpPas.Text.Length;
            }
        }
    }
}
