using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

using Buzzle.Client.Ui;

namespace Buzzle.Launcher
{
    public partial class BuzzleLoginForm : BuzzleGlobalView
    {

        public event EventHandler CredetialsSubmitted;

        public BuzzleLoginForm()
        {
            InitializeComponent();
        }

        private void MoveFocusToButton()
        {
            ActiveControl = button_Atheticate;
        }

        private void textEdit_UserName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button_Atheticate_Click(object sender, EventArgs e)
        {
            ShowWaitForm();
            if (textEdit_UserName.EditValue == null || textEdit_Password.EditValue == null)
            {
                HideWaitForm();
                return;
            }

            var username = textEdit_UserName.EditValue.ToString();
            var password = textEdit_Password.EditValue.ToString();

            

            var evtHandler = new BuzzleCredentialsEvetArgs
            {
                Userame = username,
                Password = password
            };
            CredetialsSubmitted(this, evtHandler);
        }

        public void CredentialsRejected()
        {
            HideWaitForm();
            MessageBox.Show("Invalid login credentials", "Credentials rejected", MessageBoxButtons.OK,
                MessageBoxIcon.Stop);


        }

       

        private void BuzzleLoginForm_Load(object sender, EventArgs e)
        {
            HideWaitForm();

            MoveFocusToButton();
        }

        public void ResetFields()
        {
            textEdit_Password.EditValue = textEdit_UserName.EditValue = null;
        }

        private void textEdit_UserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Atheticate_Click(sender, e);
            }
        }
    }
}
