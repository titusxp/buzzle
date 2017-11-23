using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data;
using Buzzle.Data.DataModel;
using Buzzle.GlobalStuff;

namespace Buzzle.Finances
{
    public partial class TransactionsView : BuzzleGlobalView
    {
        private DataManager _dataManager;
        public TransactionsView()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            _dataManager = new DataManager();
            transactionBindingSource.DataSource = _dataManager.GetAllTransactions();
        }

        private void barButtonItem_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindData();
        }

        private void barButtonItem_ViewAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var accountsView = new AccountsView())
            {
                accountsView.ShowDialog();
            }}

        private void barButtonItem_NewTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowNewTransactionView();
        }

        private void ShowNewTransactionView()
        {
            using (var newTransactionView = new AddTransactionView())
            {
                newTransactionView.TransactionReady += NewTransactionView_TransactionSaved;
                newTransactionView.ShowDialog();
            }
        }

        private void NewTransactionView_TransactionSaved(object sender, BuzzleSaveTransactionEventArgs e)
        {
            ((AddTransactionView)sender).Close();
            SaveNewTransaction(e.TransactionToBeSaved);
        }

        private void SaveNewTransaction(Transaction transactionToBeSaved)
        {
            _dataManager.AddTransaction(transactionToBeSaved);
            BindData();
        }
    }
}
