using System;
using System.Windows.Forms;
using medicareApp.Controller;

namespace medicareApp.View
{
    public partial class GajiDokterForm : Form
    {
        PuskesmasController controller;
        public GajiDokterForm()
        {
            controller = new PuskesmasController();
            InitializeComponent();
            cmbJenisDokter.Items.Add("Umum");
            cmbJenisDokter.Items.Add("Spesialis");

            cmbJenisDokter.SelectedIndexChanged += CmbJenisDokter_SelectedIndexChanged;
            txtGaji.TextChanged += TxtGaji_TextChanged;
        }

        private long HitungPPh21(int gajiBulanan, int tunjangan, bool isSpesialis)
        {
            long totalPendapatanBulanan = (long)gajiBulanan + tunjangan;

            long gajiTahunan = totalPendapatanBulanan * 12;
            long ptkp = 54000000;
            long penghasilanKenaPajak = gajiTahunan - ptkp;

            if (penghasilanKenaPajak <= 0)
                return 0;

            long pajak = 0;

            if (penghasilanKenaPajak > 5000000000)
            {
                pajak += (penghasilanKenaPajak - 5000000000) * 35 / 100;
                penghasilanKenaPajak = 5000000000;
            }
            if (penghasilanKenaPajak > 500000000)
            {
                pajak += (penghasilanKenaPajak - 500000000) * 30 / 100;
                penghasilanKenaPajak = 500000000;
            }
            if (penghasilanKenaPajak > 250000000)
            {
                pajak += (penghasilanKenaPajak - 250000000) * 25 / 100;
                penghasilanKenaPajak = 250000000;
            }
            if (penghasilanKenaPajak > 60000000)
            {
                pajak += (penghasilanKenaPajak - 60000000) * 15 / 100;
                penghasilanKenaPajak = 60000000;
            }
            if (penghasilanKenaPajak > 0)
            {
                pajak += penghasilanKenaPajak * 5 / 100;
            }

            return pajak;
        }

        private void CmbJenisDokter_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungDanTampilkanPajak();
        }

        private void TxtGaji_TextChanged(object sender, EventArgs e)
        {
            HitungDanTampilkanPajak();
        }


        private void HitungDanTampilkanPajak()
        {
            if (!int.TryParse(txtGaji.Text, out int gajiBulanan))
            {
                lblHasil.Text = "Masukkan gaji yang valid.";
                return;
            }

            if (cmbJenisDokter.SelectedItem == null)
            {
                lblHasil.Text = "Pilih jenis dokter.";
                return;
            }

            if (!int.TryParse(txtTunjangan.Text, out int tunjangan))
            {
                lblHasil.Text = "Masukkan tunjangan yang valid.";
                return;
            }

            bool isSpesialis = cmbJenisDokter.SelectedItem.ToString() == "Spesialis";

            long pajak = HitungPPh21(gajiBulanan, tunjangan, isSpesialis);

            if (pajak > 0)
            {
                lblHasil.Text = $"Pajak: Rp {pajak:N0}";
            }
            else
            {
                lblHasil.Text = "Pajak tidak perlu dibayarkan.";
            }
        }

        private void GajiDokterForm_Load(object sender, EventArgs e)
        {
            HitungDanTampilkanPajak();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string namaDokter = txtNama.Text.Trim();
            if (string.IsNullOrEmpty(namaDokter))
            {
                MessageBox.Show("Masukkan nama dokter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtGaji.Text, out int gajiBulanan))
            {
                MessageBox.Show("Gaji bulanan tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtTunjangan.Text, out int tunjangan))
            {
                MessageBox.Show("Tunjangan tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbJenisDokter.SelectedItem == null)
            {
                MessageBox.Show("Pilih jenis dokter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jenisDokter = cmbJenisDokter.SelectedItem.ToString();
            bool isSpesialis = jenisDokter == "Spesialis";

            long pajak = HitungPPh21(gajiBulanan, tunjangan, isSpesialis);

            try
            {
                controller.inputGaji(namaDokter, jenisDokter, gajiBulanan, tunjangan, pajak);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Gaji gaji = new Gaji();
            gaji.Show();
            this.Hide();
        }

        private void lblHasil_Click(object sender, EventArgs e)
        {

        }

        private void txtTunjangan_TextChanged(object sender, EventArgs e)
        {
            HitungDanTampilkanPajak();
        }
    }
}
