using System;
using System.Windows.Forms;
using medicareApp.Controller;
using MySqlConnector;

namespace medicareApp.View
{
    public partial class Apotek : Form
    {
        PuskesmasController controller;
        public Apotek()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void dtg_obat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode.Text = dtg_obat.CurrentRow.Cells[0].Value.ToString();
            txt_jenisObat.Text = dtg_obat.CurrentRow.Cells[1].Value.ToString();
            txt_namaObat.Text = dtg_obat.CurrentRow.Cells[2].Value.ToString();
            txt_stok.Text = dtg_obat.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddObat add = new AddObat();
            add.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateObat update = new UpdateObat();
            update.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
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
                        controller.deleteObat(txt_kode.Text);
                        showTable();
                        btn_clear.PerformClick();
                        MessageBox.Show("Obat Deleted seccesfully", "Delete obat",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_kode.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eror obat not delete", "Delete obat",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verify()
        {
            if ((txt_kode.Text == "") || (txt_jenisObat.Text == "") || (txt_namaObat.Text == "") || (txt_stok.Text == "")) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void showTable()
        {
            dtg_obat.DataSource = controller.tampilObat(new MySqlCommand("SELECT * FROM apotek"));
            dtg_obat.RowTemplate.Height = 50;
            dtg_obat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_obat.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_kode.Clear();
            txt_jenisObat.Clear();
            txt_namaObat.Clear();
            txt_stok.Clear();
        }

        private void Apotek_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dtg_obat.DataSource = controller.SearchObat(txt_search.Text);

        }
    }
}
