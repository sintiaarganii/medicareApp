namespace medicareApp.View
{
    partial class AddPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPasien));
            this.date_pas = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_keluhan = new System.Windows.Forms.Label();
            this.txt_alamatPas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_idPas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_namaPas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_noTlpPas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_keluhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_jdDok = new System.Windows.Forms.Label();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.lbl_jkel = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_spesialis = new System.Windows.Forms.Label();
            this.lbl_tlp = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_jkel = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // date_pas
            // 
            this.date_pas.BackColor = System.Drawing.Color.Transparent;
            this.date_pas.BorderRadius = 10;
            this.date_pas.Checked = true;
            this.date_pas.FillColor = System.Drawing.Color.White;
            this.date_pas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_pas.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_pas.Location = new System.Drawing.Point(192, 196);
            this.date_pas.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_pas.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_pas.Name = "date_pas";
            this.date_pas.Size = new System.Drawing.Size(331, 36);
            this.date_pas.TabIndex = 81;
            this.date_pas.Value = new System.DateTime(2024, 11, 23, 18, 15, 44, 554);
            // 
            // lbl_keluhan
            // 
            this.lbl_keluhan.AutoSize = true;
            this.lbl_keluhan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_keluhan.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keluhan.Location = new System.Drawing.Point(48, 375);
            this.lbl_keluhan.Name = "lbl_keluhan";
            this.lbl_keluhan.Size = new System.Drawing.Size(85, 42);
            this.lbl_keluhan.TabIndex = 80;
            this.lbl_keluhan.Text = "Keluhan";
            // 
            // txt_alamatPas
            // 
            this.txt_alamatPas.BackColor = System.Drawing.Color.Transparent;
            this.txt_alamatPas.BorderRadius = 15;
            this.txt_alamatPas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_alamatPas.DefaultText = "";
            this.txt_alamatPas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_alamatPas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_alamatPas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_alamatPas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_alamatPas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_alamatPas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_alamatPas.ForeColor = System.Drawing.Color.Black;
            this.txt_alamatPas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_alamatPas.Location = new System.Drawing.Point(192, 279);
            this.txt_alamatPas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_alamatPas.Name = "txt_alamatPas";
            this.txt_alamatPas.PasswordChar = '\0';
            this.txt_alamatPas.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_alamatPas.PlaceholderText = "";
            this.txt_alamatPas.SelectedText = "";
            this.txt_alamatPas.Size = new System.Drawing.Size(331, 32);
            this.txt_alamatPas.TabIndex = 79;
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
            this.txt_idPas.Location = new System.Drawing.Point(192, 117);
            this.txt_idPas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idPas.Name = "txt_idPas";
            this.txt_idPas.PasswordChar = '\0';
            this.txt_idPas.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_idPas.PlaceholderText = "";
            this.txt_idPas.SelectedText = "";
            this.txt_idPas.Size = new System.Drawing.Size(331, 32);
            this.txt_idPas.TabIndex = 78;
            // 
            // txt_namaPas
            // 
            this.txt_namaPas.BackColor = System.Drawing.Color.Transparent;
            this.txt_namaPas.BorderRadius = 15;
            this.txt_namaPas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_namaPas.DefaultText = "";
            this.txt_namaPas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_namaPas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_namaPas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_namaPas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_namaPas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_namaPas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_namaPas.ForeColor = System.Drawing.Color.Black;
            this.txt_namaPas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_namaPas.Location = new System.Drawing.Point(192, 157);
            this.txt_namaPas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_namaPas.Name = "txt_namaPas";
            this.txt_namaPas.PasswordChar = '\0';
            this.txt_namaPas.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_namaPas.PlaceholderText = "";
            this.txt_namaPas.SelectedText = "";
            this.txt_namaPas.Size = new System.Drawing.Size(331, 32);
            this.txt_namaPas.TabIndex = 77;
            // 
            // txt_noTlpPas
            // 
            this.txt_noTlpPas.BackColor = System.Drawing.Color.Transparent;
            this.txt_noTlpPas.BorderRadius = 15;
            this.txt_noTlpPas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_noTlpPas.DefaultText = "";
            this.txt_noTlpPas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_noTlpPas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_noTlpPas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_noTlpPas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_noTlpPas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_noTlpPas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_noTlpPas.ForeColor = System.Drawing.Color.Black;
            this.txt_noTlpPas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_noTlpPas.Location = new System.Drawing.Point(192, 319);
            this.txt_noTlpPas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_noTlpPas.Name = "txt_noTlpPas";
            this.txt_noTlpPas.PasswordChar = '\0';
            this.txt_noTlpPas.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_noTlpPas.PlaceholderText = "";
            this.txt_noTlpPas.SelectedText = "";
            this.txt_noTlpPas.Size = new System.Drawing.Size(331, 32);
            this.txt_noTlpPas.TabIndex = 76;
            this.txt_noTlpPas.TextChanged += new System.EventHandler(this.txt_noTlpPas_TextChanged);
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
            this.txt_keluhan.Location = new System.Drawing.Point(192, 356);
            this.txt_keluhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_keluhan.Name = "txt_keluhan";
            this.txt_keluhan.PasswordChar = '\0';
            this.txt_keluhan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_keluhan.PlaceholderText = "";
            this.txt_keluhan.SelectedText = "";
            this.txt_keluhan.Size = new System.Drawing.Size(331, 61);
            this.txt_keluhan.TabIndex = 75;
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
            this.btn_save.Location = new System.Drawing.Point(438, 424);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 36);
            this.btn_save.TabIndex = 73;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_jdDok
            // 
            this.lbl_jdDok.AutoSize = true;
            this.lbl_jdDok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jdDok.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jdDok.Location = new System.Drawing.Point(38, 20);
            this.lbl_jdDok.Name = "lbl_jdDok";
            this.lbl_jdDok.Size = new System.Drawing.Size(491, 72);
            this.lbl_jdDok.TabIndex = 72;
            this.lbl_jdDok.Text = "Tambah Data Pasien";
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alamat.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alamat.Location = new System.Drawing.Point(43, 271);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(75, 42);
            this.lbl_alamat.TabIndex = 71;
            this.lbl_alamat.Text = "Alamat";
            // 
            // lbl_jkel
            // 
            this.lbl_jkel.AutoSize = true;
            this.lbl_jkel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jkel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jkel.Location = new System.Drawing.Point(48, 229);
            this.lbl_jkel.Name = "lbl_jkel";
            this.lbl_jkel.Size = new System.Drawing.Size(124, 42);
            this.lbl_jkel.TabIndex = 70;
            this.lbl_jkel.Text = "Jenis kelamin";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nama.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(43, 145);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(64, 42);
            this.lbl_nama.TabIndex = 69;
            this.lbl_nama.Text = "Nama";
            // 
            // lbl_spesialis
            // 
            this.lbl_spesialis.AutoSize = true;
            this.lbl_spesialis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_spesialis.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spesialis.Location = new System.Drawing.Point(43, 187);
            this.lbl_spesialis.Name = "lbl_spesialis";
            this.lbl_spesialis.Size = new System.Drawing.Size(128, 42);
            this.lbl_spesialis.TabIndex = 68;
            this.lbl_spesialis.Text = "Tanggal Lahir";
            // 
            // lbl_tlp
            // 
            this.lbl_tlp.AutoSize = true;
            this.lbl_tlp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tlp.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tlp.Location = new System.Drawing.Point(43, 319);
            this.lbl_tlp.Name = "lbl_tlp";
            this.lbl_tlp.Size = new System.Drawing.Size(71, 42);
            this.lbl_tlp.TabIndex = 67;
            this.lbl_tlp.Text = "No Tlp";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(43, 103);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(91, 42);
            this.lbl_id.TabIndex = 66;
            this.lbl_id.Text = "Id Pasien";
            // 
            // txt_jkel
            // 
            this.txt_jkel.BackColor = System.Drawing.Color.Transparent;
            this.txt_jkel.BorderRadius = 15;
            this.txt_jkel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_jkel.DefaultText = "";
            this.txt_jkel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_jkel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_jkel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jkel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jkel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jkel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_jkel.ForeColor = System.Drawing.Color.Black;
            this.txt_jkel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jkel.Location = new System.Drawing.Point(192, 239);
            this.txt_jkel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_jkel.Name = "txt_jkel";
            this.txt_jkel.PasswordChar = '\0';
            this.txt_jkel.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_jkel.PlaceholderText = "";
            this.txt_jkel.SelectedText = "";
            this.txt_jkel.Size = new System.Drawing.Size(331, 32);
            this.txt_jkel.TabIndex = 82;
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
            this.btn_back.Location = new System.Drawing.Point(347, 424);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 36);
            this.btn_back.TabIndex = 83;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 483);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_jkel);
            this.Controls.Add(this.date_pas);
            this.Controls.Add(this.lbl_keluhan);
            this.Controls.Add(this.txt_alamatPas);
            this.Controls.Add(this.txt_idPas);
            this.Controls.Add(this.txt_namaPas);
            this.Controls.Add(this.txt_noTlpPas);
            this.Controls.Add(this.txt_keluhan);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_jdDok);
            this.Controls.Add(this.lbl_alamat);
            this.Controls.Add(this.lbl_jkel);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.lbl_spesialis);
            this.Controls.Add(this.lbl_tlp);
            this.Controls.Add(this.lbl_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPasien";
            this.Load += new System.EventHandler(this.AddPasien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker date_pas;
        private System.Windows.Forms.Label lbl_keluhan;
        private Guna.UI2.WinForms.Guna2TextBox txt_alamatPas;
        private Guna.UI2.WinForms.Guna2TextBox txt_idPas;
        private Guna.UI2.WinForms.Guna2TextBox txt_namaPas;
        private Guna.UI2.WinForms.Guna2TextBox txt_noTlpPas;
        private Guna.UI2.WinForms.Guna2TextBox txt_keluhan;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label lbl_jdDok;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.Label lbl_jkel;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_spesialis;
        private System.Windows.Forms.Label lbl_tlp;
        private System.Windows.Forms.Label lbl_id;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2TextBox txt_jkel;
        private Guna.UI2.WinForms.Guna2Button btn_back;
    }
}