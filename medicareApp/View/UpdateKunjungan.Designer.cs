namespace medicareApp.View
{
    partial class UpdateKunjungan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateKunjungan));
            this.date_kun = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_keluhan = new System.Windows.Forms.Label();
            this.txt_idPas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_keluhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_diagnosa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_iddok = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_diagnosa = new System.Windows.Forms.Label();
            this.lbl_jkel = new System.Windows.Forms.Label();
            this.lbl_spesialis = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_peng = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.txt_idkun = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date_kun
            // 
            this.date_kun.BackColor = System.Drawing.Color.Transparent;
            this.date_kun.BorderRadius = 10;
            this.date_kun.Checked = true;
            this.date_kun.FillColor = System.Drawing.Color.White;
            this.date_kun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_kun.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_kun.Location = new System.Drawing.Point(213, 256);
            this.date_kun.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_kun.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_kun.Name = "date_kun";
            this.date_kun.Size = new System.Drawing.Size(331, 36);
            this.date_kun.TabIndex = 119;
            this.date_kun.Value = new System.DateTime(2024, 11, 23, 18, 15, 44, 554);
            // 
            // lbl_keluhan
            // 
            this.lbl_keluhan.AutoSize = true;
            this.lbl_keluhan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_keluhan.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keluhan.Location = new System.Drawing.Point(28, 299);
            this.lbl_keluhan.Name = "lbl_keluhan";
            this.lbl_keluhan.Size = new System.Drawing.Size(85, 42);
            this.lbl_keluhan.TabIndex = 118;
            this.lbl_keluhan.Text = "Keluhan";
            // 
            // txt_idPas
            // 
            this.txt_idPas.BackColor = System.Drawing.Color.Transparent;
            this.txt_idPas.BorderRadius = 15;
            this.txt_idPas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idPas.DefaultText = "";
            this.txt_idPas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idPas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idPas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idPas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idPas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idPas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idPas.ForeColor = System.Drawing.Color.Black;
            this.txt_idPas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idPas.Location = new System.Drawing.Point(210, 178);
            this.txt_idPas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idPas.Name = "txt_idPas";
            this.txt_idPas.PasswordChar = '\0';
            this.txt_idPas.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_idPas.PlaceholderText = "";
            this.txt_idPas.SelectedText = "";
            this.txt_idPas.Size = new System.Drawing.Size(331, 32);
            this.txt_idPas.TabIndex = 116;
            this.txt_idPas.TextChanged += new System.EventHandler(this.txt_idPas_TextChanged);
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
            this.txt_keluhan.Location = new System.Drawing.Point(213, 299);
            this.txt_keluhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_keluhan.Name = "txt_keluhan";
            this.txt_keluhan.PasswordChar = '\0';
            this.txt_keluhan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_keluhan.PlaceholderText = "";
            this.txt_keluhan.SelectedText = "";
            this.txt_keluhan.Size = new System.Drawing.Size(331, 32);
            this.txt_keluhan.TabIndex = 115;
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
            this.txt_diagnosa.Location = new System.Drawing.Point(213, 336);
            this.txt_diagnosa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diagnosa.Name = "txt_diagnosa";
            this.txt_diagnosa.PasswordChar = '\0';
            this.txt_diagnosa.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_diagnosa.PlaceholderText = "";
            this.txt_diagnosa.SelectedText = "";
            this.txt_diagnosa.Size = new System.Drawing.Size(331, 37);
            this.txt_diagnosa.TabIndex = 114;
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
            this.txt_iddok.Location = new System.Drawing.Point(210, 217);
            this.txt_iddok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_iddok.Name = "txt_iddok";
            this.txt_iddok.PasswordChar = '\0';
            this.txt_iddok.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_iddok.PlaceholderText = "";
            this.txt_iddok.SelectedText = "";
            this.txt_iddok.Size = new System.Drawing.Size(331, 32);
            this.txt_iddok.TabIndex = 113;
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
            this.btn_save.Location = new System.Drawing.Point(459, 389);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 36);
            this.btn_save.TabIndex = 112;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_diagnosa
            // 
            this.lbl_diagnosa.AutoSize = true;
            this.lbl_diagnosa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_diagnosa.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diagnosa.Location = new System.Drawing.Point(28, 341);
            this.lbl_diagnosa.Name = "lbl_diagnosa";
            this.lbl_diagnosa.Size = new System.Drawing.Size(92, 42);
            this.lbl_diagnosa.TabIndex = 111;
            this.lbl_diagnosa.Text = "Diagnosa";
            // 
            // lbl_jkel
            // 
            this.lbl_jkel.AutoSize = true;
            this.lbl_jkel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jkel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jkel.Location = new System.Drawing.Point(28, 250);
            this.lbl_jkel.Name = "lbl_jkel";
            this.lbl_jkel.Size = new System.Drawing.Size(176, 42);
            this.lbl_jkel.TabIndex = 110;
            this.lbl_jkel.Text = "Tanggal Kunjungan";
            // 
            // lbl_spesialis
            // 
            this.lbl_spesialis.AutoSize = true;
            this.lbl_spesialis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_spesialis.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spesialis.Location = new System.Drawing.Point(28, 207);
            this.lbl_spesialis.Name = "lbl_spesialis";
            this.lbl_spesialis.Size = new System.Drawing.Size(96, 42);
            this.lbl_spesialis.TabIndex = 108;
            this.lbl_spesialis.Text = "Id Dokter";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(29, 165);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(91, 42);
            this.lbl_id.TabIndex = 107;
            this.lbl_id.Text = "Id Pasien";
            // 
            // lbl_peng
            // 
            this.lbl_peng.AutoSize = true;
            this.lbl_peng.BackColor = System.Drawing.Color.Transparent;
            this.lbl_peng.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peng.Location = new System.Drawing.Point(204, 19);
            this.lbl_peng.Name = "lbl_peng";
            this.lbl_peng.Size = new System.Drawing.Size(414, 49);
            this.lbl_peng.TabIndex = 106;
            this.lbl_peng.Text = "Update Data Pengunjung";
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
            this.btn_back.Location = new System.Drawing.Point(368, 389);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 36);
            this.btn_back.TabIndex = 120;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.txt_idkun.Location = new System.Drawing.Point(210, 138);
            this.txt_idkun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idkun.Name = "txt_idkun";
            this.txt_idkun.PasswordChar = '\0';
            this.txt_idkun.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_idkun.PlaceholderText = "";
            this.txt_idkun.SelectedText = "";
            this.txt_idkun.Size = new System.Drawing.Size(331, 32);
            this.txt_idkun.TabIndex = 117;
            this.txt_idkun.TextChanged += new System.EventHandler(this.txt_idkun_TextChanged);
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nama.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(28, 123);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(131, 42);
            this.lbl_nama.TabIndex = 109;
            this.lbl_nama.Text = "Id Kunjungan";
            // 
            // UpdateKunjungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.date_kun);
            this.Controls.Add(this.lbl_keluhan);
            this.Controls.Add(this.txt_idkun);
            this.Controls.Add(this.txt_idPas);
            this.Controls.Add(this.txt_keluhan);
            this.Controls.Add(this.txt_diagnosa);
            this.Controls.Add(this.txt_iddok);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_diagnosa);
            this.Controls.Add(this.lbl_jkel);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.lbl_spesialis);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_peng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateKunjungan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateKunjungan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker date_kun;
        private System.Windows.Forms.Label lbl_keluhan;
        private Guna.UI2.WinForms.Guna2TextBox txt_idPas;
        private Guna.UI2.WinForms.Guna2TextBox txt_keluhan;
        private Guna.UI2.WinForms.Guna2TextBox txt_diagnosa;
        private Guna.UI2.WinForms.Guna2TextBox txt_iddok;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label lbl_diagnosa;
        private System.Windows.Forms.Label lbl_jkel;
        private System.Windows.Forms.Label lbl_spesialis;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_peng;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2TextBox txt_idkun;
        private System.Windows.Forms.Label lbl_nama;
    }
}