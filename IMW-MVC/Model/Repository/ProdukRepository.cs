using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using IMW_MVC.Model.Entity;
using IMW_MVC.Model.Context;
using System.Runtime.CompilerServices;
using MySqlX.XDevAPI.Common;
using System.Data;
namespace IMW_MVC.Model.Repository
{
    public class ProdukRepository
    {
        private MySqlConnection _conn;
        public ProdukRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public List<Produk> ReadAll()
        {
            List<Produk> list = new List<Produk>();
            try
            {
                string sql = @"select produk.Nama_barang, produk.Tanggal_Masuk, produk.Deskripsi, produk.Harga, produk.Jumlah_Barang, produk.status, gudang.Alamat, gudang.Kapasitas, gudang.Nama_Gudang, pengguna.nama_pengguna from produk join gudang on produk.Gudang_ID = gudang.Gudang_ID join pengguna on produk.ID_pengguna = pengguna.ID_pengguna";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produk prd = new Produk();
                            prd.Nama_Barang = reader["Nama_barang"].ToString();
                            prd.Tanggal_Masuk = reader["Tanggal_Masuk"].ToString();
                            prd.Deskripsi = reader["Deskripsi"].ToString();
                            prd.Harga = int.Parse(reader["Harga"].ToString());
                            prd.Jumlah_Barang = int.Parse(reader["Jumlah_Barang"].ToString());
                            prd.Status = reader["status"].ToString();
                            prd.alamat_gudang = reader["Alamat"].ToString();
                            prd.kapasitas_gudang = reader["Kapasitas"].ToString();
                            prd.Nama_Gudang = reader["Nama_Gudang"].ToString();
                            prd.nama_penguna = reader["nama_pengguna"].ToString();
                            list.Add(prd);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll Eror nih: {0}", ex.Message);
            }
            return list;
        }
    }
}
