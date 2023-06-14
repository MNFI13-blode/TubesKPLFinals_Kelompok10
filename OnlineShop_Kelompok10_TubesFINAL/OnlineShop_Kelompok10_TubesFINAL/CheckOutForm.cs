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
    public partial class CheckOutForm : Form
    {

        AlatTuliss x = new AlatTuliss();
        AlatGambar y = new AlatGambar();
        SeragamKampus z = new SeragamKampus();



        public CheckOutForm()
        {
            InitializeComponent();
            int total = x.x+y.y+z.z;
        
            label_Total.Text = Convert.ToString(total);
       
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {

        }

        private void label_Total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.Hide();
            kategori.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMetodePembayaran new1 = new formMetodePembayaran();
            new1.Show();
        }
    }
}
