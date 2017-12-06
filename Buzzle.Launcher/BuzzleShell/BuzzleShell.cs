using System;
using System.Windows.Forms;
using Bizzle.Common.Common;
using Bizzle.Common.Views;
using Buzzle.Finances;
using Buzzle.Client.Ui;
using Buzzle.JobsManager.Views.JobsView;
using Buzzle.Sales.Views;

namespace Buzzle.Launcher
{
    public partial class BuzzleShell : BuzzleGlobalView
    {
        private FormManager _formManager;

        public BuzzleShell()
        {
            InitializeComponent();
            _formManager = new FormManager(navBarControl_Shell);
            this.Text = string.Format("Buzzle 1.1 -- {0}", CurrentlyLoggedInUser.FullName);
            HandleFormManagerEvents();
            UpdateSessionMonitor();
            HideWaitForm();
        }

        private void UpdateSessionMonitor()
        {label_LoginTime.Text = string.Format("buzzler: {1}{0}Login Time {2: hh:mmtt (dd MMM yyyy)}{0}PC: {3}",
                Environment.NewLine, CurrentlyLoggedInUser.FullName, DateTime.Now, Environment.MachineName);
        }

        private void HandleFormManagerEvents()
        {
            _formManager.FormAdded += FormManager_FormAdded;
            _formManager.FormClosed += FormManager_FormClosed;
            _formManager.CurrentFormChanged += FormManager_CurrentFormChanged;
        }

        private void FormManager_CurrentFormChanged(object sender, EventArgs e)
        {
            ShowForm(CurrentForm);
        }

        private void ShowForm(BuzzleGlobalView thisForm)
        {
            ClearScreen();
            if (thisForm == null)
            {
                return;
            }
            this.IsMdiContainer = true;
            thisForm.TopLevel = false;
            panel_Display.Controls.Add(thisForm);
            thisForm.FormBorderStyle = FormBorderStyle.None;
            thisForm.Dock = DockStyle.Fill;
            thisForm.Show();
        }

       

        private void ClearScreen()
        {
            panel_Display.Controls.Clear();
        }

        private void FormManager_FormClosed(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void FormManager_FormAdded(object sender, EventArgs e)
        {
            var addedForm = ((FormManagerEventArgs) e).FormInQuestion;
            ShowForm(addedForm);
        }

        private BuzzleGlobalView CurrentForm
        {
            get { return _formManager.GetCurrentForm(); }
        }

        private void barButtonItem_Jobs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowJobsView();
        }

        private void ShowJobsView()
        {
            ShowWaitForm("Loading Jobs View...");
            var jobsView = new JobsView();
            _formManager.OpenForm(jobsView);
            BuzzleFunctions.HideWaitForm();
        }

        private void panel_Display_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton_CloseCurrent_Click(object sender, EventArgs e)
        {
            if (CurrentForm == null) return;
            ShowWaitForm();
            _formManager.CloseForm(CurrentForm);
            HideWaitForm();
        }

        private void simpleButton_MinimizeCurrent_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void panel_Display_ControlAdded(object sender, ControlEventArgs e)
        {
            HideOrShowButtons();
        }

        private void HideOrShowButtons()
        {
            simpleButton_CloseCurrent.Enabled
                = simpleButton_MinimizeCurrent.Enabled
                = panel_Display.Controls.Count > 0;
        }

        private void barButtonItem_Settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowSettingsView();
        }

        private void ShowSettingsView()
        {
            ShowWaitForm("Loading Settings...");
            var settingsView = new BuzzleSettingsView();
            _formManager.OpenForm(settingsView);
            BuzzleFunctions.HideWaitForm();
        }

        private void simpleButton_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuzzleShell_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to stop buzzling?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void ShowTrasactionsView()
        {
            ShowWaitForm("Loading Transactions...");
            var trasactionsView = new TransactionsView();
            _formManager.OpenForm(trasactionsView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_Transactions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowTrasactionsView();
        }

        private void ShowStockItemTypesView()
        {
            ShowWaitForm("Loading Stock Item Types...");
            var stockItemTypesView = new StockItemTypesView();
            _formManager.OpenForm(stockItemTypesView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_StockItemTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowStockItemTypesView();
        }

        private void ShowPurchasesView()
        {
            ShowWaitForm("Loading purchases...");
            var purchasesView = new PurchasesView();
            _formManager.OpenForm(purchasesView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_Purchases_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowPurchasesView();
        }

        private void ShowItemsInStockView()
        {
            ShowWaitForm("Loading items in stock...");
            var itemsInStockView = new ItemsInStockView();
            _formManager.OpenForm(itemsInStockView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_ItemsInStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowItemsInStockView();
        }

        private void barButtonItem_Deliveries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDeliveriesView();
        }

        private void ShowDeliveriesView()
        {
            ShowWaitForm("Loading deliveries...");
            var suppliesView = new SuppliesView();
            _formManager.OpenForm(suppliesView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_Sales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowSalesView();
        }

        private void ShowSalesView()
        {
            ShowWaitForm("Loading Sales...");
            var salesView = new SalesView();
            _formManager.OpenForm(salesView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_CompanySettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowCompanySettingsView();
        }

        private void ShowCompanySettingsView()
        {
            ShowWaitForm("Loading Company Settings...");
            var companySettingsView = new CompanySettingsView();
            BuzzleFunctions.HideWaitForm();
            companySettingsView.ShowDialog();            
        }

        private void ShowSalesReportView()
        {
            ShowWaitForm("Loading Sales Report view...");
            var salesReportView = new Buzzle.Reports.Views.SalesReportView();
            _formManager.OpenForm(salesReportView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_General_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowSettingsView();
        }
       

        private void barButtonItem_SalesReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowSalesReportView();
        }

        private void barSubItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //BuzzleFunctions.ShowMessage("This feature is not avaliable in this version of Buzzle", "");
        }

        private void barButtonItem_JobSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowJobSettingsView();
        }

        private void ShowJobSettingsView()
        {
            ShowWaitForm("Loading Job Settings view...");
            var jobSettignsView = new JobSettingsView();
            _formManager.OpenForm(jobSettignsView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_Users_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUsersView();
        }

        private void ShowUsersView()
        {
            ShowWaitForm("Loading Users...");
            var usersView = new UsersView();
            _formManager.OpenForm(usersView);
            BuzzleFunctions.HideWaitForm();
        }

        private void barButtonItem_AccountSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAccountSettingsView();
        }

        private void ShowAccountSettingsView()
        {
            ShowWaitForm("Loading Account settings...");
            var accountSettingsView = new AccountsSettingsView();
            _formManager.OpenForm(accountSettingsView);
            HideWaitForm();
        }

        private void barButtonItem_TransactionTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowTransactionTypesView();
        }

        private void ShowTransactionTypesView()
        {
            ShowWaitForm("Loading Transaction Types...");
            var transactionTypesView = new TransactionTypesView();
            _formManager.OpenForm(transactionTypesView);
            HideWaitForm();
        }


        
        
    }
}

