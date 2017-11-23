using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data.DataModel;
using Buzzle.GlobalStuff;
using Buzzle.Data;

namespace Buzzle.Sales.Views
{
    public partial class SuppliesView : BuzzleGlobalView
    {
        private DataManager _dataManager;
        public SuppliesView()
        {
            InitializeComponent();
            LoadAllItemsInStock();
        }

        private void LoadAllItemsInStock()
        {
            _dataManager = new DataManager();
            supplyBindingSource.DataSource = _dataManager.GetAllSupplies().OrderByDescending(supply => supply.DateRecorded);
        }

        private void barButtonItem_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadAllItemsInStock();
        }

        private Supply CurrentSupply
        {
            get { return supplyBindingSource.Current as Supply; }
        }

        private void barButtonItem_ViewSupply_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowCurrentSupply();
        }

        private void ShowCurrentSupply()
        {
            if (CurrentSupply == null) return;
            using (var viewSupplyView = new ViewSupplyView(CurrentSupply))
            {
                viewSupplyView.ShowDialog();
            }
        }

        private void gridView_Supplies_DoubleClick(object sender, EventArgs e)
        {
            ShowCurrentSupply();
        }
    }
}
