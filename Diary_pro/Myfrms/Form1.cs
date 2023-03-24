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
            Myfrms.frmLogin login = new Myfrms.frmLogin();
            login.ShowDialog();

            GetTime();
            lblVersion2.Text = Application.ProductVersion.ToString();

            var sIndex = Diary_pro.Properties.Settings.Default.backImageIndex;
            //loadBackground(0);
            loadBackground(sIndex);
            BackgroundCombo();
            dropdownBackground.SelectedIndex = sIndex;
            UserInfo();
            

        }
        public void UserInfo()
        {
            lblName.Text = Properties.Settings.Default.UserName;

            //Load user image
            string destinationFile = Application.StartupPath + "\\data\\Userpics\\Shon.jpg";
            ImageBox2.Load(destinationFile);
        }

        public void BackgroundCombo()
        {
            for (int i = 1; i < 4; i++)
            {
                dropdownBackground.Items.Add("Image " + i.ToString());
            }
        }

        public void loadBackground(int dropdown_image)
        {
            dropdown_image = dropdown_image + 1;
            string backGround = Application.StartupPath + "\\data\\pics\\" + dropdown_image.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(backGround);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void GetTime()
        {
            System.Globalization.GregorianCalendar g = new System.Globalization.GregorianCalendar();

            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
            lblYear2.Text = g.GetYear(DateTime.Now).ToString();
            lblDay2.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            lblDayOfWeek2.Text = g.GetDayOfWeek(DateTime.Now).ToString();


            Int32 m;
            string monthNum;
            monthNum = g.GetMonth(DateTime.Now).ToString();
            Int32.TryParse(monthNum, out m);
            lblMonth2.Text = GetMonth(m);
        }
        public string GetMonth(Int32 monthNum)
        {
            
            string mn;

            switch (monthNum)
            {
                case 1:
                    mn = "January";
                    break;

                case 2:
                    mn = "February";
                    break;
                case 3:
                    mn = "March";
                    break;

                case 4:
                    mn = "April";
                    break;

                case 5:
                    mn = "May";
                    break;

                case 6:
                    mn = "June";
                    break;
                case 7:
                    mn = "July";
                    break;

                case 8:
                    mn = "August";
                    break;

                case 9:
                    mn = "September";
                    break;

                case 10:
                    mn = "October";
                    break;
                case 11:
                    mn = "November";
                    break;

                case 12:
                    mn = "December";
                    break;

                default:
                    mn = "Unkown";
                    break;
            }
            //lblDisplayMonth.Text = mn;

            return mn;
        }

        private void dropdownBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sIndex = dropdownBackground.SelectedIndex;
            loadBackground(sIndex);

            Diary_pro.Properties.Settings.Default.backImageIndex = dropdownBackground.SelectedIndex;
            Diary_pro.Properties.Settings.Default.Save();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Myfrms.frmAboutUs about = new Myfrms.frmAboutUs();
            about.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Myfrms.frmUserMang User = new Myfrms.frmUserMang();
            User.Show();
        }

        private void lockApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Myfrms.frmLogin login= new Myfrms.frmLogin();
            login.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tsbtnAddMemo_Click(object sender, EventArgs e)
        {
            Myfrms.frmMemo memo = new Myfrms.frmMemo(); 
            memo.Show();
        }
    }
}
