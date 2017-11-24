using System;

namespace Buzzle.DataModel
{  
    public partial class Sale
    {
        public int TotalSalesWorth { get; set; }

        public string RecordedBy
        {
            get { return this.RecordedBy; }
        }
    }
}
