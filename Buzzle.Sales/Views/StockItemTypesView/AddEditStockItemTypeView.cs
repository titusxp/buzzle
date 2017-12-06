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
using Buzzle.DataModel;
using Buzzle.Client.Ui;
using DevExpress.XtraLayout.Utils;

namespace Buzzle.Sales.Views
{
    public partial class AddEditStockItemTypeView : BuzzleGlobalView
    {
        public EventHandler<StockItemTypeSavingEventArgs> StockItemTypeSaving { get; set; }
        
        public AddEditStockItemTypeView(StockItemType stockItemType)
        {
            InitializeComponent();
            currentStockItemType = stockItemType;
            if (currentStockItemType.Id < 1)
            {
                layoutControlItem_FullName.Visibility = LayoutVisibility.Never;
            }
        }

        private void barButtonItem_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.SwitchFocus(this);
            if (!ValidationSucceeds())
                return;

            StockItemTypeSaving(this, new StockItemTypeSavingEventArgs(){StockItemType = currentStockItemType});
        }

        private StockItemType currentStockItemType
        {
            set
            {
                stockItemTypeBindingSource.DataSource = value;
            }
            get
            {
                return stockItemTypeBindingSource.Current as StockItemType;
            }
        }

        private bool ValidationSucceeds()
        {
            return
                BuzzleValidator.IsNotEmpty(currentStockItemType.StockItemName, "Stock Item Name") &&
                BuzzleValidator.IsNotLessThanOne(currentStockItemType.UnitSellingPrice, "Model");
        }
    }

    
}
