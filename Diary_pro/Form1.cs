using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_pro
{
    public partial class LashonsDiary : Form
    {
        public LashonsDiary()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();

            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnShowDsk_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetTime();
        }

        private void LashonsDiary_Load(object sender, EventArgs e)
        {
            GetTime();

        }

        public void GetTime()
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
