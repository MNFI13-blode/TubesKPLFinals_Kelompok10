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
    public partial class SeragamKampus : Form
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
            Canvas = 1,
            CatAir = 2,
            BukuGambar = 3
        }

        public enum SeragamKampusEnum
        {
            Seragamputih = 1,
            seragammerah = 2,
            Almameter = 3
        }


        //mengimplementasikan Enum menjadi Table Driven
        public class Program
        {
            public static string[] daftarSeragamKampus = { "Seragam Putih", "Seragam Merah", "Almameter" };
            public static int[] hargaSeragamKampus = { 100000, 100000, 150000 };
            public static int[] jumlahSeragamKampus = new int[daftarSeragamKampus.Length];
            public static int totalHarga = 0;
        }
        public int z = Program.totalHarga;

        // membuat agar menjumlahkan Harga Barang sesuai Unit

        private void UpdateTotalHarga<TCategory>() // Parameter Generic Dengan Tipe data Category
        {
            Program.totalHarga = 0;
            // desain By Contact
            try
            {
                if (typeof(TCategory) == typeof(SeragamKampus))
                {
                    for (int i = 0; i < Program.daftarSeragamKampus.Length; i++)
                    {
                        int hargaSatuan = Program.hargaSeragamKampus[i];
                        int jumlahSeragam = Program.jumlahSeragamKampus[i];
                        int totalHarga = hargaSatuan * jumlahSeragam;

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
        public SeragamKampus()
        {
            InitializeComponent();
        }

        // TOMBOL KLIK UNTUK BARANG CSERAGAM PUTIH
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int selectedSeragamKampusIndex = (int)SeragamKampusEnum.Seragamputih - 1;

            if (selectedSeragamKampusIndex >= 0 && selectedSeragamKampusIndex < Program.daftarSeragamKampus.Length)
            {
                Program.jumlahSeragamKampus[selectedSeragamKampusIndex] = (int)numericUpDown1.Value;
                UpdateTotalHarga<SeragamKampus>();
            }
        }

        // TOMBOL KLIK UNTUK BARANG SERAGAM MERAH

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int selectedSeragamKampusIndex = (int)SeragamKampusEnum.seragammerah - 1;

            if (selectedSeragamKampusIndex >= 0 && selectedSeragamKampusIndex < Program.daftarSeragamKampus.Length)
            {
                Program.jumlahSeragamKampus[selectedSeragamKampusIndex] = (int)numericUpDown2.Value;
                UpdateTotalHarga<SeragamKampus>();
            }
        }

        // TOMBOL KLIK UNTUK BARANG ALMAMETER
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int selectedSeragamKampusIndex = (int)SeragamKampusEnum.Almameter - 1;

            if (selectedSeragamKampusIndex >= 0 && selectedSeragamKampusIndex < Program.daftarSeragamKampus.Length)
            {
                Program.jumlahSeragamKampus[selectedSeragamKampusIndex] = (int)numericUpDown3.Value;
                UpdateTotalHarga<SeragamKampus>();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckOutForm check = new CheckOutForm();
            check.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlatGambar alatGambar = new AlatGambar();
            alatGambar.Show();
            this.Hide();
        }


        private void SeragamKampus_Load(object sender, EventArgs e)
        {

        }
    }
}
