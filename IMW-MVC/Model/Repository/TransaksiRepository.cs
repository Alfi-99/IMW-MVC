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
    }
}
