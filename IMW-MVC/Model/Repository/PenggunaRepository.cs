using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using IMW_MVC.Model.Entity;
using IMW_MVC.Model.Context;

namespace IMW_MVC.Model.Repository
{
    public class PenggunaRepository
    {
        private MySqlConnection _conn;
        public PenggunaRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Pengguna user)
        {
            int result = 0;
            string sql = @"insert into pengguna (nama_pengguna, katasandi) values (@nama_pengguna, @katasandi)";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama_pengguna", user.nama_pengguna);
                cmd.Parameters.AddWithValue("@katasandi", user.katasandi);
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
