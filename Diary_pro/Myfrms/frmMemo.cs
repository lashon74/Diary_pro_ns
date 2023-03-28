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
            int start = Properties.Settings.Default.lastmemo_id +1;
            txtMemoID.Text =start.ToString();

            txtMemoTitle.Text = "";
            txtMemoDate.Text = "";
            richTextBox1.Text = "";


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
                
           
            string fileName = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf";
            string fileName_title = Application.StartupPath + "\\data\\docs\\title_" + last_id.ToString() + ".rtf";
            string fileName_date = Application.StartupPath + "\\data\\docs\\date_" + last_id.ToString() + ".rtf";

            File.WriteAllText(fileName_title, txtMemoTitle.Text, Encoding.UTF8);
            File.WriteAllText(fileName_date, txtMemoDate.Text, Encoding.UTF8);




            richTextBox1.SaveFile(fileName);
            MessageBox.Show("Your Memo is saved!");


        }

        private void frmMemo_Load(object sender, EventArgs e)
        {
            Memobox.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastmemo_id = 0;
            Properties.Settings.Default.Save();
        }
    }
}
