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
    public partial class AddTransactionView : BuzzleGlobalView
    {
        private DataManager _dataManager;
        private readonly TransactionType _preferredTransactionType;
        public EventHandler<BuzzleSaveTransactionEventArgs> TransactionReady { get; set; }

        public AddTransactionView(TransactionType preferedTransactionType = null)
        {
            InitializeComponent();
            _preferredTransactionType = preferedTransactionType;
            InstantiateVariables();
        }

        private void InstantiateVariables()
        {
            _dataManager = new DataManager();
            lookupEdit_TransactionType.Properties.DataSource = _dataManager.GetAllTransactionTypes();

            memoEdit_Notes.Text = "[Provide details of the transaction]";

            if (_preferredTransactionType != null)
            {
                lookupEdit_TransactionType.EditValue = _preferredTransactionType.TransactionTypeID;
                lookupEdit_TransactionType.Properties.ReadOnly = true;
            }

            textBox_RecordedBy.Text = CurrentlyLoggedInUser.FullName;
        }

        private void AddTransactionView_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (AllFieldsAreValid() != true) 
                return;

            var currentTransaction = new Transaction()
            {
                TransactionTypeID = int.Parse(lookupEdit_TransactionType.EditValue.ToString()),
                Amount = (int) textEdit_Amount.EditValue,
                Notes = memoEdit_Notes.EditValue.ToString(),
                DateRecorded = DateTime.Now,
                RecordedByUserID = CurrentlyLoggedInUser.UserID
            };
            var evtArgs = new BuzzleSaveTransactionEventArgs()
            {
                TransactionToBeSaved = currentTransaction
            };
            TransactionReady(this, evtArgs);

            this.Close();
        }

        public bool AllFieldsAreValid()
        {
            return BuzzleValidator.IsNotEmpty(lookupEdit_TransactionType.EditValue, "Transaction Type")
                && BuzzleValidator.IsNotEmpty(textEdit_Amount.Text, "Amount");
        }
    }
}
