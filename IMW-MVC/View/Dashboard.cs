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
        private List<Transaksi> listTransaksiBySearch = new List<Transaksi>();

        public Dashboard()
        {
            InitializeComponent();
            user_nama.Text = Login.nama_pengguna;
            controller_pengguna = new PenggunaController();
            user();
            InisialisasiTransaksi();
            InisialisasiProduk();
            InisialisasiGudang();
            InisialisasiUser();
            controller = new TransaksiController();
            controller_produk = new ProdukController();
            controller_gudang = new GudangController();
            LoadDataTransaksi();
            LoadDataProduk();
            LoadDataGudang();
            LoadDataUser();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Login login = new Login();
            login.ShowDialog();
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
            lvt.Columns.Add("ID Transaksi", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Nama Barang", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Tanggal", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Deskripsi", 290, HorizontalAlignment.Left);
            lvt.Columns.Add("Jumlah Barang", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Harga Barang", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Gudang", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Alamat", 210, HorizontalAlignment.Left);
            lvt.Columns.Add("User", 150, HorizontalAlignment.Left);
            lvt.Columns.Add("Status Barang", 150, HorizontalAlignment.Left);
        }
        private void LoadDataTransaksi()
        {
            lvt.Items.Clear();
            listTransaksi = controller.ReadAll();
            foreach(var trs in listTransaksi) 
            {
                var noUrut = lvt.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trs.Transaksi_ID.ToString());
                item.SubItems.Add(trs.Nama_barang);
                item.SubItems.Add(trs.Tanggal_Masuk);
                item.SubItems.Add(trs.Deskripsi);
                item.SubItems.Add(trs.jumlah_barang.ToString());
                item.SubItems.Add(trs.harga_barang.ToString());
                item.SubItems.Add(trs.Gudang);
                item.SubItems.Add(trs.Alamat);
                item.SubItems.Add(trs.User);
                item.SubItems.Add(trs.Jenis_Transaksi);
                lvt.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Transaksi transaksi)
        {
            LoadDataTransaksi();
        }
        private void OnUpdateEventHandler(Transaksi transaksi)
        {
            LoadDataTransaksi();
        }
        private void btn_tambah_transaksi_Click(object sender, EventArgs e)
        {
            AddTransaksi addTransaksi = new AddTransaksi("Tambah Data Transaksi", controller);
            addTransaksi.OnCreate += OnCreateEventHandler;
            addTransaksi.ShowDialog();
        }
        private void btn_update_transaksi_Click(object sender, EventArgs e)
        {
            if(lvt.SelectedItems.Count > 0)
            {
                Transaksi trs = listTransaksi[lvt.SelectedIndices[0]];
                AddTransaksi addTransaksi = new AddTransaksi("Update Data Transaksi", trs,controller);
                addTransaksi.OnUpdate += OnUpdateEventHandler;
                addTransaksi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_tampil_transaksi_Click(object sender, EventArgs e)
        {
            LoadDataTransaksi();
        }
        private void btn_delete_transaksi_Click(object sender, EventArgs e)
        {
            if (lvt.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data transaksi ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Transaksi trs = listTransaksi[lvt.SelectedIndices[0]];
                    var result = controller.DeleteTransaksi(trs);
                    if (result > 0)
                    {
                        LoadDataTransaksi();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LoadDataSearchTransaksi()
        {
            lvt.Items.Clear();
            string input_search = input_search_transaksi.Text;
            listTransaksiBySearch = controller.SearchDataTransaksi(input_search);
            //MessageBox.Show(input_search);
            foreach (var trs in listTransaksiBySearch)
            {
                var noUrut = lvt.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trs.Transaksi_ID.ToString());
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
        private void btn_search_transaksi_Click(object sender, EventArgs e)
        {
            LoadDataSearchTransaksi();
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
            lvp.Columns.Add("Deskripsi", 280, HorizontalAlignment.Left);
            lvp.Columns.Add("Harga Barang", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Jumlah Barang", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Status", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Alamat", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Kapasitas", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Gudang", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Admin", 150, HorizontalAlignment.Left);
            lvp.Columns.Add("Product_ID", 0, HorizontalAlignment.Left);
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
                item.SubItems.Add(trs.Deskripsi);
                item.SubItems.Add(trs.Harga.ToString());
                item.SubItems.Add(trs.Jumlah_Barang.ToString());
                item.SubItems.Add(trs.Status);
                item.SubItems.Add(trs.alamat_gudang);
                item.SubItems.Add(trs.kapasitas_gudang);
                item.SubItems.Add(trs.Nama_Gudang);
                item.SubItems.Add(trs.nama_penguna);
                item.SubItems.Add(trs.Product_ID.ToString());
                lvp.Items.Add(item);
            }
        }

        private void btn_tampil_produk_Click(object sender, EventArgs e)
        {
            LoadDataProduk();
        }
        private void OnCreateProdukEventHandler(Produk produk)
        {
            LoadDataProduk();
        }
        private void OnUpdateProdukEventHandler(Produk produk)
        {
            LoadDataProduk();
        }
        private void btn_tambah_produk_Click(object sender, EventArgs e)
        {
            AddProduk AddProduk = new AddProduk("Tambah Data Produk", controller_produk);
            AddProduk.OnCreate += OnCreateProdukEventHandler;
            AddProduk.ShowDialog();
        }
        private void btn_update_produk_Click(object sender, EventArgs e)
        {
            if (lvp.SelectedItems.Count > 0)
            {
                Produk produk = listProduk[lvp.SelectedIndices[0]];
                AddProduk AddProduk = new AddProduk("Update Data Produk", produk, controller_produk);
                AddProduk.OnUpdate += OnUpdateProdukEventHandler;
                AddProduk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_delete_produk_Click(object sender, EventArgs e)
        {
            if (lvp.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data produk ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Produk produk = listProduk[lvp.SelectedIndices[0]];
                    var result = controller_produk.DeleteProduk(produk);
                    if (result > 0)
                    {
                        LoadDataProduk();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
        private void OnCreateGudangEventHandler(Gudang gudang)
        {
            LoadDataGudang();
        }
        private void OnUpdateGudangEventHandler(Gudang gudang)
        {
            LoadDataGudang();
        }
        private void btn_tambah_gudang_Click(object sender, EventArgs e)
        {
            AddGudang AddGudang = new AddGudang("Tambah Data Produk", controller_gudang);
            AddGudang.OnCreate += OnCreateGudangEventHandler;
            AddGudang.ShowDialog();
        }
        private void btn_update_gudang_Click(object sender, EventArgs e)
        {
            if (lvg.SelectedItems.Count > 0)
            {
                Gudang gudang = listGudang[lvg.SelectedIndices[0]];
                AddGudang AddGudang = new AddGudang("Update Data Produk", gudang, controller_gudang);
                AddGudang.OnUpdate += OnUpdateGudangEventHandler;
                AddGudang.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_delete_gudang_Click(object sender, EventArgs e)
        {
            if (lvg.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data gudang ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Gudang gudang = listGudang[lvg.SelectedIndices[0]];
                    var result = controller_gudang.DeleteGudang(gudang);
                    if (result > 0)
                    {
                        LoadDataGudang();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //End Tab Gudang
        //Tab User
        private void InisialisasiUser()
        {
            lvu.View = System.Windows.Forms.View.Details;
            lvu.FullRowSelect = true;
            lvu.GridLines = true;

            lvu.Columns.Add("No", 50, HorizontalAlignment.Left);
            lvu.Columns.Add("Pengguna ID", 150, HorizontalAlignment.Left);
            lvu.Columns.Add("Nama", 150, HorizontalAlignment.Left);
            lvu.Columns.Add("Status", 150, HorizontalAlignment.Left);
            lvu.Columns.Add("Tanggal Buat", 280, HorizontalAlignment.Left);
        }
        private void LoadDataUser()
        {
            lvu.Items.Clear();
            listPengguna = controller_pengguna.ReadAll();
            foreach (var user in listPengguna)
            {
                var noUrut = lvu.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(user.ID_pengguna.ToString());
                item.SubItems.Add(user.nama_pengguna);
                item.SubItems.Add(user.status);
                item.SubItems.Add(user.tanggal_buat.ToString());
                lvu.Items.Add(item);
            }
        }

        private void btn_tampil_user_Click(object sender, EventArgs e)
        {
            LoadDataUser();
        }
        private void OnCreateUserEventHandler(Pengguna pengguna)
        {
            LoadDataUser();
        }
        private void OnUpdateUserEventHandler(Pengguna pengguna)
        {
            LoadDataUser();
        }
        private void btn_tambah_user_Click(object sender, EventArgs e)
        {
            AddUser AddUser = new AddUser("Tambah Data User", controller_pengguna);
            AddUser.OnCreate += OnCreateUserEventHandler;
            AddUser.ShowDialog();
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            if (lvu.SelectedItems.Count > 0)
            {
                Pengguna user = listPengguna[lvu.SelectedIndices[0]];
                AddUser AddUser = new AddUser("Update Data User", user,controller_pengguna);
                AddUser.OnUpdate += OnUpdateUserEventHandler;
                AddUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            if (lvu.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data user ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Pengguna user = listPengguna[lvu.SelectedIndices[0]];
                    var result = controller_pengguna.DeleteUser(user);
                    if (result > 0)
                    {
                        LoadDataUser();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //End Tab User
    }
}
