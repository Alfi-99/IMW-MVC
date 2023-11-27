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
        private Pengguna user;
        private bool isNewData = true;
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
            user = obj;
            txtJudulEntry.Text = "Update Pengguna";
        }

        private void tambah_user_Click(object sender, EventArgs e)
        {

        }
    }
}
