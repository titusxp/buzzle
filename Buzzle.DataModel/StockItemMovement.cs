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
    
    public partial class StockItemMovement
    {
        public int Id { get; set; }
        public int StockItemTypeID { get; set; }
        public int Quantity { get; set; }
        public int MovementType { get; set; }
        public Nullable<int> CalculatedValue { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public int UnitPurchasePrice { get; set; }
        public string MovementReason { get; set; }
        public Nullable<System.DateTime> DateRecorded { get; set; }
    
        public virtual StockItemType StockItemType { get; set; }
    }
}
