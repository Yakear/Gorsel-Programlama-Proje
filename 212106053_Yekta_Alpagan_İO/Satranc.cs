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
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            string sonuc = txtNereye.Text.ToLower().Trim();
            if (sonuc == "")
            {
                MessageBox.Show("Boş Bırakmayınız, Lütfen Bir Değer Giriniz.");
            }
            else if (sonuc == "A1" || sonuc == "a1")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At A1: B3-C2 Oynar.";
            }
            else if (sonuc == "A2" || sonuc == "a2")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At A2: B4-C1-C3 Oynar.";
            }
            else if (sonuc == "A3" || sonuc == "a3")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At A3: B1-B5-C4-C2 Oynar.";
            }
            else if (sonuc == "A4" || sonuc == "a4")
            {

                txtNereye.Clear();
                lblSonuc.Text = "At A4: B6-B2-C5-C3 Oynar.";
            }
            else if (sonuc == "A5" || sonuc == "a5")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At A5: B7-C6-C4-B3 Oynar.";
            }
            else if (sonuc == "A6" || sonuc == "a6")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At A6: B8-B4-C5-C7 Oynar.";

            }
            else if (sonuc == "A7" || sonuc == "a7")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At A7: B5-C6-C8 Oynar.";
            }
            else if (sonuc == "A8" || sonuc == "a8")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At A8: B6-C7 Oynar.";
            }
            else if (sonuc == "B1" || sonuc == "b1")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At B1: A3-C3-D2 Oynar.";
            }
            else if (sonuc == "B2" || sonuc == "b2")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At B2: D1-D3-C4-A4 Oynar.";
            }
            else if (sonuc == "B3" || sonuc == "b3")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At B3: C1-A1-D2-D4-C5-A5 Oynar.";
            }
            else if (sonuc == "B4" || sonuc == "b4")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At B4: C2-A2-C6-A6-D3-D5 Oynar.";
            }
            else if (sonuc == "B5" || sonuc == "b5")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At B5: C7-A7-C3-A3-D4-D6 Oynar.";
            }
            else if (sonuc == "B6" || sonuc == "b6")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At B6: C4-A4-C8-A8-D5-D7 Oynar.";

            }
            else if (sonuc == "B7" || sonuc == "b7")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At B7: C5-A5-D6-D8 Oynar.";
            }
            else if (sonuc == "B8" || sonuc == "b8")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At B8: D7-C6-A6 Oynar.";
            }
            else if (sonuc == "C1" || sonuc == "c1")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At C1: B3-D3-E2-A2 Oynar.";
            }
            else if (sonuc == "C2" || sonuc == "c2")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At C2: A1-E1-E3-A3-D4-B4 Oynar.";
            }
            else if (sonuc == "C3" || sonuc == "c3")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At C3: D5-B5-D1-B1-E2-E4-A4-A2 Oynar.";
            }
            else if (sonuc == "C4" || sonuc == "c4")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At C4: D2-B2-D6-B6-E3-E5-A3-A5 Oynar.";
            }
            else if (sonuc == "C5" || sonuc == "c5")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At C5: D3-B3-D7-B7-E4-E6-A4-A6 Oynar.";
            }
            else if (sonuc == "C6" || sonuc == "c6")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At C6: D8-B8-D4-B4-E5-E7-A5-A7 Oynar.";
            }
            else if (sonuc == "C7" || sonuc == "c7")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At C7: D5-B5-A6-A8-E6-E8 Oynar.";
            }
            else if (sonuc == "C8" || sonuc == "c8")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At C8: D6-B6-E7-A7 Oynar.";
            }
            else if (sonuc == "D1" || sonuc == "d1")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At D1: E3-C3-F2-B2 Oynar.";
            }
            else if (sonuc == "D2" || sonuc == "d2")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At D2: E4-C4-F1-F3-B1-B3 Oynar.";
            }
            else if (sonuc == "D3" || sonuc == "d3")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At D3: B2-B4-C1-C5-E1-E5-F2-F4 Oynar.";
            }
            else if (sonuc == "D4" || sonuc == "d4")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At D4: E2-C2-F3-F5-B3-B5-E6-C6 Oynar.";
            }
            else if (sonuc == "D5" || sonuc == "d5")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At D5: E7-C7-E3-C3-B4-B6-F4-F6 Oynar.";
            }
            else if (sonuc == "D6" || sonuc == "d6")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At D6: E8-C8-E4-C4-B5-B7-F5-F7 Oynar.";
            }
            else if (sonuc == "D7" || sonuc == "d7")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At D7: F8-B8-F6-B6-C5-E5 Oynar.";
            }
            else if (sonuc == "D8" || sonuc == "d8")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At D8: F7-B7-C6-E6 Oynar.";
            }
            else if (sonuc == "E1" || sonuc == "e1")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At E1: F3-D3-C2-G2 Oynar.";
            }
            else if (sonuc == "E2" || sonuc == "e2")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At E2: F4-D4-G1-G3-C3-C1 Oynar.";
            }
            else if (sonuc == "E3" || sonuc == "e3")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At E3: F5-D5-G2-G4-C4-C2-F1-D1 Oynar.";
            }
            else if (sonuc == "E4" || sonuc == "e4")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At E4: F6-D6-G3-G5-C5-C3-F2-D2 Oynar.";
            }
            else if (sonuc == "E5" || sonuc == "e5")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At E5: F7-D7-G4-G6-C6-C4-F3-D3 Oynar.";
            }
            else if (sonuc == "E6" || sonuc == "e6")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At E6: F8-D8-G5-G7-C7-C4-F4-D4 Oynar.";
            }
            else if (sonuc == "E7" || sonuc == "e7")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At E7: G6-G8-C6-C8-F5-D5 Oynar.";

            }
            else if (sonuc == "E8" || sonuc == "e8")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At E8: G7-C7-F6-D6 Oynar.";
            }
            else if (sonuc == "F1" || sonuc == "f1")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At F1: G3-E3-H2-D2 Oynar.";
            }
            else if (sonuc == "F2" || sonuc == "f2")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At F2: G4-E4-H1-H3-D1-D3 Oynar.";
            }
            else if (sonuc == "F3" || sonuc == "f3")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At F3: G5-E5-H2-H4-D2-D4-G1-E1 Oynar.";
            }
            else if (sonuc == "F4" || sonuc == "f4")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At F4: G6-E6-H3-H5-D3-D5-G2-E2 Oynar.";
            }
            else if (sonuc == "F5" || sonuc == "f5")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At F5: G7-E7-H4-H6-D4-D6-G3-E3 Oynar.";
            }
            else if (sonuc == "F6" || sonuc == "f6")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At F6: G8-E8-H5-H7-D5-D7-G4-E4 Oynar.";
            }
            else if (sonuc == "F7" || sonuc == "f7")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At F7: H6-H8-D6-D8-G5-E5 Oynar.";
            }
            else if (sonuc == "F8" || sonuc == "f8")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At F8: H7-D7-G6-E6 Oynar.";
            }
            else if (sonuc == "G1" || sonuc == "g1")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At G1: H3-F3-E2 Oynar.";
            }
            else if (sonuc == "G2" || sonuc == "g2")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At G2: H4-F4-E3-E1 Oynar.";
            }
            else if (sonuc == "G3" || sonuc == "g3")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At G3: H5-F5-H1-F1-E4-E2 Oynar.";
            }
            else if (sonuc == "G4" || sonuc == "g4")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At G4: H6-F6-H2-F2-E5-E3 Oynar.";
            }
            else if (sonuc == "G5" || sonuc == "g5")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At G5: H7-F7-H3-F3-E6-E4 Oynar.";
            }
            else if (sonuc == "G6" || sonuc == "g6")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At G6: H8-F8-H4-F4-E7-E5 Oynar.";
            }
            else if (sonuc == "G7" || sonuc == "g7")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At G7: H5-F5-E8-E6 Oynar.";
            }
            else if (sonuc == "G8" || sonuc == "g8")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At G8: H6-F6-E7 Oynar.";
            }
            else if (sonuc == "H1" || sonuc == "h1")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At H1: F2-G3 Oynar.";
            }
            else if (sonuc == "H2" || sonuc == "h2")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At H2: G4-F1-F3 Oynar.";
            }
            else if (sonuc == "H3" || sonuc == "h3")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At H3: G5-F2-F4-G1 Oynar.";
            }
            else if (sonuc == "H4" || sonuc == "h4")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At H4: G6-F3-F5-G2 Oynar.";
            }
            else if (sonuc == "H5" || sonuc == "h5")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At H5: G7-F4-F6-G3 Oynar.";
            }
            else if (sonuc == "H6" || sonuc == "h6")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At H6: G8-F5-F7-G4 Oynar.";
            }
            else if (sonuc == "H7" || sonuc == "h7")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At H7: F6-F8-G5 Oynar.";
            }
            else if (sonuc == "H8" || sonuc == "h8")
            {
                txtNereye.Clear();
                lblSonuc.Text = "At H8: G6-F7 Oynar.";
            }
            else
            {
                txtNereye.Clear();
                MessageBox.Show("Geçersiz Bir De§er Girdiniz, Lütfen Tekrar Deneyiniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At A8: B6-C7 Oynar.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At B8: D7-C6-A6 Oynar.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At C8: D6-B6-E7-A7 Oynar.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At D8: F7-B7-C6-E6 Oynar.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At E8: G7-C7-F6-D6 Oynar.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At F8: H7-D7-G6-E6 Oynar.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G8: H6-F6-E7 Oynar.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At H8: G6-F7 Oynar.";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At A7: B5-C6-C8 Oynar.";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At B7: C5-A5-D6-D8 Oynar.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At C7: D5-B5-A6-A8-E6-E8 Oynar.";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At D7: F8-B8-F6-B6-C5-E5 Oynar.";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At E7: G6-G8-C6-C8-F5-D5 Oynar.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At F7: H6-H8-D6-D8-G5-E5 Oynar.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G7: H5-F5-E8-E6 Oynar.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At H7: F6-F8-G5 Oynar.";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At A6: B8-B4-C5-C7 Oynar.";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At B6: C4-A4-C8-A8-D5-D7 Oynar.";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At C6: D8-B8-D4-B4-E5-E7-A5-A7 Oynar.";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At D6: E8-C8-E4-C4-B5-B7-F5-F7 Oynar.";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At E6: F8-D8-G5-G7-C7-C4-F4-D4 Oynar.";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At F6: G8-E8-H5-H7-D5-D7-G4-E4 Oynar.";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G6: H8-F8-H4-F4-E7-E5 Oynar.";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At H6: G8-F5-F7-G4 Oynar.";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At A5: B7-C6-C4-B3 Oynar.";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At B5: C7-A7-C3-A3-D4-D6 Oynar.";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At C5: D3-B3-D7-B7-E4-E6-A4-A6 Oynar.";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At D5: E7-C7-E3-C3-B4-B6-F4-F6 Oynar.";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At E5: F7-D7-G4-G6-C6-C4-F3-D3 Oynar.";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At F5: G7-E7-H4-H6-D4-D6-G3-E3 Oynar.";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G5: H7-F7-H3-F3-E6-E4 Oynar.";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At H5: G7-F4-F6-G3 Oynar.";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At A4: B6-B2-C5-C3 Oynar.";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At B4: C2-A2-C6-A6-D3-D5 Oynar.";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At C4: D2-B2-D6-B6-E3-E5-A3-A5 Oynar.";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At D4: E2-C2-F3-F5-B3-B5-E6-C6 Oynar.";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At E4: F6-D6-G3-G5-C5-C3-F2-D2 Oynar.";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At F4: G6-E6-H3-H5-D3-D5-G2-E2 Oynar.";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G4: H6-F6-H2-F2-E5-E3 Oynar.";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At H4: G6-F3-F5-G2 Oynar.";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At A3: B1-B5-C4-C2 Oynar.";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At B3: C1-A1-D2-D4-C5-A5 Oynar.";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At C3: D5-B5-D1-B1-E2-E4-A4-A2 Oynar.";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At D3: B2-B4-C1-C5-E1-E5-F2-F4 Oynar.";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At E3: F5-D5-G2-G4-C4-C2-F1-D1 Oynar.";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At F3: G5-E5-H2-H4-D2-D4-G1-E1 Oynar.";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G3: H5-F5-H1-F1-E4-E2 Oynar.";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At H3: G5-F2-F4-G1 Oynar.";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At A2: B4-C1-C3 Oynar.";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At B3: D1-D3-C4-A4 Oynar.";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At C2: A1-E1-E3-A3-D4-B4 Oynar.";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At D2: E4-C4-F1-F3-B1-B3 Oynar.";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At E2: F4-D4-G1-G3-C3-C1 Oynar.";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At F2: G4-E4-H1-H3-D1-D3 Oynar.";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G2: E1-E3-F4-H4 Oynar.";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G2: H5-F5-H1-F1-E4-E2 Oynar.";
        }

        private void button71_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At A1: B3-C2 Oynar.";
        }

        private void button70_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At B1: A3-C3-D2 Oynar.";
        }

        private void button69_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At C1: B3-D3-E2-A2 Oynar.";
        }

        private void button68_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At D1: E3-C3-F2-B2 Oynar.";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At E1: F3-D3-C2-G2 Oynar.";
        }

        private void button66_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At F1: G3-E3-H2-D2 Oynar.";
        }

        private void button65_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At G1: H3-F3-E2 Oynar.";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "At H1: F2-G3 Oynar.";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
