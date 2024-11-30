using System;
using medicareApp.Controller;
using System.Windows.Forms;
using MySqlConnector;

namespace medicareApp.View
{
    public partial class Dokter : Form
    {
        private PuskesmasController controller;
        public Dokter()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }
        private void showTable()
        {
            dtg_dokter.DataSource = controller.tampilDokter(new MySqlCommand("SELECT * FROM dokter"));
            dtg_dokter.RowTemplate.Height = 50;
            dtg_dokter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_dokter.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void Dokter_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateDokter updateDokter = new UpdateDokter();
            updateDokter.Show();
            this.Hide();
        }

        bool verify()
        {
            if ((txt_id.Text == "") || (txt_nama.Text == "") || (txt_spesial.Text == "") || (txt_notlp.Text == "") || (txt_almat.Text == "") ||(txt_jdwl.Text == ""))
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
                        controller.deleteDokter(txt_id.Text);
                        showTable();
                        btn_clear.PerformClick();
                        MessageBox.Show("Dokter Deleted seccesfully", "Delete dokter",
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
                MessageBox.Show("Eror dokter not delete", "Delete dokter",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDokter addDokter = new AddDokter();
            addDokter.Show();
            this.Hide();
        }

        private void dtg_dokter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_dokter.CurrentRow.Cells[0].Value.ToString();
            txt_nama.Text = dtg_dokter.CurrentRow.Cells[1].Value.ToString();
            txt_spesial.Text = dtg_dokter.CurrentRow.Cells[2].Value.ToString();
            txt_notlp.Text = dtg_dokter.CurrentRow.Cells[3].Value.ToString();
            txt_almat.Text = dtg_dokter.CurrentRow.Cells[4].Value.ToString();
            txt_jdwl.Text = dtg_dokter.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_nama.Clear();
            txt_spesial.Clear();
            txt_notlp.Clear();
            txt_almat.Clear();
            txt_jdwl.Clear();
        }
    }
}
