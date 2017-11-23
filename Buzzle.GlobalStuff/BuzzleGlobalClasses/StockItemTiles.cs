using Buzzle.Data.DataModel;
using DevExpress.XtraEditors;

namespace Buzzle.GlobalStuff
{
    public class StockItemTile : TileItem
    {
        public StockItemTile(StockItemBalance thisStockItem = null)
        {
            ItemSize = TileItemSize.Medium;
            AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(255, ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            AppearanceItem.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            AppearanceItem.Hovered.Options.UseBackColor = true;
            AppearanceItem.Hovered.Options.UseFont = true;
            AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            AppearanceItem.Normal.Options.UseFont = true;
            TextAlignment = TileItemContentAlignment.MiddleCenter;

            if (thisStockItem != null)
            {
                StockBalance = thisStockItem;
                if (!string.IsNullOrWhiteSpace(thisStockItem.StockItemName))
                {
                    this.Text = thisStockItem.StockItemName;
                    this.Text2 = thisStockItem.QuantityInStock.Value.ToString("0,# CFA");}
            }
        }

        public StockItemBalance StockBalance { get; set; }
    }
}
