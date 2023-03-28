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

namespace Diary_pro
{
    public partial class frmMemoSearch : Form
    {
        public frmMemoSearch()
        {
            InitializeComponent();
        }

        private void frmMemoSearch_Load(object sender, EventArgs e)
        {
            int start = Properties.Settings.Default.lastmemo_id + 1;

            for (int i = 0; i < start; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void btnMemo_Click(object sender, EventArgs e)
        {
            Myfrms.frmMemo memo = new Myfrms.frmMemo();
            memo.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int last_id; 
            Int32.TryParse(this.listBox1.Text, out last_id);
            string fileName = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf";
            string fileName_title = Application.StartupPath + "\\data\\docs\\title_" + last_id.ToString() + ".rtf";
            string fileName_date = Application.StartupPath + "\\data\\docs\\date_" + last_id.ToString() + ".rtf";
            richTextBox1.LoadFile(fileName);

            txtMemoTitle.Text = File.ReadAllText(fileName_title, Encoding.UTF8);
            txtMemoDate.Text = File.ReadAllText(fileName_date, Encoding.UTF8);
            txtMemoID.Text = last_id.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int start = listBox1.FindStringExact(txtSearch.Text);
            listBox1.SelectedIndex = 1;
        }
    }
}
