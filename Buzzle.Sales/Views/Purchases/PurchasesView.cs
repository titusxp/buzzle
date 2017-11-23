using System;
using System.Linq;
using Buzzle.Data;
using Buzzle.Data.DataModel;
using Buzzle.GlobalStuff;
using Buzzle.Sales.Views.Purchases.ProcessPurchasesView;
using DevExpress.Data.Linq;

namespace Buzzle.Sales.Views
{
    public partial class PurchasesView : BuzzleGlobalView
    {
        private DataManager _dataManager;
        public PurchasesView()
        {
            InitializeComponent();
            LoadAllPurchases();
        }

        private void LoadAllPurchases()
        {
            _dataManager = new DataManager();
            purchaseBindingSource.DataSource = _dataManager.GetAllPurchases().OrderByDescending(pr => pr.DateRecorded);
        }

        private void barButtonItem_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAddEditPurchaseView();
        }

        private void ShowAddEditPurchaseView(Purchase purchase = null)
        {
            using (var newPurchaseView = new AddEditPurchaseView(purchase))
            {
                newPurchaseView.SaveButtonClicked += addEditPurchaseView_SaveButtonClicked;
                newPurchaseView.ShowDialog();
            }
        }

        private void addEditPurchaseView_SaveButtonClicked(object sender, PurchaseSavingEventArgs e)
        {
            (sender as AddEditPurchaseView).Close();
            if (e.PurchaseBeingSaved.PurchaseID < 1)
            {
                _dataManager.AddPurchase(e.PurchaseBeingSaved);
                LoadAllPurchases();
            }
            else
            {
                _dataManager.UpdatePurchase(e.PurchaseBeingSaved);
            }
        }

        private Purchase CurrentPurchase
        {
            get
            {
                if (purchaseBindingSource.Current == null)
                {
                    return null;
                }
                return purchaseBindingSource.Current as Purchase;
            }
        }

        private void purchaseBindingSource_CurrentChanged(object sender, System.EventArgs e)
        {
            if (CurrentPurchase == null) return;
            RefreshButtons();
        }

        private void RefreshButtons()
        {
            barButtonItem_ProcessPurchase.Enabled = 
                CurrentPurchase.Status == BuzzleEnums.PurshaseStatuses.Awaiting_Purchase.ToString()
                || CurrentPurchase.Status == BuzzleEnums.PurshaseStatuses.Part_Supplied.ToString();
            barButtonItem_Cancel.Enabled = CurrentPurchase.Status ==
                                                    BuzzleEnums.PurshaseStatuses.Awaiting_Purchase.ToString();
        }

        private void barButtonItem_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentPurchase == null || CurrentPurchase.Status != BuzzleEnums.PurshaseStatuses.Awaiting_Purchase.ToString()) return;
            if(BuzzleFunctions.AskQuestion() != true) return;
            CurrentPurchase.Status = BuzzleEnums.PurshaseStatuses.Cancelled.ToString();
            _dataManager.UpdatePurchase(CurrentPurchase);
        }

        private void barButtonItem_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentPurchase == null || CurrentPurchase.Status != BuzzleEnums.PurshaseStatuses.Cancelled.ToString()) return;
            if (BuzzleFunctions.AskQuestion() != true) return;
            _dataManager.DeletePurchase(CurrentPurchase);
            purchaseBindingSource.RemoveCurrent();
        }

        private void barButtonItem_ProcessPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentPurchase == null || CurrentPurchase.Status != BuzzleEnums.PurshaseStatuses.Awaiting_Purchase.ToString()) return;

            ProcessPurchase(CurrentPurchase);
        }

        private void ProcessPurchase(Purchase purchase)
        {
            using (var processPurchaseView = new ProcessPurchaseView(purchase))
            {
                processPurchaseView.RecordButtonClicked += ProcessPurchaseView_RecordButtonClicked;
                processPurchaseView.ShowDialog();
            }
        }

        private void ProcessPurchaseView_RecordButtonClicked(object sender, SupplySavingEventArgs e)
        {
            var purchase = e.PurchaseBeingUpdated;
            var supply = e.SupplyBeingSaved;
            (sender as ProcessPurchaseView).Close();

            //UpdatePurchaseStatus
            if (purchase.PurchaseItems.Any(item => item.IsSupplied != true) != true)
            {
                purchase.Status = BuzzleEnums.PurshaseStatuses.Completed.ToString();
            }
            else
            {
                purchase.Status = BuzzleEnums.PurshaseStatuses.Part_Supplied.ToString();
            }

            //save to database           
            supply = _dataManager.AddSupply(supply);

            //foreach (SupplyItem item in e.SupplyItems)
            //{
            //    item.SupplyID = supply.SupplyID;
            //    _dataManager.AddSupplyItem(item);
            //}
            _dataManager.UpdatePurchase(purchase);
        }

       

        private void barButtonItem_ViewEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentPurchase == null) return;
            ShowAddEditPurchaseView(CurrentPurchase);
        }

        private void gridView_Purchases_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Right) 
                return;
            popupMenu1.ShowPopup(MousePosition);
        }

        private void gridView_Purchases_DoubleClick(object sender, EventArgs e)
        {
            if (CurrentPurchase == null) return;
            ShowAddEditPurchaseView(CurrentPurchase);
        }
    }
}
