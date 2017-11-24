using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Bizzle.Common.Views;
using Buzzle.DataModel;

namespace Bizzle.Common.Common
{
    public static class BuzzleFunctions
    {
        private static BuzzleWaitForm _waitForm;
        private static Thread waiThread, splashThread;
        private static BuzzleSplashScreen _splashScreen;
        private static bool _waitFormIsOpen, _splashScreenIsOpen;
        private static User _currentUser;
        
        public static bool IsRuntime
        {
            get { return LicenseManager.UsageMode == LicenseUsageMode.Runtime; }
        }

        public static void ShowWaitForm(string waitText = null)
        {
            _waitFormIsOpen = true;

            waiThread = new Thread(show) { IsBackground = true, Name = "WaitFormThread" };
            waiThread.SetApartmentState(ApartmentState.STA);
            waiThread.Start();
        }

        public static void HideWaitForm()
        {
            if (_waitFormIsOpen != true) return;
            _waitFormIsOpen = false;

            try
            {
                _waitForm.Invoke((MethodInvoker) (() => _waitForm.Close()));
                _waitForm.Invoke((MethodInvoker) (() => _waitForm.Dispose()));
            }
            catch (InvalidOperationException)
            {
            }
            finally
            {
                waiThread.Abort();
                waiThread.Join(); 
            }
        }

        public static void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        public static void SwitchFocus(BuzzleGlobalView thisForm, GridView gridView = null)
        {
            if (thisForm.ActiveControl != null)
                thisForm.ActiveControl.SelectNextControl(thisForm.ActiveControl, true, true, false, true);
            else
                thisForm.SelectNextControl(thisForm, true, true, true, true);

            if (gridView != null)
            {
                gridView.CloseEditor();
                gridView.UpdateCurrentRow();
            }
        }


        public static bool AskQuestion(string Question = "Are you sure?", string Caption = "Please Confirm")
        {
            return MessageBox.Show(Question, Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private static void show()
        {
            _waitForm = new BuzzleWaitForm();
            Application.Run(_waitForm);
        }

        public static void ShowSplashScreen(bool closeAutomatically = true)
        {
            _splashScreenIsOpen = true;

            splashThread = new Thread(DisplaySplash)
            {
                IsBackground = true,
                Name = "Splashthread",
            };
            splashThread.Start();

            Thread.Sleep(5000);
            
            if(closeAutomatically)
                CloseSlashScreen();
        }

        public static void CloseSlashScreen()
        {
            if (_splashScreenIsOpen != true) return;
            _splashScreenIsOpen = false;

            try
            {
                _splashScreen.Invoke((MethodInvoker)(() => _splashScreen.Close()));
                _splashScreen.Invoke((MethodInvoker)(() => _splashScreen.Dispose()));
            }
            catch (Exception)
            {
            }
            finally
            {
                splashThread.Abort();
                splashThread.Join();
            }
        }

        private static void DisplaySplash()
        {
            _splashScreen = new BuzzleSplashScreen();
            Application.Run(_splashScreen);
        }

        public static User GetCurrentUser()
        {
            return _currentUser;
        }

        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

        public static Company GetCompanyInfo()
        {
            return new DataManager().GetCompanyData();
        }

        public static Image ResizeImage(Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics graphic = Graphics.FromImage(newImage))
            {
                graphic.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }

        
    }
}
