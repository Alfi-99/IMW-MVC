using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using IMW_MVC.Model.Context;
using IMW_MVC.Model.Repository;
using IMW_MVC.Model.Entity;

namespace IMW_MVC.Controller
{
    public class TransaksiController
    {
        private TransaksiRepository _repository;
        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();
            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
