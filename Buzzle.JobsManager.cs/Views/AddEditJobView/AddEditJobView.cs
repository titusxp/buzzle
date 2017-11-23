using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Buzzle.Data;
using Buzzle.Data.DataModel;
using Buzzle.Finances;
using Buzzle.GlobalStuff;
using DevExpress.XtraBars;
using DevExpress.XtraRichEdit.API.Word;

namespace Buzzle.JobsManager.Views
{
    public partial class AddEditJobView : BuzzleGlobalView
    {
        public event EventHandler SaveButtonClicked;
        public event EventHandler RecordJobPaymentButtonClicked;

        private DataManager _dataManager;
        private List<JobItemType> _allItemTypes;
        private List<FaultType> _allFaultTypes; 

        private Job _currentJob;

        public AddEditJobView(Job thisJob)
        {
            InitializeComponent();
            if (!IsRuntime) return;
            _currentJob = thisJob;
            InitializeStuff();
            BindDataSources();
            UpdateCurrentJobFaultType();
            UpdateCurrentJobItemType();
            UpDateOrSetJobCreator();
        }

        private void UpDateOrSetJobCreator()
        {
            if (_currentJob.JobID < 1)
            {
                _currentJob.CreatorUserID = CurrentlyLoggedInUser.UserID;
                textEdit_CreatedBy.Text = CurrentlyLoggedInUser.FullName;
            }
            else
            {
                textEdit_CreatedBy.Text = _currentJob.CreatorUser.FullName;
            }
        }

        private string CurrentItemType
        {
            get { return comboEdit_ItemType.Text; }
            set { comboEdit_ItemType.Text = value; }
        }

        private string CurrentFaultType
        {
            get { return comboEdit_FaultType.Text; }
            set { comboEdit_FaultType.Text = value; }
        }

        private void InitializeStuff()
        {
            _dataManager = new DataManager();
            _allFaultTypes = new List<FaultType>();
            _allItemTypes = new List<JobItemType>();
        }

        private void BindDataSources()
        {
            _allItemTypes = _dataManager.GetAllItemTypes();
            _allFaultTypes = _dataManager.GetAllFaultTypes();
            jobBindingSource.DataSource = _currentJob;
            LoadJobPayments();
            InitializeComboEdits();
        }

        private void InitializeComboEdits()
        {
            comboEdit_ItemType.Properties.Items.AddRange(_allItemTypes.Select(item => item.ItemName).ToList());
            
            comboEdit_FaultType.Properties.Items.AddRange(_allFaultTypes.Select(item => item.FaultName).ToList());
            
        }

        private void UpdateCurrentJobFaultType()
        {
            var firstOrDefault = _allFaultTypes.FirstOrDefault(item => item.FaultTypeID == _currentJob.FaultTypeID);
            CurrentFaultType =  (firstOrDefault != null)?
                firstOrDefault.FaultName: "";
        }

        private void UpdateCurrentJobItemType()
        {
            var firstOrDefault = _allItemTypes.FirstOrDefault(item => item.ItemTypeID == _currentJob.ItemTypeID);
            CurrentItemType = (firstOrDefault != null)?
                firstOrDefault.ItemName: "";
        }

        private void LoadJobPayments()
        {
            transactionBindingSource.DataSource = _currentJob.JobPayments.Select(payment => payment.Transaction);
        }

        private void barButtonItem_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuzzleFunctions.SwitchFocus(this);
            if (AllFieldsValid() != true) return;

            _currentJob.ItemTypeID = GetItemTypeID();
            _currentJob.FaultTypeID = GetFaultTypeID();

            var evtArgs = new BuzzleSaveJobViewEventArgs() {JobToBeSaved = _currentJob};
            SaveButtonClicked(this, evtArgs);
            if (this.IsDisposed != true)
            {
                RefreshButtons();
            }
        }

        private int GetFaultTypeID()
        {
            var firstOrDefault =
                _allFaultTypes.FirstOrDefault(fault => fault.FaultName.ToUpper() == CurrentFaultType.ToUpper());
            if (firstOrDefault != null) return firstOrDefault.FaultTypeID;
            return CreateNewFaultType().FaultTypeID;
        }

