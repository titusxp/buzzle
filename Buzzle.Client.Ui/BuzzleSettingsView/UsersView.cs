using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data;

using DevExpress.XtraEditors;
using Buzzle.DataModel;

namespace Buzzle.Client.Ui
{
    public partial class UsersView : BuzzleGlobalView
    {
        private DataManager _dataManager;

        public UsersView()
        {
            InitializeComponent();
            InitializeUsersSection();
        }

#region Users

        private List<User> _allUsers;
        
        private void InitializeUsersSection()
        {
            _dataManager = new DataManager();
            _allUsers = _dataManager.GetAllUsers();
            LoadUsersToTiles();
        }

        private void LoadUsersToTiles()
        {
            tileGroup_UsersGroup.Items.Clear();
            foreach (var newTile in _allUsers.Select(user => new UserTile(user)))
            {
                newTile.ItemClick += UserTileClicked;
                newTile.RightItemClick += UserTileRightClicked;
                tileGroup_UsersGroup.Items.Add(newTile);
            }
        }

        private User CurrentUser { get; set; }

        private void UserTileRightClicked(object sender, TileItemEventArgs e)
        {
            CurrentUser = ((UserTile)e.Item).User;
            popupMenu_Tiles.ShowPopup(MousePosition);
        }

        private void UserTileClicked(object sender, TileItemEventArgs e)
        {
            CurrentUser = ((UserTile)e.Item).User;
            ShowUserDetailsView();
        }

        private void barButtonItem_Refresh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitializeUsersSection();
        }

        private void barButtonItem_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUserDetailsView(new User());
        }

        private void ShowUserDetailsView(User user = null)
        {
            var userToLoad = user ?? CurrentUser;
            using (var userDetailsView = new AddEditUserView(userToLoad))
            {
                userDetailsView.UserSaved += UserSaved;
                userDetailsView.ShowDialog();
            }
        }

        private void UserSaved(object sender, BuzzleUserEventArgs e)
        {
            var userToBeSaved = e.UserToBeSaved;
            ((AddEditUserView)sender).Close();

            if (userToBeSaved.UserID < 1)
            {
                _dataManager.AddUser(userToBeSaved);
            }
            else
            {
                _dataManager.UpdateUser(userToBeSaved);
            }
            InitializeUsersSection();
        }

        private void barButtonItem_DeleteUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentUser == null) return;
            var message = string.Format("Are you sure you want to delete the user {0} ?", CurrentUser.FirstName);
            if (MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes)
                return;
            _dataManager.DeleteUser(CurrentUser);
            InitializeUsersSection();
        }

        #endregion   

        

        
    }
}
