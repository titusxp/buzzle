using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buzzle.Data.DataModel
{
    public partial class Job
    {
        Lazy<BuzzleTFEntities> _dataBaseEntity = new Lazy<BuzzleTFEntities>();

        public int TotalAmountPaid
        {
            get
            {
                return _dataBaseEntity.Value.ExecuteStoreQuery<int>("EXEC [dbo].[GetJobPaymentAmount] @JobID = " + this.JobID).FirstOrDefault();
            }
        }
    }
}
