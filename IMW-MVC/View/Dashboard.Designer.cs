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
            this.btn_tampil_transaksi = new System.Windows.Forms.Button();
            this.btn_tambah_transaksi = new System.Windows.Forms.Button();
            this.lvt = new System.Windows.Forms.ListView();
            this.TabProduk = new System.Windows.Forms.TabPage();
            this.lvp = new System.Windows.Forms.ListView();
            this.TabGudang = new System.Windows.Forms.TabPage();
            this.user_nama = new System.Windows.Forms.Label();
            this.lvg = new System.Windows.Forms.ListView();
            this.TabUser = new System.Windows.Forms.TabPage();
            this.btn_tambah_produk = new System.Windows.Forms.Button();
            this.btn_tampil_produk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.status_user = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabTransaksi.SuspendLayout();
            this.TabProduk.SuspendLayout();
            this.TabGudang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabTransaksi);
            this.tabControl1.Controls.Add(this.TabProduk);
            this.tabControl1.Controls.Add(this.TabGudang);
            this.tabControl1.Controls.Add(this.TabUser);
            this.tabControl1.Location = new System.Drawing.Point(39, 91);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1891, 743);
            this.tabControl1.TabIndex = 0;
            // 
            // TabTransaksi
            // 
            this.TabTransaksi.Controls.Add(this.btn_delete_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_update_transaksi);
            this.TabTransaksi.Controls.Add(this.lvt);
            this.TabTransaksi.Controls.Add(this.btn_tampil_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_tambah_transaksi);
            this.TabTransaksi.Location = new System.Drawing.Point(4, 25);
            this.TabTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabTransaksi.Name = "TabTransaksi";
            this.TabTransaksi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabTransaksi.Size = new System.Drawing.Size(1883, 714);
            this.TabTransaksi.TabIndex = 0;
            this.TabTransaksi.Text = "Transaksi";
            this.TabTransaksi.UseVisualStyleBackColor = true;
            // 
            // btn_delete_transaksi
            // 
            this.btn_delete_transaksi.Location = new System.Drawing.Point(616, 601);
            this.btn_delete_transaksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete_transaksi.Name = "btn_delete_transaksi";
            this.btn_delete_transaksi.Size = new System.Drawing.Size(100, 28);
            this.btn_delete_transaksi.TabIndex = 1;
            this.btn_delete_transaksi.Text = "Delete";
            this.btn_delete_transaksi.UseVisualStyleBackColor = true;
            // 
            // btn_update_transaksi
            // 
            this.btn_update_transaksi.Location = new System.Drawing.Point(472, 601);
            this.btn_update_transaksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update_transaksi.Name = "btn_update_transaksi";
            this.btn_update_transaksi.Size = new System.Drawing.Size(100, 28);
            this.btn_update_transaksi.TabIndex = 2;
            this.btn_update_transaksi.Text = "Update";
            this.btn_update_transaksi.UseVisualStyleBackColor = true;
            // 
            // btn_tampil_transaksi
            // 
            this.btn_tampil_transaksi.Location = new System.Drawing.Point(180, 601);
            this.btn_tampil_transaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tampil_transaksi.Name = "btn_tampil_transaksi";
            this.btn_tampil_transaksi.Size = new System.Drawing.Size(137, 23);
            this.btn_tampil_transaksi.TabIndex = 2;
            this.btn_tampil_transaksi.Text = "Tampil";
            this.btn_tampil_transaksi.UseVisualStyleBackColor = true;
            this.btn_tampil_transaksi.Click += new System.EventHandler(this.btn_tampil_transaksi_Click);
            // 
            // btn_tambah_transaksi
            // 
            this.btn_tambah_transaksi.Location = new System.Drawing.Point(19, 601);
            this.btn_tambah_transaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tambah_transaksi.Name = "btn_tambah_transaksi";
            this.btn_tambah_transaksi.Size = new System.Drawing.Size(132, 23);
            this.btn_tambah_transaksi.TabIndex = 1;
            this.btn_tambah_transaksi.Text = "Tambah";
            this.btn_tambah_transaksi.UseVisualStyleBackColor = true;
            this.btn_tambah_transaksi.Click += new System.EventHandler(this.btn_tambah_transaksi_Click);
            // 
            // lvt
            // 
            this.lvt.HideSelection = false;
            this.lvt.Location = new System.Drawing.Point(0, 0);
            this.lvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvt.Name = "lvt";
            this.lvt.Size = new System.Drawing.Size(1832, 558);
            this.lvt.TabIndex = 0;
            this.lvt.UseCompatibleStateImageBehavior = false;
            // 
            // TabProduk
            // 
            this.TabProduk.Controls.Add(this.button2);
            this.TabProduk.Controls.Add(this.button1);
            this.TabProduk.Controls.Add(this.btn_tampil_produk);
            this.TabProduk.Controls.Add(this.btn_tambah_produk);
            this.TabProduk.Controls.Add(this.lvp);
            this.TabProduk.Location = new System.Drawing.Point(4, 25);
            this.TabProduk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabProduk.Name = "TabProduk";
            this.TabProduk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabProduk.Size = new System.Drawing.Size(1883, 714);
            this.TabProduk.TabIndex = 1;
            this.TabProduk.Text = "Produk";
            this.TabProduk.UseVisualStyleBackColor = true;
            // 
            // lvp
            // 
            this.lvp.HideSelection = false;
            this.lvp.Location = new System.Drawing.Point(0, 0);
            this.lvp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvp.Name = "lvp";
            this.lvp.Size = new System.Drawing.Size(1900, 570);
            this.lvp.TabIndex = 0;
            this.lvp.UseCompatibleStateImageBehavior = false;
            // 
            // TabGudang
            // 
            this.TabGudang.Controls.Add(this.lvg);
            this.TabGudang.Location = new System.Drawing.Point(4, 25);
            this.TabGudang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabGudang.Name = "TabGudang";
            this.TabGudang.Size = new System.Drawing.Size(1883, 714);
            this.TabGudang.TabIndex = 2;
            this.TabGudang.Text = "Gudang";
            this.TabGudang.UseVisualStyleBackColor = true;
            // 
            // user_nama
            // 
            this.user_nama.AutoSize = true;
            this.user_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_nama.Location = new System.Drawing.Point(1616, 33);
            this.user_nama.Name = "user_nama";
            this.user_nama.Size = new System.Drawing.Size(122, 25);
            this.user_nama.TabIndex = 0;
            this.user_nama.Text = "User_nama";
            // 
            // lvg
            // 
            this.lvg.HideSelection = false;
            this.lvg.Location = new System.Drawing.Point(-4, 0);
            this.lvg.Name = "lvg";
            this.lvg.Size = new System.Drawing.Size(1908, 528);
            this.lvg.TabIndex = 0;
            this.lvg.UseCompatibleStateImageBehavior = false;
            // 
            // TabUser
            // 
            this.TabUser.Location = new System.Drawing.Point(4, 25);
            this.TabUser.Name = "TabUser";
            this.TabUser.Size = new System.Drawing.Size(1883, 714);
            this.TabUser.TabIndex = 3;
            this.TabUser.Text = "User";
            this.TabUser.UseVisualStyleBackColor = true;
            // 
            // btn_tambah_produk
            // 
            this.btn_tambah_produk.Location = new System.Drawing.Point(190, 613);
            this.btn_tambah_produk.Name = "btn_tambah_produk";
            this.btn_tambah_produk.Size = new System.Drawing.Size(75, 23);
            this.btn_tambah_produk.TabIndex = 1;
            this.btn_tambah_produk.Text = "Tambah";
            this.btn_tambah_produk.UseVisualStyleBackColor = true;
            // 
            // btn_tampil_produk
            // 
            this.btn_tampil_produk.Location = new System.Drawing.Point(64, 613);
            this.btn_tampil_produk.Name = "btn_tampil_produk";
            this.btn_tampil_produk.Size = new System.Drawing.Size(75, 23);
            this.btn_tampil_produk.TabIndex = 2;
            this.btn_tampil_produk.Text = "Tampil";
            this.btn_tampil_produk.UseVisualStyleBackColor = true;
            this.btn_tampil_produk.Click += new System.EventHandler(this.btn_tampil_produk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 613);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // status_user
            // 
            this.status_user.AutoSize = true;
            this.status_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_user.Location = new System.Drawing.Point(1616, 60);
            this.status_user.Name = "status_user";
            this.status_user.Size = new System.Drawing.Size(212, 29);
            this.status_user.TabIndex = 1;
            this.status_user.Text = "Status_Karyawan";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 832);
            this.Controls.Add(this.status_user);
            this.Controls.Add(this.user_nama);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.TabTransaksi.ResumeLayout(false);
            this.TabProduk.ResumeLayout(false);
            this.TabGudang.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_tampil_produk;
        private System.Windows.Forms.Button btn_tambah_produk;
        private System.Windows.Forms.Label status_user;
    }
}