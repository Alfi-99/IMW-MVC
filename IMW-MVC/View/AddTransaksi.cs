using MySql.Data.MySqlClient;
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
using IMW_MVC.Model.Entity;
namespace IMW_MVC.View
{
    public partial class AddTransaksi : Form
    {
        private List<Produk> listBarangCombobox = new List<Produk>();
        private List<Produk> listfillform = new List<Produk>();
        private TransaksiController controllerCombo;
        private TransaksiController controller;
        public delegate void CreateUpdateEventHandler(Transaksi transaksi);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private Transaksi transaksi;
        private bool isNewData = true;
        public static string nama_pengguna = Dashboard.nama_pengguna;
        public AddTransaksi()
        {
            InitializeComponent();
            controllerCombo = new TransaksiController();
            ComboBoxBarang();
            ket_input.ReadOnly = true;
            sisa_barang.ReadOnly = true;
            harga.ReadOnly = true;
        }
        public AddTransaksi(string title, TransaksiController controller)
        : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public AddTransaksi(string title, Transaksi obj, TransaksiController controller)
         : this()
                {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            transaksi = obj;
        }
        private void ComboBoxBarang()
        {
            select_barang.Items.Clear();
            listBarangCombobox = controllerCombo.ReadProdukOnlyForComboBox();
            foreach (var prdk in listBarangCombobox)
            {
                select_barang.Items.Add(prdk.Product_ID.ToString() + " - " + prdk.Nama_Barang.ToString());
            }
        }

        private void barang_keluar_Click(object sender, EventArgs e)
        {
            string item_list = select_barang.SelectedItem.ToString();
            string new_item_list = new string(item_list.Where(char.IsDigit).ToArray());
            int item_id = int.Parse(new_item_list);
            if (isNewData) transaksi = new Transaksi();
            transaksi.Product_ID = item_id;
            transaksi.Deskripsi = ket_input.Text;
            transaksi.harga_barang = int.Parse(harga.Text);
            transaksi.jumlah_barang = int.Parse(jml_input.Text);
            transaksi.Jenis_Transaksi = "Barang Keluar";
            int jumlah_barang = int.Parse(sisa_barang.Text) - transaksi.jumlah_barang;
            int result = 0;
            int id_pengguna = controller.PenggunaID(nama_pengguna);
            if (isNewData)
            {
                result = controller.Create(transaksi, id_pengguna);
                controller.UpdateJumlahProduk(transaksi, jumlah_barang);
                if (result > 0)
                {
                    OnCreate(transaksi);
                    this.Close();
                }
            }
        }

        private void barang_masuk_Click(object sender, EventArgs e)
        {
            string item_list = select_barang.SelectedItem.ToString();
            string new_item_list = new string(item_list.Where(char.IsDigit).ToArray());
            int item_id = int.Parse(new_item_list);
            if (isNewData) transaksi = new Transaksi();
            transaksi.Product_ID = item_id;
            transaksi.Deskripsi = ket_input.Text;
            transaksi.harga_barang = int.Parse(harga.Text);
            transaksi.jumlah_barang = int.Parse(jml_input.Text);
            transaksi.Jenis_Transaksi = "Barang Masuk";
            int jumlah_barang = int.Parse(sisa_barang.Text) - transaksi.jumlah_barang;
            int result = 0;
            int id_pengguna = controller.PenggunaID(nama_pengguna);
            if (isNewData)
            {
                result = controller.Create(transaksi, id_pengguna);
                controller.UpdateJumlahProduk(transaksi, jumlah_barang);
                if (result > 0)
                {
                    OnCreate(transaksi);
                    this.Close();
                }
            }
        }

        private void select_barang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item_list = select_barang.SelectedItem.ToString();
            string new_item_list = new string(item_list.Where(char.IsDigit).ToArray());
            int item_id = int.Parse(new_item_list);
            listfillform = controllerCombo.ReadForFillForm(item_id);
            foreach (var prdk in listfillform)
            {
                ket_input.Text = prdk.Deskripsi.ToString();
                harga.Text = prdk.Harga.ToString();
                sisa_barang.Text = prdk.Jumlah_Barang.ToString();
            }
        }
    }
}
