using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buzzle.Data.DataModel
{
    public partial class StockItemType
    {
        public string FullStockItemName
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.Model) ? 
                    string.Format("{0} ({1})", this.StockItemName, this.Model) :
                    this.StockItemName;
            }
        }
    }
}
