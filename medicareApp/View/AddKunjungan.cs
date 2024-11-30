using System;
using System.Windows.Forms;
using medicareApp.Controller;
using medicareApp.Validation;

namespace medicareApp.View
{
    public partial class AddKunjungan : Form
    {
        PuskesmasController controller;
        public AddKunjungan()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Validasi val = new Validasi();

            if (val.valkeluhan(txt_keluhan.Text) && val.valDiagnosa(txt_diagnosa.Text) && val.valId(txt_idkun.Text) && val.valId(txt_idpas.Text) && val.valId(txt_iddok.Text))
            {
                controller.insertKunjungan(txt_idkun.Text, txt_idpas.Text, txt_iddok.Text, date_pas.Value, txt_keluhan.Text, txt_diagnosa.Text);

                this.Controls.Clear();
                this.InitializeComponent();
                txt_idkun.Focus();
                MessageBox.Show("Data berhasil disimpan");

                Kunjungan kun = new Kunjungan();
                kun.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Data tidak dapat disimpan");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Kunjungan kun = new Kunjungan();
            kun.Show();
            this.Hide();
        }

        private void txt_idkun_TextChanged(object sender, EventArgs e)
        {
            if (txt_idkun.Text.Length > 3)
            {
                txt_idkun.Text = txt_idkun.Text.Substring(0, 3);
                txt_idkun.SelectionStart = txt_idkun.Text.Length;
            }
        }

        private void txt_idpas_TextChanged(object sender, EventArgs e)
        {
            if (txt_idpas.Text.Length > 3)
            {
                txt_idpas.Text = txt_idpas.Text.Substring(0, 3);
                txt_idpas.SelectionStart = txt_idpas.Text.Length;
            }
        }

        private void txt_iddok_TextChanged(object sender, EventArgs e)
        {
            if (txt_iddok.Text.Length > 3)
            {
                txt_iddok.Text = txt_iddok.Text.Substring(0, 3);
                txt_iddok.SelectionStart = txt_iddok.Text.Length;
            }
        }
    }
}
