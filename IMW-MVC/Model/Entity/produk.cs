using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMW_MVC.Model.Entity
{
    public class Produk
    {
        public int Product_ID { get; set; }
        public int ID_pengguna { get; set; }
        public int Gudang_ID { get; set; }
        public string Nama_Barang { get; set; }
        public string Tanggal_Masuk { get; set; }
        public string Tanggal_Keluar { get; set; }
        public string Deskripsi {  get; set; }
        public int Harga {  get; set; }
        public string Lokasi { get; set; }
        public int Jumlah_Barang { get; set; }
        public string Status { get; set;}

        //untuk menyimpan field dari table lain
        public string nama_penguna {  get; set; }
        public string alamat_gudang { get; set; }
        public string kapasitas_gudang { get; set; }
        public string Nama_Gudang { get; set; }
    }
}
