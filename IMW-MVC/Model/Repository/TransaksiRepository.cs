using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using IMW_MVC.Model.Entity;
using IMW_MVC.Model.Context;

namespace IMW_MVC.Model.Repository
{
    public class TransaksiRepository
    {
        private MySqlConnection _conn;
        public TransaksiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();
            try
            {
                string sql = @"select transaksi.Tanggal_Transaksi, transaksi.Jenis_Transaksi, transaksi.Jumlah_Barang,  produk.Nama_Barang, produk.Deskripsi, produk.Harga, gudang.Nama_Gudang, gudang.Alamat, pengguna.nama_pengguna FROM transaksi JOIN produk ON transaksi.Product_ID = produk.Product_ID JOIN gudang ON produk.Gudang_ID = gudang.Gudang_ID JOIN pengguna ON transaksi.ID_pengguna = pengguna.ID_pengguna";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read()) 
                        {
                            Transaksi trs = new Transaksi();
                            trs.Nama_barang = reader["Nama_Barang"].ToString();
                            trs.Tanggal_Masuk = reader["Tanggal_Transaksi"].ToString();
                            trs.Deskripsi = reader["Deskripsi"].ToString();
                            trs.jumlah_barang = int.Parse(reader["Jumlah_Barang"].ToString());
                            trs.harga_barang = int.Parse(reader["Harga"].ToString());
                            trs.Gudang = reader["Nama_Gudang"].ToString();
                            trs.Alamat = reader["Alamat"].ToString();
                            trs.User = reader["nama_pengguna"].ToString();
                            list.Add(trs);
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
