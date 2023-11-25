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

    }
}
