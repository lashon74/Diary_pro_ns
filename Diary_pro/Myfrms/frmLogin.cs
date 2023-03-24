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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a nice day!");
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("User name Or Password is empty");
            }
            
            if (txtPassword.Text == Properties.Settings.Default.UserPass)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Your password is not correct! Please try again");
            }
        }
        public void UserInfo()
        {
            txtUserName.Text = Properties.Settings.Default.UserName;

            //Load user image
            string destinationFile = Application.StartupPath + "\\data\\Userpics\\Shon.jpg";
            ImageBox2.Load(destinationFile);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UserInfo();
        }
    }
}
