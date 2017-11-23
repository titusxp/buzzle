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
using Buzzle.GlobalStuff;

namespace Buzzle.Sales.Views
{
    public partial class AddSaleView : BuzzleGlobalView
    {
        private Sale _currentSale;
        private readonly DataManager _dataManager = new DataManager();
        public AddSaleView(Sale sale = null)
        {
            InitializeComponent();
            _currentSale = sale ?? new Sale();
            Initialize();
        }

        private void Initialize()
        {
            lookUpEdit_Item.Properties.DataSource = _dataManager.GetAllItemsInStock();
            lookUpEdit_RecordedBy.Properties.DataSource = _dataManager.GetAllUsers();
            repositoryItem_StockItems.DataSource = _dataManager.GetAllStockItemTypes();
            saleBindingSource.DataSource = _currentSale;
            saleItemBindingSource.DataSource = _currentSale.SaleItems;
        }
    }
}
