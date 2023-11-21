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
using IMW_MVC.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace IMW_MVC
{
    public partial class Login : Form
    {
        private PenggunaController controller;
        private Pengguna user;
        public Login()
        {
            InitializeComponent();
            controller = new PenggunaController();
        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Daftar daftar = new Daftar();
            daftar.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            user = new Pengguna();
            user.nama_pengguna = name_input.Text;
            user.katasandi = pass_input.Text;
            bool result = controller.LoginValidasi(user.nama_pengguna, user.katasandi);
            if(result == true)
            {
                MessageBox.Show("Selamat Anda Berhasil Login");
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.ShowDialog();
            }
            else
            {
                MessageBox.Show("Maaf Anda Gagal Login");
            }

        }

        private void sh_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (sh_pass.Checked)
            {
                pass_input.UseSystemPasswordChar = true;

            }
            else
            {
                pass_input.UseSystemPasswordChar = false;
            }
        }
    }
}
