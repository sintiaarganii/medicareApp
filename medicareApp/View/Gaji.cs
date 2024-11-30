using System;
using System.Windows.Forms;
using medicareApp.Controller;
using MySqlConnector;

namespace medicareApp.View
{
    public partial class Gaji : Form
    {
        PuskesmasController controller;
        public Gaji()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            GajiDokterForm dok = new GajiDokterForm();
            dok.Show();
            this.Hide();
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_nama.Clear();
            txt_spesialis.Clear();
            txt_GajiPokok.Clear();
            txt_tunjungan.Clear();
            txtPajak.Clear();
        }
        bool verify()
        {
            if ((txt_id.Text == "") || (txt_nama.Text == "") || (txt_spesialis.Text == "") || (txt_GajiPokok.Text == "") || (txt_tunjungan.Text == "") || (txtPajak.Text == ""))
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
                        controller.deleteTransaksi(txt_id.Text);
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
                MessageBox.Show("Eror Gaji not delete", "Delete Gaji gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void showTable() 
        {
            dtg_gaji.DataSource = controller.transaksiGaji(new MySqlCommand("SELECT * FROM DokterGaji"));
            dtg_gaji.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_gaji.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dtg_gaji_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_gaji.CurrentRow.Cells[0].Value.ToString();
            txt_nama.Text = dtg_gaji.CurrentRow.Cells[1].Value.ToString();
            txt_spesialis.Text = dtg_gaji.CurrentRow.Cells[2].Value.ToString();
            txt_GajiPokok.Text = dtg_gaji.CurrentRow.Cells[3].Value.ToString();
            txt_tunjungan.Text = dtg_gaji.CurrentRow.Cells[4].Value.ToString();
            txtPajak.Text = dtg_gaji.CurrentRow.Cells[5].Value.ToString();
        }

        private void Gaji_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void dtg_gaji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDialogGaji.Document = printDocumentGaji;
            printDialogGaji.ShowDialog();
        }
    }
}
