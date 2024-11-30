using System;
using System.Data;
using System.Windows.Forms;
using medicareApp.Controller;
using medicareApp.Validation;
using medicareApp.View;

namespace medicareApp
{
    public partial class Login : Form
    {
        PuskesmasController controller;
        public Login()
        {
            controller = new PuskesmasController();
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {

            Validasi val = new Validasi();
            if (val.valUser(txt_user.Text) && val.valPass(txt_pass.Text))
            {
                string name = txt_user.Text;
                string password = txt_pass.Text;
                DataTable table = controller.getList(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM signUp WHERE userr = '" + name + "' AND pass ='" + password + "'"));

                if (table.Rows.Count > 0)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your admin and password are not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if ((txt_user.Text == "") || (txt_pass.Text == ""))
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verify()
        {
            if ((txt_user.Text == "") || (txt_pass.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_up_Click(object sender, EventArgs e)
        {
            Validasi val = new Validasi();
            if (verify())
            {
                if (val.valUser(txt_user.Text) && val.valPass(txt_pass.Text))
                {
                    controller.signUp(txt_user.Text, txt_pass.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txt_user.Focus();
                    MessageBox.Show("Data Saved");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("are you sure want to exit?", "exit", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBoxEyeClosed_Click(object sender, EventArgs e)
        {
            pictureBoxEyeOpen.Visible = true;
            pictureBoxEyeClosed.Visible = false;
            txt_pass.UseSystemPasswordChar = true;
        }

        private void pictureBoxEyeOpen_Click(object sender, EventArgs e)
        {
            pictureBoxEyeOpen.Visible = false;
            pictureBoxEyeClosed.Visible = true;
            txt_pass.UseSystemPasswordChar = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            if (txt_user.Text.Length > 5)
            {
                txt_user.Text = txt_user.Text.Substring(0, 5);
                txt_user.SelectionStart = txt_user.Text.Length;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text.Length > 8)
            {
                txt_pass.Text = txt_pass.Text.Substring(0, 8);
                txt_pass.SelectionStart = txt_pass.Text.Length;
            }
        }
    }
}
