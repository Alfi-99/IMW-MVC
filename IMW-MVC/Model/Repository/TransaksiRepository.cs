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
                string sql = @"select transaksi.Transaksi_ID, transaksi.Tanggal_Transaksi, transaksi.Jenis_Transaksi, transaksi.Jumlah_Barang,  produk.Nama_Barang, produk.Deskripsi, produk.Harga, gudang.Nama_Gudang, gudang.Alamat, pengguna.nama_pengguna FROM transaksi JOIN produk ON transaksi.Product_ID = produk.Product_ID JOIN gudang ON produk.Gudang_ID = gudang.Gudang_ID JOIN pengguna ON transaksi.ID_pengguna = pengguna.ID_pengguna";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read()) 
                        {
                            Transaksi trs = new Transaksi();
                            trs.Transaksi_ID = int.Parse(reader["Transaksi_ID"].ToString());
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
        //Select ComboBox Data
        public List<Produk> ReadProdukOnlyForComboBox()
        {
            List<Produk> list = new List<Produk>();
            try
            {
                string sql = @"select * from produk";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produk brg = new Produk();
                            brg.Product_ID = int.Parse(reader["Product_ID"].ToString());
                            brg.Nama_Barang = reader["Nama_Barang"].ToString();
                            brg.Deskripsi = reader["Deskripsi"].ToString();
                            brg.Jumlah_Barang = int.Parse(reader["Jumlah_barang"].ToString()) ;
                            list.Add(brg);
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
        public List<Produk> ReadForFillForm(int item_id)
        {
            List<Produk> list = new List<Produk>();
            try
            {
                string sql = @"select * from produk where Product_ID = @itemid";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@itemid", item_id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produk brg = new Produk();
                            brg.Product_ID = int.Parse(reader["Product_ID"].ToString());
                            brg.Nama_Barang = reader["Nama_Barang"].ToString();
                            brg.Deskripsi = reader["Deskripsi"].ToString();
                            brg.Jumlah_Barang = int.Parse(reader["Jumlah_barang"].ToString());
                            brg.Harga = int.Parse(reader["Harga"].ToString());
                            list.Add(brg);
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
        //Ambil ID_Pengguna
        public int PenggunaID(string nama_pengguna)
        {
            int result = 0;
            try
            {
                string ambil_pengguna = @"select * from pengguna where nama_pengguna = '" + nama_pengguna + "'";
                using (MySqlCommand cmd = new MySqlCommand(ambil_pengguna, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = int.Parse(reader["ID_Pengguna"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
            }
            return result;


        }
        //Add data Transaksi Barang Keluar
        public int Create_Barang_Keluar(Transaksi transaksi, int id_pengguna)
        {
            string strFormat = "yyyy-MM-dd";
            string datenow = DateTime.Now.ToString(strFormat);
            int result = 0;
            string sql = @"insert into transaksi (Product_ID, ID_pengguna, Tanggal_Transaksi, Jenis_Transaksi, Jumlah_Barang) values (@Product_ID, @ID_pengguna, @Tanggal_Transaksi, @Jenis_Transaksi, @Jumlah_Barang)";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Product_ID", transaksi.Product_ID);
                cmd.Parameters.AddWithValue("@ID_pengguna", id_pengguna);
                cmd.Parameters.AddWithValue("@Tanggal_Transaksi", datenow);
                cmd.Parameters.AddWithValue("@Jenis_Transaksi", transaksi.Jenis_Transaksi);
                cmd.Parameters.AddWithValue("@Jumlah_Barang", transaksi.jumlah_barang);
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

        //Update Jumlah di Produk
        public int UpdateJumlahProduk(Transaksi transaksi, int jumlah_produk)
        {
            int result = 0;
            string sql = @"update produk set Jumlah_Barang = '"+jumlah_produk+"' where Product_ID = '"+transaksi.Product_ID+"'";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
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
        //Update Transaksi
        //Ambil Data Berdasarkan Nama Barang
        public List<Produk> ReadProdukForComboBoxByNama(string namabarang)
        {
            List<Produk> list = new List<Produk>();
            try
            {
                string sql = @"select * from produk where Nama_Barang = '"+namabarang+"'";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produk brg = new Produk();
                            brg.Product_ID = int.Parse(reader["Product_ID"].ToString());
                            brg.Nama_Barang = reader["Nama_Barang"].ToString();
                            brg.Deskripsi = reader["Deskripsi"].ToString();
                            brg.Jumlah_Barang = int.Parse(reader["Jumlah_barang"].ToString());
                            brg.Harga = int.Parse(reader["Harga"].ToString());
                            list.Add(brg);
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
        //Update Transaksi
        public int UpdateTransaksi(Transaksi transaksi, int transaksiid)
        {
            int result = 0;
            string sql = @"update transaksi set Jumlah_Barang = '" + transaksi.jumlah_barang + "', Jenis_Transaksi = '"+transaksi.Jenis_Transaksi+"' where Transaksi_ID = " + transaksiid + "";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }
        //Delete Transaksi
        public int DeleteTransaksi(Transaksi transaksi)
        {
            int result = 0;
            string sql = @"delete from transaksi where Transaksi_ID = "+transaksi.Transaksi_ID+"";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }
        public List<Transaksi> SearchDataTransaksi(string input_search)
        {
            List<Transaksi> list = new List<Transaksi>();
            try
            {
                string sql = @"select transaksi.Transaksi_ID, transaksi.Tanggal_Transaksi, transaksi.Jenis_Transaksi, transaksi.Jumlah_Barang,  produk.Nama_Barang, produk.Deskripsi, produk.Harga, gudang.Nama_Gudang, gudang.Alamat, pengguna.nama_pengguna FROM transaksi JOIN produk ON transaksi.Product_ID = produk.Product_ID JOIN gudang ON produk.Gudang_ID = gudang.Gudang_ID JOIN pengguna ON transaksi.ID_pengguna = pengguna.ID_pengguna where produk.Nama_Barang like '"+input_search+"%' ";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaksi trs = new Transaksi();
                            trs.Transaksi_ID = int.Parse(reader["Transaksi_ID"].ToString());
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
