using System;
using System.Windows.Forms;
using medicareApp.Controller;
using medicareApp.Validation;

namespace medicareApp.View
{
    public partial class UpdateKunjungan : Form
    {
        PuskesmasController controller;
        public UpdateKunjungan()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Validasi val = new Validasi();
            if(val.valId(txt_idkun.Text) && val.valId(txt_idPas.Text) && val.valId(txt_iddok.Text) && val.valkeluhan(txt_keluhan.Text) && val.valDiagnosa(txt_diagnosa.Text))
            {
                controller.updateKunjungan(txt_idkun.Text, txt_idPas.Text, txt_iddok.Text, date_kun.Value, txt_keluhan.Text, txt_diagnosa.Text);

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

        private void txt_idPas_TextChanged(object sender, EventArgs e)
        {
            if (txt_idPas.Text.Length > 3)
            {
                txt_idPas.Text = txt_idPas.Text.Substring(0, 3);
                txt_idPas.SelectionStart = txt_idPas.Text.Length;
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
