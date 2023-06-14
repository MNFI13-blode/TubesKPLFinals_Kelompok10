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
    public partial class formMetodePembayaran : Form
    {
        public formMetodePembayaran()
        {
            InitializeComponent();
        }

        //table driven
        public enum kodeCaraBayar
        {
            COD,
            TFB,
            QRIS
        }

        public string getPenjelasan(kodeCaraBayar kodeCaraBayar)
        {
            string[] penjelasan = { "Anda menggunakan metode Cash on Delivery", "Anda menggunakan metode Transfer via Bank", "Anda menggunakan metode QRIS" };

            int indeks = (int)kodeCaraBayar;
            return penjelasan[indeks];
        }

        private void COD_Click(object sender, EventArgs e)
        {
            string caraBayar = getPenjelasan(kodeCaraBayar.COD);
            MessageBox.Show(caraBayar);

            CODform codf =  new CODform();
            codf.Show();
            this.Hide();
        }

        private void TFB_Click(object sender, EventArgs e)
        {
            string caraBayar = getPenjelasan(kodeCaraBayar.TFB);
            MessageBox.Show(caraBayar);

            TFBform tfbf = new TFBform();
            tfbf.Show();
            this.Hide();
        }

        private void QRC_Click(object sender, EventArgs e)
        {
            string caraBayar = getPenjelasan(kodeCaraBayar.QRIS);
            MessageBox.Show(caraBayar);

            QRISform qrf = new QRISform();
            qrf.Show();
            this.Hide();
        }

        private void formMetodePembayaran_Load(object sender, EventArgs e)
        {

        }
    }
}
