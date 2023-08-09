using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _212106053_Yekta_Alpagan_İO
{
    public partial class NotDefteri : Form
    {
        public NotDefteri()
        {
            InitializeComponent();
        }

        private string file = "";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Text Files |*.txt";
            if (dr == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                read.Close();
                file = openFileDialog1.FileName;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);

                write.Write(richTextBox1.Text);
                write.Close();

            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK) ;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
            {
                richTextBox1.Redo();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            richTextBox1.Text = dt.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Uygulama 212106053 numaralı Yekta ALPAGAN'a Aittir");
        }
    }
}