using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buzzle.Data.DataModel
{  
    public partial class Sale
    {
        private Lazy<BuzzleTFEntities> _dataBaseContext = new Lazy<BuzzleTFEntities>();
        public int TotalSalesWorth
        {
            get { return _dataBaseContext.Value.SaleItems.Where(sitem => sitem.SaleID == this.SaleID).Select(item => item.TotalSoldPrice.Value).Sum(); }
        }

        public string RecordedBy
        {
            get
            {
                var recordingUser = _dataBaseContext.Value.Users.FirstOrDefault(user => user.UserID == this.RecordedByUserID);
                return recordingUser == null ? "" : recordingUser.FullName;
            }
        }
    }
}
