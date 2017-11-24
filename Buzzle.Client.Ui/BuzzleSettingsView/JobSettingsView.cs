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
using Buzzle.DataModel;

namespace Buzzle.Client.Ui
{
    public partial class JobSettingsView : BuzzleGlobalView
    {
        private DataManager _dataManager;

        public JobSettingsView()
        {
            InitializeComponent();
            InitializeVariables();
            BindDataToControls();
        }
        

#region JobSettings
        private List<FaultType> _deletedFaultTypes;
        private List<JobItemType> _deletedItemTypes;

        private List<JobItemType> ItemTypes
        {
            get
            {
                return ItemTypeBindingSource.DataSource as List<JobItemType>;
            }
        }

        private List<FaultType> FaultTypes
        {
            get
            {
                return faultTypeBindingSource.DataSource as List<FaultType>;
            }
        } 

        

        private void BindDataToControls()
        {
            ItemTypeBindingSource.DataSource = _dataManager.GetAllItemTypes();
            faultTypeBindingSource.DataSource = _dataManager.GetAllFaultTypes();
        }

        private void InitializeVariables()
        {
            _dataManager = new DataManager();
            _deletedItemTypes = new List<JobItemType>();
            _deletedFaultTypes = new List<FaultType>();
        }

        private void barButtonItem_SaveJobSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.SwitchFocus(this);
            _dataManager.SaveChangesToDataBase();
            SaveNewItemTypes();
            SaveNewJobTypes();

            SaveAllDeletions();

            BuzzleFunctions.ShowMessage("All Changes Saved Successfully", "Success");
        }

        private void SaveAllDeletions()
        {
            if (_deletedFaultTypes.Any())
            {
                _deletedFaultTypes.ForEach(_dataManager.RemoveFaultType);
            }

            if (_deletedItemTypes.Any())
            {
                _deletedItemTypes.ForEach(_dataManager.RemoveItemType);
            }
        }

        private void SaveNewJobTypes()
        {
            foreach(var item in ItemTypes.Where(item => item.ItemTypeID < 1))
            {
                item.ItemTypeID = _dataManager.AddItemType(item).ItemTypeID;
            }
        }

        private void SaveNewItemTypes()
        {
            foreach (var faultType in FaultTypes.Where(faultType => faultType.FaultTypeID < 1))
            {
                faultType.FaultTypeID = _dataManager.AddFaultType(faultType).FaultTypeID;
            }
        }

        private JobItemType SelectedItemType
        {
            get { return ItemTypeBindingSource.Current as JobItemType; }
        }

        private FaultType SelectedFaultType
        {
            get { return faultTypeBindingSource.Current as FaultType; }
        }

        private void barButtonItem_RemoveItemType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SelectedItemType == null) return;
            _deletedItemTypes.Add(SelectedItemType);
            ItemTypeBindingSource.RemoveCurrent();
        }

        private void barButtonItem_RemoveFault_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SelectedFaultType == null) return;
            _deletedFaultTypes.Add(SelectedFaultType);
            faultTypeBindingSource.RemoveCurrent();
        }

        private void gridView_ItemTypes_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu_ItemTypes.ShowPopup(MousePosition);
        }

        private void gridView_FaultTypes_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu_Fault.ShowPopup(MousePosition);
        }

#endregion

    }
}
