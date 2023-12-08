using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IMW_MVC.Controller;
using IMW_MVC.Model.Entity;

namespace IMW_MVC.View
{
    public partial class AddGudang : Form
    {
        public delegate void CreateUpdateEventHandler(Gudang gudang);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private GudangController controller;
        private Gudang gudang;
        private List<Gudang> listbarangcombobox = new List<Gudang>();
        private bool isNewData = true;
        public int Gudang_ID;
        public AddGudang()
        {
            InitializeComponent();
            controller = new GudangController();
        }
        public AddGudang(string title, GudangController controller)
        : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public AddGudang(string title, Gudang obj, GudangController controller)
        : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            gudang = obj;
            txtJudulEntry.Text = "Update Gudang";
            Gudang_ID = obj.Gudang_ID;
            input_nama_gudang.Text = obj.Nama_Gudang;
            input_alamat_gudang.Text = obj.Alamat;
            input_kapasitas_gudang.Text = obj.Kapasitas.ToString();
        }

        private void btn_tambah_gudang_Click(object sender, EventArgs e)
        {
            if (isNewData) gudang = new Gudang();
            gudang.Nama_Gudang = input_nama_gudang.Text;
            gudang.Alamat = input_alamat_gudang.Text;
            gudang.Kapasitas = int.Parse(input_kapasitas_gudang.Text);
            int result = 0;
            if (isNewData)
            {
               result = controller.Create(gudang);
               if (result > 0)
               {
                  OnCreate(gudang);
                  this.Close();
               }
            }
            else
            {

              result = controller.Update(gudang, Gudang_ID);
              if (result > 0)
              {
                OnUpdate(gudang);
                this.Close();
              }

            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
