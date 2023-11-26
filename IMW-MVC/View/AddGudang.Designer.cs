namespace IMW_MVC.View
{
    partial class AddGudang
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
            this.label4 = new System.Windows.Forms.Label();
            this.input_kapasitas_gudang = new System.Windows.Forms.TextBox();
            this.harga_input = new System.Windows.Forms.Label();
            this.input_alamat_gudang = new System.Windows.Forms.TextBox();
            this.btn_tambah_gudang = new System.Windows.Forms.Button();
            this.txtJudulEntry = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_nama_gudang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(106, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Kapasitas";
            // 
            // input_kapasitas_gudang
            // 
            this.input_kapasitas_gudang.Location = new System.Drawing.Point(95, 246);
            this.input_kapasitas_gudang.Multiline = true;
            this.input_kapasitas_gudang.Name = "input_kapasitas_gudang";
            this.input_kapasitas_gudang.Size = new System.Drawing.Size(231, 30);
            this.input_kapasitas_gudang.TabIndex = 72;
            // 
            // harga_input
            // 
            this.harga_input.AutoSize = true;
            this.harga_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_input.ForeColor = System.Drawing.Color.Black;
            this.harga_input.Location = new System.Drawing.Point(106, 168);
            this.harga_input.Name = "harga_input";
            this.harga_input.Size = new System.Drawing.Size(45, 13);
            this.harga_input.TabIndex = 68;
            this.harga_input.Text = "Alamat";
            // 
            // input_alamat_gudang
            // 
            this.input_alamat_gudang.Location = new System.Drawing.Point(95, 184);
            this.input_alamat_gudang.Multiline = true;
            this.input_alamat_gudang.Name = "input_alamat_gudang";
            this.input_alamat_gudang.Size = new System.Drawing.Size(231, 30);
            this.input_alamat_gudang.TabIndex = 67;
            // 
            // btn_tambah_gudang
            // 
            this.btn_tambah_gudang.BackColor = System.Drawing.Color.Brown;
            this.btn_tambah_gudang.ForeColor = System.Drawing.Color.White;
            this.btn_tambah_gudang.Location = new System.Drawing.Point(147, 319);
            this.btn_tambah_gudang.Name = "btn_tambah_gudang";
            this.btn_tambah_gudang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_tambah_gudang.Size = new System.Drawing.Size(110, 30);
            this.btn_tambah_gudang.TabIndex = 66;
            this.btn_tambah_gudang.Text = "Tambah";
            this.btn_tambah_gudang.UseVisualStyleBackColor = false;
            this.btn_tambah_gudang.Click += new System.EventHandler(this.btn_tambah_gudang_Click);
            // 
            // txtJudulEntry
            // 
            this.txtJudulEntry.AutoSize = true;
            this.txtJudulEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudulEntry.ForeColor = System.Drawing.Color.Black;
            this.txtJudulEntry.Location = new System.Drawing.Point(121, 21);
            this.txtJudulEntry.Name = "txtJudulEntry";
            this.txtJudulEntry.Size = new System.Drawing.Size(185, 25);
            this.txtJudulEntry.TabIndex = 63;
            this.txtJudulEntry.Text = "Tambah Gudang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(106, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nama Gudang";
            // 
            // input_nama_gudang
            // 
            this.input_nama_gudang.Location = new System.Drawing.Point(95, 121);
            this.input_nama_gudang.Multiline = true;
            this.input_nama_gudang.Name = "input_nama_gudang";
            this.input_nama_gudang.Size = new System.Drawing.Size(231, 30);
            this.input_nama_gudang.TabIndex = 75;
            // 
            // AddGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 400);
            this.Controls.Add(this.input_nama_gudang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_kapasitas_gudang);
            this.Controls.Add(this.harga_input);
            this.Controls.Add(this.input_alamat_gudang);
            this.Controls.Add(this.btn_tambah_gudang);
            this.Controls.Add(this.txtJudulEntry);
            this.Name = "AddGudang";
            this.Text = "AddGudang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_kapasitas_gudang;
        private System.Windows.Forms.Label harga_input;
        private System.Windows.Forms.TextBox input_alamat_gudang;
        private System.Windows.Forms.Button btn_tambah_gudang;
        private System.Windows.Forms.Label txtJudulEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_nama_gudang;
    }
}