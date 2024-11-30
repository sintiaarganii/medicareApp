namespace medicareApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_in = new Guna.UI2.WinForms.Guna2Button();
            this.btn_up = new Guna.UI2.WinForms.Guna2Button();
            this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_sign = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxEyeClosed = new System.Windows.Forms.PictureBox();
            this.pictureBoxEyeOpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_in
            // 
            this.btn_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_in.BorderRadius = 5;
            this.btn_in.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_in.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_in.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_in.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_in.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_in.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_in.ForeColor = System.Drawing.Color.White;
            this.btn_in.Location = new System.Drawing.Point(525, 249);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(98, 28);
            this.btn_in.TabIndex = 13;
            this.btn_in.Text = "Sign In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_up
            // 
            this.btn_up.BorderRadius = 5;
            this.btn_up.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_up.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_up.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_up.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_up.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_up.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_up.ForeColor = System.Drawing.Color.White;
            this.btn_up.Location = new System.Drawing.Point(421, 249);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(98, 28);
            this.btn_up.TabIndex = 12;
            this.btn_up.Text = "Sign Up";
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultText = "";
            this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.Location = new System.Drawing.Point(394, 156);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(229, 23);
            this.txt_pass.TabIndex = 11;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // txt_user
            // 
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.DefaultText = "";
            this.txt_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_user.ForeColor = System.Drawing.Color.Black;
            this.txt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user.Location = new System.Drawing.Point(394, 110);
            this.txt_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.PlaceholderText = "";
            this.txt_user.SelectedText = "";
            this.txt_user.Size = new System.Drawing.Size(229, 23);
            this.txt_user.TabIndex = 10;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.Black;
            this.lbl_pass.Location = new System.Drawing.Point(310, 156);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(74, 20);
            this.lbl_pass.TabIndex = 9;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Black;
            this.lbl_user.Location = new System.Drawing.Point(310, 110);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(78, 20);
            this.lbl_user.TabIndex = 8;
            this.lbl_user.Text = "Username";
            // 
            // lbl_sign
            // 
            this.lbl_sign.AutoSize = true;
            this.lbl_sign.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sign.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sign.ForeColor = System.Drawing.Color.Black;
            this.lbl_sign.Location = new System.Drawing.Point(413, 41);
            this.lbl_sign.Name = "lbl_sign";
            this.lbl_sign.Size = new System.Drawing.Size(106, 24);
            this.lbl_sign.TabIndex = 7;
            this.lbl_sign.Text = "MEDICARE";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(606, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(57, 37);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBoxEyeClosed
            // 
            this.pictureBoxEyeClosed.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEyeClosed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEyeClosed.Image")));
            this.pictureBoxEyeClosed.Location = new System.Drawing.Point(593, 156);
            this.pictureBoxEyeClosed.Name = "pictureBoxEyeClosed";
            this.pictureBoxEyeClosed.Size = new System.Drawing.Size(30, 23);
            this.pictureBoxEyeClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEyeClosed.TabIndex = 15;
            this.pictureBoxEyeClosed.TabStop = false;
            this.pictureBoxEyeClosed.Click += new System.EventHandler(this.pictureBoxEyeClosed_Click);
            // 
            // pictureBoxEyeOpen
            // 
            this.pictureBoxEyeOpen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEyeOpen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEyeOpen.Image")));
            this.pictureBoxEyeOpen.Location = new System.Drawing.Point(593, 156);
            this.pictureBoxEyeOpen.Name = "pictureBoxEyeOpen";
            this.pictureBoxEyeOpen.Size = new System.Drawing.Size(30, 23);
            this.pictureBoxEyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEyeOpen.TabIndex = 16;
            this.pictureBoxEyeOpen.TabStop = false;
            this.pictureBoxEyeOpen.Click += new System.EventHandler(this.pictureBoxEyeOpen_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 358);
            this.Controls.Add(this.pictureBoxEyeOpen);
            this.Controls.Add(this.pictureBoxEyeClosed);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_sign);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_in;
        private Guna.UI2.WinForms.Guna2Button btn_up;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_sign;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        public Guna.UI2.WinForms.Guna2TextBox txt_pass;
        public Guna.UI2.WinForms.Guna2TextBox txt_user;
        private System.Windows.Forms.PictureBox pictureBoxEyeClosed;
        private System.Windows.Forms.PictureBox pictureBoxEyeOpen;
    }
}

