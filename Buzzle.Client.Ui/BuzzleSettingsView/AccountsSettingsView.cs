using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizzle.Common.Common;
using Bizzle.Common.Views;
using Buzzle.Api.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;

namespace Buzzle.Client.Ui
{
    public partial class AccountsSettingsView : BuzzleGlobalView
    {
        private DataManager _dataManager;

        public AccountsSettingsView()
        {
            InitializeComponent();

            InitializeAccountsSection();
        }

        #region Account Settings

        private DataManager _accountsDataManager;

        private void InitializeAccountsSection()
        {
            _accountsDataManager = _accountsDataManager ?? new DataManager();
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            accountBindingSource.DataSource = _accountsDataManager.GetAllAccounts();
        }

        private void barButtonItem_SaveAccountSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.SwitchFocus(this, gridView_Accounts);
            _accountsDataManager.SaveChangesToDataBase();
            BuzzleFunctions.ShowMessage("Saved Successfully", "");
        }

        private void barButtonItem_RefreshAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitializeAccountsSection();
        }

        #endregion       

        

        
    }
}
