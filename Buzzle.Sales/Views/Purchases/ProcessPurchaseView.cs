using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizzle.Common.Common;
using Bizzle.Common.Views;
using Buzzle.Api.Core;
using Buzzle.Client.Ui;
using Buzzle.DataModel;

namespace Buzzle.Sales.Views.Purchases.ProcessPurchasesView
{
    public partial class ProcessPurchaseView : BuzzleGlobalView
    {
        private Purchase _currentPurchase;

        private DataManager _dataManager = new DataManager();
        public EventHandler<SupplySavingEventArgs> RecordButtonClicked { get; set; } 
        public ProcessPurchaseView(Purchase purchase)
        {
            InitializeComponent();
            _currentPurchase = purchase;
            Initialize();
        }

        private void Initialize()
        {
            repositoryItem_StockItems.DataSource = _dataManager.GetAllStockItemTypes();
            lookUpEdit_PurchaseItems.Properties.DataSource = _currentPurchase.PurchaseItems.Where(item => item.IsSupplied != true);
            supplyItemBindingSource.DataSource = new List<SupplyItem>();
        }

        private void gridView_PurchasedItems_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu1.ShowPopup(MousePosition);
        }

        private List<SupplyItem> SupplyItems
        {
            get
            {
                return supplyItemBindingSource.DataSource as List<SupplyItem>;
            }
        }

        private void supplyItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (SupplyItems == null || SupplyItems.Any() != true) return;
            RefreshTotals();
        }

        private PurchaseItem SelectedPurchaseItem
        {
            get
            {
                if (lookUpEdit_PurchaseItems.EditValue == null)
                {
                    return null;
                }
                return lookUpEdit_PurchaseItems.GetSelectedDataRow() as PurchaseItem;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (SelectedPurchaseItem == null || textEdit_PurchasedQty.EditValue== null || textEdit_UnitPurchasePrice.EditValue == null)
                return;
            if (SupplyItems.Any(item => item.Id == SelectedPurchaseItem.Id))
            {
                BuzzleFunctions.ShowMessage("The item is already on the list", "Duplicate item");
                return;
            }

            var supplyItem = new SupplyItem()
            {
                 PurchaseItemID = SelectedPurchaseItem.Id,
                 PurchasedUnitPrice = int.Parse(textEdit_UnitPurchasePrice.EditValue.ToString()),
                 PurchasedQuantity = int.Parse(textEdit_PurchasedQty.EditValue.ToString()),
                 StockItemTypeID = SelectedPurchaseItem.Id
            };
            supplyItem.TotalSpent = supplyItem.PurchasedUnitPrice*supplyItem.PurchasedQuantity;

            supplyItemBindingSource.Add(supplyItem);
        }

        private void button_AddAll_Click(object sender, EventArgs e)
        {
            if (SupplyItems.Any())
            {
                var userIsSure = BuzzleFunctions.AskQuestion(
                    "This will clear all items in the list and then populate the list with all items in the original purchase with their initial quantities and purchase prices. Do you want to continue?",
                    "warning");
                if (!userIsSure) return;
            }

            supplyItemBindingSource.Clear();
            AddAllPSupplyItems();
        }

        private void AddAllPSupplyItems()
        {
            foreach (var item in _currentPurchase.PurchaseItems)
            {
                var supplyItem = new SupplyItem()
                {
                    PurchaseItemID = item.Id,
                    PurchasedUnitPrice = item.ProposedUnitPrice,
                    PurchasedQuantity = item.Quantity,
                    StockItemTypeID= item.Id
                };
                supplyItem.TotalSpent = supplyItem.PurchasedUnitPrice * supplyItem.PurchasedQuantity;
                supplyItemBindingSource.Add(supplyItem);
            }
        }

        private void barButtonItem_RecordPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SupplyItems.Any() != true)
            {
                BuzzleFunctions.ShowMessage("No items selected for supply", "Empty supply list");
                return;
            }

            foreach (
                var item in
                    _currentPurchase.PurchaseItems.Where(
                        it => SupplyItems.Any(si => si.Id == it.Id)))
            {
                item.IsSupplied = true;
            }

            var supply = new Supply()
            {
                DateRecorded = DateTime.Now,
                RecordedByUserID = CurrentlyLoggedInUser.Id,
                PurchaseID = _currentPurchase.Id
            };

            foreach (var item in SupplyItems)
            {
                supply.SupplyItems.Add(item);
            }

            var args = new SupplySavingEventArgs()
            {
                SupplyBeingSaved = supply,
                PurchaseBeingUpdated = _currentPurchase,
               // SupplyItems = SupplyItems
            };

            RecordButtonClicked(this, args);
        }

       

        private SupplyItem CurrentSupplyItem
        {
            get
            {
                return supplyItemBindingSource.Current as SupplyItem;
            }
        }


        private void RefreshTotals()
        {
            label_TotProposedValue.Text = string.Format("{0:0,#} CFA",
                SupplyItems.Select(item => item.TotalSpent).Sum());
        }

        private void barButtonItem_RemoveItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentSupplyItem == null) return;
            supplyItemBindingSource.RemoveCurrent();
        }

        private void lookUpEdit_PurchaseItems_EditValueChanged(object sender, EventArgs e)
        {
            if (SelectedPurchaseItem == null) return;
            textEdit_PurchasedQty.Text = SelectedPurchaseItem.Quantity.ToString();
            textEdit_UnitPurchasePrice.Text = SelectedPurchaseItem.ProposedUnitPrice.ToString();
        }
    }
}
