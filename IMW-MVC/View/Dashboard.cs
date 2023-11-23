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
        private List<Transaksi> listTransaksi = new List<Transaksi>();
        private TransaksiController controller;

        public Dashboard()
        {
            InitializeComponent();
            InisialisasiTransaksi();
            controller = new TransaksiController();
            LoadDataTransaksi();
            user_nama.Text = Login.nama_pengguna;
        }
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
            if(listTransaksi != null)
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
    }
}
