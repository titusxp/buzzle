using System;
using DevExpress.XtraSplashScreen;

namespace Bizzle.Common.Views
{
    public partial class BuzzleSplashScreen : SplashScreen
    {
        public BuzzleSplashScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}