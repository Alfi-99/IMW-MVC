namespace IMW_MVC.View
{
    partial class AddTransaksi
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
            this.sisa_barang = new System.Windows.Forms.TextBox();
            this.simpan_id = new System.Windows.Forms.Label();
            this.select_barang = new System.Windows.Forms.ComboBox();
            this.harga_input = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.TextBox();
            this.barang_masuk = new System.Windows.Forms.Button();
            this.barang_keluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.jml_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ket_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(101, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Sisa Barang";
            // 
            // sisa_barang
            // 
            this.sisa_barang.Location = new System.Drawing.Point(90, 236);
            this.sisa_barang.Multiline = true;
            this.sisa_barang.Name = "sisa_barang";
            this.sisa_barang.Size = new System.Drawing.Size(231, 30);
            this.sisa_barang.TabIndex = 40;
            // 
            // simpan_id
            // 
            this.simpan_id.AutoSize = true;
            this.simpan_id.BackColor = System.Drawing.Color.Transparent;
            this.simpan_id.ForeColor = System.Drawing.Color.White;
            this.simpan_id.Location = new System.Drawing.Point(339, 253);
            this.simpan_id.Name = "simpan_id";
            this.simpan_id.Size = new System.Drawing.Size(0, 13);
            this.simpan_id.TabIndex = 39;
            // 
            // select_barang
            // 
            this.select_barang.FormattingEnabled = true;
            this.select_barang.Location = new System.Drawing.Point(90, 109);
            this.select_barang.Name = "select_barang";
            this.select_barang.Size = new System.Drawing.Size(231, 21);
            this.select_barang.TabIndex = 38;
            this.select_barang.SelectedIndexChanged += new System.EventHandler(this.select_barang_SelectedIndexChanged);
            // 
            // harga_input
            // 
            this.harga_input.AutoSize = true;
            this.harga_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_input.ForeColor = System.Drawing.Color.Black;
            this.harga_input.Location = new System.Drawing.Point(101, 344);
            this.harga_input.Name = "harga_input";
            this.harga_input.Size = new System.Drawing.Size(41, 13);
            this.harga_input.TabIndex = 37;
            this.harga_input.Text = "Harga";
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(90, 360);
            this.harga.Multiline = true;
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(231, 30);
            this.harga.TabIndex = 36;
            // 
            // barang_masuk
            // 
            this.barang_masuk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.barang_masuk.ForeColor = System.Drawing.Color.White;
            this.barang_masuk.Location = new System.Drawing.Point(211, 403);
            this.barang_masuk.Name = "barang_masuk";
            this.barang_masuk.Size = new System.Drawing.Size(110, 30);
            this.barang_masuk.TabIndex = 35;
            this.barang_masuk.Text = "Barang Masuk";
            this.barang_masuk.UseVisualStyleBackColor = false;
            this.barang_masuk.Click += new System.EventHandler(this.barang_masuk_Click);
            // 
            // barang_keluar
            // 
            this.barang_keluar.BackColor = System.Drawing.Color.Brown;
            this.barang_keluar.ForeColor = System.Drawing.Color.White;
            this.barang_keluar.Location = new System.Drawing.Point(90, 403);
            this.barang_keluar.Name = "barang_keluar";
            this.barang_keluar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barang_keluar.Size = new System.Drawing.Size(110, 30);
            this.barang_keluar.TabIndex = 34;
            this.barang_keluar.Text = "Barang Keluar";
            this.barang_keluar.UseVisualStyleBackColor = false;
            this.barang_keluar.Click += new System.EventHandler(this.barang_keluar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Jumlah Barang";
            // 
            // jml_input
            // 
            this.jml_input.Location = new System.Drawing.Point(90, 297);
            this.jml_input.Multiline = true;
            this.jml_input.Name = "jml_input";
            this.jml_input.Size = new System.Drawing.Size(231, 30);
            this.jml_input.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(99, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tambah Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(101, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Keterangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(101, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nama Barang";
            // 
            // ket_input
            // 
            this.ket_input.Location = new System.Drawing.Point(90, 179);
            this.ket_input.Multiline = true;
            this.ket_input.Name = "ket_input";
            this.ket_input.Size = new System.Drawing.Size(231, 30);
            this.ket_input.TabIndex = 28;
            // 
            // AddTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 464);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sisa_barang);
            this.Controls.Add(this.simpan_id);
            this.Controls.Add(this.select_barang);
            this.Controls.Add(this.harga_input);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.barang_masuk);
            this.Controls.Add(this.barang_keluar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jml_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ket_input);
            this.Name = "AddTransaksi";
            this.Text = "AddTransaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sisa_barang;
        private System.Windows.Forms.Label simpan_id;
        private System.Windows.Forms.ComboBox select_barang;
        private System.Windows.Forms.Label harga_input;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Button barang_masuk;
        private System.Windows.Forms.Button barang_keluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jml_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ket_input;
    }
}