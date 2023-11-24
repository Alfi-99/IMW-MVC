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
    public class ProdukController
    {
        private ProdukRepository _repository;
        public List<Produk> ReadAll()
        {
            List<Produk> list = new List<Produk>();
            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
