using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OnlineShop_Kelompok10_TubesFINAL
{
    public partial class TFBform : Form
    {
        public TFBform()
        {
            InitializeComponent();
        }

        //dalam masing-masing tombol menggunakan runtime config dengan cara serialisasi data
        private void bca_Click(object sender, EventArgs e)
        {
            classBankFee bank = new classBankFee() 
            {
                biayaAdmin =  2500
            };
            labelBiayaAdmin.Text = JsonConvert.SerializeObject(bank.biayaAdmin, Formatting.Indented);
        }

        private void bni_Click(object sender, EventArgs e)
        {
            classBankFee bank = new classBankFee()
            {
                biayaAdmin = 2000
            };
            labelBiayaAdmin.Text = JsonConvert.SerializeObject(bank.biayaAdmin, Formatting.Indented);
        }

        private void bri_Click(object sender, EventArgs e)
        {
            classBankFee bank = new classBankFee()
            {
                biayaAdmin = 1500
            };
            labelBiayaAdmin.Text = JsonConvert.SerializeObject(bank.biayaAdmin, Formatting.Indented);
        }

        private void mandiri_Click(object sender, EventArgs e)
        {
            classBankFee bank = new classBankFee()
            {
                biayaAdmin = 1000
            };
            labelBiayaAdmin.Text = JsonConvert.SerializeObject(bank.biayaAdmin, Formatting.Indented);
        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            try
            {
                int cekInput = Convert.ToInt32(textBoxNomorRekening.Text); //cek inputan nomor atm semua harus berupa inputan INT
                cekInput = textBoxNomorRekening.Text.Length;

                //cek inputan noor atm harus == 9 digit inputan INT
                if (cekInput > 9)
                {
                    MessageBox.Show("Nomor tidak relevan atau berlebih");
                }
                else if (cekInput < 9)
                {
                    MessageBox.Show("Nomor tidak relevan atau kurang");
                }
                else
                {
                    MessageBox.Show("Silahkan Menunggu Barang");
                    Home home = new Home();
                    home.Show();
                    this.Close();
                }

            }
            catch (FormatException a) 
            {
                MessageBox.Show("PERHATIKAN! Input harus berupa angka");
            }
        }
    }
}
