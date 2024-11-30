namespace medicareApp.View
{
    partial class AddObat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddObat));
            this.lbl_kode = new System.Windows.Forms.Label();
            this.lbl_namaObat = new System.Windows.Forms.Label();
            this.lbl_jenis = new System.Windows.Forms.Label();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.lbl_jdDok = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.txt_nama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_jenis = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_kode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_stok = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbl_kode
            // 
            this.lbl_kode.AutoSize = true;
            this.lbl_kode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kode.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kode.Location = new System.Drawing.Point(65, 76);
            this.lbl_kode.Name = "lbl_kode";
            this.lbl_kode.Size = new System.Drawing.Size(102, 42);
            this.lbl_kode.TabIndex = 82;
            this.lbl_kode.Text = "Kode Obat";
            // 
            // lbl_namaObat
            // 
            this.lbl_namaObat.AutoSize = true;
            this.lbl_namaObat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_namaObat.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namaObat.Location = new System.Drawing.Point(65, 159);
            this.lbl_namaObat.Name = "lbl_namaObat";
            this.lbl_namaObat.Size = new System.Drawing.Size(108, 42);
            this.lbl_namaObat.TabIndex = 84;
            this.lbl_namaObat.Text = "Nama Obat";
            // 
            // lbl_jenis
            // 
            this.lbl_jenis.AutoSize = true;
            this.lbl_jenis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jenis.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jenis.Location = new System.Drawing.Point(65, 119);
            this.lbl_jenis.Name = "lbl_jenis";
            this.lbl_jenis.Size = new System.Drawing.Size(100, 42);
            this.lbl_jenis.TabIndex = 85;
            this.lbl_jenis.Text = "Jenis Obat";
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stok.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stok.Location = new System.Drawing.Point(65, 201);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(53, 42);
            this.lbl_stok.TabIndex = 86;
            this.lbl_stok.Text = "Stok";
            // 
            // lbl_jdDok
            // 
            this.lbl_jdDok.AutoSize = true;
            this.lbl_jdDok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jdDok.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jdDok.Location = new System.Drawing.Point(157, 0);
            this.lbl_jdDok.Name = "lbl_jdDok";
            this.lbl_jdDok.Size = new System.Drawing.Size(227, 49);
            this.lbl_jdDok.TabIndex = 88;
            this.lbl_jdDok.Text = "Tambah Obat";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderRadius = 10;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(382, 259);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 36);
            this.btn_save.TabIndex = 89;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_nama
            // 
            this.txt_nama.BackColor = System.Drawing.Color.Transparent;
            this.txt_nama.BorderRadius = 15;
            this.txt_nama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nama.DefaultText = "";
            this.txt_nama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nama.ForeColor = System.Drawing.Color.Black;
            this.txt_nama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nama.Location = new System.Drawing.Point(186, 159);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.PasswordChar = '\0';
            this.txt_nama.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_nama.PlaceholderText = "";
            this.txt_nama.SelectedText = "";
            this.txt_nama.Size = new System.Drawing.Size(283, 32);
            this.txt_nama.TabIndex = 90;
            // 
            // txt_jenis
            // 
            this.txt_jenis.BackColor = System.Drawing.Color.Transparent;
            this.txt_jenis.BorderRadius = 15;
            this.txt_jenis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_jenis.DefaultText = "";
            this.txt_jenis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_jenis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_jenis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jenis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jenis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_jenis.ForeColor = System.Drawing.Color.Black;
            this.txt_jenis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jenis.Location = new System.Drawing.Point(186, 119);
            this.txt_jenis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_jenis.Name = "txt_jenis";
            this.txt_jenis.PasswordChar = '\0';
            this.txt_jenis.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_jenis.PlaceholderText = "";
            this.txt_jenis.SelectedText = "";
            this.txt_jenis.Size = new System.Drawing.Size(281, 32);
            this.txt_jenis.TabIndex = 93;
            // 
            // txt_kode
            // 
            this.txt_kode.BackColor = System.Drawing.Color.Transparent;
            this.txt_kode.BorderRadius = 15;
            this.txt_kode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kode.DefaultText = "";
            this.txt_kode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_kode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_kode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_kode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_kode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_kode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_kode.ForeColor = System.Drawing.Color.Black;
            this.txt_kode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_kode.Location = new System.Drawing.Point(186, 76);
            this.txt_kode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.PasswordChar = '\0';
            this.txt_kode.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_kode.PlaceholderText = "";
            this.txt_kode.SelectedText = "";
            this.txt_kode.Size = new System.Drawing.Size(281, 32);
            this.txt_kode.TabIndex = 94;
            this.txt_kode.TextChanged += new System.EventHandler(this.txt_kode_TextChanged);
            // 
            // txt_stok
            // 
            this.txt_stok.BackColor = System.Drawing.Color.Transparent;
            this.txt_stok.BorderRadius = 15;
            this.txt_stok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stok.DefaultText = "";
            this.txt_stok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_stok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_stok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_stok.ForeColor = System.Drawing.Color.Black;
            this.txt_stok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stok.Location = new System.Drawing.Point(186, 199);
            this.txt_stok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.PasswordChar = '\0';
            this.txt_stok.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_stok.PlaceholderText = "";
            this.txt_stok.SelectedText = "";
            this.txt_stok.Size = new System.Drawing.Size(283, 32);
            this.txt_stok.TabIndex = 95;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderRadius = 10;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(291, 259);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 36);
            this.btn_back.TabIndex = 96;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 483);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.txt_jenis);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_jdDok);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_jenis);
            this.Controls.Add(this.lbl_namaObat);
            this.Controls.Add(this.lbl_kode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddObat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kode;
        private System.Windows.Forms.Label lbl_namaObat;
        private System.Windows.Forms.Label lbl_jenis;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Label lbl_jdDok;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2TextBox txt_nama;
        private Guna.UI2.WinForms.Guna2TextBox txt_jenis;
        private Guna.UI2.WinForms.Guna2TextBox txt_kode;
        private Guna.UI2.WinForms.Guna2TextBox txt_stok;
        private Guna.UI2.WinForms.Guna2Button btn_back;
    }
}