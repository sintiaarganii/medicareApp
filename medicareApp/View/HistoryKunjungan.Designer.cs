namespace medicareApp.View
{
    partial class HistoryKunjungan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryKunjungan));
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtg_pengunjung = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.txt_idkun = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_iddok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_diagnosa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_idpas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tanggal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_riwayat = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pengunjung)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.BorderRadius = 15;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(713, 106);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search..";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(195, 37);
            this.txt_search.TabIndex = 57;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dtg_pengunjung
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtg_pengunjung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_pengunjung.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_pengunjung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_pengunjung.ColumnHeadersHeight = 20;
            this.dtg_pengunjung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_pengunjung.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_pengunjung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_pengunjung.Location = new System.Drawing.Point(12, 150);
            this.dtg_pengunjung.Name = "dtg_pengunjung";
            this.dtg_pengunjung.RowHeadersVisible = false;
            this.dtg_pengunjung.RowHeadersWidth = 51;
            this.dtg_pengunjung.RowTemplate.Height = 24;
            this.dtg_pengunjung.Size = new System.Drawing.Size(939, 232);
            this.dtg_pengunjung.TabIndex = 55;
            this.dtg_pengunjung.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_pengunjung.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_pengunjung.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_pengunjung.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_pengunjung.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_pengunjung.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dtg_pengunjung.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_pengunjung.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_pengunjung.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_pengunjung.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_pengunjung.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_pengunjung.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_pengunjung.ThemeStyle.HeaderStyle.Height = 20;
            this.dtg_pengunjung.ThemeStyle.ReadOnly = false;
            this.dtg_pengunjung.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_pengunjung.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_pengunjung.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_pengunjung.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_pengunjung.ThemeStyle.RowsStyle.Height = 24;
            this.dtg_pengunjung.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_pengunjung.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 10;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(866, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 36);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.txt_idkun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idkun.Location = new System.Drawing.Point(271, 413);
            this.txt_idkun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idkun.Name = "txt_idkun";
            this.txt_idkun.PasswordChar = '\0';
            this.txt_idkun.PlaceholderText = "";
            this.txt_idkun.SelectedText = "";
            this.txt_idkun.Size = new System.Drawing.Size(119, 28);
            this.txt_idkun.TabIndex = 50;
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
            this.txt_iddok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_iddok.Location = new System.Drawing.Point(12, 413);
            this.txt_iddok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_iddok.Name = "txt_iddok";
            this.txt_iddok.PasswordChar = '\0';
            this.txt_iddok.PlaceholderText = "";
            this.txt_iddok.SelectedText = "";
            this.txt_iddok.Size = new System.Drawing.Size(119, 28);
            this.txt_iddok.TabIndex = 49;
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
            this.txt_diagnosa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diagnosa.Location = new System.Drawing.Point(12, 449);
            this.txt_diagnosa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diagnosa.Name = "txt_diagnosa";
            this.txt_diagnosa.PasswordChar = '\0';
            this.txt_diagnosa.PlaceholderText = "";
            this.txt_diagnosa.SelectedText = "";
            this.txt_diagnosa.Size = new System.Drawing.Size(119, 28);
            this.txt_diagnosa.TabIndex = 48;
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
            this.txt_idpas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idpas.Location = new System.Drawing.Point(271, 449);
            this.txt_idpas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idpas.Name = "txt_idpas";
            this.txt_idpas.PasswordChar = '\0';
            this.txt_idpas.PlaceholderText = "";
            this.txt_idpas.SelectedText = "";
            this.txt_idpas.Size = new System.Drawing.Size(119, 28);
            this.txt_idpas.TabIndex = 47;
            // 
            // txt_tanggal
            // 
            this.txt_tanggal.BackColor = System.Drawing.Color.Transparent;
            this.txt_tanggal.BorderRadius = 15;
            this.txt_tanggal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tanggal.DefaultText = "";
            this.txt_tanggal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tanggal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tanggal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tanggal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tanggal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tanggal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tanggal.Location = new System.Drawing.Point(146, 413);
            this.txt_tanggal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tanggal.Name = "txt_tanggal";
            this.txt_tanggal.PasswordChar = '\0';
            this.txt_tanggal.PlaceholderText = "";
            this.txt_tanggal.SelectedText = "";
            this.txt_tanggal.Size = new System.Drawing.Size(119, 28);
            this.txt_tanggal.TabIndex = 46;
            // 
            // txt_riwayat
            // 
            this.txt_riwayat.BackColor = System.Drawing.Color.Transparent;
            this.txt_riwayat.BorderRadius = 15;
            this.txt_riwayat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_riwayat.DefaultText = "";
            this.txt_riwayat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_riwayat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_riwayat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_riwayat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_riwayat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_riwayat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_riwayat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_riwayat.Location = new System.Drawing.Point(146, 449);
            this.txt_riwayat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_riwayat.Name = "txt_riwayat";
            this.txt_riwayat.PasswordChar = '\0';
            this.txt_riwayat.PlaceholderText = "";
            this.txt_riwayat.SelectedText = "";
            this.txt_riwayat.Size = new System.Drawing.Size(119, 28);
            this.txt_riwayat.TabIndex = 45;
            // 
            // HistoryKunjungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 517);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dtg_pengunjung);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txt_idkun);
            this.Controls.Add(this.txt_iddok);
            this.Controls.Add(this.txt_diagnosa);
            this.Controls.Add(this.txt_idpas);
            this.Controls.Add(this.txt_tanggal);
            this.Controls.Add(this.txt_riwayat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryKunjungan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryKunjungan";
            this.Load += new System.EventHandler(this.HistoryKunjungan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pengunjung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2DataGridView dtg_pengunjung;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2TextBox txt_idkun;
        private Guna.UI2.WinForms.Guna2TextBox txt_iddok;
        private Guna.UI2.WinForms.Guna2TextBox txt_diagnosa;
        private Guna.UI2.WinForms.Guna2TextBox txt_idpas;
        private Guna.UI2.WinForms.Guna2TextBox txt_tanggal;
        private Guna.UI2.WinForms.Guna2TextBox txt_riwayat;
    }
}