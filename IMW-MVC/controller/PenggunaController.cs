using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using IMW_MVC.Model.Context;
using IMW_MVC.Model.Repository;
using IMW_MVC.Model.Entity;

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
        public int Create(Pengguna user)
        {
            bool valid = DaftarValidasi(user.nama_pengguna);
            int result = 0;
            if (string.IsNullOrEmpty(user.nama_pengguna))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(user.katasandi))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if(valid == true)
            {
                MessageBox.Show("Akun dengan nama berikut sudah ada !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new PenggunaRepository(context);
                result = _repository.Create(user);
            }
            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }



        //Login
        public bool LoginValidasi(string nama_pengguna, string password)
        {
            bool valid = false;
            using (DbContext context = new DbContext())
            {
                _repository = new PenggunaRepository(context);
                valid = _repository.LoginValidasi(nama_pengguna, password);
            }

            return valid;
        }

        public List<Pengguna> ReadUserByName(string username)
        {
            List<Pengguna> list = new List<Pengguna>();
            using (DbContext context = new DbContext())
            {
                _repository = new PenggunaRepository(context);
                list = _repository.ReadUserByName(username);
            }
            return list;
        }
    }
}
