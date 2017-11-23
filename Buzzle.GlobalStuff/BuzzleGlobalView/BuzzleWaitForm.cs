using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using Label = System.Reflection.Emit.Label;
using System.Threading;  

namespace Buzzle.GlobalStuff
{
    public partial class BuzzleWaitForm : WaitForm
    {

        public BuzzleWaitForm(string message = null)
        {
            InitializeComponent();
            label_WaitText.Text = message ?? "Buzzling, Please Wait...";
            this.BringToFront();
        }

        public string WaitFormText
        {
            set
            {
                label_WaitText.Text = value;
            }
        }


    }
}