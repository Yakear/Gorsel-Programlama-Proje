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
    public partial class AnaForm : System.Windows.Forms.Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poker frm2 = new Poker();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asker frm3 = new Asker();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bilgisayar_Kapatıcı frm5 = new Bilgisayar_Kapatıcı();
            frm5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buyuk_unlu_uyumu frm6 = new Buyuk_unlu_uyumu();
            frm6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Slot frm7 = new Slot();
            frm7.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Hesap_mak frm8 = new Hesap_mak();
            frm8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NotDefteri frm1 = new NotDefteri();
            frm1.Show();
        }

    }
}
