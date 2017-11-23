using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Buzzle.GlobalStuff;
using DevExpress.XtraNavBar;

namespace Buzzle.GlobalStuff
{
    public class BuzzleNavBarItem : NavBarItem
    {
        public BuzzleGlobalView TargetForm;
        public bool IsCurrent;

        public BuzzleNavBarItem(BuzzleGlobalView targetForm)
        {
            TargetForm = targetForm;
            Caption = targetForm.Text;
        }
    }
}
