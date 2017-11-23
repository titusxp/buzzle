﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.Data;
using Buzzle.GlobalStuff;

namespace Buzzle.Finances
{
    public partial class AccountsView : BuzzleGlobalView
    {
        public AccountsView()
        {
            InitializeComponent();
            LoadAccountStats();
        }

        private void LoadAccountStats()
        {
            gridControl_Accounts.DataSource = new DataManager().GetAccountStats();
        }
    }
}
