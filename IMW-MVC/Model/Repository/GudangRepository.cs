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
    public class GudangRepository
    {
        private MySqlConnection _conn;
        public GudangRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public List<Gudang> ReadAll()
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
                            Gudang gdg = new Gudang();
                            gdg.Gudang_ID = int.Parse(reader["Gudang_ID"].ToString());
                            gdg.Nama_Gudang = reader["Nama_Gudang"].ToString();
                            gdg.Alamat = reader["Alamat"].ToString();
                            gdg.Kapasitas = int.Parse(reader["Kapasitas"].ToString());
                            list.Add(gdg);
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
        public int Create(Gudang gudang)
        {
            int result = 0;
            string sql = @"insert into gudang (Nama_Gudang, Alamat, Kapasitas) values (@Nama_Gudang, @Alamat, @Kapasitas)";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama_Gudang", gudang.Nama_Gudang);
                cmd.Parameters.AddWithValue("@Alamat", gudang.Alamat);
                cmd.Parameters.AddWithValue("@Kapasitas", gudang.Kapasitas);
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
        public int Update(Gudang gudang, int gudang_id)
        {
            int result = 0;
            string sql = @"update gudang set Nama_Gudang = @Nama_Gudang, Alamat = @Alamat, Kapasitas = @Kapasitas where Gudang_ID = @gudang_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama_Gudang", gudang.Nama_Gudang);
                cmd.Parameters.AddWithValue("@Alamat", gudang.Alamat);
                cmd.Parameters.AddWithValue("@Kapasitas", gudang.Kapasitas);
                cmd.Parameters.AddWithValue("@gudang_id", gudang_id);
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
        public int DeleteGudang(Gudang gudang)
        {
            int result = 0;
            string sql = @"delete from gudang where Gudang_ID = " + gudang.Gudang_ID + "";
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
    }
}
