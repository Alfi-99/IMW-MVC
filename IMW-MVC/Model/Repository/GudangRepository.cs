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
    public class GudangRepository
    {
        private MySqlConnection _conn;
        public GudangRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        //Daftar user
        public int Create(Pengguna user)
        {
            string strFormat = "yyyy-MM-dd";
            string datenow = DateTime.Now.ToString(strFormat);
            int result = 0;
            string sql = @"insert into pengguna (nama_pengguna, katasandi, status, tanggal_buat) values (@nama_pengguna, @katasandi, 'User',@tanggal_buat)";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama_pengguna", user.nama_pengguna);
                cmd.Parameters.AddWithValue("@katasandi", user.katasandi);
                cmd.Parameters.AddWithValue("@katasandi", datenow);
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
        //Validasi akun sudah terbuat atau belum
        public bool DaftarValidasi(string nama_pengguna)
        {
            bool valid = false;
            try
            {
                string sql = @"select nama_pengguna, katasandi from pengguna where nama_pengguna = @nama_pengguna";
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama_pengguna", nama_pengguna);
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read()) 
                        {
                            valid = true;
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Get User and Pass Error: {0}", ex.Message);
            }
            return valid;
        }

    }
}
