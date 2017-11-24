namespace Buzzle.DataModel
{
    public partial class StockItemType
    {
        public string FullStockItemName
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.Model) ? 
                    string.Format("{0} ({1})", this.StockItemName, this.Model) :
                    this.StockItemName;
            }
        }
    }
}
