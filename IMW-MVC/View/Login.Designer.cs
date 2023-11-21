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
            this.sh_pass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_daftar = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sh_pass
            // 
            this.sh_pass.AutoSize = true;
            this.sh_pass.BackColor = System.Drawing.Color.Transparent;
            this.sh_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sh_pass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.sh_pass.Location = new System.Drawing.Point(190, 323);
            this.sh_pass.Name = "sh_pass";
            this.sh_pass.Size = new System.Drawing.Size(115, 17);
            this.sh_pass.TabIndex = 18;
            this.sh_pass.Text = "Show Password";
            this.sh_pass.UseVisualStyleBackColor = false;
            this.sh_pass.CheckedChanged += new System.EventHandler(this.sh_pass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(69, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "System Management";
            // 
            // btn_daftar
            // 
            this.btn_daftar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_daftar.ForeColor = System.Drawing.Color.White;
            this.btn_daftar.Location = new System.Drawing.Point(74, 408);
            this.btn_daftar.Name = "btn_daftar";
            this.btn_daftar.Size = new System.Drawing.Size(231, 30);
            this.btn_daftar.TabIndex = 16;
            this.btn_daftar.Text = "Daftar";
            this.btn_daftar.UseVisualStyleBackColor = false;
            this.btn_daftar.Click += new System.EventHandler(this.btn_daftar_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(74, 361);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(231, 30);
            this.btn_login.TabIndex = 15;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(85, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(85, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // pass_input
            // 
            this.pass_input.Location = new System.Drawing.Point(74, 278);
            this.pass_input.Multiline = true;
            this.pass_input.Name = "pass_input";
            this.pass_input.PasswordChar = '*';
            this.pass_input.Size = new System.Drawing.Size(231, 30);
            this.pass_input.TabIndex = 12;
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(74, 187);
            this.name_input.Multiline = true;
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(231, 30);
            this.name_input.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(115, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Warehouse\r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 512);
            this.Controls.Add(this.sh_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_daftar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sh_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_daftar;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label1;
    }
}

