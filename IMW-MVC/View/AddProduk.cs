﻿using MySql.Data.MySqlClient;
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
        private bool isNewData = true;
        public int Produk_ID;
        public static string nama_pengguna = Dashboard.nama_pengguna;
        public AddProduk()
        {
            InitializeComponent();
            controller = new ProdukController();
            controller_transaksi = new TransaksiController();
            ComboBoxProduk();
        }
        public AddProduk(string title, ProdukController controller)
        : this()
        {
            this.Text = title;
            this.controller = controller;
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
            MessageBox.Show(datenow);
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
            MessageBox.Show(id_pengguna.ToString());
            if (isNewData)
            {
                result = controller.Create(produk, id_pengguna);
                if (result > 0)
                {
                    OnCreate(produk);
                    this.Close();
                }
            }
            else
            {
                result = controller.Update(produk, Produk_ID);
                if (result > 0)
                {
                    OnUpdate(produk);
                    this.Close();
                }
            }
        }
    }
}
