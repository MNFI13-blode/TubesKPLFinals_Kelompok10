using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop_Kelompok10_TubesFINAL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = user.Text;
            string password = pass.Text;

            if (IsValidLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                // Lakukan tindakan setelah login berhasil

                this.Hide(); // Menyembunyikan Form login

                Home lobyForm = new Home(); // Membuat instance baru dari Home
                lobyForm.Show(); // Menampilkan Form Home

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        private bool IsValidLogin(string username, string password)
        {
            // Kode untuk memeriksa kecocokan username dan password
            // Contoh sederhana untuk tujuan demonstrasi:
            return username == "admin" && password == "123";


        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            // Mengubah textbox menjadi password textbox
            pass.PasswordChar = '*';
            pass.UseSystemPasswordChar = true;
        }
    }
}
