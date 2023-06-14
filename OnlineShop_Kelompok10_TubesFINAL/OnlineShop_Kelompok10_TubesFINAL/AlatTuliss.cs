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
    public partial class AlatTuliss : Form
    {
        //=========Table driven==================
        public enum Kategori
        {
            AlatTulis = 1,
            AlatGambar,
            SeragamKampus
        }
        
        public enum AlatTulis
        {
            Pulpen = 1,
            Buku,
            Pensil
        }

        public enum Alat_Gamabr
        {
            PensilWarna = 1,
            Kuas = 2,
            CatAir = 3
        }

        public enum SeragamKampus
        {
            Seragamputih = 1,
            seragammerah = 2,
            Almameter = 3
        }

        //mengimplementasikan Enum menjadi Table Driven
        public class Program
        {
            public static string[] daftarAlatTulis = { "Pulpen", "Buku", "Pensil" };
            public static int[] hargaAlatTulis = { 3000, 10000, 2000 };
            public static int[] jumlahAlatTulis = new int[daftarAlatTulis.Length];
            public static int totalHarga = 0;

        }
        //untuk passing data ke form checkout
        public int x = Program.totalHarga;
 
        // membuat agar menjumlahkan Harga Barang sesuai Unit
        private void UpdateTotalHarga<TCategory>() // Parameter Generic Dengan Tipe data Category
        {
            Program.totalHarga = 0;

            // desain By Contact
            try
            {
                if (typeof(TCategory) == typeof(AlatTulis))
                {
                    for (int i = 0; i < Program.daftarAlatTulis.Length; i++)
                    {
                        int hargaSatuan = Program.hargaAlatTulis[i];
                        int jumlahAlatTulis = Program.jumlahAlatTulis[i];
                        int totalHarga = hargaSatuan * jumlahAlatTulis;

                        Program.totalHarga += totalHarga;
                    }
                }

                label11.Text = $"Rp. {Program.totalHarga}";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terjadi kesalahan: {e.Message}");
            }
        }
        public static AlatTuliss instance;
        public AlatTuliss()
        {
            InitializeComponent();
            instance = this;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // TOMBOL KLIK UNTUK BARANG PENSIL
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int selectedAlatTulisIndex = (int)AlatTulis.Pensil - 1;

            if (selectedAlatTulisIndex >= 0 && selectedAlatTulisIndex < Program.daftarAlatTulis.Length)
            {
                Program.jumlahAlatTulis[selectedAlatTulisIndex] = (int)numericUpDown2.Value;
                UpdateTotalHarga<AlatTulis>();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        // TOMBOL KLIK UNTUK BARANG PULPEN
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int selectedAlatTulisIndex = (int)AlatTulis.Pulpen - 1;

            if (selectedAlatTulisIndex >= 0 && selectedAlatTulisIndex < Program.daftarAlatTulis.Length)
            {
                Program.jumlahAlatTulis[selectedAlatTulisIndex] = (int)numericUpDown1.Value;
                UpdateTotalHarga<AlatTulis>();
            }

        }
        // TOMBOL KLIK UNTUK BARANG BUKU
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

            int selectedAlatTulisIndex = (int)AlatTulis.Buku - 1;

            if (selectedAlatTulisIndex >= 0 && selectedAlatTulisIndex < Program.daftarAlatTulis.Length)
            {
                Program.jumlahAlatTulis[selectedAlatTulisIndex] = (int)numericUpDown3.Value;
                UpdateTotalHarga<AlatTulis>();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           CheckOutForm cek = new CheckOutForm(); 
           cek.Show();
           this.Hide();
        }

        private void AlatTuliss_Load(object sender, EventArgs e)
        {

        }
    }
}
