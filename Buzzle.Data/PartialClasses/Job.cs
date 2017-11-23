using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buzzle.Data.DataModel
{
    public partial class Job
    {
        public string Status
        {
            get
            {
                if (IsCancel)
                    return "Cancelled";
                if (IsPending)
                    return "Pending";
                if (IsFixedWaitingPayment)
                    return "Fixed, Awaiting Payment";
                if (IsPaidWaitingCollection)
                    return "Paid, Awaiting Collection";
                if (IsCompleted)
                    return "Completed";
                return "Unknown";
            }
        }

        public bool IsPending
        {
            get { return !IsFixed; }
        }

        public bool IsFixedWaitingPayment
        {
            get { return IsFixed && !IsPaid && !IsCollected; }
        }

        public bool IsPaidWaitingCollection
        {
            get { return IsPaid && !IsCollected; }
        }

        public bool IsCompleted
        {
            get { return IsPaid && IsCollected; }
        }
    }
}
