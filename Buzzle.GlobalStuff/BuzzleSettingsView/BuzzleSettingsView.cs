﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data;
using Buzzle.Data.DataModel;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;

namespace Buzzle.GlobalStuff
{
    public partial class BuzzleSettingsView : BuzzleGlobalView
    {
        private DataManager _dataManager;

        public BuzzleSettingsView()
        {
            InitializeComponent();
            InitializeGeneralSettings();
        }

        private DataManager _generalSettingsManager;

        private void InitializeGeneralSettings()
        {
            _generalSettingsManager = _generalSettingsManager ?? new DataManager();
            LoadSalesTransactionType();
        }
             

        private void LoadSalesTransactionType()
        {
            lookUpEdit_SalesTransactionType.Properties.DataSource = _generalSettingsManager.GetAllTransactionTypes();

            var salesTransactionType = _generalSettingsManager.GetSalesTransactionTypeID();
            if (salesTransactionType == null)
            {
                _generalSettingsManager.CreateSalesTransactionTypeSetting();
                salesTransactionType = _generalSettingsManager.GetSalesTransactionTypeID();
            }
            lookUpEdit_SalesTransactionType.EditValue =
                salesTransactionType;
        }

        private void barButtonItem_SaveGeneralSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.SwitchFocus(this);

            if (lookUpEdit_SalesTransactionType.EditValue != null)
                _generalSettingsManager.SetSalesTransactionType(
                    (int.Parse(lookUpEdit_SalesTransactionType.EditValue.ToString())));
            BuzzleFunctions.ShowMessage("Saved Successfully", "");
        }


        

        

        
    }
}
