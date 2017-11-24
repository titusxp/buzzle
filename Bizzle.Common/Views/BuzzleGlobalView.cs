using Buzzle.DataModel;
using DevExpress.XtraEditors;
using System.ComponentModel;
using Bizzle.Common.Common;

namespace Bizzle.Common.Views
{
    public partial class BuzzleGlobalView : XtraForm
    {
        public BuzzleGlobalView()
        {
            InitializeComponent();
        }

        public static Company GetCompanyInfo()
        {
            return BuzzleFunctions.GetCompanyInfo();
        }
        
        public bool IsRuntime
        {
            get { return LicenseManager.UsageMode == LicenseUsageMode.Runtime; }
        }

        /// <summary>
        /// Used by the Shell to know if the form is the one currently Displayed
        /// in the panel
        /// </summary>
        public bool IsCurrentForm { get; set; }


        /// <summary>
        /// Used by the shell to easily know an open form's link
        /// in the navigation bar
        /// </summary>
        public BuzzleNavBarItem NavBarLink { get; set; }

        public void ShowWaitForm(string text = null)
        {
            BuzzleFunctions.ShowWaitForm(text);
        }

        public void HideWaitForm()
        {
            BuzzleFunctions.HideWaitForm();
        }

        public User CurrentlyLoggedInUser
        {
            get
            {
                return BuzzleFunctions.GetCurrentUser();
            }
            set
            {
                BuzzleFunctions.SetCurrentUser(value);
            }
        }

    }
}
