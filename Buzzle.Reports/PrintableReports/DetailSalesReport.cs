
using Buzzle.Client.Ui;
using System;
using System.Collections.Generic;
using System.Drawing;
using Bizzle.Common.Common;
using Buzzle.Client.Core;
using Buzzle.DataModel;

namespace Buzzle.Reports
{
    public partial class DetailSalesReport : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailSalesReport()
        {
            InitializeComponent();
            InitializeComponent();
            lbl_CreatedBy.Text = BuzzleFunctions.GetCurrentUser().FullName;
            CompanyInfo = BuzzleClientFunctions.GetCompanyInfo();
            lbl_GeneratedDate.Text = string.Format("{0: dddd, dd-MMMM-YYYY hh:mm tt}", DateTime.Now);
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



        public List<Sale> SalesToReport
        {
            set
            {
                DataSource = value;
            }
        }



    }
}
