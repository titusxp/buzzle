//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buzzle.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleItem
    {
        public long SaleItemID { get; set; }
        public long SaleID { get; set; }
        public int StockItemTypeID { get; set; }
        public int UnitSoldPrice { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> TotalSoldPrice { get; set; }
        public int UnitPurchasePrice { get; set; }
    
        public virtual Sale Sale { get; set; }
        public virtual StockItemType StockItemType { get; set; }
    }
}