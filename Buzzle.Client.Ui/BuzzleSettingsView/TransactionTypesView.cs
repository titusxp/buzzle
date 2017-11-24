using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data;

using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;

namespace Buzzle.Client.Ui
{
    public partial class TransactionTypesView : BuzzleGlobalView
    {
        private DataManager _dataManager;

        public TransactionTypesView()
        {
            InitializeComponent();
            InitializeTransactionTypesSection();
        }       

        #region Transaction Types

        private DataManager _transactionTypesManager;

        private void InitializeTransactionTypesSection()
        {
            _transactionTypesManager = new DataManager();
            repoLookUpEdit_Accounts.DataSource = _transactionTypesManager.GetAllAccounts();
            LoadTransactionTypes();
        }

        private void LoadTransactionTypes()
        {
            transactionTypeBindingSource.DataSource = _transactionTypesManager.GetAllTransactionTypes();
        }

        private void barButtonItem_SaveTransactionTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.SwitchFocus(this, gridView_TransactionTypes);
            _transactionTypesManager.SaveChangesToDataBase();
            BuzzleFunctions.ShowMessage("Saved Successfully", "");
        }
        
        private void barButtonItem_RefreshTransactionTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitializeTransactionTypesSection();
        }

        #endregion
    }
}
