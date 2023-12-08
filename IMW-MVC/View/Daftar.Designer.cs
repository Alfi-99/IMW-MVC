namespace IMW_MVC.View
{
    partial class Daftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daftar));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txt_pass_daftar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_daftar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_kembali = new Guna.UI2.WinForms.Guna2Button();
            this.txt_retype_daftar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_user_daftar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(484, 318);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 25);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-25, -21);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(435, 528);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 29;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(10, 10);
            this.guna2ImageButton1.Location = new System.Drawing.Point(739, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.guna2ImageButton1.Size = new System.Drawing.Size(57, 40);
            this.guna2ImageButton1.TabIndex = 30;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // txt_pass_daftar
            // 
            this.txt_pass_daftar.BorderRadius = 15;
            this.txt_pass_daftar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass_daftar.DefaultText = "";
            this.txt_pass_daftar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass_daftar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass_daftar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass_daftar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass_daftar.FillColor = System.Drawing.Color.Gainsboro;
            this.txt_pass_daftar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass_daftar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pass_daftar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_pass_daftar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass_daftar.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_pass_daftar.IconLeft")));
            this.txt_pass_daftar.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_pass_daftar.Location = new System.Drawing.Point(379, 208);
            this.txt_pass_daftar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pass_daftar.Multiline = true;
            this.txt_pass_daftar.Name = "txt_pass_daftar";
            this.txt_pass_daftar.PasswordChar = '*';
            this.txt_pass_daftar.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_pass_daftar.PlaceholderText = "Password";
            this.txt_pass_daftar.SelectedText = "";
            this.txt_pass_daftar.Size = new System.Drawing.Size(250, 42);
            this.txt_pass_daftar.TabIndex = 39;
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
            this.btn_daftar.Location = new System.Drawing.Point(379, 376);
            this.btn_daftar.Name = "btn_daftar";
            this.btn_daftar.Size = new System.Drawing.Size(110, 34);
            this.btn_daftar.TabIndex = 38;
            this.btn_daftar.Text = "Daftar";
            this.btn_daftar.Click += new System.EventHandler(this.btn_daftar_Click_1);
            // 
            // btn_kembali
            // 
            this.btn_kembali.BorderRadius = 15;
            this.btn_kembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_kembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_kembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_kembali.FillColor = System.Drawing.Color.White;
            this.btn_kembali.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_kembali.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_kembali.Location = new System.Drawing.Point(519, 376);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(110, 34);
            this.btn_kembali.TabIndex = 37;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click_1);
            // 
            // txt_retype_daftar
            // 
            this.txt_retype_daftar.BorderRadius = 15;
            this.txt_retype_daftar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_retype_daftar.DefaultText = "";
            this.txt_retype_daftar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_retype_daftar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_retype_daftar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_retype_daftar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_retype_daftar.FillColor = System.Drawing.Color.Gainsboro;
            this.txt_retype_daftar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_retype_daftar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_retype_daftar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_retype_daftar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_retype_daftar.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_retype_daftar.IconLeft")));
            this.txt_retype_daftar.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_retype_daftar.Location = new System.Drawing.Point(379, 268);
            this.txt_retype_daftar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_retype_daftar.Multiline = true;
            this.txt_retype_daftar.Name = "txt_retype_daftar";
            this.txt_retype_daftar.PasswordChar = '*';
            this.txt_retype_daftar.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_retype_daftar.PlaceholderText = "Retype Password";
            this.txt_retype_daftar.SelectedText = "";
            this.txt_retype_daftar.Size = new System.Drawing.Size(250, 42);
            this.txt_retype_daftar.TabIndex = 36;
            // 
            // txt_user_daftar
            // 
            this.txt_user_daftar.BorderRadius = 15;
            this.txt_user_daftar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_daftar.DefaultText = "";
            this.txt_user_daftar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_user_daftar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_user_daftar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user_daftar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user_daftar.FillColor = System.Drawing.Color.Gainsboro;
            this.txt_user_daftar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user_daftar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_user_daftar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_user_daftar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user_daftar.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_user_daftar.IconLeft")));
            this.txt_user_daftar.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_user_daftar.Location = new System.Drawing.Point(379, 146);
            this.txt_user_daftar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_user_daftar.Name = "txt_user_daftar";
            this.txt_user_daftar.PasswordChar = '\0';
            this.txt_user_daftar.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_user_daftar.PlaceholderText = "Username";
            this.txt_user_daftar.SelectedText = "";
            this.txt_user_daftar.Size = new System.Drawing.Size(250, 42);
            this.txt_user_daftar.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 82);
            this.label1.TabIndex = 40;
            this.label1.Text = "WAREHOUSE SYSTEM\r\nMANAGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Daftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass_daftar);
            this.Controls.Add(this.btn_daftar);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.txt_retype_daftar);
            this.Controls.Add(this.txt_user_daftar);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Daftar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass_daftar;
        private Guna.UI2.WinForms.Guna2Button btn_daftar;
        private Guna.UI2.WinForms.Guna2Button btn_kembali;
        private Guna.UI2.WinForms.Guna2TextBox txt_retype_daftar;
        private Guna.UI2.WinForms.Guna2TextBox txt_user_daftar;
    }
}