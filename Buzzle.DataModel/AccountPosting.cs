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
    
    public partial class AccountPosting
    {
        public int PostingID { get; set; }
        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public int PostingType { get; set; }
        public int Amount { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}