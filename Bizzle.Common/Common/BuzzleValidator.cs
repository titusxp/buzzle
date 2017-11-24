namespace Bizzle.Common.Common
{
    public static class BuzzleValidator
    {
        public static bool IsNotEmpty(string value, string valueName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                var message = string.Concat(valueName, " must be provided");
                ShowMessage(message, "Null value not allowed");
                return false;
            }
            return true;
        }

        public static bool IsNotEmpty(object value, string valueName)
        {
            if (value == null)
            {
                var message = string.Concat(valueName, " must be provided");
                ShowMessage(message, "Null value not allowed");
                return false;
            }
            return true;
        }

        public static bool IsNotLessThanOne(int value, string valueName)
        {
            if (value < 1)
            {
                var message = string.Concat(valueName, " must be provided");
                ShowMessage(message, "Null value not allowed");
                return false;
            }
            return true;
        }

        public static void ShowMessage(string message, string caption)
        {
            BuzzleFunctions.ShowMessage(message, caption);
        }
    }
}
