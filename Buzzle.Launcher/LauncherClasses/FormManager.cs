using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.GlobalStuff;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.Utils;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting.Native;

namespace Buzzle.Launcher
{
    public class FormManager : IFormManager
    {
        private List<BuzzleGlobalView> OpenForms;



        private AppearanceObject GenerateClickedLinkAppearance()
        {
            var appearanceObject = new AppearanceObject()
            {
                BackColor = Color.Transparent,
                Font = new Font("Tahoma", 14, FontStyle.Bold | FontStyle.Underline),
                ForeColor = Color.DeepSkyBlue,
            };

            appearanceObject.Options.UseBackColor = true;
            appearanceObject.Options.UseFont = true;
            appearanceObject.Options.UseForeColor = true;

            return appearanceObject;
        }

        private AppearanceObject GenerateNormalLinkAppearance()
        {
            var appearanceObject = new AppearanceObject()
            {
                BackColor = Color.Transparent,
                Font = new Font("Tahoma", 12, FontStyle.Regular),
                ForeColor = Color.Black,
            };

            appearanceObject.Options.UseBackColor = true;
            appearanceObject.Options.UseFont = true;
            appearanceObject.Options.UseForeColor = true;

            return appearanceObject;
        }
        
        public event EventHandler FormAdded;
        public event EventHandler FormClosed;
        public event EventHandler CurrentFormChanged;

        private NavBarGroup _navBarGroup = new NavBarGroup()
        {
            Name = "nabBarGroup_OpenWindows",
            Caption = "Open Windows",
            Expanded = true
        };

        public NavBarGroup CurrentNavBarGroup
        {
            get
            {
                return _navBarGroup;
            }
        }

        public FormManager(NavBarControl navBar)
        {
            OpenForms = new List<BuzzleGlobalView>();
            InitializeNavBar(navBar);
        }

        private void InitializeNavBar(NavBarControl navBar)
        {
            navBar.Groups.Clear();
            navBar.Groups.Add(_navBarGroup);
        }

        public void OpenForm(BuzzleGlobalView thisForm, bool CloseAnyExistingInstance = false)
        {
            //If the form is not already open, open it, case closed.
            if (FormIsOpen(thisForm) != true)
            {
                LoadNewForm(thisForm);
                return;
            }

            //If the form is already open and we did not 
            //specify to close existing instances, just load the existing instance
            //on the screen. Easy right?
            if (CloseAnyExistingInstance == false)
            {
                SetAsCurrentForm(thisForm);
                return;
            }

            //Finally, if the above are all not satisfied, then it is clear
            //what must be done, kill the existing instance and load a fresh one
            CloseForm(thisForm);
            LoadNewForm(thisForm);
            
        }

        private void LoadNewForm(BuzzleGlobalView thisForm)
        {
            AddNavBarItem(thisForm);
            OpenForms.Add(thisForm);
            SetAsCurrentForm(thisForm);
            FormAdded(this, new FormManagerEventArgs(thisForm));
        }

        private void AddNavBarItem(BuzzleGlobalView thisForm)
        {
            var navBarItem = new BuzzleNavBarItem(thisForm);
            navBarItem.LinkClicked += NavBarItemClicked;
            thisForm.NavBarLink = navBarItem;
            CurrentNavBarGroup.ItemLinks.Add(navBarItem);
        }

        private void NavBarItemClicked(object sender, NavBarLinkEventArgs e)
        {
            var clickedItem = e.Link.Item as BuzzleNavBarItem;
            var targetForm = clickedItem.TargetForm;
            SetAsCurrentForm(targetForm);

            UpdateNavBarAppearance(clickedItem);
        }

        private void UpdateNavBarAppearance(BuzzleNavBarItem highlightedItem)
        {
            var items = new List<NavBarItem>();
            for (int i = 0; i < CurrentNavBarGroup.ItemLinks.Count; i++)
            {
                items.Add(CurrentNavBarGroup.ItemLinks[i].Item);
            }

            items.Where(item => item != highlightedItem).ForEach(item => item.Appearance.Assign(GenerateNormalLinkAppearance()));

            highlightedItem.Appearance.Assign(GenerateClickedLinkAppearance());
        }

     
        public void CloseForm(BuzzleGlobalView thisForm)
        {
            if (FormIsOpen(thisForm))
            {
                var form = GetOpenForm(thisForm);
                RemoveNavBarItem(form);
                OpenForms.Remove(form);
            }
            UnSetAsCurrentForm(thisForm);
            thisForm.Close();
            FormClosed(this, new FormManagerEventArgs(thisForm));
        }

        private BuzzleGlobalView GetOpenForm(BuzzleGlobalView thisForm)
        {
            return OpenForms.FirstOrDefault(form => form.Name == thisForm.Name);
        }

        private void RemoveNavBarItem(BuzzleGlobalView thisForm)
        {
            var navBarItem = thisForm.NavBarLink;
            CurrentNavBarGroup.ItemLinks.Remove(navBarItem);
        }

        public bool IsCurrentForm(BuzzleGlobalView thisForm)
        {
            return thisForm.IsCurrentForm;
        }

        public bool FormIsOpen(BuzzleGlobalView thisForm)
        {
            return OpenForms.Any(form => form.Name == thisForm.Name);
        }

        public BuzzleGlobalView GetCurrentForm()
        {
            return OpenForms.FirstOrDefault(form => form.IsCurrentForm);
        }

        public void SetAsCurrentForm(BuzzleGlobalView passedForm)
        {
            var thisForm = GetOpenForm(passedForm);
            thisForm.IsCurrentForm = true;
            OpenForms.Where(form => form != thisForm).ForEach(form => form.IsCurrentForm = false);
            thisForm.NavBarLink.IsCurrent = true;
            UpdateNavBarAppearance(thisForm.NavBarLink);
            CurrentFormChanged(this, new EventArgs());
        }

        public void UnSetAsCurrentForm(BuzzleGlobalView thisForm)
        {
            thisForm.IsCurrentForm = false;
            thisForm.NavBarLink.IsCurrent = false;
            CurrentFormChanged(this, new EventArgs());
        }
    }
}
