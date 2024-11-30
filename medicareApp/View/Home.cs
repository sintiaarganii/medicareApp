using System;
using System.Windows.Forms;

namespace medicareApp.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_dokter_Click(object sender, EventArgs e)
        {
            Dokter dokter = new Dokter();
            dokter.Show();
            this.Hide();
        }

        private void btn_pasien_Click(object sender, EventArgs e)
        {
            Pasien pasien = new Pasien();
            pasien.Show();
            this.Hide();
        }

        private void btn_apotek_Click(object sender, EventArgs e)
        {
            Apotek apotek = new Apotek();
            apotek.Show(); 
            this.Hide();
        }

        private void btn_visit_Click(object sender, EventArgs e)
        {
            Kunjungan kun = new Kunjungan();
            kun.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void btn_gaji_Click(object sender, EventArgs e)
        {
            GajiDokterForm gaji = new GajiDokterForm();
            gaji.Show();
            this.Hide();
        }
    }
}
