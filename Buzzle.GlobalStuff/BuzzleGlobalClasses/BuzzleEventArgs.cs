using System;
using System.Security.Permissions;
using Buzzle.Data;
using Buzzle.Data.DataModel;
using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace Buzzle.GlobalStuff
{
    public class BuzzleNotesEventArgs : EventArgs
    {
        public string Note;
    }

    public class BuzzleSaveJobViewEventArgs : EventArgs
    {
        public Job JobToBeSaved;
    }

    public class BuzzleSaveTransactionEventArgs : EventArgs
    {
        public Transaction TransactionToBeSaved;
    }

    public class StockItemTypeSavingEventArgs : EventArgs
    {
        public StockItemType StockItemType { get; set; }
    }

    public class BuzzleCredentialsEvetArgs : EventArgs
    {
        public string Userame { get; set; }
        public string Password { get; set; }
    }

    public class BuzzleUserEventArgs : EventArgs
    {
        public User UserToBeSaved { get; set; }
    }

    public class PurchaseSavingEventArgs : EventArgs
    {
        public Purchase PurchaseBeingSaved { get; set; }
    }

    public class SupplySavingEventArgs : EventArgs
    {
        public Supply SupplyBeingSaved { get; set; }
        public Purchase PurchaseBeingUpdated { get; set; }

        //public List<SupplyItem> SupplyItems { get; set; }
    }

    public class SaleSavingArgs : EventArgs
    {
        public Sale Sale { get; set; }
        public bool PrintCommandPassed { get; set; }
    }



    

    //public class BuzzleStockItemArgs : EventArgs
    //{
    //    public StockItem StockItem { get; set; } 
    //}
}
