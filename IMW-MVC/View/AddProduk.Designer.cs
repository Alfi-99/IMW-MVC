namespace IMW_MVC.View
{
    partial class AddProduk
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
            this.input_deskripsi = new System.Windows.Forms.TextBox();
            this.simpan_id = new System.Windows.Forms.Label();
            this.select_gudang = new System.Windows.Forms.ComboBox();
            this.harga_input = new System.Windows.Forms.Label();
            this.input_lokasi = new System.Windows.Forms.TextBox();
            this.btn_tambah_barang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_jml = new System.Windows.Forms.TextBox();
            this.txtJudulEntry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_nama = new System.Windows.Forms.TextBox();
            this.input_kapasitas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_harga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(104, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Deskripsi";
            // 
            // input_deskripsi
            // 
            this.input_deskripsi.Location = new System.Drawing.Point(93, 229);
            this.input_deskripsi.Multiline = true;
            this.input_deskripsi.Name = "input_deskripsi";
            this.input_deskripsi.Size = new System.Drawing.Size(231, 30);
            this.input_deskripsi.TabIndex = 54;
            // 
            // simpan_id
            // 
            this.simpan_id.AutoSize = true;
            this.simpan_id.BackColor = System.Drawing.Color.Transparent;
            this.simpan_id.ForeColor = System.Drawing.Color.White;
            this.simpan_id.Location = new System.Drawing.Point(525, 246);
            this.simpan_id.Name = "simpan_id";
            this.simpan_id.Size = new System.Drawing.Size(0, 13);
            this.simpan_id.TabIndex = 53;
            // 
            // select_gudang
            // 
            this.select_gudang.FormattingEnabled = true;
            this.select_gudang.Location = new System.Drawing.Point(93, 102);
            this.select_gudang.Name = "select_gudang";
            this.select_gudang.Size = new System.Drawing.Size(231, 21);
            this.select_gudang.TabIndex = 52;
            this.select_gudang.SelectedIndexChanged += new System.EventHandler(this.select_gudang_SelectedIndexChanged);
            // 
            // harga_input
            // 
            this.harga_input.AutoSize = true;
            this.harga_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_input.ForeColor = System.Drawing.Color.Black;
            this.harga_input.Location = new System.Drawing.Point(104, 337);
            this.harga_input.Name = "harga_input";
            this.harga_input.Size = new System.Drawing.Size(44, 13);
            this.harga_input.TabIndex = 51;
            this.harga_input.Text = "Lokasi";
            // 
            // input_lokasi
            // 
            this.input_lokasi.Location = new System.Drawing.Point(93, 353);
            this.input_lokasi.Multiline = true;
            this.input_lokasi.Name = "input_lokasi";
            this.input_lokasi.Size = new System.Drawing.Size(231, 30);
            this.input_lokasi.TabIndex = 50;
            // 
            // btn_tambah_barang
            // 
            this.btn_tambah_barang.BackColor = System.Drawing.Color.Brown;
            this.btn_tambah_barang.ForeColor = System.Drawing.Color.White;
            this.btn_tambah_barang.Location = new System.Drawing.Point(148, 550);
            this.btn_tambah_barang.Name = "btn_tambah_barang";
            this.btn_tambah_barang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_tambah_barang.Size = new System.Drawing.Size(110, 30);
            this.btn_tambah_barang.TabIndex = 48;
            this.btn_tambah_barang.Text = "Tambah";
            this.btn_tambah_barang.UseVisualStyleBackColor = false;
            this.btn_tambah_barang.Click += new System.EventHandler(this.btn_tambah_barang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Jumlah Barang";
            // 
            // input_jml
            // 
            this.input_jml.Location = new System.Drawing.Point(93, 290);
            this.input_jml.Multiline = true;
            this.input_jml.Name = "input_jml";
            this.input_jml.Size = new System.Drawing.Size(231, 30);
            this.input_jml.TabIndex = 46;
            // 
            // txtJudulEntry
            // 
            this.txtJudulEntry.AutoSize = true;
            this.txtJudulEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudulEntry.ForeColor = System.Drawing.Color.Black;
            this.txtJudulEntry.Location = new System.Drawing.Point(115, 29);
            this.txtJudulEntry.Name = "txtJudulEntry";
            this.txtJudulEntry.Size = new System.Drawing.Size(177, 25);
            this.txtJudulEntry.TabIndex = 45;
            this.txtJudulEntry.Text = "Tambah Produk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(104, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(104, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Gudang";
            // 
            // input_nama
            // 
            this.input_nama.Location = new System.Drawing.Point(93, 172);
            this.input_nama.Multiline = true;
            this.input_nama.Name = "input_nama";
            this.input_nama.Size = new System.Drawing.Size(231, 30);
            this.input_nama.TabIndex = 42;
            // 
            // input_kapasitas
            // 
            this.input_kapasitas.Location = new System.Drawing.Point(93, 415);
            this.input_kapasitas.Multiline = true;
            this.input_kapasitas.Name = "input_kapasitas";
            this.input_kapasitas.Size = new System.Drawing.Size(231, 30);
            this.input_kapasitas.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(104, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Kapasitas";
            // 
            // input_harga
            // 
            this.input_harga.Location = new System.Drawing.Point(93, 481);
            this.input_harga.Multiline = true;
            this.input_harga.Name = "input_harga";
            this.input_harga.Size = new System.Drawing.Size(231, 30);
            this.input_harga.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(104, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "label7";
            // 
            // AddProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_harga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_kapasitas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_deskripsi);
            this.Controls.Add(this.simpan_id);
            this.Controls.Add(this.select_gudang);
            this.Controls.Add(this.harga_input);
            this.Controls.Add(this.input_lokasi);
            this.Controls.Add(this.btn_tambah_barang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_jml);
            this.Controls.Add(this.txtJudulEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_nama);
            this.Name = "AddProduk";
            this.Text = "AddProduk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_deskripsi;
        private System.Windows.Forms.Label simpan_id;
        private System.Windows.Forms.ComboBox select_gudang;
        private System.Windows.Forms.Label harga_input;
        private System.Windows.Forms.TextBox input_lokasi;
        private System.Windows.Forms.Button btn_tambah_barang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_jml;
        private System.Windows.Forms.Label txtJudulEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_nama;
        private System.Windows.Forms.TextBox input_kapasitas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_harga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}