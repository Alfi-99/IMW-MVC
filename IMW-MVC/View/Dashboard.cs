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

namespace IMW_MVC.View
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {;
            InitializeComponent();
            InisialisasiTransaksi();
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
    }
}
