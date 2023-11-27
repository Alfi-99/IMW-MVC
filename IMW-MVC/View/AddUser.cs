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
    public partial class AddUser : Form
    {
        private PenggunaController controller;
        public delegate void CreateUpdateEventHandler(Pengguna user);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private Pengguna pengguna;
        private bool isNewData = true;
        public int Pengguna_ID;
        public AddUser()
        {
            InitializeComponent();
            controller = new PenggunaController();
        }
        public AddUser(string title, PenggunaController controller)
        : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public AddUser(string title, Pengguna obj, PenggunaController controller)
         : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            pengguna = obj;
            Pengguna_ID = obj.ID_pengguna;
            username_input.Text = obj.nama_pengguna;
            password_input.Text = obj.katasandi;
            select_status.SelectedItem = obj.status;
            txtJudulEntry.Text = "Update Pengguna";
        }

        private void tambah_user_Click(object sender, EventArgs e)
        {
            if (isNewData) pengguna = new Pengguna();
            pengguna.nama_pengguna = username_input.Text;
            pengguna.status = select_status.SelectedItem.ToString();
            pengguna.katasandi = password_input.Text;
            int result = 0;
            if (isNewData)
            {
                result = controller.CreateFromAdmin(pengguna);
                if (result > 0)
                {
                    OnCreate(pengguna);
                    this.Close();
                }
            }
            else
            {
                result = controller.UpdateFromAdmin(pengguna, Pengguna_ID);
                if (result > 0)
                {
                    OnUpdate(pengguna);
                    this.Close();
                }

            }
        }
    }
}
