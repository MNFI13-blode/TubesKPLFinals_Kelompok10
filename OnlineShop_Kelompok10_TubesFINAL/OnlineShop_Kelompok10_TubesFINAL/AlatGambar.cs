using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OnlineShop_Kelompok10_TubesFINAL.AlatTuliss;

namespace OnlineShop_Kelompok10_TubesFINAL
{
    public partial class AlatGambar : Form
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

        public enum SeragamKampus
        {
            Seragamputih = 1,
            seragammerah = 2,
            Almameter = 3
        }

        //mengimplementasikan Enum menjadi Table Driven
        public class Program
        {
            public static string[] daftarAlatGambar = { "Canvas", "CatAir", "BukuGambar" };
            public static int[] hargaAlatGambar = { 30000, 20000, 15000 };
            public static int[] jumlahAlatGambar = new int[daftarAlatGambar.Length];
            public static int totalHarga = 0;
        }
        public int y = Program.totalHarga;
        // membuat agar menjumlahkan Harga Barang sesuai Unit
        private void UpdateTotalHarga<TCategory>() // Parameter Generic Dengan Tipe data Category
        {
            Program.totalHarga = 0;

            // desain By Contact
            try
            {
                if (typeof(TCategory) == typeof(AlatGambar))
                {
                    for (int i = 0; i < Program.daftarAlatGambar.Length; i++)
                    {
                        int hargaSatuan = Program.hargaAlatGambar[i];
                        int jumlaGambar = Program.jumlahAlatGambar[i];
                        int totalHarga = hargaSatuan * jumlaGambar;

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
        public AlatGambar()
        {
            InitializeComponent();
        }

        // TOMBOL KLIK UNTUK BARANG CANVAS
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int selectedAlatGambarIndex = (int)Alat_Gamabr.Canvas - 1;

            if (selectedAlatGambarIndex >= 0 && selectedAlatGambarIndex < Program.daftarAlatGambar.Length)
            {
                Program.jumlahAlatGambar[selectedAlatGambarIndex] = (int)numericUpDown1.Value;
                UpdateTotalHarga<AlatGambar>();
            }
        }

        // TOMBOL KLIK UNTUK BARANG CAT AIR
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int selectedAlatGambarIndex = (int)Alat_Gamabr.CatAir - 1;

            if (selectedAlatGambarIndex >= 0 && selectedAlatGambarIndex < Program.daftarAlatGambar.Length)
            {
                Program.jumlahAlatGambar[selectedAlatGambarIndex] = (int)numericUpDown2.Value;
                UpdateTotalHarga<AlatGambar>();
            }
        }

        // TOMBOL KLIK UNTUK BARANG BUKU GAMBAR
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int selectedAlatGambarIndex = (int)Alat_Gamabr.BukuGambar - 1;

            if (selectedAlatGambarIndex >= 0 && selectedAlatGambarIndex < Program.daftarAlatGambar.Length)
            {
                Program.jumlahAlatGambar[selectedAlatGambarIndex] = (int)numericUpDown3.Value;
                UpdateTotalHarga<AlatGambar>();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AlatGambar_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckOutForm check = new CheckOutForm();
            check.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
