using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMW_MVC.Model.Entity
{
    public class Gudang
    {
        public int Gudang_ID { get; set; }
        public string Nama_Gudang { get; set; }
        public string Alamat {  get; set; }
        public int Kapasitas { get; set; }
    }
}
