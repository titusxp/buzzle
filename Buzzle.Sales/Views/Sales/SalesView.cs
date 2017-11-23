using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data;
using Buzzle.GlobalStuff;
using Buzzle.Data.DataModel;
using System.Drawing.Printing;

namespace Buzzle.Sales.Views
{
    public partial class SalesView : BuzzleGlobalView
    {
        private DataManager _dataManager;
        private ReceiptPrinter _receiptPrinter;
        public SalesView()
        {
            InitializeComponent();
            _receiptPrinter = new ReceiptPrinter();
            LoadOrReloadAllSales();
        }

        private void LoadOrReloadAllSales()
        {
            _dataManager = new DataManager();
            saleBindingSource.DataSource = _dataManager.GetAllSales().OrderByDescending(sale => sale.DateRecorded);
        }

        private TransactionType SalesTransactionType { get; set; }

        private void barButtonItem_NewSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.ShowWaitForm();

            var salesTransactionType = _dataManager.GetSalesTransactionType();

            if (salesTransactionType == null)
            {
                BuzzleFunctions.ShowMessage(
                    "No transaction type set for sales. Please go to the general settings tab on the settings page and set a transaction type for sales",
                    "Cannot record sales");
                return;
            }

            SalesTransactionType = salesTransactionType;

            using (var addSaleView = new AddSaleView())
            {
                addSaleView.RecordButtonClicked += addSaleView_RecordButtonClicked;
                addSaleView.ShowDialog();
            }
        }

        private void addSaleView_RecordButtonClicked(object sender, SaleSavingArgs e)
        {
            if (SalesTransactionType == null)
            {
                BuzzleFunctions.ShowMessage(
                    "Cannot record this sale. No transaction type set for sales. Please go to the general settings tab on the settings page and set a transaction type for sales",
                    "Cannot record sales");
                return;
            }

            (sender as AddSaleView).Close();

            //add transaction
            var saleTransaction = new Transaction(){

                TransactionTypeID = SalesTransactionType.TransactionTypeID,
                Amount = e.Sale.SaleItems.Select(item => item.Quantity * item.UnitSoldPrice).Sum(),
                Notes = "New Sale",
                RecordedByUserID = CurrentlyLoggedInUser.UserID,
                DateRecorded = DateTime.Now
            };
            _dataManager.AddTransaction(saleTransaction);

            //add movement
            foreach(var item in e.Sale.SaleItems){
                var movement = new StockItemMovement()
                {
                    StockItemTypeID = item.StockItemTypeID,
                    Quantity = item.Quantity,
                    MovementType = (int)BuzzleEnums.StockMovementTypes.Stock_Out,
                    UnitPurchasePrice = item.UnitPurchasePrice,
                    MovementReason = BuzzleEnums.StockMovementReasons.Sales.ToString(),
                    DateRecorded = DateTime.Now
                };
                _dataManager.AddStockItemMovement(movement);
            }

            //add sale
            _dataManager.AddSale(e.Sale);
            if (e.PrintCommandPassed)
            {
                _receiptPrinter.PrintSaleReceipt(e.Sale);
            }
            LoadOrReloadAllSales();
        }       

        private Sale CurrentSale
        {
            get
            {
                return saleBindingSource.Current as Sale;
            }
        }

        private void barButtonItem_ViewSaleDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowCurrentSaleDetails();
        }

        private void ShowCurrentSaleDetails()
        {
            if (CurrentSale == null) return;
            using (var saleDetailsView = new ViewSaleView(CurrentSale))
            {
                saleDetailsView.ShowDialog();
            }
        }

        private void gridView_Sales_DoubleClick(object sender, EventArgs e)
        {
            ShowCurrentSaleDetails();
        }

        private void gridView_Sales_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu1.ShowPopup(MousePosition);
        }

        private void barButtonItem_PrintReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentSale == null) return;
            _receiptPrinter.PrintSaleReceipt(CurrentSale);
        }
    }
}
