using Bizzle.Common.Views;

namespace Bizzle.Common.Common
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
