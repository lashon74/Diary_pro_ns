using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_pro.Myfrms
{
    public partial class frmMemo : Form
    {
        public frmMemo()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = richTextBox1.SelectionIndent;
            i = i - 10;
            richTextBox1.SelectionIndent = i;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = richTextBox1.SelectionIndent;
            i = i + 10;
            richTextBox1.SelectionIndent = i;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void btnNewMemo_Click(object sender, EventArgs e)
        {
            Memobox.Enabled= true;
            btnSave.Enabled= true;
            btnNewMemo.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Memobox.Enabled = false;
            btnSave.Enabled = false;
            btnNewMemo.Enabled = true;

            //---------------------------------
            Int32 last_id;
            last_id = Properties.Settings.Default.lastmemo_id;
            last_id = last_id+ 1;

            Properties.Settings.Default.lastmemo_id = last_id;
            Properties.Settings.Default.Save();
                
            string filePath = "\\data\\docs\\";
            string fileType = ".rtf";
            string fileName = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf";

            richTextBox1.SaveFile(fileName);
            MessageBox.Show("Your Memo is saved!");


        }

        private void frmMemo_Load(object sender, EventArgs e)
        {
            Memobox.Enabled = false;
            btnSave.Enabled = false;
        }
    }
}
