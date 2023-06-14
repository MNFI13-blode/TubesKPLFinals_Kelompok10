using Finders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop_Kelompok10_TubesFINAL
{
    public partial class Search : Form
    {
        static bool IsValidInput(string input)
        {
            string pattern = @"^[a-zA-Z0-9]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }
        public Search()
        {
            InitializeComponent();
        }
        enum State { Start, Stop }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Visible)
            {
                label3.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Visible)
            {
                label4.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Visible)
            {
                label5.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Visible)
            {
                label6.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Visible)
            {
                label7.Visible = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Visible)
            {
                label8.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Visible)
            {
                label9.Visible = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (pictureBox14.Visible)
            {
                label10.Visible = true;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (pictureBox15.Visible)
            {
                label11.Visible = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible)
            {
                label12.Visible = true;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Visible)
            {
                label13.Visible = true;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (pictureBox18.Visible)
            {
                label14.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Menghapus Input Search User
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox3.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox6.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Menampilkan input dan menghilangkan gambar menu sampai user menekan cari
            label1.Visible = false;
            textBox1.Text = string.Empty;//Mereset lagi apabila user ingin memasukkan pencarian baru
            textBox1.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox3.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            State state = State.Start;//Automata
            string input = textBox1.Text;//input yang dimasukkan user
            int number1 = Finder.Searching(input);
            if (!IsValidInput(input))
            {
                //kalau user memasukkan input label tidak jelas
                MessageBox.Show("Input yag anda masukkan tidak valid");
                return;
            }
            else if (number1 < 1)
            {
                //kalau user memasukkan input label kosong dan tidak ditemukan
                label3.Visible = true;
                return;
            }
            while (state != State.Stop)
            {
                int number = Finder.Searching(textBox1.Text);
                if (number == 1)
                {
                    //User memasukkan input pena
                    pictureBox11.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox14.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    return;
                }
                else if (number == 2)
                {
                    //User memasukkan input pensil
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    return;
                }
                else if (number == 3)
                {
                    //User memasukkan input pensil kenko
                    pictureBox7.Visible = true;
                    label3.Visible = true;
                    return;
                }
                else if (number == 4)
                {
                    //User memasukkan input pensil joyko
                    pictureBox8.Visible = true;
                    label4.Visible = true;
                    return;
                }
                else if (number == 5)
                {
                    //User memasukkan input pensil stabilo
                    pictureBox9.Visible = true;
                    label5.Visible = true;
                    return;
                }
                else if (number == 6)
                {
                    //User memasukkan input pensil faber castel
                    pictureBox10.Visible = true;
                    label6.Visible = true;
                    return;
                }
                else if (number == 7)
                {
                    //User memasukkan input pena dell
                    pictureBox11.Visible = true;
                    label6.Visible = true;
                    return;
                }
                else if (number == 8)
                {
                    //User memasukkan input pena joyko
                    pictureBox12.Visible = true;
                    label7.Visible = true;
                    return;
                }
                else if (number == 9)
                {
                    //User memasukkan input pena snowmann
                    pictureBox14.Visible = true;
                    label9.Visible = true;
                    return;
                }
                else if (number == 10)
                {
                    //User memasukkan input water colour/cat warna
                    pictureBox16.Visible = true;
                    label10.Visible = true;
                    return;
                }
                else if (number == 11)
                {
                    //User memasukkan input buku tulis
                    pictureBox15.Visible = true;
                    label11.Visible = true;
                    return;
                }
                else if (number == 12)
                {
                    //User memasukkan input buku gambar
                    pictureBox3.Visible = true;
                    label12.Visible = true;
                    return;
                }
                else if (number == 13)
                {
                    //User memasukkan input correction pen
                    pictureBox17.Visible = true;
                    label13.Visible = true;
                    return;
                }
                else if (number == 14)
                {
                    //User memasukkan input penggaris
                    pictureBox18.Visible = true;
                    label14.Visible = true;
                    return;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Menampilkan input dan menghilangkan gambar menu sampai user menekan cari
            label1.Visible = false;
            textBox1.Text = string.Empty;//Mereset lagi apabila user ingin memasukkan pencarian baru
            textBox1.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox3.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
