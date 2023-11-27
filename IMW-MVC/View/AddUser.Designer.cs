namespace IMW_MVC.View
{
    partial class AddUser
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
            this.label5 = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.simpan_id = new System.Windows.Forms.Label();
            this.tambah_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJudulEntry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.select_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(102, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Password User";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(91, 175);
            this.password_input.Multiline = true;
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(231, 30);
            this.password_input.TabIndex = 54;
            // 
            // simpan_id
            // 
            this.simpan_id.AutoSize = true;
            this.simpan_id.BackColor = System.Drawing.Color.Transparent;
            this.simpan_id.ForeColor = System.Drawing.Color.White;
            this.simpan_id.Location = new System.Drawing.Point(340, 192);
            this.simpan_id.Name = "simpan_id";
            this.simpan_id.Size = new System.Drawing.Size(0, 13);
            this.simpan_id.TabIndex = 53;
            // 
            // tambah_user
            // 
            this.tambah_user.BackColor = System.Drawing.Color.Brown;
            this.tambah_user.ForeColor = System.Drawing.Color.White;
            this.tambah_user.Location = new System.Drawing.Point(142, 325);
            this.tambah_user.Name = "tambah_user";
            this.tambah_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tambah_user.Size = new System.Drawing.Size(110, 30);
            this.tambah_user.TabIndex = 48;
            this.tambah_user.Text = "Tambah";
            this.tambah_user.UseVisualStyleBackColor = false;
            this.tambah_user.Click += new System.EventHandler(this.tambah_user_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Status User";
            // 
            // txtJudulEntry
            // 
            this.txtJudulEntry.AutoSize = true;
            this.txtJudulEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudulEntry.ForeColor = System.Drawing.Color.Black;
            this.txtJudulEntry.Location = new System.Drawing.Point(126, 31);
            this.txtJudulEntry.Name = "txtJudulEntry";
            this.txtJudulEntry.Size = new System.Drawing.Size(152, 25);
            this.txtJudulEntry.TabIndex = 45;
            this.txtJudulEntry.Text = "Tambah User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nama User";
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(91, 118);
            this.username_input.Multiline = true;
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(231, 30);
            this.username_input.TabIndex = 42;
            // 
            // select_status
            // 
            this.select_status.FormattingEnabled = true;
            this.select_status.Items.AddRange(new object[] {
            "Karyawan",
            "User"});
            this.select_status.Location = new System.Drawing.Point(91, 237);
            this.select_status.Name = "select_status";
            this.select_status.Size = new System.Drawing.Size(231, 21);
            this.select_status.TabIndex = 56;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 404);
            this.Controls.Add(this.select_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.simpan_id);
            this.Controls.Add(this.tambah_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJudulEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_input);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label simpan_id;
        private System.Windows.Forms.Button tambah_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtJudulEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.ComboBox select_status;
    }
}