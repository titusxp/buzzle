using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data;
using Buzzle.DataModel;
using Buzzle.Client.Ui;

namespace Buzzle.Sales.Views
{
    public partial class AddSaleView : BuzzleGlobalView
    {
        private Sale _currentSale;
        private readonly DataManager _dataManager = new DataManager();
        private bool PrintReceiptAfterSaving = false;

        public EventHandler<SaleSavingArgs> RecordButtonClicked { get; set; }
        public AddSaleView(Sale sale = null)
        {
            InitializeComponent();
            _currentSale = sale ?? new Sale();
            Initialize();
        }

        private void Initialize()
        {
            saleItemBindingSource.DataSource = new List<SaleItem>();
            lookUpEdit_Item.Properties.DataSource = _dataManager.GetAllItemsInStock();
            repositoryItem_StockItems.DataSource = _dataManager.GetAllStockItemTypes();
            saleBindingSource.DataSource = _currentSale;
            saleItemBindingSource.DataSource = _currentSale.SaleItems.ToList();
        }

        private List<SaleItem> SelectedSaleItems
        {
            get
            {
                return saleItemBindingSource.DataSource as List<SaleItem>;
            }
        }

        private StockItemBalance SelectedItem
        {
            get { return lookUpEdit_Item.GetSelectedDataRow() as StockItemBalance; }
        }

        private void lookUpEdit_Item_EditValueChanged(object sender, EventArgs e)
        {
            if (SelectedItem == null) return;
            textEdit_UnitPrice.EditValue = SelectedItem.UnitSellingPrice;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!RequiredFieldValid || SelectedItem == null) return;

            if (SelectedSaleItems.Any(itm => itm.StockItemTypeID == SelectedItem.StockItemTypeID))
            {
                BuzzleFunctions.ShowMessage("Item is already in the list", "Cannot add duplicate");
                return;
            }
            var selectedQuantity = int.Parse(textEdit_Quantity.EditValue.ToString());

            if (SelectedItem.QuantityInStock < selectedQuantity)
            {
                BuzzleFunctions.ShowMessage("Cannot sell more than the available " + SelectedItem.QuantityInStock, "");
                return;
            }

            var item = new SaleItem()
            {
                StockItemTypeID = SelectedItem.StockItemTypeID,
                UnitSoldPrice = int.Parse(textEdit_UnitPrice.EditValue.ToString()),
                Quantity = selectedQuantity,
                UnitPurchasePrice = SelectedItem.UnitPurchasePrice
            };
            item.TotalSoldPrice = item.UnitSoldPrice*item.Quantity;
            saleItemBindingSource.Add(item);
        }

        private SaleItem CurrentItem
        {
            get
            {
                return saleItemBindingSource.Current as SaleItem;
            }
        }

        public bool RequiredFieldValid
        {
            get
            {
                return BuzzleValidator.IsNotEmpty(textEdit_UnitPrice.EditValue, "Unit price") &&
                       BuzzleValidator.IsNotEmpty(textEdit_Quantity.EditValue, "Quanitity");
            }
        }

        private void saleItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            int total;
            if (SelectedSaleItems == null || SelectedSaleItems.Any() != true)
                total = 0;
            else
                total = SelectedSaleItems.Select(item => item.UnitSoldPrice * item.Quantity).Sum();
            label_AmountPayable.Text = string.Format("{0: 0,#} CFA", total);
        }

        private void barButtonItem_RecordSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RecordSale();
        }

        private void RecordSale(bool printReceipt = false)
        {
            if (SelectedSaleItems == null || SelectedSaleItems.Any() != true)
            {
                BuzzleFunctions.ShowMessage("No sale items selected", "");
                return;
            }
            if (_currentSale.CustomerName == null)
                _currentSale.CustomerName = "Unavailable";
            _currentSale.DateRecorded = DateTime.Now;
            _currentSale.RecordedByUserID = CurrentlyLoggedInUser.UserID;

            foreach (var item in SelectedSaleItems)
            {
                _currentSale.SaleItems.Add(item);
            }

            RecordButtonClicked(this, new SaleSavingArgs() { Sale = _currentSale, PrintCommandPassed = printReceipt });
        }

        private void barButtonItem_RecordAndPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RecordSale(true);
        }

        private void barButtonItem_Remove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentItem == null) return;
            saleItemBindingSource.RemoveCurrent();
        }

        private void gridView_SaleItems_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(MousePosition);
            }
        }

    }
}
