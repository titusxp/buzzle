﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Buzzle.Data.DataModel;
using System.Collections.Generic;
using Buzzle.GlobalStuff;

namespace Buzzle.Reports.PrintableReports
{
    public partial class SalesReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SalesReport()
        {
            InitializeComponent();
            xrLabel6_CreatedBy.Text = BuzzleFunctions.GetCurrentUser().FullName;
            CompanyInfo = BuzzleFunctions.GetCompanyInfo();
        }

        public Company CompanyInfo
        {
            set
            {
                xrLabel_CompanyName.Text = value.CompanyName;
                xrPictureBox1.Image = (Image)new ImageConverter().ConvertFrom(value.CompanyLogo);
            }
        }

        public string Seller
        {
            set
            {
                lbl_Seller.Text = value;
            }
        }

        public string StartDate
        {
            set
            {
                lbl_StartDate.Text = value;
            }
        }

        public string EndDate
        {
            set
            {
                lbl_EndDate.Text = value;
            }
        }



        public IEnumerable<Sale> SalesToReport
        {
            set
            {
                DataSource = value;
            }
        }

    }
}