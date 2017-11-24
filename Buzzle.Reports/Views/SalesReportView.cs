using Buzzle.Data;
using Buzzle.Client.Ui;
using Buzzle.Reports.PrintableReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Buzzle.DataModel;

namespace Buzzle.Reports.Views
{
    public partial class SalesReportView : BuzzleGlobalView
    {
        private DateTime? _filterStartDate;
        private DateTime? _filterEndDate;
        private int? _filterUserID;

        private DataManager _dataManager;
        public SalesReportView()
        {
            InitializeComponent();
            Initialize();
        }
        
        private void Initialize()
        {
            _dataManager = new DataManager();
            lookUpEdit_User.Properties.DataSource = _dataManager.GetAllUsers();
            saleBindingSource.DataSource = new List<Sale>();
        }

        private void barButtonItem_Search_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var query = GenerateSQLSearchQuery();
            saleBindingSource.DataSource = _dataManager.GetSalesByQuery(query).OrderByDescending(sale => sale.DateRecorded);
            RefreshTotalLabel();
        }

        private void RefreshTotalLabel()
        {
            if (AllSales == null || !AllSales.Any()) return;
            int total = AllSales.Select(sale => sale.TotalSalesWorth).Sum();
            label_Total.Text = string.Format("{0:0,#} CFA", total); 
        }

        private string GenerateSQLSearchQuery()
        {
            _filterStartDate = dateEdit_StartDate.EditValue == null? null : (DateTime?)dateEdit_StartDate.DateTime;
            _filterEndDate = dateEdit_EndDate.EditValue == null ? null : (DateTime?)dateEdit_EndDate.DateTime;
            _filterUserID = lookUpEdit_User.EditValue == null? null : (int?)int.Parse(lookUpEdit_User.EditValue.ToString());

            var query = "EXEC [dbo].[FindSales] ";
            if (_filterStartDate.HasValue)
                query += "@StartDate = '" + _filterStartDate + "', ";
            if (_filterEndDate.HasValue)
                query += "@EndDate = '" + _filterEndDate + "', ";
            if (_filterUserID.HasValue)
                query += "@RecordedByUserID = " + _filterUserID;

            if (query.EndsWith(", "))
                query = query.Remove(query.Length - 2);

            return query;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (AllSales == null || !AllSales.Any()) return;
            ShowWaitForm();
            var salesReport = new SalesReport()
            {
                StartDate = _filterStartDate.HasValue ? string.Format("{0: dd MMM yyyy}", _filterStartDate.Value) : "Any",
                EndDate = _filterEndDate.HasValue ? string.Format("{0: dd MMM yyyy}", _filterEndDate.Value) : "Any",
                Seller = _filterUserID.HasValue ? lookUpEdit_User.Text : "All Users"
            };
            salesReport.SalesToReport = AllSales;
            HideWaitForm();
            salesReport.ShowPreview();
        }

        private IEnumerable<Sale> AllSales
        {
            get
            {
                return saleBindingSource.DataSource as IEnumerable<Sale>;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem_Reset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saleBindingSource.DataSource = new List<Sale>();
            lookUpEdit_User.EditValue = null;
            dateEdit_EndDate.EditValue = dateEdit_StartDate.EditValue = null;
            label_Total.Text = "0 CFA";
        }

    }
}
