using DevExpress.XtraWaitForm;

namespace Bizzle.Common.Views
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