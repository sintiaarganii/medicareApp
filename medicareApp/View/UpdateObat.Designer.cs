namespace medicareApp.View
{
    partial class UpdateObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateObat));
            this.txt_stok = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_jdDok = new System.Windows.Forms.Label();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.txt_kode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_kode = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.txt_stok.Location = new System.Drawing.Point(346, 182);
            this.txt_stok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.PasswordChar = '\0';
            this.txt_stok.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_stok.PlaceholderText = "";
            this.txt_stok.SelectedText = "";
            this.txt_stok.Size = new System.Drawing.Size(87, 32);
            this.txt_stok.TabIndex = 105;
            this.txt_stok.TextChanged += new System.EventHandler(this.txt_stok_TextChanged);
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
            this.btn_save.Location = new System.Drawing.Point(348, 244);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 36);
            this.btn_save.TabIndex = 101;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_jdDok
            // 
            this.lbl_jdDok.AutoSize = true;
            this.lbl_jdDok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jdDok.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jdDok.Location = new System.Drawing.Point(137, 60);
            this.lbl_jdDok.Name = "lbl_jdDok";
            this.lbl_jdDok.Size = new System.Drawing.Size(236, 49);
            this.lbl_jdDok.TabIndex = 100;
            this.lbl_jdDok.Text = "Tambah Stock";
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stok.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stok.Location = new System.Drawing.Point(272, 182);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(53, 42);
            this.lbl_stok.TabIndex = 99;
            this.lbl_stok.Text = "Stok";
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
            this.txt_kode.Location = new System.Drawing.Point(183, 141);
            this.txt_kode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.PasswordChar = '\0';
            this.txt_kode.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_kode.PlaceholderText = "";
            this.txt_kode.SelectedText = "";
            this.txt_kode.Size = new System.Drawing.Size(250, 32);
            this.txt_kode.TabIndex = 104;
            this.txt_kode.TextChanged += new System.EventHandler(this.txt_kode_TextChanged);
            // 
            // lbl_kode
            // 
            this.lbl_kode.AutoSize = true;
            this.lbl_kode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kode.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kode.Location = new System.Drawing.Point(75, 131);
            this.lbl_kode.Name = "lbl_kode";
            this.lbl_kode.Size = new System.Drawing.Size(102, 42);
            this.lbl_kode.TabIndex = 96;
            this.lbl_kode.Text = "Kode Obat";
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
            this.btn_back.Location = new System.Drawing.Point(257, 244);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 36);
            this.btn_back.TabIndex = 106;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // UpdateObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_jdDok);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_kode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateObat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_stok;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label lbl_jdDok;
        private System.Windows.Forms.Label lbl_stok;
        private Guna.UI2.WinForms.Guna2TextBox txt_kode;
        private System.Windows.Forms.Label lbl_kode;
        private Guna.UI2.WinForms.Guna2Button btn_back;
    }
}