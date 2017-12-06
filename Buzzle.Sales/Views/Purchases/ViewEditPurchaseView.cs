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

namespace Buzzle.Sales.Views
{
    public partial class ViewEditPurchaseView : BuzzleGlobalView
    {
        private Purchase _currentPurchase;
        public EventHandler<PurchaseSavingEventArgs> SaveButtonClicked { get; set; } 

        private DataManager _dataManager = new DataManager();
        public ViewEditPurchaseView(Purchase thisPurchase)
        {
            InitializeComponent();
            _currentPurchase = thisPurchase;
            this.Text = string.Format("Purchase No. {0:0000}", _currentPurchase);
            InitializeThings();
        }

        private void InitializeThings()
        {
            purchaseBindingSource.DataSource = _currentPurchase;
            purchaseItemBindingSource.DataSource = _currentPurchase.PurchaseItems;
            barButtonItem_Save.Enabled = _currentPurchase.Status ==
                                         BuzzleEnums.PurshaseStatuses.Awaiting_Purchase.ToString();
            lookupEdit_CreatedBy.Properties.DataSource = _dataManager.GetAllUsers();
        }

        private IEnumerable<PurchaseItem> _currentPurchaseItems
        {
            get
            {
                return purchaseItemBindingSource.DataSource as IEnumerable<PurchaseItem>;
            }
        }

        private void ViewEditPurchaseView_Load(object sender, EventArgs e)
        {

        }

        private void gridView_PurchaseItems_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(MousePosition);
        }

        private void barButtonItem_Remove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (purchaseItemBindingSource.Current == null) return;
            purchaseItemBindingSource.RemoveCurrent();
        }

        private void barButtonItem_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_currentPurchaseItems.Any() != true)
            {
                BuzzleFunctions.ShowMessage("Cannot save empty list", "Empty purchase items list ");
                return;
            }
            SaveButtonClicked(this, new PurchaseSavingEventArgs(){PurchaseBeingSaved = _currentPurchase});
        }
    }
}
