using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraNavBar;

namespace Buzzle.GlobalStuff
{
    public class BuzzleNavBarItem : NavBarItem
    {
        public BuzzleGlobalView TargetForm;

        public BuzzleNavBarItem(BuzzleGlobalView targetForm)
        {
            TargetForm = targetForm;
        }
    }
}
