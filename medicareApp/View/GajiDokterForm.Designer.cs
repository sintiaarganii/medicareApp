namespace medicareApp.View
{
    partial class GajiDokterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GajiDokterForm));
            this.cmbJenisDokter = new System.Windows.Forms.ComboBox();
            this.lblHasil = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_show = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lblSpesialis = new System.Windows.Forms.Label();
            this.lblGaji = new System.Windows.Forms.Label();
            this.lblPajak = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.txtTunjangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGaji = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTunjangan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbJenisDokter
            // 
            this.cmbJenisDokter.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenisDokter.FormattingEnabled = true;
            this.cmbJenisDokter.Location = new System.Drawing.Point(450, 146);
            this.cmbJenisDokter.Name = "cmbJenisDokter";
            this.cmbJenisDokter.Size = new System.Drawing.Size(201, 31);
            this.cmbJenisDokter.TabIndex = 0;
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.BackColor = System.Drawing.Color.Transparent;
            this.lblHasil.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(446, 272);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(43, 19);
            this.lblHasil.TabIndex = 2;
            this.lblHasil.Text = "Hasil";
            this.lblHasil.Click += new System.EventHandler(this.lblHasil_Click);
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
            this.btn_save.Location = new System.Drawing.Point(585, 360);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 36);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.Transparent;
            this.txtNama.BorderRadius = 10;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(450, 102);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(201, 37);
            this.txtNama.TabIndex = 42;
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.BorderRadius = 10;
            this.btn_show.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_show.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_show.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.Location = new System.Drawing.Point(501, 360);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(78, 36);
            this.btn_show.TabIndex = 43;
            this.btn_show.Text = "Show";
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nama.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(309, 102);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(62, 23);
            this.lbl_nama.TabIndex = 44;
            this.lbl_nama.Text = "Nama";
            // 
            // lblSpesialis
            // 
            this.lblSpesialis.AutoSize = true;
            this.lblSpesialis.BackColor = System.Drawing.Color.Transparent;
            this.lblSpesialis.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpesialis.Location = new System.Drawing.Point(309, 146);
            this.lblSpesialis.Name = "lblSpesialis";
            this.lblSpesialis.Size = new System.Drawing.Size(109, 23);
            this.lblSpesialis.TabIndex = 45;
            this.lblSpesialis.Text = "Jenis Dokter";
            // 
            // lblGaji
            // 
            this.lblGaji.AutoSize = true;
            this.lblGaji.BackColor = System.Drawing.Color.Transparent;
            this.lblGaji.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaji.Location = new System.Drawing.Point(309, 183);
            this.lblGaji.Name = "lblGaji";
            this.lblGaji.Size = new System.Drawing.Size(97, 23);
            this.lblGaji.TabIndex = 46;
            this.lblGaji.Text = "Gaji/Bulan";
            // 
            // lblPajak
            // 
            this.lblPajak.AutoSize = true;
            this.lblPajak.BackColor = System.Drawing.Color.Transparent;
            this.lblPajak.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPajak.Location = new System.Drawing.Point(311, 272);
            this.lblPajak.Name = "lblPajak";
            this.lblPajak.Size = new System.Drawing.Size(107, 23);
            this.lblPajak.TabIndex = 47;
            this.lblPajak.Text = "Kena Pajak";
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
            this.btn_back.Location = new System.Drawing.Point(585, 402);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 36);
            this.btn_back.TabIndex = 48;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtTunjangan
            // 
            this.txtTunjangan.BackColor = System.Drawing.Color.Transparent;
            this.txtTunjangan.BorderRadius = 10;
            this.txtTunjangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTunjangan.DefaultText = "";
            this.txtTunjangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTunjangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTunjangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTunjangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTunjangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTunjangan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTunjangan.ForeColor = System.Drawing.Color.Black;
            this.txtTunjangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTunjangan.Location = new System.Drawing.Point(450, 228);
            this.txtTunjangan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTunjangan.Name = "txtTunjangan";
            this.txtTunjangan.PasswordChar = '\0';
            this.txtTunjangan.PlaceholderText = "";
            this.txtTunjangan.SelectedText = "";
            this.txtTunjangan.Size = new System.Drawing.Size(201, 37);
            this.txtTunjangan.TabIndex = 49;
            this.txtTunjangan.TextChanged += new System.EventHandler(this.txtTunjangan_TextChanged);
            // 
            // txtGaji
            // 
            this.txtGaji.BackColor = System.Drawing.Color.Transparent;
            this.txtGaji.BorderRadius = 10;
            this.txtGaji.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGaji.DefaultText = "";
            this.txtGaji.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGaji.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGaji.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGaji.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGaji.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGaji.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGaji.ForeColor = System.Drawing.Color.Black;
            this.txtGaji.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGaji.Location = new System.Drawing.Point(450, 183);
            this.txtGaji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGaji.Name = "txtGaji";
            this.txtGaji.PasswordChar = '\0';
            this.txtGaji.PlaceholderText = "";
            this.txtGaji.SelectedText = "";
            this.txtGaji.Size = new System.Drawing.Size(201, 37);
            this.txtGaji.TabIndex = 50;
            // 
            // lblTunjangan
            // 
            this.lblTunjangan.AutoSize = true;
            this.lblTunjangan.BackColor = System.Drawing.Color.Transparent;
            this.lblTunjangan.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTunjangan.Location = new System.Drawing.Point(309, 228);
            this.lblTunjangan.Name = "lblTunjangan";
            this.lblTunjangan.Size = new System.Drawing.Size(97, 23);
            this.lblTunjangan.TabIndex = 51;
            this.lblTunjangan.Text = "Tunjangan";
            // 
            // GajiDokterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTunjangan);
            this.Controls.Add(this.txtGaji);
            this.Controls.Add(this.txtTunjangan);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lblPajak);
            this.Controls.Add(this.lblGaji);
            this.Controls.Add(this.lblSpesialis);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.cmbJenisDokter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GajiDokterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GajiDokterForm";
            this.Load += new System.EventHandler(this.GajiDokterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJenisDokter;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2Button btn_show;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lblSpesialis;
        private System.Windows.Forms.Label lblGaji;
        private System.Windows.Forms.Label lblPajak;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2TextBox txtTunjangan;
        private Guna.UI2.WinForms.Guna2TextBox txtGaji;
        private System.Windows.Forms.Label lblTunjangan;
        public System.Windows.Forms.Label lblHasil;
    }
}