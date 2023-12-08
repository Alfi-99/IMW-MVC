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
    public partial class AddProduk : Form
    {
        public delegate void CreateUpdateEventHandler(Produk produk);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private ProdukController controller;
        private TransaksiController controller_transaksi;
        private Produk produk;
        private List<Gudang> listbarangcombobox = new List<Gudang>();
        private List<Gudang> listfillform = new List<Gudang>();
        private List<Produk> listjumlahprodukbygudang = new List<Produk>();
        private List<Gudang> listgudangcomboboxupdate = new List<Gudang>();
        private bool isNewData = true;
        public int Product_ID;
        public static string nama_pengguna = Dashboard.nama_pengguna;

        public AddProduk()
        {
            InitializeComponent();
            controller = new ProdukController();
            controller_transaksi = new TransaksiController();
            ComboBoxProduk();
            input_lokasi.ReadOnly = true;
            input_kapasitas.ReadOnly = true;    
        }
        public AddProduk(string title, ProdukController controller)
        : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public AddProduk(string title, Produk obj, ProdukController controller)
        : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            produk = obj;
            txtJudulEntry.Text = "Update Transaksi";
            Product_ID = obj.Product_ID;
            MessageBox.Show(Product_ID.ToString());
            listgudangcomboboxupdate = controller.ReadGudangBasedOnGudangID(obj.Nama_Gudang);
            input_nama.Text = obj.Nama_Barang;
            input_deskripsi.Text = obj.Deskripsi;
            input_jml.Text = obj.Jumlah_Barang.ToString();
            input_harga.Text = obj.Harga.ToString();
            foreach (var brg in listgudangcomboboxupdate)
            {
                string item_selected = brg.Gudang_ID.ToString() + " - " + obj.Nama_Gudang.ToString();
                select_gudang.SelectedItem = item_selected;
                input_lokasi.Text = brg.Alamat.ToString();
                input_kapasitas.Text = brg.Kapasitas.ToString();
            }
        }
        private void ComboBoxProduk()
        {
            select_gudang.Items.Clear();
            listbarangcombobox = controller.ReadProdukOnlyForComboBox();
            foreach (var gdg in listbarangcombobox)
            {
                select_gudang.Items.Add(gdg.Gudang_ID.ToString() + " - " + gdg.Nama_Gudang.ToString());
            }
        }

        private void select_gudang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gudang_list = select_gudang.SelectedItem.ToString();
            string new_gudang_list = new string(gudang_list.Where(char.IsDigit).ToArray());
            int v = int.Parse(new_gudang_list);
            int gudang_id = v;
            listfillform = controller.ReadForFillForm(gudang_id);
            foreach (var prdk in listfillform)
            {
                input_lokasi.Text = prdk.Alamat;
                input_kapasitas.Text = prdk.Kapasitas.ToString();
            }
        }

        private void btn_tambah_barang_Click(object sender, EventArgs e)
        {
            string strFormat = "yyyy-MM-dd H:m:s";
            string datenow = DateTime.Now.ToString(strFormat);
            string item_list = select_gudang.SelectedItem.ToString();
            string new_item_list = new string(item_list.Where(char.IsDigit).ToArray());
            int gudang_id = int.Parse(new_item_list);
            if (isNewData) produk = new Produk();
            produk.Gudang_ID = gudang_id;
            produk.Nama_Barang = input_nama.Text;
            produk.Tanggal_Masuk = datenow;
            produk.Deskripsi = input_deskripsi.Text;
            produk.Harga = int.Parse(input_harga.Text);
            produk.Lokasi = input_lokasi.Text;
            produk.Jumlah_Barang = int.Parse(input_jml.Text);
            produk.Status = "Ada";
            int result = 0;
            int id_pengguna = controller_transaksi.PenggunaID(nama_pengguna);
            listjumlahprodukbygudang = controller.GetProdukListJumlah(gudang_id);
            int jumlah_barang_suatu_gudang = 0;
            foreach (var ini in listjumlahprodukbygudang)
            {
                jumlah_barang_suatu_gudang += ini.Jumlah_Barang;
            }
            if (isNewData)
            {
                if(jumlah_barang_suatu_gudang + int.Parse(input_jml.Text) > int.Parse(input_kapasitas.Text))
                {
                    MessageBox.Show("Jumlah Barang melebihi kapasitas gudang!!!!");
                }
                else
                {
                    result = controller.Create(produk, id_pengguna);
                    if (result > 0)
                    {
                        OnCreate(produk);
                        this.Close();
                    }
                }
            }
            else
            {
                if (jumlah_barang_suatu_gudang + int.Parse(input_jml.Text) > int.Parse(input_kapasitas.Text))
                {
                    MessageBox.Show("Jumlah Barang melebihi kapasitas gudang!!!!");
                }
                else
                {
                    result = controller.Update(produk, Product_ID);
                    if (result > 0)
                    {
                        OnUpdate(produk);
                        this.Close();
                    }
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
