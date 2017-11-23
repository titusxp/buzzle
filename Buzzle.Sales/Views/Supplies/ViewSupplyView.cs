using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data.DataModel;
using Buzzle.GlobalStuff;

namespace Buzzle.Sales.Views
{
    public partial class ViewSupplyView : BuzzleGlobalView
    {
        public ViewSupplyView(Supply supply)
        {
            InitializeComponent();
            supplyBindingSource.DataSource = supply;
            gridControl_SupplyItems.DataSource = supply.SupplyItems;
            var totalSpent = supply.SupplyItems.Select(item => item.TotalSpent).Sum();
            if (totalSpent.HasValue != true) totalSpent = 0;
            label_TotalSpent.Text = string.Format("{0:0,#} CFA", totalSpent);
        }
    }
}
