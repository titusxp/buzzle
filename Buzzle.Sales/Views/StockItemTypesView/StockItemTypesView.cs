using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizzle.Common.Common;
using Bizzle.Common.Views;
using Buzzle.Api.Core;

using Buzzle.DataModel;
using Buzzle.Client.Ui;
using DevExpress.XtraEditors;

namespace Buzzle.Sales.Views
{
    public partial class StockItemTypesView : BuzzleGlobalView
    {
        private DataManager _dataManager;

        public StockItemTypesView()
        {
            InitializeComponent();
            LoadAllStockItems();
        }

        private void LoadAllStockItems()
        {
            _dataManager = new DataManager();
            stockItemTypeBindingSource.DataSource = _dataManager.GetAllStockItemTypes();
        }

        private void barButtonItem_ViewEditItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentStockItemType == null) return;
            ShowStockItemTypeDetails(CurrentStockItemType);
        }

        private void ShowStockItemTypeDetails(StockItemType stockItemType)
        {
            using (var stockItemTypeView = new AddEditStockItemTypeView(stockItemType))
            {
                stockItemTypeView.StockItemTypeSaving += StockItemSavingEvent;
                stockItemTypeView.ShowDialog();
            }
        }

        private void StockItemSavingEvent(object sender, StockItemTypeSavingEventArgs e)
        {
            ((AddEditStockItemTypeView)sender).Close();
            var stockItemTypeBeingSaved = e.StockItemType;
            if (stockItemTypeBeingSaved.Id == 0)
            {
                stockItemTypeBeingSaved = _dataManager.AddNewStockItemType(stockItemTypeBeingSaved);
                stockItemTypeBindingSource.Add(stockItemTypeBeingSaved);
            }
            else
            {
                stockItemTypeBeingSaved = _dataManager.UpdateStockItemType(stockItemTypeBeingSaved);
            }
        }

        public StockItemType CurrentStockItemType
        {
            get
            {
                return stockItemTypeBindingSource.Current as StockItemType;
            }
        }

        private void stockItemTypeBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            //stockItemTypeBindingSource.ResetBindings(false);
        }

        private void barButtonItem_NewItemType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowStockItemTypeDetails(new StockItemType());
        }

        private void gridView_StockItemTypes_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu1.ShowPopup(MousePosition);
        }

        private void gridView_StockItemTypes_DoubleClick(object sender, EventArgs e)
        {
            if (CurrentStockItemType == null) return;
            ShowStockItemTypeDetails(CurrentStockItemType);
        }
    }
}
