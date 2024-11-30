namespace medicareApp.View
{
    partial class AddKunjungan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKunjungan));
            this.lbl_jdDok = new System.Windows.Forms.Label();
            this.date_pas = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_keluhan = new System.Windows.Forms.Label();
            this.txt_idpas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_keluhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_diagnosa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_iddok = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_diagnosa = new System.Windows.Forms.Label();
            this.lbl_jkel = new System.Windows.Forms.Label();
            this.lbl_spesialis = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.txt_idkun = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lbl_jdDok
            // 
            this.lbl_jdDok.AutoSize = true;
            this.lbl_jdDok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jdDok.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jdDok.Location = new System.Drawing.Point(188, 32);
            this.lbl_jdDok.Name = "lbl_jdDok";
            this.lbl_jdDok.Size = new System.Drawing.Size(418, 49);
            this.lbl_jdDok.TabIndex = 89;
            this.lbl_jdDok.Text = "Tambah Data Pengunjung";
            // 
            // date_pas
            // 
            this.date_pas.BackColor = System.Drawing.Color.Transparent;
            this.date_pas.BorderRadius = 10;
            this.date_pas.Checked = true;
            this.date_pas.FillColor = System.Drawing.Color.White;
            this.date_pas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_pas.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_pas.Location = new System.Drawing.Point(197, 246);
            this.date_pas.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_pas.MinDate = new System.DateTime(2024, 11, 30, 0, 0, 0, 0);
            this.date_pas.Name = "date_pas";
            this.date_pas.Size = new System.Drawing.Size(331, 36);
            this.date_pas.TabIndex = 105;
            this.date_pas.Value = new System.DateTime(2024, 11, 30, 0, 0, 0, 0);
            // 
            // lbl_keluhan
            // 
            this.lbl_keluhan.AutoSize = true;
            this.lbl_keluhan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_keluhan.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keluhan.Location = new System.Drawing.Point(12, 289);
            this.lbl_keluhan.Name = "lbl_keluhan";
            this.lbl_keluhan.Size = new System.Drawing.Size(85, 42);
            this.lbl_keluhan.TabIndex = 104;
            this.lbl_keluhan.Text = "Keluhan";
            // 
            // txt_idpas
            // 
            this.txt_idpas.BackColor = System.Drawing.Color.Transparent;
            this.txt_idpas.BorderRadius = 15;
            this.txt_idpas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idpas.DefaultText = "";
            this.txt_idpas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idpas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idpas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idpas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idpas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idpas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idpas.ForeColor = System.Drawing.Color.Black;
            this.txt_idpas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idpas.Location = new System.Drawing.Point(194, 168);
            this.txt_idpas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idpas.Name = "txt_idpas";
            this.txt_idpas.PasswordChar = '\0';
            this.txt_idpas.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_idpas.PlaceholderText = "";
            this.txt_idpas.SelectedText = "";
            this.txt_idpas.Size = new System.Drawing.Size(331, 32);
            this.txt_idpas.TabIndex = 101;
            this.txt_idpas.TextChanged += new System.EventHandler(this.txt_idpas_TextChanged);
            // 
            // txt_keluhan
            // 
            this.txt_keluhan.BackColor = System.Drawing.Color.Transparent;
            this.txt_keluhan.BorderRadius = 15;
            this.txt_keluhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_keluhan.DefaultText = "";
            this.txt_keluhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_keluhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_keluhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_keluhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_keluhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_keluhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_keluhan.ForeColor = System.Drawing.Color.Black;
            this.txt_keluhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_keluhan.Location = new System.Drawing.Point(197, 289);
            this.txt_keluhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_keluhan.Name = "txt_keluhan";
            this.txt_keluhan.PasswordChar = '\0';
            this.txt_keluhan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_keluhan.PlaceholderText = "";
            this.txt_keluhan.SelectedText = "";
            this.txt_keluhan.Size = new System.Drawing.Size(331, 32);
            this.txt_keluhan.TabIndex = 100;
            // 
            // txt_diagnosa
            // 
            this.txt_diagnosa.BackColor = System.Drawing.Color.Transparent;
            this.txt_diagnosa.BorderRadius = 15;
            this.txt_diagnosa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diagnosa.DefaultText = "";
            this.txt_diagnosa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_diagnosa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_diagnosa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diagnosa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diagnosa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diagnosa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_diagnosa.ForeColor = System.Drawing.Color.Black;
            this.txt_diagnosa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diagnosa.Location = new System.Drawing.Point(197, 326);
            this.txt_diagnosa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diagnosa.Name = "txt_diagnosa";
            this.txt_diagnosa.PasswordChar = '\0';
            this.txt_diagnosa.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_diagnosa.PlaceholderText = "";
            this.txt_diagnosa.SelectedText = "";
            this.txt_diagnosa.Size = new System.Drawing.Size(331, 37);
            this.txt_diagnosa.TabIndex = 99;
            // 
            // txt_iddok
            // 
            this.txt_iddok.BackColor = System.Drawing.Color.Transparent;
            this.txt_iddok.BorderRadius = 15;
            this.txt_iddok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_iddok.DefaultText = "";
            this.txt_iddok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_iddok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_iddok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_iddok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_iddok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_iddok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_iddok.ForeColor = System.Drawing.Color.Black;
            this.txt_iddok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_iddok.Location = new System.Drawing.Point(194, 207);
            this.txt_iddok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_iddok.Name = "txt_iddok";
            this.txt_iddok.PasswordChar = '\0';
            this.txt_iddok.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_iddok.PlaceholderText = "";
            this.txt_iddok.SelectedText = "";
            this.txt_iddok.Size = new System.Drawing.Size(331, 32);
            this.txt_iddok.TabIndex = 98;
            this.txt_iddok.TextChanged += new System.EventHandler(this.txt_iddok_TextChanged);
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
            this.btn_save.Location = new System.Drawing.Point(443, 379);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 36);
            this.btn_save.TabIndex = 97;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_diagnosa
            // 
            this.lbl_diagnosa.AutoSize = true;
            this.lbl_diagnosa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_diagnosa.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diagnosa.Location = new System.Drawing.Point(12, 331);
            this.lbl_diagnosa.Name = "lbl_diagnosa";
            this.lbl_diagnosa.Size = new System.Drawing.Size(92, 42);
            this.lbl_diagnosa.TabIndex = 95;
            this.lbl_diagnosa.Text = "Diagnosa";
            // 
            // lbl_jkel
            // 
            this.lbl_jkel.AutoSize = true;
            this.lbl_jkel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jkel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jkel.Location = new System.Drawing.Point(12, 240);
            this.lbl_jkel.Name = "lbl_jkel";
            this.lbl_jkel.Size = new System.Drawing.Size(176, 42);
            this.lbl_jkel.TabIndex = 94;
            this.lbl_jkel.Text = "Tanggal Kunjungan";
            // 
            // lbl_spesialis
            // 
            this.lbl_spesialis.AutoSize = true;
            this.lbl_spesialis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_spesialis.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spesialis.Location = new System.Drawing.Point(12, 197);
            this.lbl_spesialis.Name = "lbl_spesialis";
            this.lbl_spesialis.Size = new System.Drawing.Size(96, 42);
            this.lbl_spesialis.TabIndex = 92;
            this.lbl_spesialis.Text = "Id Dokter";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(13, 155);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(91, 42);
            this.lbl_id.TabIndex = 90;
            this.lbl_id.Text = "Id Pasien";
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
            this.btn_back.Location = new System.Drawing.Point(352, 379);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 36);
            this.btn_back.TabIndex = 106;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nama.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(12, 113);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(131, 42);
            this.lbl_nama.TabIndex = 93;
            this.lbl_nama.Text = "Id Kunjungan";
            // 
            // txt_idkun
            // 
            this.txt_idkun.BackColor = System.Drawing.Color.Transparent;
            this.txt_idkun.BorderRadius = 15;
            this.txt_idkun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idkun.DefaultText = "";
            this.txt_idkun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idkun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idkun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idkun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idkun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idkun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idkun.ForeColor = System.Drawing.Color.Black;
            this.txt_idkun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idkun.Location = new System.Drawing.Point(194, 128);
            this.txt_idkun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idkun.Name = "txt_idkun";
            this.txt_idkun.PasswordChar = '\0';
            this.txt_idkun.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_idkun.PlaceholderText = "";
            this.txt_idkun.SelectedText = "";
            this.txt_idkun.Size = new System.Drawing.Size(331, 32);
            this.txt_idkun.TabIndex = 102;
            this.txt_idkun.TextChanged += new System.EventHandler(this.txt_idkun_TextChanged);
            // 
            // AddKunjungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.date_pas);
            this.Controls.Add(this.lbl_keluhan);
            this.Controls.Add(this.txt_idkun);
            this.Controls.Add(this.txt_idpas);
            this.Controls.Add(this.txt_keluhan);
            this.Controls.Add(this.txt_diagnosa);
            this.Controls.Add(this.txt_iddok);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_diagnosa);
            this.Controls.Add(this.lbl_jkel);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.lbl_spesialis);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_jdDok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddKunjungan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddKunjungan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_jdDok;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_pas;
        private System.Windows.Forms.Label lbl_keluhan;
        private Guna.UI2.WinForms.Guna2TextBox txt_idpas;
        private Guna.UI2.WinForms.Guna2TextBox txt_keluhan;
        private Guna.UI2.WinForms.Guna2TextBox txt_diagnosa;
        private Guna.UI2.WinForms.Guna2TextBox txt_iddok;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label lbl_diagnosa;
        private System.Windows.Forms.Label lbl_jkel;
        private System.Windows.Forms.Label lbl_spesialis;
        private System.Windows.Forms.Label lbl_id;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private System.Windows.Forms.Label lbl_nama;
        private Guna.UI2.WinForms.Guna2TextBox txt_idkun;
    }
}