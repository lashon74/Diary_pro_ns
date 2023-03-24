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
    public partial class frmUserMang : Form
    {
        public frmUserMang()
        {
            InitializeComponent();
        }

        private void frmUserMang_Load(object sender, EventArgs e)
        {

            UserInfo();
        }

        public void UserInfo()
        {
            txtUserName.Text = Properties.Settings.Default.UserName;
            txtPassword1.Text = Properties.Settings.Default.UserPass;

            //Load user image
            string destinationFile = Application.StartupPath + "\\data\\Userpics\\Shon.jpg";
            ImageBox.Load(destinationFile);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtPassword1.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("User name Or Password is empty");
            }
            if (txtPassword1.Text != txtPassword2.Text)
            {
                MessageBox.Show("Passwords must match!");
            }
           
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.UserPass = txtPassword1.Text;
                Properties.Settings.Default.Save();
            if (openFileDialog1.FileName!= "openFileDialog1")
            {
                //Save picture
                string fileName = openFileDialog1.FileName;
                string destinationFile = Application.StartupPath + "\\data\\Userpics\\Shon.jpg";
                File.Copy(fileName, destinationFile, true);
            }

                
                MessageBox.Show("Done");

            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            ImageBox.Load(fileName);
        }
    }
}
