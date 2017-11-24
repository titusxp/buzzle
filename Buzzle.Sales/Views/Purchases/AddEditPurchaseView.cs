using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Client.Ui;
using Buzzle.Data;
using Buzzle.DataModel;
using DevExpress.XtraLayout.Utils;

namespace Buzzle.Sales.Views
{
    public partial class AddEditPurchaseView : BuzzleGlobalView
    {
        private readonly DataManager _dataManager = new DataManager();
        public EventHandler<PurchaseSavingEventArgs> SaveButtonClicked { get; set; }

        private Purchase _currentPurchase;

        public AddEditPurchaseView(Purchase purchase = null)
        {
            InitializeComponent();
            
            _currentPurchase = purchase ?? new Purchase
            {
                DateRecorded = DateTime.Now,
                CreatedByUserID = CurrentlyLoggedInUser.UserID,
                Status = BuzzleEnums.PurshaseStatuses.Awaiting_Purchase.ToString()
            };

            Initialize();
        }

        private void Initialize()
        {
            purchaseItemBindingSource.DataSource = _currentPurchase.PurchaseItems;
            if (_currentPurchase.PurchaseID > 0)
            {
                layoutControlItem_PurchaseDetails.Visibility = LayoutVisibility.Always;
                lookupEdit_CreatedBy.Properties.DataSource = _dataManager.GetAllUsers();
                purchaseBindingSource.DataSource = _currentPurchase;
                this.Text = string.Format("Purchase No {0}", _currentPurchase);
            }
            if (IsAwaitingPurchase)
            {
                bar_Menu.Visible = true;
                LoadAllStockItemTypes();
                layoutItem_SelectMenu.Visibility = LayoutVisibility.Always;
            }
        }

        private bool IsAwaitingPurchase
        {
            get
            {
                return _currentPurchase.Status == BuzzleEnums.PurshaseStatuses.Awaiting_Purchase.ToString();
            }
        }

        private void LoadAllStockItemTypes()
        {
            lookUpEdit_StockItem.Properties.DataSource =
                    repositoryItem_StockItemTypes.DataSource = _dataManager.GetAllStockItemTypes();
        }



        private void AddPurchaseItem(PurchaseItem thisItem)
        {
            purchaseItemBindingSource.Add(thisItem);
            purchaseItemBindingSource.ResetBindings(false);
        }

        private void RemoveCurrentPurchaseItem()
        {
            purchaseItemBindingSource.RemoveCurrent();
        }

        private StockItemType currentlySelectedStockItemType
        {
            get
            {
                return lookUpEdit_StockItem.GetSelectedDataRow() as StockItemType;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!AllFieldsValid())
                return;
            if (currentlySelectedStockItemType == null) return;

            var currentStockItemTypeID = currentlySelectedStockItemType.StockItemTypeID;

            if (_currentPurchase.PurchaseItems.Any(item => item.StockItemTypeID == currentStockItemTypeID))
            {
                BuzzleFunctions.ShowMessage("The item is already in the list", "Duplicate entry!!");
                return;
            }

            var newPurchaseItem = new PurchaseItem()
            {
                StockItemTypeID = currentStockItemTypeID,
                ProposedUnitPrice = int.Parse(textEdit_ProposedPurchasePrice.EditValue.ToString()),
                Quantity = int.Parse(spinEdit_Quantity.EditValue.ToString()),
            };
            newPurchaseItem.TotalProposedPrice = newPurchaseItem.Quantity*newPurchaseItem.ProposedUnitPrice;
            AddPurchaseItem(newPurchaseItem);
        }

        private bool AllFieldsValid()
        {
            return BuzzleValidator.IsNotEmpty(lookUpEdit_StockItem.EditValue, "Stock Item") ||
                   BuzzleValidator.IsNotEmpty(textEdit_ProposedPurchasePrice.EditValue, "Proposed Purchase Price") ||
                   BuzzleValidator.IsNotLessThanOne(int.Parse(spinEdit_Quantity.EditValue.ToString()), "Quantity");
        }

        private void barButtonItem_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_currentPurchase.PurchaseItems.Any() != true) //no purchase items
            {
                BuzzleFunctions.ShowMessage("No items selected to save", "Empty purchase list");
                return;
            }

            SaveButtonClicked(this, new PurchaseSavingEventArgs() { PurchaseBeingSaved = _currentPurchase });

            
        }

        private void lookUpEdit_StockItem_EditValueChanged(object sender, EventArgs e)
        {
            if (currentlySelectedStockItemType == null) return;
            textEdit_ProposedPurchasePrice.EditValue = currentlySelectedStockItemType.UnitPurchasePrice;
        }

        private void purchaseItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (_currentPurchase == null) return;
            int total;
            if (_currentPurchase.PurchaseItems.Any() != true)
                total = 0;
            else
            {
                total = _currentPurchase.PurchaseItems.Select(item => item.TotalProposedPrice).Sum().Value;
            }
            label_TotalProposedPrice.Text = string.Format("{0: 0,#} CFA", total);
        }

        private void gridView_PurchaseItems_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu1.ShowPopup(MousePosition);
        }

        private PurchaseItem SelectedPurchaseItem
        {
            get
            {
                return purchaseItemBindingSource.Current as PurchaseItem;
                
            }
        }

        private void barButtonItem_Remove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SelectedPurchaseItem != null)
            {
                purchaseItemBindingSource.RemoveCurrent();
            }
        }

        private void barButtonItem_RemoveAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_currentPurchase.PurchaseItems.Any())
            {
                purchaseItemBindingSource.Clear();
            }
        }
        
    }
}
