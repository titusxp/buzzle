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
    
    public partial class PurchaseItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseItem()
        {
            this.SupplyItems = new HashSet<SupplyItem>();
        }
    
        public int Id { get; set; }
        public int PurchaseID { get; set; }
        public int StockItemTypeID { get; set; }
        public int ProposedUnitPrice { get; set; }
        public string Notes { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> TotalProposedPrice { get; set; }
        public bool IsSupplied { get; set; }
    
        public virtual Purchase Purchase { get; set; }
        public virtual StockItemType StockItemType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyItem> SupplyItems { get; set; }
    }
}
