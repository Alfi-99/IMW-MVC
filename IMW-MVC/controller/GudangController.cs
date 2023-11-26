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
    public class GudangController
    {
        private GudangRepository _repository;
        public List<Gudang> ReadAll()
        {
            List<Gudang> list = new List<Gudang>();
            using (DbContext context = new DbContext())
            {
                _repository = new GudangRepository(context);
                list = _repository.ReadAll();
            }
            return list;
        }
        public int Create(Gudang gudang)
        {
            int result = 0;
            if (string.IsNullOrEmpty(gudang.Nama_Gudang.ToString()))
            {
                MessageBox.Show("Product harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(gudang.Alamat.ToString()))
            {
                MessageBox.Show("Nama Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(gudang.Kapasitas.ToString()))
            {
                MessageBox.Show("Deskripsi harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new GudangRepository(context);
                result = _repository.Create(gudang);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Gudang berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Gudang gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public int Update(Gudang gudang, int gudang_id)
        {
            int result = 0;
            if (string.IsNullOrEmpty(gudang.Nama_Gudang.ToString()))
            {
                MessageBox.Show("Product harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(gudang.Alamat.ToString()))
            {
                MessageBox.Show("Nama Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(gudang.Kapasitas.ToString()))
            {
                MessageBox.Show("Deskripsi harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new GudangRepository(context);
                result = _repository.Update(gudang, gudang_id);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Gudang berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Gudang gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public int DeleteGudang(Gudang gudang)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new GudangRepository(context);
                result = _repository.DeleteGudang(gudang);
            }
            return result;
        }
    }
}
