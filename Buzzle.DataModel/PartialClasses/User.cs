namespace Buzzle.DataModel
{
    public partial class User
    {
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}
