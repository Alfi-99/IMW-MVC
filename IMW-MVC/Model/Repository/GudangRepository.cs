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
        

    }
}
