namespace IMW_MVC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.sh_pass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_daftar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sh_pass
            // 
            this.sh_pass.AutoSize = true;
            this.sh_pass.BackColor = System.Drawing.Color.Transparent;
            this.sh_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.sh_pass.ForeColor = System.Drawing.Color.White;
            this.sh_pass.Location = new System.Drawing.Point(484, 277);
            this.sh_pass.Margin = new System.Windows.Forms.Padding(4);
            this.sh_pass.Name = "sh_pass";
            this.sh_pass.Size = new System.Drawing.Size(145, 25);
            this.sh_pass.TabIndex = 18;
            this.sh_pass.Text = "Show Password";
            this.sh_pass.UseVisualStyleBackColor = false;
            this.sh_pass.CheckedChanged += new System.EventHandler(this.sh_pass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(382, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 82);
            this.label1.TabIndex = 25;
            this.label1.Text = "WAREHOUSE SYSTEM\r\nMANAGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pass_input
            // 
            this.pass_input.BorderRadius = 15;
            this.pass_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_input.DefaultText = "";
            this.pass_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass_input.FillColor = System.Drawing.Color.Gainsboro;
            this.pass_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pass_input.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pass_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass_input.IconLeft = ((System.Drawing.Image)(resources.GetObject("pass_input.IconLeft")));
            this.pass_input.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.pass_input.Location = new System.Drawing.Point(379, 228);
            this.pass_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass_input.Multiline = true;
            this.pass_input.Name = "pass_input";
            this.pass_input.PasswordChar = '*';
            this.pass_input.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.pass_input.PlaceholderText = "Password";
            this.pass_input.SelectedText = "";
            this.pass_input.Size = new System.Drawing.Size(250, 42);
            this.pass_input.TabIndex = 27;
            // 
            // name_input
            // 
            this.name_input.BorderRadius = 15;
            this.name_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_input.DefaultText = "";
            this.name_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_input.FillColor = System.Drawing.Color.Gainsboro;
            this.name_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name_input.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_input.IconLeft = ((System.Drawing.Image)(resources.GetObject("name_input.IconLeft")));
            this.name_input.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.name_input.Location = new System.Drawing.Point(379, 167);
            this.name_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_input.Name = "name_input";
            this.name_input.PasswordChar = '\0';
            this.name_input.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.name_input.PlaceholderText = "Username";
            this.name_input.SelectedText = "";
            this.name_input.Size = new System.Drawing.Size(250, 42);
            this.name_input.TabIndex = 26;
            // 
            // btn_daftar
            // 
            this.btn_daftar.BorderRadius = 15;
            this.btn_daftar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_daftar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_daftar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_daftar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_daftar.FillColor = System.Drawing.Color.White;
            this.btn_daftar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_daftar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_daftar.Location = new System.Drawing.Point(379, 322);
            this.btn_daftar.Name = "btn_daftar";
            this.btn_daftar.Size = new System.Drawing.Size(100, 34);
            this.btn_daftar.TabIndex = 30;
            this.btn_daftar.Text = "Daftar";
            this.btn_daftar.Click += new System.EventHandler(this.btn_daftar_Click_1);
            // 
            // btn_login
            // 
            this.btn_login.BorderRadius = 15;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.White;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.Location = new System.Drawing.Point(529, 322);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 34);
            this.btn_login.TabIndex = 29;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(10, 10);
            this.guna2ImageButton1.Location = new System.Drawing.Point(750, -5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.guna2ImageButton1.Size = new System.Drawing.Size(57, 40);
            this.guna2ImageButton1.TabIndex = 31;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-853, -109);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1661, 1010);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btn_daftar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pass_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sh_pass);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sh_pass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox pass_input;
        private Guna.UI2.WinForms.Guna2TextBox name_input;
        private Guna.UI2.WinForms.Guna2Button btn_daftar;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

