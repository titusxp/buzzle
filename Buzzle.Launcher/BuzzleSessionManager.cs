using System;
using System.Windows.Forms;
using Bizzle.Common.Common;
using Bizzle.Common.Views;
using Buzzle.Api.Core;
using Buzzle.Client.Ui;
using Buzzle.DataModel;

namespace Buzzle.Launcher
{
    public class BuzzleSessionManager
    {
        private BuzzleLoginForm _buzzleLoginForm;
        private BuzzleShell _buzzleShell;
        private readonly DataManager _dataManager = new DataManager();

        private static User CurrentUser
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

        public BuzzleSessionManager(BuzzleLoginForm loginForm)
        {
            _buzzleLoginForm = loginForm;
            _buzzleLoginForm.CredetialsSubmitted += LoginDetailsReceived;
            ShowLoginForm();
        }

        private void NewUserCreated(object sender, BuzzleUserEventArgs e)
        {
            ((BuzzleGlobalView)sender).Close();
            _dataManager.AddUser(e.UserToBeSaved);
        }

        private void ShowLoginForm()
        {
            if (_buzzleLoginForm == null)
            {
                _buzzleLoginForm = new BuzzleLoginForm();
                _buzzleLoginForm.CredetialsSubmitted += LoginDetailsReceived;
            }
            _buzzleLoginForm.ResetFields();
            _buzzleLoginForm.Show();
        }

        private void LoginDetailsReceived(object sender, EventArgs e)
        {
            var username = ((BuzzleCredentialsEvetArgs) e).Userame;
            var password = ((BuzzleCredentialsEvetArgs) e).Password;
            var user = _dataManager.GetUser(username, password);
            if (user == null)
            {
                _buzzleLoginForm.CredentialsRejected();
                if (_dataManager.NoUsers)
                {
                    BuzzleFunctions.ShowMessage(
                        "No User found in database. You must create a new user to enable you become a buzzler",
                        "User Database empty");
                    CreateNewUser();
                }
                return;
            }
            _buzzleLoginForm.Hide();
            CurrentUser = user;

            LoadShell();
        }

        private void CreateNewUser()
        {
            using (var userDetailsView = new AddEditUserView(new User(){IsAdministrator = true}))
            {
                userDetailsView.UserSaved += NewUserCreated;
                userDetailsView.ShowDialog();
            }
        }



        private void LoadShell()
        {
            if (CurrentUser == null)
            {
                ShowLoginForm();
                return;
            }
            
            _buzzleShell = new BuzzleShell();
            _buzzleShell.FormClosed += _buzzleShell_ShellClosed;
            _buzzleShell.Show();
            _buzzleShell.BringToFront();

        }

        private void _buzzleShell_ShellClosed(object sender, FormClosedEventArgs e)
        {
            ShowLoginForm();
        }
    }
}
