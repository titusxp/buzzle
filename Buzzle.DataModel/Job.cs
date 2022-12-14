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
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.JobHistories = new HashSet<JobHistory>();
            this.JobPayments = new HashSet<JobPayment>();
        }
    
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int ItemTypeID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Notes { get; set; }
        public string ItemDescription { get; set; }
        public int FaultTypeID { get; set; }
        public string FaultDescription { get; set; }
        public Nullable<int> CustomerPhoneNumber { get; set; }
        public bool IsPaid { get; set; }
        public bool IsCollected { get; set; }
        public bool IsFixed { get; set; }
        public bool IsCancel { get; set; }
        public int CreatorUserID { get; set; }
    
        public virtual FaultType FaultType { get; set; }
        public virtual JobItemType JobItemType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobHistory> JobHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobPayment> JobPayments { get; set; }
        public virtual User CreatorUser { get; set; }
    }
}
