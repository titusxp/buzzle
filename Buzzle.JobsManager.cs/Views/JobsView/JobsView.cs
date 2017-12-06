using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bizzle.Common.Common;
using Bizzle.Common.Views;
using Buzzle.Api.Core;
using Buzzle.Finances;
using Buzzle.Client.Ui;
using Buzzle.DataModel;
using DevExpress.XtraBars;

namespace Buzzle.JobsManager.Views.JobsView
{
    public partial class JobsView : BuzzleGlobalView
    {
        private DataManager _dataManager;
        private ReceiptPrinter _receiptPrinter;

        public JobsView()
        {
            InitializeComponent();
            if (this.IsRuntime)
            {
                InitializeVariables();
                LoadAllJobs();
            }
        }

        private void InitializeVariables()
        {
            _dataManager = new DataManager();
            _receiptPrinter = new ReceiptPrinter();
        }

        private void LoadAllJobs()
        {
            JobsBindingSource.DataSource = _dataManager.GetAllJobs();
        }

        private Job CurrentJob
        {
            get
            {
                return JobsBindingSource.Current as Job;
            }
        }

        private void gridView_Jobs_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu1.ShowPopup(MousePosition);
        }

        private void barButtonItem_ViewEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentJob == null) return;
            ShowJobDetails(CurrentJob);
        }

        private void ShowJobDetails(Job thisJob)
        {
            ShowWaitForm();
            using (var jobDetailsView = new AddEditJobView(thisJob))
            {
                jobDetailsView.SaveButtonClicked += SaveChanges;
                jobDetailsView.RecordJobPaymentButtonClicked += RecordJobPaymentButtonClicked;
                HideWaitForm();
                jobDetailsView.ShowDialog();
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var jobTobeSaved = (e as BuzzleSaveJobViewEventArgs).JobToBeSaved;
            SaveOrUpdateJob(jobTobeSaved);

            //Close the Form
            var senderForm = sender as BuzzleGlobalView;
            senderForm.Close();
        }

        private void SaveOrUpdateJob(Job thisJob)
        {
            if (thisJob.Id < 1)
            {
                _dataManager.AddJob(thisJob);
                JobsBindingSource.Add(thisJob);
            }
            else
            {
                _dataManager.UpdateJob(thisJob);
            }
        }

        private void SaveAllNewJobs()
        {
            var allJobs = JobsBindingSource.DataSource as List<Job>;
            foreach (var job in allJobs.Where(job => job.Id < 1))
            {
                _dataManager.AddJob(job);
            }
        }

        private void gridView_Jobs_DoubleClick(object sender, EventArgs e)
        {
            ShowJobDetails(CurrentJob);
        }

        private void barButtonItem_NewJob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowJobDetails(CreateJob());
        }

       

        private Job CreateJob()
        {
            return new Job()
            {
                DateCreated = DateTime.Now
            };
        }

        private void barButtonItem_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.AskQuestion();
            CancelJob();
            RefreshButtons();
        }

        private void CancelJob()
        {
            CurrentJob.IsCancel = true;
            SaveCurrentJob();
        }

        private void SaveCurrentJob()
        {
            _dataManager.UpdateJob(CurrentJob);
        }

        private void barButtonItem_Collected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            const string question = "This can't be undone, are you sure?";
            BuzzleFunctions.AskQuestion(question);
            MarkAsCollected();
            RefreshButtons();
        }

        private void MarkAsCollected()
        {
            CurrentJob.IsCollected = true;
            CurrentJob.IsCancel = false;
            SaveCurrentJob();
        }

        private void RefreshButtons()
        {
            EnableOrDisable(barButtonItem_Cancel, !CurrentJob.IsPaid && !CurrentJob.IsCancel);
            EnableOrDisable(barButtonItem_Collected, CurrentJob.IsPaidWaitingCollection && !CurrentJob.IsCancel);
            EnableOrDisable(barButtonItem_Pay, CurrentJob.IsFixedWaitingPayment && !CurrentJob.IsCancel);
            EnableOrDisable(barButtonItem_Revert, CurrentJob.IsFixedWaitingPayment || CurrentJob.IsCancel);
            EnableOrDisable(barButtonItem_Fixed, CurrentJob.IsPending && !CurrentJob.IsCancel);
            EnableOrDisable(barButtonItem_PrintReceipt, CurrentJob.IsCompleted);
        }

        private void EnableOrDisable(BarItem thisControl, bool Enable)
        {
            thisControl.Enabled = Enable;
        }

        private void JobsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (CurrentJob == null) return;
            RefreshButtons();
        }

        private void RecordJobPaymentButtonClicked(object sender, EventArgs e)
        {
            BuzzleFunctions.ShowWaitForm();

            var jobsTransactionType = _dataManager.GetJobsTransactionType();

            if (jobsTransactionType == null)
            {
                BuzzleFunctions.ShowMessage(
                    "No transaction type set for job payments. Please go to the general settings tab on the settings page and set a transaction type for job payments",
                    "Cannot record job payments");
                return;
            }

            using (var newTransactionView = new AddTransactionView(jobsTransactionType))
            {
                newTransactionView.TransactionReady += RecordJobPayment;
                BuzzleFunctions.HideWaitForm();
                newTransactionView.ShowDialog();
            }
        }

        private void barButtonItem_Pay_ItemClick(object sender, ItemClickEventArgs e)
        {
            RecordJobPaymentButtonClicked(this, e);
        }

        private void RecordJobPayment(object sender, EventArgs e)
        {
            var transactionToBeSaved = ((BuzzleSaveTransactionEventArgs)e).TransactionToBeSaved;
            
            transactionToBeSaved = _dataManager.AddTransaction(transactionToBeSaved);
            _dataManager.AddJobPayment(new JobPayment
            {
                Id = CurrentJob.Id,
                TransactionID = transactionToBeSaved.Id
            });
            CurrentJob.IsPaid = true;
            CurrentJob.EndDate = DateTime.Now;
            SaveCurrentJob();
            _receiptPrinter.PrintJobReceipt(CurrentJob);
        }

        private void barButtonItem_Revert_ItemClick(object sender, ItemClickEventArgs e)
        {
            RevertToPending();
            RefreshButtons();
        }

        private void RevertToPending()
        {
            CurrentJob.IsFixed = false;
            CurrentJob.IsCancel = false;
            SaveCurrentJob();
        }

        private void barButtonItem_Fixed_ItemClick(object sender, ItemClickEventArgs e)
        {
            MarkAsFixed();
            RefreshButtons();
        }

        private void MarkAsFixed()
        {
            CurrentJob.IsFixed = true;
            CurrentJob.IsCancel = false;
            SaveCurrentJob();
        }

        private void barButtonItem_PrintReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CurrentJob == null || !CurrentJob.IsCompleted)
            {
                BuzzleFunctions.ShowMessage("Only receipts of Completed jobs can be printed", "Cannot print receipt");
                return;
            }
            _receiptPrinter.PrintJobReceipt(CurrentJob);
        }
    }
}
