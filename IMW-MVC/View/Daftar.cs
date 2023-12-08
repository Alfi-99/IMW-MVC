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
    public partial class Daftar : Form
    {
        private PenggunaController controller;
        private Pengguna user;
        public Daftar()
        {
            InitializeComponent();
            controller = new PenggunaController();
        }

       


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_retype_daftar.UseSystemPasswordChar = true;
                txt_pass_daftar.UseSystemPasswordChar = true;
            }
            else
            {
                txt_retype_daftar.UseSystemPasswordChar = false;
                txt_pass_daftar.UseSystemPasswordChar = false;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_daftar_Click_1(object sender, EventArgs e)
        {
            bool checkuser = false;
            Pengguna user = new Pengguna();
            if (txt_pass_daftar.Text == txt_retype_daftar.Text)
            {
                user.nama_pengguna = txt_user_daftar.Text;
                user.katasandi = txt_pass_daftar.Text;
                checkuser = controller.CheckUsername(user.nama_pengguna);
                if (checkuser == false)
                {
                    int result = controller.Create(user);
                    if (result == 1)
                    {
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Maaf User dengan Nama berikut sudah ada");
                }

            }
            else
            {
                MessageBox.Show("Mohon masukkan password yang benar dan sama");
            }
        }

        private void btn_kembali_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
