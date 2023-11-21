using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMW_MVC.Model.Entity
{
    public class Transaksi
    {
        public int Transaksi_ID { get; set; }
        public int Product_ID { get; set; }
        public int ID_pengguna { get; set; }
        public string Tanggal_Transaksi { get; set; }
        public string Jenis_Transaksi { get; set; }
        public int Jumlah_Barang {  get; set; }

    }
}
