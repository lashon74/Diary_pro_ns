﻿using System;
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
    public partial class frmAboutUs : Form
    {
        public frmAboutUs()
        {
            InitializeComponent();
        }

        private void frmAboutUs_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = Application.CompanyName;
            lblProductName.Text = "Product Name: " + Application.ProductName;
            lblVersion.Text = "Version: " + Application.ProductVersion;
            lblSite.Text = Properties.Settings.Default.Site;
            lblProgrammer.Text = "Author: " + Properties.Settings.Default.Programmer_name;
            lblYear.Text = Properties.Settings.Default.Product_year;
        }
    }
}
