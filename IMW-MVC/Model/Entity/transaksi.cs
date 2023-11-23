using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMW_MVC.Model.Entity
{
    public class Transaksi
    {
        public string Nama_barang { get; set; }
        public string Tanggal_Masuk {  get; set; }
        public string Deskripsi {  get; set; }
        public int jumlah_barang { get; set; }
        public int harga_barang { get; set; }
        public string Gudang {  get; set; }
        public string Alamat {  get; set; }
        public string User { get; set;}

    }
}
