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
        public List<Gudang> ReadProdukOnlyForComboBox()
        {
            List<Gudang> list = new List<Gudang>();
            try
            {
                string sql = @"select * from gudang";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Gudang prd = new Gudang();
                            prd.Gudang_ID = int.Parse(reader["Gudang_ID"].ToString());
                            prd.Nama_Gudang = reader["Nama_Gudang"].ToString();
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
        public List<Gudang> ReadForFillForm(int gudang_id)
        {
            List<Gudang> list = new List<Gudang>();
            try
            {
                string sql = @"select * from gudang where Gudang_ID = "+gudang_id+"";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Gudang prd = new Gudang();
                            prd.Gudang_ID = int.Parse(reader["Gudang_ID"].ToString());
                            prd.Alamat = reader["Alamat"].ToString();
                            prd.Kapasitas = int.Parse(reader["Kapasitas"].ToString());
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
        public int Create(Produk produk, int id_pengguna)
        {
            int result = 0;
            string sql = @"insert into produk (ID_pengguna, Gudang_ID, Nama_Barang, Tanggal_Masuk, Deskripsi, Harga, Lokasi, Jumlah_Barang, Status) values (@ID_pengguna, @Gudang_ID, @Nama_Barang, @Tanggal_Masuk, @Deskripsi, @Harga, @Lokasi, @Jumlah_Barang, @Status)";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@ID_pengguna", id_pengguna);
                cmd.Parameters.AddWithValue("@Gudang_ID", produk.Gudang_ID);
                cmd.Parameters.AddWithValue("@Nama_Barang", produk.Nama_Barang);
                cmd.Parameters.AddWithValue("@Tanggal_Masuk", produk.Tanggal_Masuk);
                cmd.Parameters.AddWithValue("@Deskripsi", produk.Deskripsi);
                cmd.Parameters.AddWithValue("@Harga", produk.Harga);
                cmd.Parameters.AddWithValue("@Lokasi", produk.Lokasi);
                cmd.Parameters.AddWithValue("@Jumlah_Barang", produk.Jumlah_Barang);
                cmd.Parameters.AddWithValue("@Status", produk.Status);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int Update(Produk produk, int id_pengguna)
        {
            int result = 0;
            return result;
        }
    }
}
