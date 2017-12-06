using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizzle.Common.Views;
using Buzzle.Api.Core;

namespace Buzzle.Sales.Views
{
    public partial class ItemsInStockView : BuzzleGlobalView
    {
        private DataManager _dataManager;// = new DataManager();
        public ItemsInStockView()
        {
            InitializeComponent();
            LoadAllItemsInStock();
        }

        private void LoadAllItemsInStock()
        {
            _dataManager = new DataManager();
            stockItemBalanceBindingSource.DataSource = _dataManager.GetAllItemsInStock();
        }

        private void barButtonItem_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadAllItemsInStock();
        }
    }
}
