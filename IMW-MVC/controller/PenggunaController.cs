using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using IMW_MVC.Model.Context;
using IMW_MVC.Model.Repository;
using IMW_MVC.Model.Entity;
using MySql.Data.MySqlClient;

namespace IMW_MVC.Controller
{
    public class PenggunaController
    {
        private PenggunaRepository _repository;

        //Daftar Akun
        public bool DaftarValidasi(string nama_pengguna)
        {
            bool valid = false;
            using(DbContext context = new DbContext())
            {
                _repository = new PenggunaRepository(context);
                valid = _repository.DaftarValidasi(nama_pengguna);
            }

            return valid;
        }
        

        //Login
        public bool LoginValidasi(string nama_pengguna)
        {
            bool valid = false;
            using (DbContext context = new DbContext())
            {
                _repository = new PenggunaRepository(context);
                valid = _repository.DaftarValidasi(nama_pengguna);
            }

            return valid;
        }
    }
}
