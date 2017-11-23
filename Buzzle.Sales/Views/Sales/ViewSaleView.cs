using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.GlobalStuff;
using Buzzle.Data.DataModel;

namespace Buzzle.Sales.Views
{
    public partial class ViewSaleView : BuzzleGlobalView
    {
        public ViewSaleView(Sale sale)
        {
            InitializeComponent();
            saleBindingSource.DataSource = sale;
            gridControl_SaleItems.DataSource = sale.SaleItems;
            label_Total.Text = string.Format("{0:0,# CFA}", sale.TotalSalesWorth);
        }
    }
}