        private FaultType CreateNewFaultType()
        {
            return _dataManager.AddFaultType(new FaultType()
            {
                FaultName = CurrentFaultType
            });
        }

        private int GetItemTypeID()
        {
            var firstOrDefault =
                _allItemTypes.FirstOrDefault(item => item.ItemName.ToUpper() == CurrentItemType.ToUpper());
            if (firstOrDefault != null) return firstOrDefault.ItemTypeID;
            return CreateNewItemType().ItemTypeID;
        }

        private JobItemType CreateNewItemType()
        {
            return _dataManager.AddItemType(new JobItemType()
            {
                ItemName = CurrentItemType
            });
        }

        private void barButtonItem_AddNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWaitForm();
            using (var newNoteView = new AddNotesView())
            {
                newNoteView.AddButtonClicked += AddNote;
                HideWaitForm();
                newNoteView.ShowDialog();
            }
        }

        private void  AddNote(object sender, EventArgs e)
        {
            var newNote = ((BuzzleNotesEventArgs) e).Note;
            _currentJob.Notes = string.Concat(FormatNote(newNote), _currentJob.Notes);

            var sendingForm = sender as AddNotesView;
            sendingForm.Close();
        }

        private string FormatNote(string newNote)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{3}{1}<u>{0: dd MMM yyyy (hh:mm tt)}</u> {1}<font size=5>{2}</font>{1}{1}",
                DateTime.Now, "<br>", newNote, CurrentlyLoggedInUser.FullName);return stringBuilder.ToString();
        }

        private bool AllFieldsValid()
        {
            return
                BuzzleValidator.IsNotEmpty(textEdit_CustomerName.Text, "Customer Name") &&
                BuzzleValidator.IsNotEmpty(calcEdit_PhoneNumber.Text, "Phone Number") &&
                BuzzleValidator.IsNotEmpty(comboEdit_ItemType.Text, "Item type") &&
                BuzzleValidator.IsNotEmpty(comboEdit_FaultType.Text, "Fault type");
        }

        private void RefreshButtons()
        {
            EnableOrDisable(barButtonItem_Cancel, !_currentJob.IsPaid && !_currentJob.IsCancel);
            EnableOrDisable(barButtonItem_Collected, _currentJob.IsPaidWaitingCollection && !_currentJob.IsCancel);
            EnableOrDisable(barButtonItem_Pay, _currentJob.IsFixedWaitingPayment && !_currentJob.IsCancel);
            EnableOrDisable(barButtonItem_Revert, _currentJob.IsFixedWaitingPayment || _currentJob.IsCancel);
            EnableOrDisable(barButtonItem_Fixed, _currentJob.IsPending && !_currentJob.IsCancel);
            EnableOrDisable(barButtonItem_Pay, _currentJob.JobID > 0);
        }

        private void EnableOrDisable(BarItem thisControl, bool enable)
        {
            thisControl.Enabled = enable;
        }

        private void barButtonItem_Cancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            _currentJob.IsCancel = true;
            RefreshButtons();
        }

        private void barButtonItem_Pay_ItemClick(object sender, ItemClickEventArgs e)
        {
            RecordJobPaymentButtonClicked(this, new EventArgs());
        }

        private void barButtonItem_Collected_ItemClick(object sender, ItemClickEventArgs e)
        {
            _currentJob.IsCollected = true;
            _currentJob.IsCancel = false;
            RefreshButtons();
        }

        private void barButtonItem_Fixed_ItemClick(object sender, ItemClickEventArgs e)
        {
            _currentJob.IsFixed = true;
            _currentJob.IsCancel = false;
            RefreshButtons();
        }

        private void barButtonItem_Revert_ItemClick(object sender, ItemClickEventArgs e)
        {
            _currentJob.IsFixed = false;
            _currentJob.IsCancel = false;
            RefreshButtons();
        }

        private void AddEditJobView_Load(object sender, EventArgs e)
        {
            RefreshButtons();
        }
    }
}
