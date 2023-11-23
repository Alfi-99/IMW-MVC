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
    public class TransaksiController
    {
        private TransaksiRepository _repository;
        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();
            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                list = _repository.ReadAll();
            }
            return list;
        }
        public List<Produk> ReadProdukOnlyForComboBox()
        {
            List<Produk> list = new List<Produk>();
            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                list = _repository.ReadProdukOnlyForComboBox();
            }
            return list;
        }
        public List<Produk> ReadForFillForm(int itemid)
        {
            List<Produk> list = new List<Produk>();
            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                list = _repository.ReadForFillForm(itemid);
            }
            return list;
        }
        public int PenggunaID(string nama_pengguna)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                result = _repository.PenggunaID(nama_pengguna);
            }
            return result;
        }
        public int Create(Transaksi transaksi, int id_pengguna)
        {
            int result = 0;
            if (string.IsNullOrEmpty(transaksi.Product_ID.ToString()))
            {
                MessageBox.Show("Product harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(transaksi.jumlah_barang.ToString()))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                result = _repository.Create_Barang_Keluar(transaksi, id_pengguna);
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
        public int UpdateJumlahProduk(Transaksi transaksi, int jumlah_barang)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                result = _repository.UpdateJumlahProduk(transaksi, jumlah_barang);
            }
            return result; 
        }

    }
}
