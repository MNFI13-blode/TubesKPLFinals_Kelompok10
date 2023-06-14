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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlatTuliss AlatTulis = new AlatTuliss();  // Membuat instance objek Form2
            AlatTulis.Show();  // Menampilkan Form2
            this.Hide();  // Menyembunyikan Form1
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlatGambar formAlatGambar = new AlatGambar();  // Membuat instance objek AlatGambar
            formAlatGambar.Show();  // Menampilkan Form AlatGambar
            this.Hide();  // Menyembunyikan Form1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeragamKampus formSeragam = new SeragamKampus();  // Membuat instance objek SeragamKampus
            formSeragam.Show();  // Menampilkan Form Seragam
            this.Hide();  // Menyembunyikan Form1
        }
    }
}
