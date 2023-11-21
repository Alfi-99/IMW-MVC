using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMW_MVC.Model.Entity
{
    public class Pengguna
    {
        public int ID_pengguna { get; set; }
        public string nama_pengguna { get; set; }

        public string status { get; set; }
        public string katasandi { get; set; }
        public string tanggal_buat { get; set; }

}
