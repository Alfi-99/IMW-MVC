namespace IMW_MVC.View
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabTransaksi = new System.Windows.Forms.TabPage();
            this.btn_delete_transaksi = new System.Windows.Forms.Button();
            this.btn_update_transaksi = new System.Windows.Forms.Button();
            this.lvt = new System.Windows.Forms.ListView();
            this.btn_tampil_transaksi = new System.Windows.Forms.Button();
            this.btn_tambah_transaksi = new System.Windows.Forms.Button();
            this.TabProduk = new System.Windows.Forms.TabPage();
            this.btn_update_produk = new System.Windows.Forms.Button();
            this.btn_delete_produk = new System.Windows.Forms.Button();
            this.btn_tampil_produk = new System.Windows.Forms.Button();
            this.btn_tambah_produk = new System.Windows.Forms.Button();
            this.lvp = new System.Windows.Forms.ListView();
            this.TabGudang = new System.Windows.Forms.TabPage();
            this.lvg = new System.Windows.Forms.ListView();
            this.TabUser = new System.Windows.Forms.TabPage();
            this.lvu = new System.Windows.Forms.ListView();
            this.user_nama = new System.Windows.Forms.Label();
            this.status_user = new System.Windows.Forms.Label();
            this.btn_delete_gudang = new System.Windows.Forms.Button();
            this.btn_update_gudang = new System.Windows.Forms.Button();
            this.btn_tampil_gudang = new System.Windows.Forms.Button();
            this.btn_tambah_gudang = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabTransaksi.SuspendLayout();
            this.TabProduk.SuspendLayout();
            this.TabGudang.SuspendLayout();
            this.TabUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabTransaksi);
            this.tabControl1.Controls.Add(this.TabProduk);
            this.tabControl1.Controls.Add(this.TabGudang);
            this.tabControl1.Controls.Add(this.TabUser);
            this.tabControl1.Location = new System.Drawing.Point(33, 74);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1414, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // TabTransaksi
            // 
            this.TabTransaksi.Controls.Add(this.btn_delete_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_update_transaksi);
            this.TabTransaksi.Controls.Add(this.lvt);
            this.TabTransaksi.Controls.Add(this.btn_tampil_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_tambah_transaksi);
            this.TabTransaksi.Location = new System.Drawing.Point(4, 22);
            this.TabTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.TabTransaksi.Name = "TabTransaksi";
            this.TabTransaksi.Padding = new System.Windows.Forms.Padding(2);
            this.TabTransaksi.Size = new System.Drawing.Size(1410, 578);
            this.TabTransaksi.TabIndex = 0;
            this.TabTransaksi.Text = "Transaksi";
            this.TabTransaksi.UseVisualStyleBackColor = true;
            // 
            // btn_delete_transaksi
            // 
            this.btn_delete_transaksi.Location = new System.Drawing.Point(462, 488);
            this.btn_delete_transaksi.Name = "btn_delete_transaksi";
            this.btn_delete_transaksi.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_transaksi.TabIndex = 1;
            this.btn_delete_transaksi.Text = "Delete";
            this.btn_delete_transaksi.UseVisualStyleBackColor = true;
            this.btn_delete_transaksi.Click += new System.EventHandler(this.btn_delete_transaksi_Click);
            // 
            // btn_update_transaksi
            // 
            this.btn_update_transaksi.Location = new System.Drawing.Point(354, 488);
            this.btn_update_transaksi.Name = "btn_update_transaksi";
            this.btn_update_transaksi.Size = new System.Drawing.Size(75, 23);
            this.btn_update_transaksi.TabIndex = 2;
            this.btn_update_transaksi.Text = "Update";
            this.btn_update_transaksi.UseVisualStyleBackColor = true;
            this.btn_update_transaksi.Click += new System.EventHandler(this.btn_update_transaksi_Click);
            // 
            // lvt
            // 
            this.lvt.HideSelection = false;
            this.lvt.Location = new System.Drawing.Point(0, 0);
            this.lvt.Margin = new System.Windows.Forms.Padding(2);
            this.lvt.Name = "lvt";
            this.lvt.Size = new System.Drawing.Size(1375, 454);
            this.lvt.TabIndex = 0;
            this.lvt.UseCompatibleStateImageBehavior = false;
            // 
            // btn_tampil_transaksi
            // 
            this.btn_tampil_transaksi.Location = new System.Drawing.Point(135, 488);
            this.btn_tampil_transaksi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tampil_transaksi.Name = "btn_tampil_transaksi";
            this.btn_tampil_transaksi.Size = new System.Drawing.Size(103, 19);
            this.btn_tampil_transaksi.TabIndex = 2;
            this.btn_tampil_transaksi.Text = "Tampil";
            this.btn_tampil_transaksi.UseVisualStyleBackColor = true;
            this.btn_tampil_transaksi.Click += new System.EventHandler(this.btn_tampil_transaksi_Click);
            // 
            // btn_tambah_transaksi
            // 
            this.btn_tambah_transaksi.Location = new System.Drawing.Point(14, 488);
            this.btn_tambah_transaksi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tambah_transaksi.Name = "btn_tambah_transaksi";
            this.btn_tambah_transaksi.Size = new System.Drawing.Size(99, 19);
            this.btn_tambah_transaksi.TabIndex = 1;
            this.btn_tambah_transaksi.Text = "Tambah";
            this.btn_tambah_transaksi.UseVisualStyleBackColor = true;
            this.btn_tambah_transaksi.Click += new System.EventHandler(this.btn_tambah_transaksi_Click);
            // 
            // TabProduk
            // 
            this.TabProduk.Controls.Add(this.btn_update_produk);
            this.TabProduk.Controls.Add(this.btn_delete_produk);
            this.TabProduk.Controls.Add(this.btn_tampil_produk);
            this.TabProduk.Controls.Add(this.btn_tambah_produk);
            this.TabProduk.Controls.Add(this.lvp);
            this.TabProduk.Location = new System.Drawing.Point(4, 22);
            this.TabProduk.Margin = new System.Windows.Forms.Padding(2);
            this.TabProduk.Name = "TabProduk";
            this.TabProduk.Padding = new System.Windows.Forms.Padding(2);
            this.TabProduk.Size = new System.Drawing.Size(1406, 578);
            this.TabProduk.TabIndex = 1;
            this.TabProduk.Text = "Produk";
            this.TabProduk.UseVisualStyleBackColor = true;
            // 
            // btn_update_produk
            // 
            this.btn_update_produk.Location = new System.Drawing.Point(272, 498);
            this.btn_update_produk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update_produk.Name = "btn_update_produk";
            this.btn_update_produk.Size = new System.Drawing.Size(56, 19);
            this.btn_update_produk.TabIndex = 4;
            this.btn_update_produk.Text = "Update";
            this.btn_update_produk.UseVisualStyleBackColor = true;
            this.btn_update_produk.Click += new System.EventHandler(this.btn_update_produk_Click);
            // 
            // btn_delete_produk
            // 
            this.btn_delete_produk.Location = new System.Drawing.Point(387, 498);
            this.btn_delete_produk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete_produk.Name = "btn_delete_produk";
            this.btn_delete_produk.Size = new System.Drawing.Size(56, 19);
            this.btn_delete_produk.TabIndex = 3;
            this.btn_delete_produk.Text = "Delete";
            this.btn_delete_produk.UseVisualStyleBackColor = true;
            this.btn_delete_produk.Click += new System.EventHandler(this.btn_delete_produk_Click);
            // 
            // btn_tampil_produk
            // 
            this.btn_tampil_produk.Location = new System.Drawing.Point(154, 498);
            this.btn_tampil_produk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tampil_produk.Name = "btn_tampil_produk";
            this.btn_tampil_produk.Size = new System.Drawing.Size(64, 19);
            this.btn_tampil_produk.TabIndex = 2;
            this.btn_tampil_produk.Text = "Tampil";
            this.btn_tampil_produk.UseVisualStyleBackColor = true;
            this.btn_tampil_produk.Click += new System.EventHandler(this.btn_tampil_produk_Click);
            // 
            // btn_tambah_produk
            // 
            this.btn_tambah_produk.Location = new System.Drawing.Point(51, 498);
            this.btn_tambah_produk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tambah_produk.Name = "btn_tambah_produk";
            this.btn_tambah_produk.Size = new System.Drawing.Size(56, 19);
            this.btn_tambah_produk.TabIndex = 1;
            this.btn_tambah_produk.Text = "Tambah";
            this.btn_tambah_produk.UseVisualStyleBackColor = true;
            this.btn_tambah_produk.Click += new System.EventHandler(this.btn_tambah_produk_Click);
            // 
            // lvp
            // 
            this.lvp.HideSelection = false;
            this.lvp.Location = new System.Drawing.Point(0, 0);
            this.lvp.Name = "lvp";
            this.lvp.Size = new System.Drawing.Size(1426, 464);
            this.lvp.TabIndex = 0;
            this.lvp.UseCompatibleStateImageBehavior = false;
            // 
            // TabGudang
            // 
            this.TabGudang.Controls.Add(this.btn_tambah_gudang);
            this.TabGudang.Controls.Add(this.btn_tampil_gudang);
            this.TabGudang.Controls.Add(this.btn_update_gudang);
            this.TabGudang.Controls.Add(this.btn_delete_gudang);
            this.TabGudang.Controls.Add(this.lvg);
            this.TabGudang.Location = new System.Drawing.Point(4, 22);
            this.TabGudang.Margin = new System.Windows.Forms.Padding(2);
            this.TabGudang.Name = "TabGudang";
            this.TabGudang.Size = new System.Drawing.Size(1406, 578);
            this.TabGudang.TabIndex = 2;
            this.TabGudang.Text = "Gudang";
            this.TabGudang.UseVisualStyleBackColor = true;
            // 
            // lvg
            // 
            this.lvg.HideSelection = false;
            this.lvg.Location = new System.Drawing.Point(-3, 0);
            this.lvg.Margin = new System.Windows.Forms.Padding(2);
            this.lvg.Name = "lvg";
            this.lvg.Size = new System.Drawing.Size(1432, 430);
            this.lvg.TabIndex = 0;
            this.lvg.UseCompatibleStateImageBehavior = false;
            // 
            // TabUser
            // 
            this.TabUser.Controls.Add(this.lvu);
            this.TabUser.Location = new System.Drawing.Point(4, 22);
            this.TabUser.Margin = new System.Windows.Forms.Padding(2);
            this.TabUser.Name = "TabUser";
            this.TabUser.Size = new System.Drawing.Size(1410, 578);
            this.TabUser.TabIndex = 3;
            this.TabUser.Text = "User";
            this.TabUser.UseVisualStyleBackColor = true;
            // 
            // lvu
            // 
            this.lvu.HideSelection = false;
            this.lvu.Location = new System.Drawing.Point(0, 0);
            this.lvu.Name = "lvu";
            this.lvu.Size = new System.Drawing.Size(1410, 473);
            this.lvu.TabIndex = 0;
            this.lvu.UseCompatibleStateImageBehavior = false;
            // 
            // user_nama
            // 
            this.user_nama.AutoSize = true;
            this.user_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_nama.Location = new System.Drawing.Point(1212, 27);
            this.user_nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user_nama.Name = "user_nama";
            this.user_nama.Size = new System.Drawing.Size(101, 20);
            this.user_nama.TabIndex = 0;
            this.user_nama.Text = "User_nama";
            // 
            // status_user
            // 
            this.status_user.AutoSize = true;
            this.status_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_user.Location = new System.Drawing.Point(1212, 49);
            this.status_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status_user.Name = "status_user";
            this.status_user.Size = new System.Drawing.Size(167, 24);
            this.status_user.TabIndex = 1;
            this.status_user.Text = "Status_Karyawan";
            // 
            // btn_delete_gudang
            // 
            this.btn_delete_gudang.Location = new System.Drawing.Point(424, 500);
            this.btn_delete_gudang.Name = "btn_delete_gudang";
            this.btn_delete_gudang.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_gudang.TabIndex = 1;
            this.btn_delete_gudang.Text = "Delete";
            this.btn_delete_gudang.UseVisualStyleBackColor = true;
            this.btn_delete_gudang.Click += new System.EventHandler(this.btn_delete_gudang_Click);
            // 
            // btn_update_gudang
            // 
            this.btn_update_gudang.Location = new System.Drawing.Point(297, 500);
            this.btn_update_gudang.Name = "btn_update_gudang";
            this.btn_update_gudang.Size = new System.Drawing.Size(75, 23);
            this.btn_update_gudang.TabIndex = 2;
            this.btn_update_gudang.Text = "Update";
            this.btn_update_gudang.UseVisualStyleBackColor = true;
            this.btn_update_gudang.Click += new System.EventHandler(this.btn_update_gudang_Click);
            // 
            // btn_tampil_gudang
            // 
            this.btn_tampil_gudang.Location = new System.Drawing.Point(171, 500);
            this.btn_tampil_gudang.Name = "btn_tampil_gudang";
            this.btn_tampil_gudang.Size = new System.Drawing.Size(75, 23);
            this.btn_tampil_gudang.TabIndex = 3;
            this.btn_tampil_gudang.Text = "Tampil";
            this.btn_tampil_gudang.UseVisualStyleBackColor = true;
            this.btn_tampil_gudang.Click += new System.EventHandler(this.btn_tampil_gudang_Click);
            // 
            // btn_tambah_gudang
            // 
            this.btn_tambah_gudang.Location = new System.Drawing.Point(41, 500);
            this.btn_tambah_gudang.Name = "btn_tambah_gudang";
            this.btn_tambah_gudang.Size = new System.Drawing.Size(75, 23);
            this.btn_tambah_gudang.TabIndex = 4;
            this.btn_tambah_gudang.Text = "Tambah";
            this.btn_tambah_gudang.UseVisualStyleBackColor = true;
            this.btn_tambah_gudang.Click += new System.EventHandler(this.btn_tambah_gudang_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 676);
            this.Controls.Add(this.status_user);
            this.Controls.Add(this.user_nama);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.TabTransaksi.ResumeLayout(false);
            this.TabProduk.ResumeLayout(false);
            this.TabGudang.ResumeLayout(false);
            this.TabUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabTransaksi;
        private System.Windows.Forms.TabPage TabProduk;
        private System.Windows.Forms.TabPage TabGudang;
        private System.Windows.Forms.ListView lvt;
        private System.Windows.Forms.Label user_nama;
        private System.Windows.Forms.Button btn_tampil_transaksi;
        private System.Windows.Forms.Button btn_tambah_transaksi;
        private System.Windows.Forms.Button btn_delete_transaksi;
        private System.Windows.Forms.Button btn_update_transaksi;
        private System.Windows.Forms.ListView lvp;
        private System.Windows.Forms.ListView lvg;
        private System.Windows.Forms.TabPage TabUser;
        private System.Windows.Forms.Button btn_update_produk;
        private System.Windows.Forms.Button btn_delete_produk;
        private System.Windows.Forms.Button btn_tampil_produk;
        private System.Windows.Forms.Button btn_tambah_produk;
        private System.Windows.Forms.Label status_user;
        private System.Windows.Forms.ListView lvu;
        private System.Windows.Forms.Button btn_tambah_gudang;
        private System.Windows.Forms.Button btn_tampil_gudang;
        private System.Windows.Forms.Button btn_update_gudang;
        private System.Windows.Forms.Button btn_delete_gudang;
    }
}