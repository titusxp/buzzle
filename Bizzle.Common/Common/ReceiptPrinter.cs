using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Buzzle.DataModel;

namespace Bizzle.Common.Common
{
    public class ReceiptPrinter
    {
        private Sale SaleToBePrinted;
        private Job JobToBePrinted;
        private Company Company = new Company();// BuzzleFunctions.GetCompanyInfo();
        public void PrintSaleReceipt(Sale saleToBePrinted)
        {
            SaleToBePrinted = saleToBePrinted;

            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += printSale_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printSale_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);

            SolidBrush brush = new SolidBrush(Color.Black);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offSet = 85;
            int logoOffsetX = 85;
            int logoOffsetY = 0;



            if (Company != null && Company.CompanyLogo != null)
            {
                Image companyLogo = (Image)new ImageConverter().ConvertFrom(Company.CompanyLogo);
                companyLogo = BuzzleFunctions.ResizeImage(companyLogo, new Size(80, 80));
                graphic.DrawImage(companyLogo, startX, startY);
            }

            graphic.DrawString(Company.CompanyName + " - Sales Receipt", new Font("Arial", 16, FontStyle.Bold), brush, startX + logoOffsetX, startY + logoOffsetY);
            logoOffsetY += 25;

            var headerString = string.Format("Sale No. {0:00000} {2}Customer Name: {3}{2}Date: {1:dd MMM yyyy hh:mm}", SaleToBePrinted.Id, SaleToBePrinted.DateRecorded, Environment.NewLine, SaleToBePrinted.CustomerName);
            graphic.DrawString(headerString, new Font("Courier New", 12, FontStyle.Italic), brush, startX + logoOffsetX, startY + logoOffsetY);

            var saleHeaderString = string.Format("{0}{1}{2}",
                    "Item".PadRight(30), "Quantity", "Total".PadLeft(12));
            graphic.DrawString(saleHeaderString, new Font("Courier New", 12), brush, startX, startY + offSet);
            offSet += (int)fontHeight + 5;

            graphic.DrawLine(new Pen(brush), startX, startY + offSet, startX + 550, startY + offSet);
            
            foreach (SaleItem saleItem in SaleToBePrinted.SaleItems)
            {
                var saleItemString = string.Format("{0}{1}{2}",
                    saleItem.StockItemType.FullStockItemName.PadRight(30), saleItem.Quantity, 
                    saleItem.TotalSoldPrice.ToString().PadLeft(17) + " CFA");
                graphic.DrawString(saleItemString, font, brush, startX, startY + offSet);
                offSet += (int)fontHeight + 5;
            }
            offSet += 20;
            graphic.DrawString("Total: ".PadLeft(42) + SaleToBePrinted.SaleItems.Select(item => item.TotalSoldPrice).Sum() + " CFA", font, brush, startX, startY + offSet);
            offSet += 20;

            graphic.DrawLine(new Pen(brush), startX, startY + offSet, startX + 550, startY + offSet);

            graphic.DrawString("You were served by " + BuzzleFunctions.GetCurrentUser().FullName, new Font("Courier New", 12, FontStyle.Italic), brush, startX, startY + offSet);

        }



        public void PrintJobReceipt(Job jobToBePrinted)
        {
            JobToBePrinted = jobToBePrinted;

            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += printJob_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printJob_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);

            SolidBrush brush = new SolidBrush(Color.Black);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offSet = 110;
            int logoOffsetX = 110;
            int logoOffsetY = 0;



            if (Company != null && Company.CompanyLogo != null)
            {
                Image companyLogo = (Image)new ImageConverter().ConvertFrom(Company.CompanyLogo);
                companyLogo = BuzzleFunctions.ResizeImage(companyLogo, new Size(100, 100));
                graphic.DrawImage(companyLogo, startX, startY);
            }

            graphic.DrawString(Company.CompanyName + " - Jobs Receipt", new Font("Arial", 16, FontStyle.Bold), brush, startX + logoOffsetX, startY + logoOffsetY);
            logoOffsetY += 25;

            string customerName = string.IsNullOrWhiteSpace(JobToBePrinted.CustomerName) ? "Unavailable" : JobToBePrinted.CustomerName;


            var headerString = string.Format("Job No. {0:00000} {2}Customer Name: {3}{2}Date Started: {1:dd MMM yyyy hh:mm} {2}Date Completed: {4:dd MMM yyyy hh:mm}", JobToBePrinted.Id, JobToBePrinted.DateCreated, Environment.NewLine, customerName, JobToBePrinted.EndDate);

            graphic.DrawString(headerString, new Font("Courier New", 12, FontStyle.Italic), brush, startX + logoOffsetX, startY + logoOffsetY);

            graphic.DrawLine(new Pen(brush), startX, startY + offSet, startX + 550, startY + offSet);
            graphic.DrawString("Item: " + JobToBePrinted.JobItemType.ItemName + " " + JobToBePrinted.ItemDescription, new Font("Courier New", 13), brush, startX, startY + offSet);
            offSet += 20;

            graphic.DrawString("Fault: " + JobToBePrinted.FaultType.FaultName + " " + JobToBePrinted.FaultDescription, new Font("Courier New", 13), brush, startX, startY + offSet);

            offSet += 40;
            graphic.DrawString("Total Paid: ".PadLeft(42) + JobToBePrinted.TotalAmountPaid + " CFA", font, brush, startX, startY + offSet);
            offSet += 20;

            graphic.DrawLine(new Pen(brush), startX, startY + offSet, startX + 550, startY + offSet);

            graphic.DrawString("You were served by " + BuzzleFunctions.GetCurrentUser().FullName, new Font("Courier New", 12, FontStyle.Italic), brush, startX, startY + offSet);

        }        
    }
}
