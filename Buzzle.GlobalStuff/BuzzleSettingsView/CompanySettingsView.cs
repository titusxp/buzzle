using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data;
using Buzzle.Data.DataModel;

namespace Buzzle.GlobalStuff
{
    public partial class CompanySettingsView : BuzzleGlobalView
    {
        private DataManager _dataManager = new DataManager();
        public CompanySettingsView()
        {
            InitializeComponent();
            LoadCompanyData();
        }

        private Company CurrentCompany
        {
            get { return companyBindingSource.DataSource as Company; }
        }

        private void LoadCompanyData()
        {
            companyBindingSource.DataSource = _dataManager.GetCompanyData() ?? new Company();
        }

        private void barButtonItem_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.SwitchFocus(this);
            if(String.IsNullOrWhiteSpace(CurrentCompany.CompanyName))
            {
                BuzzleFunctions.ShowMessage("Company name must be provided", "");
                return;
            }
                      

            if (CurrentCompany.CompanyID < 1)
                _dataManager.AddCompanyInfo(CurrentCompany);
            else
                _dataManager.UpdateCompanyInfo(CurrentCompany);

            this.Close();
        }

        private void barButtonItem_ChangePicture_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangePicture();
        }

        private void ChangePicture()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files ( *.jpg, *.jpeg, *.jpe, *.jtif, *.png | *.jpg; *.png; *.jtif, *.jpe, *.jpeg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = System.Drawing.Image.FromFile(fileDialog.FileName);
                pictureBox_Logo.Image = image;
                pictureBox_Logo.Refresh();
                CurrentCompany.CompanyLogo = (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
            }
        }

        private void pictureBox_Logo_DoubleClick(object sender, EventArgs e)
        {
            ChangePicture();
        }
    }
}
