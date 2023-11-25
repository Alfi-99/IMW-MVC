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
    public class GudangController
    {
        private GudangRepository _repository;
        public List<Gudang> ReadAll()
        {
            List<Gudang> list = new List<Gudang>();
            using (DbContext context = new DbContext())
            {
                _repository = new GudangRepository(context);
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
