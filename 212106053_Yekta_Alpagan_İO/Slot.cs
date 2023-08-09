using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _212106053_Yekta_Alpagan_İO
{
    public partial class Slot : System.Windows.Forms.Form
    {
        public Slot()
        {
            InitializeComponent();
        }
        private int jetonSayisi = 0; // Kasada kaç jeton olduğunu tutan değişken
        private bool onceParaVerdigi = false; // Makinanın daha önce para verip vermediğini tutan değişken
        private Random rng = new Random(); // Rastgele sayı üretebilmek için kullanılacak nesne

        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcının oynaması için yeterli jeton olup olmadığını kontrol edin
            if (jetonSayisi < 1)
            {
                MessageBox.Show("Önce para eklemelisiniz!");
                return;
            }
            jetonSayisi--; // Oynandığı için jeton sayısını azaltın
            JetonSayisiEtiket1.Text = jetonSayisi.ToString(); // Jeton sayısını güncelleyin

            if (jetonSayisi >= 10 && !onceParaVerdigi)
            {
                // %20 kazanma şansı
                if (rng.Next(1, 101) <= 20)
                {
                    MessageBox.Show("KAZANDINIZ!");
                    onceParaVerdigi = true; // Makina şimdi para verdi, bundan sonra %5 kazanma şansı verilecek
                }
                else
                {
                    MessageBox.Show("Kaybettiniz :(");
                }
            }
            else if (jetonSayisi >= 10 && onceParaVerdigi)
            {
                // %5 kazanma şansı
                if (rng.Next(1, 101) <= 5)
                {
                    MessageBox.Show("KAZANDINIZ!");
                }


                else if (jetonSayisi >= 10 && onceParaVerdigi)
                {
                    // %5 kazanma şansı
                    if (rng.Next(1, 101) <= 5)
                    {
                        MessageBox.Show("KAZANDINIZ!");
                    }
                    else
                    {
                        MessageBox.Show("Kaybettiniz :(");
                    }
                }

            }
            else
            {
                MessageBox.Show("Kaybettiniz :(");
            }
            GuncelleKazanmaIhtimali();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kasaya 1 jeton ekleyin
            jetonSayisi++;
            JetonSayisiEtiket1.Text = jetonSayisi.ToString();
            GuncelleKazanmaIhtimali();
        }
        private void GuncelleKazanmaIhtimali()
        {
            if (jetonSayisi < 10)
            {
                CasinoEtiket.Text = "Kazanma ihtimali: 0%";
            }
            else if (!onceParaVerdigi)
            {
                CasinoEtiket.Text = "Kazanma ihtimali: 20%";
            }
            else
            {
                CasinoEtiket.Text = "Kazanma ihtimali: 5%";
            }
        }

        private void CasinoEtiket_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    

