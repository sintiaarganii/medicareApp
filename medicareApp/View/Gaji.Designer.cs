namespace medicareApp.View
{
    partial class Gaji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gaji));
            this.dtg_gaji = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_GajiPokok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tunjungan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_spesialis = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Gaji = new System.Windows.Forms.Label();
            this.txtPajak = new Guna.UI2.WinForms.Guna2TextBox();
            this.printDialogGaji = new System.Windows.Forms.PrintDialog();
            this.printDocumentGaji = new System.Drawing.Printing.PrintDocument();
            this.btn_print = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gaji)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_gaji
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtg_gaji.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_gaji.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_gaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_gaji.ColumnHeadersHeight = 20;
            this.dtg_gaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_gaji.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_gaji.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_gaji.Location = new System.Drawing.Point(12, 126);
            this.dtg_gaji.Name = "dtg_gaji";
            this.dtg_gaji.RowHeadersVisible = false;
            this.dtg_gaji.RowHeadersWidth = 20;
            this.dtg_gaji.RowTemplate.Height = 24;
            this.dtg_gaji.Size = new System.Drawing.Size(776, 211);
            this.dtg_gaji.TabIndex = 0;
            this.dtg_gaji.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_gaji.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_gaji.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_gaji.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_gaji.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_gaji.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dtg_gaji.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_gaji.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_gaji.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_gaji.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_gaji.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_gaji.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_gaji.ThemeStyle.HeaderStyle.Height = 20;
            this.dtg_gaji.ThemeStyle.ReadOnly = false;
            this.dtg_gaji.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_gaji.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_gaji.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_gaji.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_gaji.ThemeStyle.RowsStyle.Height = 24;
            this.dtg_gaji.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_gaji.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_gaji.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_gaji_CellClick);
            this.dtg_gaji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_gaji_CellContentClick);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderRadius = 10;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.Location = new System.Drawing.Point(471, 360);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(85, 36);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderRadius = 10;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(471, 402);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 36);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_back.Location = new System.Drawing.Point(562, 402);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 36);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_id.BorderRadius = 15;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(12, 344);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(119, 28);
            this.txt_id.TabIndex = 30;
            // 
            // txt_GajiPokok
            // 
            this.txt_GajiPokok.BackColor = System.Drawing.Color.Transparent;
            this.txt_GajiPokok.BorderRadius = 15;
            this.txt_GajiPokok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GajiPokok.DefaultText = "";
            this.txt_GajiPokok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_GajiPokok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_GajiPokok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_GajiPokok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_GajiPokok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_GajiPokok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_GajiPokok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_GajiPokok.Location = new System.Drawing.Point(137, 380);
            this.txt_GajiPokok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_GajiPokok.Name = "txt_GajiPokok";
            this.txt_GajiPokok.PasswordChar = '\0';
            this.txt_GajiPokok.PlaceholderText = "";
            this.txt_GajiPokok.SelectedText = "";
            this.txt_GajiPokok.Size = new System.Drawing.Size(119, 28);
            this.txt_GajiPokok.TabIndex = 32;
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
            this.txt_nama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nama.Location = new System.Drawing.Point(137, 344);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.PasswordChar = '\0';
            this.txt_nama.PlaceholderText = "";
            this.txt_nama.SelectedText = "";
            this.txt_nama.Size = new System.Drawing.Size(119, 28);
            this.txt_nama.TabIndex = 33;
            // 
            // txt_tunjungan
            // 
            this.txt_tunjungan.BackColor = System.Drawing.Color.Transparent;
            this.txt_tunjungan.BorderRadius = 15;
            this.txt_tunjungan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tunjungan.DefaultText = "";
            this.txt_tunjungan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tunjungan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tunjungan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tunjungan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tunjungan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tunjungan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tunjungan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tunjungan.Location = new System.Drawing.Point(12, 416);
            this.txt_tunjungan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tunjungan.Name = "txt_tunjungan";
            this.txt_tunjungan.PasswordChar = '\0';
            this.txt_tunjungan.PlaceholderText = "";
            this.txt_tunjungan.SelectedText = "";
            this.txt_tunjungan.Size = new System.Drawing.Size(119, 28);
            this.txt_tunjungan.TabIndex = 34;
            // 
            // txt_spesialis
            // 
            this.txt_spesialis.BackColor = System.Drawing.Color.Transparent;
            this.txt_spesialis.BorderRadius = 15;
            this.txt_spesialis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_spesialis.DefaultText = "";
            this.txt_spesialis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_spesialis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_spesialis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_spesialis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_spesialis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_spesialis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_spesialis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_spesialis.Location = new System.Drawing.Point(12, 380);
            this.txt_spesialis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_spesialis.Name = "txt_spesialis";
            this.txt_spesialis.PasswordChar = '\0';
            this.txt_spesialis.PlaceholderText = "";
            this.txt_spesialis.SelectedText = "";
            this.txt_spesialis.Size = new System.Drawing.Size(119, 28);
            this.txt_spesialis.TabIndex = 35;
            // 
            // lbl_Gaji
            // 
            this.lbl_Gaji.AutoSize = true;
            this.lbl_Gaji.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gaji.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gaji.Location = new System.Drawing.Point(177, 24);
            this.lbl_Gaji.Name = "lbl_Gaji";
            this.lbl_Gaji.Size = new System.Drawing.Size(484, 52);
            this.lbl_Gaji.TabIndex = 36;
            this.lbl_Gaji.Text = "PENGGAJIAN DOKTER";
            // 
            // txtPajak
            // 
            this.txtPajak.BackColor = System.Drawing.Color.Transparent;
            this.txtPajak.BorderRadius = 15;
            this.txtPajak.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPajak.DefaultText = "";
            this.txtPajak.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPajak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPajak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPajak.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPajak.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPajak.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPajak.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPajak.Location = new System.Drawing.Point(137, 416);
            this.txtPajak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPajak.Name = "txtPajak";
            this.txtPajak.PasswordChar = '\0';
            this.txtPajak.PlaceholderText = "";
            this.txtPajak.SelectedText = "";
            this.txtPajak.Size = new System.Drawing.Size(119, 28);
            this.txtPajak.TabIndex = 37;
            // 
            // printDialogGaji
            // 
            this.printDialogGaji.UseEXDialog = true;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.BorderRadius = 10;
            this.btn_print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_print.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.Location = new System.Drawing.Point(562, 360);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(85, 36);
            this.btn_print.TabIndex = 38;
            this.btn_print.Text = "Print";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Gaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txtPajak);
            this.Controls.Add(this.lbl_Gaji);
            this.Controls.Add(this.txt_spesialis);
            this.Controls.Add(this.txt_tunjungan);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_GajiPokok);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dtg_gaji);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaji";
            this.Load += new System.EventHandler(this.Gaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtg_gaji;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_GajiPokok;
        private Guna.UI2.WinForms.Guna2TextBox txt_nama;
        private Guna.UI2.WinForms.Guna2TextBox txt_tunjungan;
        private Guna.UI2.WinForms.Guna2TextBox txt_spesialis;
        private System.Windows.Forms.Label lbl_Gaji;
        private Guna.UI2.WinForms.Guna2TextBox txtPajak;
        private System.Windows.Forms.PrintDialog printDialogGaji;
        private System.Drawing.Printing.PrintDocument printDocumentGaji;
        private Guna.UI2.WinForms.Guna2Button btn_print;
    }
}