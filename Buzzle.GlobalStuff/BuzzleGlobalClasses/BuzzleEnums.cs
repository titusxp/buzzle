using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buzzle.GlobalStuff
{
    public static class BuzzleEnums
    {
        public enum LookupTableIDs
        {
            JobStatus = 1,
        }

        public enum PurshaseStatuses
        {
            Cancelled = 1,
            Completed = 2,
            Awaiting_Purchase = 3,
            Part_Supplied = 4
        }

        public enum StockMovementTypes
        {
            Stock_In = 1,
            Stock_Out = -1,
        }

        public enum StockMovementReasons
        {
            Damaged = 1,
            Expired = 2,
            Sales = 3,
            Incoming_Stock = 4
        }
    }
}
