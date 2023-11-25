using IMW_MVC.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IMW_MVC.Controller;

namespace IMW_MVC.View
{
    public partial class Dashboard : Form
    {
        public static string nama_pengguna = Login.nama_pengguna;
        private List<Transaksi> listTransaksi = new List<Transaksi>();
        private TransaksiController controller;
        private List<Produk> listProduk = new List<Produk>();
        private ProdukController controller_produk;
        private List<Gudang> listGudang = new List<Gudang>();
        private GudangController controller_gudang;
        private List<Pengguna> listPengguna = new List<Pengguna>();
        private PenggunaController controller_pengguna;

        public Dashboard()
        {
            InitializeComponent();
            user_nama.Text = Login.nama_pengguna;
            controller_pengguna = new PenggunaController();
            user();
            InisialisasiTransaksi();
            InisialisasiProduk();
            InisialisasiGudang();
            controller = new TransaksiController();
            controller_produk = new ProdukController();
            controller_gudang = new GudangController();
            LoadDataTransaksi();
            LoadDataProduk();
            LoadDataGudang();
        }
        //Checking Status User
        private void user()
        {
            listPengguna = controller_pengguna.ReadUserByName(user_nama.Text.ToString());
            foreach(var user in listPengguna)
            {
                status_user.Text = user.status;
                if (user.status == "User")
                {
                    tabControl1.TabPages.Remove(TabProduk);
                    tabControl1.TabPages.Remove(TabGudang);
                    tabControl1.TabPages.Remove(TabUser);
                }
            }
        }
        //Tab Transaksi
        private void InisialisasiTransaksi()
        {
            lvt.View = System.Windows.Forms.View.Details;
            lvt.FullRowSelect = true;
            lvt.GridLines = true;

            lvt.Columns.Add("No", 50, HorizontalAlignment.Left);
            lvt.Columns.Add("Nama Barang", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Tanggal Masuk", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Deskripsi", 290, HorizontalAlignment.Left);
            lvt.Columns.Add("Jumlah Barang", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Harga Barang", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Gudang", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Alamat", 210, HorizontalAlignment.Left);
            lvt.Columns.Add("User", 150, HorizontalAlignment.Left);
        }
        private void LoadDataTransaksi()
        {
            lvt.Items.Clear();
            listTransaksi = controller.ReadAll();
            if (listTransaksi != null)
            {
                MessageBox.Show("Hore");
            }
            else
            {
                MessageBox.Show("Kosong");
            }
            foreach(var trs in listTransaksi) 
            {
                var noUrut = lvt.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trs.Nama_barang);
                item.SubItems.Add(trs.Tanggal_Masuk);
                item.SubItems.Add(trs.Deskripsi);
                item.SubItems.Add(trs.jumlah_barang.ToString());
                item.SubItems.Add(trs.harga_barang.ToString());
                item.SubItems.Add(trs.Gudang);
                item.SubItems.Add(trs.Alamat);
                item.SubItems.Add(trs.User);
                lvt.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Transaksi transaksi)
        {
            lvt.Items.Clear();
            listTransaksi = controller.ReadAll();
            foreach (var trs in listTransaksi)
            {
                var noUrut = lvt.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trs.Nama_barang);
                item.SubItems.Add(trs.Tanggal_Masuk);
                item.SubItems.Add(trs.Deskripsi);
                item.SubItems.Add(trs.jumlah_barang.ToString());
                item.SubItems.Add(trs.harga_barang.ToString());
                item.SubItems.Add(trs.Gudang);
                item.SubItems.Add(trs.Alamat);
                item.SubItems.Add(trs.User);
                lvt.Items.Add(item);
            }
        }
        private void btn_tambah_transaksi_Click(object sender, EventArgs e)
        {
            AddTransaksi addTransaksi = new AddTransaksi("Tambah Data Transaksi", controller);
            addTransaksi.ShowDialog();
        }

        private void btn_tampil_transaksi_Click(object sender, EventArgs e)
        {
            LoadDataTransaksi();
        }
        //End Tab Transaksi
        //Tab Produk
        private void InisialisasiProduk()
        {
            lvp.View = System.Windows.Forms.View.Details;
            lvp.FullRowSelect = true;
            lvp.GridLines = true;

            lvp.Columns.Add("No", 50, HorizontalAlignment.Left);
            lvp.Columns.Add("Nama Barang", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Tanggal Masuk", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Tanggal Keluar", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Deskripsi", 280, HorizontalAlignment.Left);
            lvp.Columns.Add("Harga Barang", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Jumlah Barang", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Status", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Alamat", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Kapasitas", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Gudang", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Admin", 150, HorizontalAlignment.Left);
        }
        private void LoadDataProduk()
        {
            lvp.Items.Clear();
            listProduk = controller_produk.ReadAll();
            foreach (var trs in listProduk)
            {
                var noUrut = lvp.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trs.Nama_Barang);
                item.SubItems.Add(trs.Tanggal_Masuk);
                item.SubItems.Add(trs.Tanggal_Keluar);
                item.SubItems.Add(trs.Deskripsi);
                item.SubItems.Add(trs.Harga.ToString());
                item.SubItems.Add(trs.Jumlah_Barang.ToString());
                item.SubItems.Add(trs.Status);
                item.SubItems.Add(trs.alamat_gudang);
                item.SubItems.Add(trs.kapasitas_gudang);
                item.SubItems.Add(trs.Nama_Gudang);
                item.SubItems.Add(trs.nama_penguna);
                lvp.Items.Add(item);
            }
        }

        private void btn_tampil_produk_Click(object sender, EventArgs e)
        {
            LoadDataProduk();
        }
        //End Tab Produk
        //Tab Gudang
        private void InisialisasiGudang()
        {
            lvg.View = System.Windows.Forms.View.Details;
            lvg.FullRowSelect = true;
            lvg.GridLines = true;

            lvg.Columns.Add("No", 50, HorizontalAlignment.Left);
            lvg.Columns.Add("Gudang ID", 150, HorizontalAlignment.Left);
            lvg.Columns.Add("Nama Gudang", 150, HorizontalAlignment.Left);
            lvg.Columns.Add("Alamat", 150, HorizontalAlignment.Left);
            lvg.Columns.Add("Kapasitas", 280, HorizontalAlignment.Left);
        }
        private void LoadDataGudang()
        {
            lvg.Items.Clear();
            listGudang = controller_gudang.ReadAll();
            foreach (var trs in listGudang)
            {
                var noUrut = lvp.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trs.Gudang_ID.ToString());
                item.SubItems.Add(trs.Nama_Gudang);
                item.SubItems.Add(trs.Alamat);
                item.SubItems.Add(trs.Kapasitas.ToString());
                lvg.Items.Add(item);
            }
        }

        private void btn_tampil_gudang_Click(object sender, EventArgs e)
        {
            LoadDataGudang();   
        }
        //End Tab Gudang
    }
}
