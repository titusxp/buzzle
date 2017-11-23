using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.GlobalStuff;

namespace Buzzle.JobsManager.Views
{
    public partial class AddNotesView : BuzzleGlobalView
    {
        public event EventHandler AddButtonClicked;

        public AddNotesView()
        {
            InitializeComponent();
        }

        private void barButtonItem_AddNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var eventArgs = new BuzzleNotesEventArgs()
            {
                Note = memoEdit_Note.Text
            };
            AddButtonClicked(this, eventArgs);
        }
    }
}
