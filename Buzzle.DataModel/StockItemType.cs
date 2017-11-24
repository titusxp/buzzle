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
    
    public partial class StockItemType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockItemType()
        {
            this.PurchaseItems = new HashSet<PurchaseItem>();
            this.SaleItems = new HashSet<SaleItem>();
            this.StockItemMovements = new HashSet<StockItemMovement>();
            this.SupplyItems = new HashSet<SupplyItem>();
        }
    
        public int StockItemTypeID { get; set; }
        public string StockItemName { get; set; }
        public int UnitSellingPrice { get; set; }
        public string Notes { get; set; }
        public string Model { get; set; }
        public Nullable<int> UnitPurchasePrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleItem> SaleItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemMovement> StockItemMovements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyItem> SupplyItems { get; set; }
    }
}
