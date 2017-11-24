using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.DataModel;

namespace Buzzle.Client.Ui
{
    public partial class AddEditUserView : BuzzleGlobalView
    {
        public event EventHandler<BuzzleUserEventArgs> UserSaved;

        public AddEditUserView(User thisUser)
        {
            InitializeComponent();
            _currentUser = thisUser;

            if (_currentUser.UserID > 0)
            {
                Text = string.Format("Buzzle - Edit User {0}", CurrentlyLoggedInUser.FullName);
            }
        }

        private User _currentUser
        {
            get
            {
                return userBindingSource.DataSource as User;
            }
            set
            {
                userBindingSource.DataSource = value;
            }
        }

        private void barButtonItem_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuzzleFunctions.SwitchFocus(this);
            if (AllFieldsValid() != true) return;

            if (_currentUser.UserID < 1)
            {
                _currentUser.DateCreated = DateTime.Now;
            }

            var eventArgs = new BuzzleUserEventArgs
            {
                UserToBeSaved = _currentUser
            };

            UserSaved(this, eventArgs);
        }

        private bool AllFieldsValid()
        {
            return
                BuzzleValidator.IsNotEmpty(textEdit_Username.Text, "Username") &&
                BuzzleValidator.IsNotEmpty(textEdit_Password.Text, "Password") &&
                BuzzleValidator.IsNotEmpty(textEdit_FirstName.Text, "First Name") &&
                BuzzleValidator.IsNotEmpty(textEdit_LastName.Text, "Last Name");
        }
    }
}
