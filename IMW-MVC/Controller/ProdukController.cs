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
    public class ProdukController
    {
        private ProdukRepository _repository;
        public List<Produk> ReadAll()
        {
            List<Produk> list = new List<Produk>();
            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                list = _repository.ReadAll();
            }
            return list;
        }
        public List<Gudang> ReadProdukOnlyForComboBox() 
        {
            List<Gudang> list = new List<Gudang>();
            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                list = _repository.ReadProdukOnlyForComboBox();
            }
            return list;
        }
        public List<Gudang> ReadForFillForm(int gudang_id)
        {
            List<Gudang> list = new List<Gudang>();
            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                list = _repository.ReadForFillForm(gudang_id);
            }
            return list;
        }
        public int Create(Produk produk, int id_pengguna)
        {
            int result = 0;
            if (string.IsNullOrEmpty(produk.Gudang_ID.ToString()))
            {
                MessageBox.Show("Product harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(produk.Nama_Barang.ToString()))
            {
                MessageBox.Show("Nama Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(produk.Deskripsi.ToString()))
            {
                MessageBox.Show("Deskripsi harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(produk.Jumlah_Barang.ToString()))
            {
                MessageBox.Show("Jumlah Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(produk.Harga.ToString()))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                result = _repository.Create(produk, id_pengguna);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Transaksi gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public int Update(Produk produk, int id_pengguna)
        {
            int result = 0;
            if (string.IsNullOrEmpty(produk.Gudang_ID.ToString()))
            {
                MessageBox.Show("Product harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(produk.Nama_Barang.ToString()))
            {
                MessageBox.Show("Nama Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(produk.Deskripsi.ToString()))
            {
                MessageBox.Show("Deskripsi harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(produk.Jumlah_Barang.ToString()))
            {
                MessageBox.Show("Jumlah Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(produk.Harga.ToString()))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                result = _repository.Update(produk, id_pengguna);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Transaksi gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public List<Produk> GetProdukListJumlah(int gudang_id)
        {
            List<Produk> list = new List<Produk>();
            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                list = _repository.GetProdukListJumlah(gudang_id);
            }
            return list;
        }
    }
}
