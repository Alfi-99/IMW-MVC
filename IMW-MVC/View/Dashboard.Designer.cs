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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabTransaksi = new System.Windows.Forms.TabPage();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search_transaksi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete_transaksi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update_transaksi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tampil_transaksi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tambah_transaksi = new Guna.UI2.WinForms.Guna2Button();
            this.lvt = new System.Windows.Forms.ListView();
            this.TabProduk = new System.Windows.Forms.TabPage();
            this.btn_delete_produk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update_produk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tampil_produk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tambah_produk = new Guna.UI2.WinForms.Guna2Button();
            this.lvp = new System.Windows.Forms.ListView();
            this.TabGudang = new System.Windows.Forms.TabPage();
            this.btn_delete_gudang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update_gudang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tampil_gudang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tambah_gudang = new Guna.UI2.WinForms.Guna2Button();
            this.lvg = new System.Windows.Forms.ListView();
            this.TabUser = new System.Windows.Forms.TabPage();
            this.btn_delete_user = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update_user = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tampil_user = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tambah_user = new Guna.UI2.WinForms.Guna2Button();
            this.lvu = new System.Windows.Forms.ListView();
            this.user_nama = new System.Windows.Forms.Label();
            this.status_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_search_transaksi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 91);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1922, 717);
            this.tabControl1.TabIndex = 0;
            // 
            // TabTransaksi
            // 
            this.TabTransaksi.Controls.Add(this.input_search_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_logout);
            this.TabTransaksi.Controls.Add(this.btn_search_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_delete_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_update_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_tampil_transaksi);
            this.TabTransaksi.Controls.Add(this.btn_tambah_transaksi);
            this.TabTransaksi.Controls.Add(this.lvt);
            this.TabTransaksi.Location = new System.Drawing.Point(4, 25);
            this.TabTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabTransaksi.Name = "TabTransaksi";
            this.TabTransaksi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabTransaksi.Size = new System.Drawing.Size(1914, 688);
            this.TabTransaksi.TabIndex = 0;
            this.TabTransaksi.Text = "Transaksi";
            this.TabTransaksi.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.BorderRadius = 15;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.White;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_logout.Location = new System.Drawing.Point(1749, 602);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(100, 34);
            this.btn_logout.TabIndex = 39;
            this.btn_logout.Text = "Logout";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_search_transaksi
            // 
            this.btn_search_transaksi.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_transaksi.BorderRadius = 15;
            this.btn_search_transaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search_transaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search_transaksi.FillColor = System.Drawing.Color.White;
            this.btn_search_transaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_search_transaksi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_search_transaksi.Location = new System.Drawing.Point(1095, 602);
            this.btn_search_transaksi.Name = "btn_search_transaksi";
            this.btn_search_transaksi.Size = new System.Drawing.Size(123, 34);
            this.btn_search_transaksi.TabIndex = 38;
            this.btn_search_transaksi.Text = "Search";
            this.btn_search_transaksi.Click += new System.EventHandler(this.btn_search_transaksi_Click);
            // 
            // btn_delete_transaksi
            // 
            this.btn_delete_transaksi.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_transaksi.BorderRadius = 15;
            this.btn_delete_transaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_transaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_transaksi.FillColor = System.Drawing.Color.White;
            this.btn_delete_transaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_delete_transaksi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete_transaksi.Location = new System.Drawing.Point(614, 602);
            this.btn_delete_transaksi.Name = "btn_delete_transaksi";
            this.btn_delete_transaksi.Size = new System.Drawing.Size(123, 34);
            this.btn_delete_transaksi.TabIndex = 35;
            this.btn_delete_transaksi.Text = "Delete";
            this.btn_delete_transaksi.Click += new System.EventHandler(this.btn_delete_transaksi_Click);
            // 
            // btn_update_transaksi
            // 
            this.btn_update_transaksi.BackColor = System.Drawing.Color.Transparent;
            this.btn_update_transaksi.BorderRadius = 15;
            this.btn_update_transaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_transaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_transaksi.FillColor = System.Drawing.Color.White;
            this.btn_update_transaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_update_transaksi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_update_transaksi.Location = new System.Drawing.Point(458, 602);
            this.btn_update_transaksi.Name = "btn_update_transaksi";
            this.btn_update_transaksi.Size = new System.Drawing.Size(123, 34);
            this.btn_update_transaksi.TabIndex = 34;
            this.btn_update_transaksi.Text = "Update";
            this.btn_update_transaksi.Click += new System.EventHandler(this.btn_update_transaksi_Click);
            // 
            // btn_tampil_transaksi
            // 
            this.btn_tampil_transaksi.BackColor = System.Drawing.Color.Transparent;
            this.btn_tampil_transaksi.BorderRadius = 15;
            this.btn_tampil_transaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tampil_transaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tampil_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tampil_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tampil_transaksi.FillColor = System.Drawing.Color.White;
            this.btn_tampil_transaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tampil_transaksi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tampil_transaksi.Location = new System.Drawing.Point(212, 602);
            this.btn_tampil_transaksi.Name = "btn_tampil_transaksi";
            this.btn_tampil_transaksi.Size = new System.Drawing.Size(123, 34);
            this.btn_tampil_transaksi.TabIndex = 33;
            this.btn_tampil_transaksi.Text = "Tampil";
            this.btn_tampil_transaksi.Click += new System.EventHandler(this.btn_tampil_transaksi_Click);
            // 
            // btn_tambah_transaksi
            // 
            this.btn_tambah_transaksi.BackColor = System.Drawing.Color.Transparent;
            this.btn_tambah_transaksi.BorderRadius = 15;
            this.btn_tambah_transaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_transaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tambah_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tambah_transaksi.FillColor = System.Drawing.Color.White;
            this.btn_tambah_transaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tambah_transaksi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tambah_transaksi.Location = new System.Drawing.Point(56, 602);
            this.btn_tambah_transaksi.Name = "btn_tambah_transaksi";
            this.btn_tambah_transaksi.Size = new System.Drawing.Size(123, 34);
            this.btn_tambah_transaksi.TabIndex = 32;
            this.btn_tambah_transaksi.Text = "Tambah";
            this.btn_tambah_transaksi.Click += new System.EventHandler(this.btn_tambah_transaksi_Click);
            // 
            // lvt
            // 
            this.lvt.HideSelection = false;
            this.lvt.Location = new System.Drawing.Point(0, 0);
            this.lvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvt.Name = "lvt";
            this.lvt.Size = new System.Drawing.Size(1900, 570);
            this.lvt.TabIndex = 0;
            this.lvt.UseCompatibleStateImageBehavior = false;
            // 
            // TabProduk
            // 
            this.TabProduk.Controls.Add(this.guna2Button1);
            this.TabProduk.Controls.Add(this.btn_delete_produk);
            this.TabProduk.Controls.Add(this.btn_update_produk);
            this.TabProduk.Controls.Add(this.btn_tampil_produk);
            this.TabProduk.Controls.Add(this.btn_tambah_produk);
            this.TabProduk.Controls.Add(this.lvp);
            this.TabProduk.Location = new System.Drawing.Point(4, 25);
            this.TabProduk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabProduk.Name = "TabProduk";
            this.TabProduk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabProduk.Size = new System.Drawing.Size(1914, 688);
            this.TabProduk.TabIndex = 1;
            this.TabProduk.Text = "Produk";
            this.TabProduk.UseVisualStyleBackColor = true;
            // 
            // btn_delete_produk
            // 
            this.btn_delete_produk.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_produk.BorderRadius = 15;
            this.btn_delete_produk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_produk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_produk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_produk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_produk.FillColor = System.Drawing.Color.White;
            this.btn_delete_produk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_delete_produk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete_produk.Location = new System.Drawing.Point(614, 602);
            this.btn_delete_produk.Name = "btn_delete_produk";
            this.btn_delete_produk.Size = new System.Drawing.Size(123, 34);
            this.btn_delete_produk.TabIndex = 36;
            this.btn_delete_produk.Text = "Delete";
            this.btn_delete_produk.Click += new System.EventHandler(this.btn_delete_produk_Click);
            // 
            // btn_update_produk
            // 
            this.btn_update_produk.BackColor = System.Drawing.Color.Transparent;
            this.btn_update_produk.BorderRadius = 15;
            this.btn_update_produk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_produk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_produk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_produk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_produk.FillColor = System.Drawing.Color.White;
            this.btn_update_produk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_update_produk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_update_produk.Location = new System.Drawing.Point(456, 602);
            this.btn_update_produk.Name = "btn_update_produk";
            this.btn_update_produk.Size = new System.Drawing.Size(123, 34);
            this.btn_update_produk.TabIndex = 35;
            this.btn_update_produk.Text = "Update";
            this.btn_update_produk.Click += new System.EventHandler(this.btn_update_produk_Click);
            // 
            // btn_tampil_produk
            // 
            this.btn_tampil_produk.BackColor = System.Drawing.Color.Transparent;
            this.btn_tampil_produk.BorderRadius = 15;
            this.btn_tampil_produk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tampil_produk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tampil_produk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tampil_produk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tampil_produk.FillColor = System.Drawing.Color.White;
            this.btn_tampil_produk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tampil_produk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tampil_produk.Location = new System.Drawing.Point(214, 602);
            this.btn_tampil_produk.Name = "btn_tampil_produk";
            this.btn_tampil_produk.Size = new System.Drawing.Size(123, 34);
            this.btn_tampil_produk.TabIndex = 34;
            this.btn_tampil_produk.Text = "Tampil";
            this.btn_tampil_produk.Click += new System.EventHandler(this.btn_tampil_produk_Click);
            // 
            // btn_tambah_produk
            // 
            this.btn_tambah_produk.BackColor = System.Drawing.Color.Transparent;
            this.btn_tambah_produk.BorderRadius = 15;
            this.btn_tambah_produk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_produk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_produk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tambah_produk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tambah_produk.FillColor = System.Drawing.Color.White;
            this.btn_tambah_produk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tambah_produk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tambah_produk.Location = new System.Drawing.Point(56, 602);
            this.btn_tambah_produk.Name = "btn_tambah_produk";
            this.btn_tambah_produk.Size = new System.Drawing.Size(123, 34);
            this.btn_tambah_produk.TabIndex = 33;
            this.btn_tambah_produk.Text = "Tambah";
            this.btn_tambah_produk.Click += new System.EventHandler(this.btn_tambah_produk_Click);
            // 
            // lvp
            // 
            this.lvp.HideSelection = false;
            this.lvp.Location = new System.Drawing.Point(0, 0);
            this.lvp.Margin = new System.Windows.Forms.Padding(4);
            this.lvp.Name = "lvp";
            this.lvp.Size = new System.Drawing.Size(1900, 570);
            this.lvp.TabIndex = 0;
            this.lvp.UseCompatibleStateImageBehavior = false;
            // 
            // TabGudang
            // 
            this.TabGudang.Controls.Add(this.guna2Button2);
            this.TabGudang.Controls.Add(this.btn_delete_gudang);
            this.TabGudang.Controls.Add(this.btn_update_gudang);
            this.TabGudang.Controls.Add(this.btn_tampil_gudang);
            this.TabGudang.Controls.Add(this.btn_tambah_gudang);
            this.TabGudang.Controls.Add(this.lvg);
            this.TabGudang.Location = new System.Drawing.Point(4, 25);
            this.TabGudang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabGudang.Name = "TabGudang";
            this.TabGudang.Size = new System.Drawing.Size(1914, 688);
            this.TabGudang.TabIndex = 2;
            this.TabGudang.Text = "Gudang";
            this.TabGudang.UseVisualStyleBackColor = true;
            // 
            // btn_delete_gudang
            // 
            this.btn_delete_gudang.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_gudang.BorderRadius = 15;
            this.btn_delete_gudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_gudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_gudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_gudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_gudang.FillColor = System.Drawing.Color.White;
            this.btn_delete_gudang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_delete_gudang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete_gudang.Location = new System.Drawing.Point(615, 610);
            this.btn_delete_gudang.Name = "btn_delete_gudang";
            this.btn_delete_gudang.Size = new System.Drawing.Size(123, 34);
            this.btn_delete_gudang.TabIndex = 40;
            this.btn_delete_gudang.Text = "Delete";
            this.btn_delete_gudang.Click += new System.EventHandler(this.btn_delete_gudang_Click);
            // 
            // btn_update_gudang
            // 
            this.btn_update_gudang.BackColor = System.Drawing.Color.Transparent;
            this.btn_update_gudang.BorderRadius = 15;
            this.btn_update_gudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_gudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_gudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_gudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_gudang.FillColor = System.Drawing.Color.White;
            this.btn_update_gudang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_update_gudang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_update_gudang.Location = new System.Drawing.Point(457, 610);
            this.btn_update_gudang.Name = "btn_update_gudang";
            this.btn_update_gudang.Size = new System.Drawing.Size(123, 34);
            this.btn_update_gudang.TabIndex = 39;
            this.btn_update_gudang.Text = "Update";
            this.btn_update_gudang.Click += new System.EventHandler(this.btn_update_gudang_Click);
            // 
            // btn_tampil_gudang
            // 
            this.btn_tampil_gudang.BackColor = System.Drawing.Color.Transparent;
            this.btn_tampil_gudang.BorderRadius = 15;
            this.btn_tampil_gudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tampil_gudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tampil_gudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tampil_gudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tampil_gudang.FillColor = System.Drawing.Color.White;
            this.btn_tampil_gudang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tampil_gudang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tampil_gudang.Location = new System.Drawing.Point(215, 610);
            this.btn_tampil_gudang.Name = "btn_tampil_gudang";
            this.btn_tampil_gudang.Size = new System.Drawing.Size(123, 34);
            this.btn_tampil_gudang.TabIndex = 38;
            this.btn_tampil_gudang.Text = "Tampil";
            this.btn_tampil_gudang.Click += new System.EventHandler(this.btn_tampil_gudang_Click);
            // 
            // btn_tambah_gudang
            // 
            this.btn_tambah_gudang.BackColor = System.Drawing.Color.Transparent;
            this.btn_tambah_gudang.BorderRadius = 15;
            this.btn_tambah_gudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_gudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_gudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tambah_gudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tambah_gudang.FillColor = System.Drawing.Color.White;
            this.btn_tambah_gudang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tambah_gudang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tambah_gudang.Location = new System.Drawing.Point(57, 610);
            this.btn_tambah_gudang.Name = "btn_tambah_gudang";
            this.btn_tambah_gudang.Size = new System.Drawing.Size(123, 34);
            this.btn_tambah_gudang.TabIndex = 37;
            this.btn_tambah_gudang.Text = "Tambah";
            this.btn_tambah_gudang.Click += new System.EventHandler(this.btn_tambah_gudang_Click);
            // 
            // lvg
            // 
            this.lvg.HideSelection = false;
            this.lvg.Location = new System.Drawing.Point(-4, 0);
            this.lvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvg.Name = "lvg";
            this.lvg.Size = new System.Drawing.Size(1900, 570);
            this.lvg.TabIndex = 0;
            this.lvg.UseCompatibleStateImageBehavior = false;
            // 
            // TabUser
            // 
            this.TabUser.Controls.Add(this.guna2Button3);
            this.TabUser.Controls.Add(this.btn_delete_user);
            this.TabUser.Controls.Add(this.btn_update_user);
            this.TabUser.Controls.Add(this.btn_tampil_user);
            this.TabUser.Controls.Add(this.btn_tambah_user);
            this.TabUser.Controls.Add(this.lvu);
            this.TabUser.Location = new System.Drawing.Point(4, 25);
            this.TabUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabUser.Name = "TabUser";
            this.TabUser.Size = new System.Drawing.Size(1914, 688);
            this.TabUser.TabIndex = 3;
            this.TabUser.Text = "User";
            this.TabUser.UseVisualStyleBackColor = true;
            // 
            // btn_delete_user
            // 
            this.btn_delete_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_user.BorderRadius = 15;
            this.btn_delete_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_user.FillColor = System.Drawing.Color.White;
            this.btn_delete_user.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_delete_user.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete_user.Location = new System.Drawing.Point(621, 608);
            this.btn_delete_user.Name = "btn_delete_user";
            this.btn_delete_user.Size = new System.Drawing.Size(123, 34);
            this.btn_delete_user.TabIndex = 44;
            this.btn_delete_user.Text = "Delete";
            this.btn_delete_user.Click += new System.EventHandler(this.btn_delete_user_Click);
            // 
            // btn_update_user
            // 
            this.btn_update_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_update_user.BorderRadius = 15;
            this.btn_update_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_user.FillColor = System.Drawing.Color.White;
            this.btn_update_user.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_update_user.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_update_user.Location = new System.Drawing.Point(463, 608);
            this.btn_update_user.Name = "btn_update_user";
            this.btn_update_user.Size = new System.Drawing.Size(123, 34);
            this.btn_update_user.TabIndex = 43;
            this.btn_update_user.Text = "Update";
            this.btn_update_user.Click += new System.EventHandler(this.btn_update_user_Click);
            // 
            // btn_tampil_user
            // 
            this.btn_tampil_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_tampil_user.BorderRadius = 15;
            this.btn_tampil_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tampil_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tampil_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tampil_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tampil_user.FillColor = System.Drawing.Color.White;
            this.btn_tampil_user.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tampil_user.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tampil_user.Location = new System.Drawing.Point(221, 608);
            this.btn_tampil_user.Name = "btn_tampil_user";
            this.btn_tampil_user.Size = new System.Drawing.Size(123, 34);
            this.btn_tampil_user.TabIndex = 42;
            this.btn_tampil_user.Text = "Tampil";
            this.btn_tampil_user.Click += new System.EventHandler(this.btn_tampil_user_Click);
            // 
            // btn_tambah_user
            // 
            this.btn_tambah_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_tambah_user.BorderRadius = 15;
            this.btn_tambah_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tambah_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tambah_user.FillColor = System.Drawing.Color.White;
            this.btn_tambah_user.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tambah_user.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tambah_user.Location = new System.Drawing.Point(63, 608);
            this.btn_tambah_user.Name = "btn_tambah_user";
            this.btn_tambah_user.Size = new System.Drawing.Size(123, 34);
            this.btn_tambah_user.TabIndex = 41;
            this.btn_tambah_user.Text = "Tambah";
            this.btn_tambah_user.Click += new System.EventHandler(this.btn_tambah_user_Click);
            // 
            // lvu
            // 
            this.lvu.HideSelection = false;
            this.lvu.Location = new System.Drawing.Point(0, 0);
            this.lvu.Margin = new System.Windows.Forms.Padding(4);
            this.lvu.Name = "lvu";
            this.lvu.Size = new System.Drawing.Size(1900, 570);
            this.lvu.TabIndex = 0;
            this.lvu.UseCompatibleStateImageBehavior = false;
            // 
            // user_nama
            // 
            this.user_nama.AutoSize = true;
            this.user_nama.BackColor = System.Drawing.Color.Transparent;
            this.user_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_nama.ForeColor = System.Drawing.Color.White;
            this.user_nama.Location = new System.Drawing.Point(1616, 33);
            this.user_nama.Name = "user_nama";
            this.user_nama.Size = new System.Drawing.Size(122, 25);
            this.user_nama.TabIndex = 0;
            this.user_nama.Text = "User_nama";
            // 
            // status_user
            // 
            this.status_user.AutoSize = true;
            this.status_user.BackColor = System.Drawing.Color.Transparent;
            this.status_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_user.ForeColor = System.Drawing.Color.White;
            this.status_user.Location = new System.Drawing.Point(1616, 60);
            this.status_user.Name = "status_user";
            this.status_user.Size = new System.Drawing.Size(212, 29);
            this.status_user.TabIndex = 1;
            this.status_user.Text = "Status_Karyawan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 54);
            this.label1.TabIndex = 37;
            this.label1.Text = "WAREHOUSE SYSTEM MANAGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input_search_transaksi
            // 
            this.input_search_transaksi.BorderRadius = 15;
            this.input_search_transaksi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_search_transaksi.DefaultText = "";
            this.input_search_transaksi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.input_search_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.input_search_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.input_search_transaksi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.input_search_transaksi.FillColor = System.Drawing.Color.Gainsboro;
            this.input_search_transaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input_search_transaksi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.input_search_transaksi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_search_transaksi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input_search_transaksi.IconLeft = ((System.Drawing.Image)(resources.GetObject("input_search_transaksi.IconLeft")));
            this.input_search_transaksi.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.input_search_transaksi.Location = new System.Drawing.Point(805, 602);
            this.input_search_transaksi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_search_transaksi.Name = "input_search_transaksi";
            this.input_search_transaksi.PasswordChar = '\0';
            this.input_search_transaksi.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.input_search_transaksi.PlaceholderText = "Username";
            this.input_search_transaksi.SelectedText = "";
            this.input_search_transaksi.Size = new System.Drawing.Size(250, 34);
            this.input_search_transaksi.TabIndex = 40;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button1.Location = new System.Drawing.Point(1751, 602);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(100, 34);
            this.guna2Button1.TabIndex = 40;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button2.Location = new System.Drawing.Point(1767, 610);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(100, 34);
            this.guna2Button2.TabIndex = 41;
            this.guna2Button2.Text = "Logout";
            this.guna2Button2.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button3.Location = new System.Drawing.Point(1766, 608);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(100, 34);
            this.guna2Button3.TabIndex = 45;
            this.guna2Button3.Text = "Logout";
            this.guna2Button3.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1911, 895);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status_user);
            this.Controls.Add(this.user_nama);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ListView lvp;
        private System.Windows.Forms.ListView lvg;
        private System.Windows.Forms.TabPage TabUser;
        private System.Windows.Forms.Label status_user;
        private System.Windows.Forms.ListView lvu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_search_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_delete_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_update_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_tampil_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_tambah_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_delete_produk;
        private Guna.UI2.WinForms.Guna2Button btn_update_produk;
        private Guna.UI2.WinForms.Guna2Button btn_tampil_produk;
        private Guna.UI2.WinForms.Guna2Button btn_tambah_produk;
        private Guna.UI2.WinForms.Guna2Button btn_delete_gudang;
        private Guna.UI2.WinForms.Guna2Button btn_update_gudang;
        private Guna.UI2.WinForms.Guna2Button btn_tampil_gudang;
        private Guna.UI2.WinForms.Guna2Button btn_tambah_gudang;
        private Guna.UI2.WinForms.Guna2Button btn_delete_user;
        private Guna.UI2.WinForms.Guna2Button btn_update_user;
        private Guna.UI2.WinForms.Guna2Button btn_tampil_user;
        private Guna.UI2.WinForms.Guna2Button btn_tambah_user;
        private Guna.UI2.WinForms.Guna2TextBox input_search_transaksi;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}