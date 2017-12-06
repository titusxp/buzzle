using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Bizzle.Common.Views;
using Buzzle.DataModel;
using DevExpress.XtraGrid.Views.Grid;

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

        

        public static Image ResizeImage(Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics graphic = Graphics.FromImage(newImage))
            {
                graphic.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }

        private static IList<Assembly> LoadedAssemblies;

        /// <summary>
        /// Returns a list of Types within all referenced and loaded assemblies that implement or inherit the passed type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Type> GetLoadedTypes<T>() where T : class
        {
            var type = typeof(T);
            if (LoadedAssemblies == null)
            {
                // load all the types that are found in all loaded assemblies
                // For the type to be found, the Module's project must be referenced within the MediTrak.Shell project or in the BIN directory
                // in the future, we might consider using manual project/assembly loading thus eliminating the need to add references
                // load all referenced assemblies manually since the .NET runtime does not do it automatically
                // http://stackoverflow.com/q/12779665
                var binAssemblies =
                    Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory)
                        .Where(file => Path.GetExtension(file) == ".dll")
                        .Select(Assembly.LoadFrom)
                        .ToList();

                binAssemblies.Add(Assembly.GetEntryAssembly());

                LoadedAssemblies = binAssemblies.ToArray();
            }

            return LoadedAssemblies.SelectMany(s => s.GetTypes()).Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToArray();

        }

        /// <summary>
        /// Returns a list of Types within all referenced and loaded assemblies that implement or inherit the passed type and satisfy the passed predicate function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetLoadedTypes<T>(Func<T, bool> predicate) where T : class
        {
            IEnumerable<T> types = GetLoadedTypesInstances<T>();
            return types.Where(predicate);
        }

        /// <summary>
        /// Returns a list of instantiated objects within all referenced and loaded assemblies that implement or inherit the passed type.
        /// Note, this method only returns types that have a PARAMETER-LESS constructor.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetLoadedTypesInstances<T>() where T : class
        {
            var types = GetLoadedTypes<T>().ToArray();
            if (types.Any())
            {
                return types.Select(m =>
                {
                    // exclude types that DO NOT have a parameterless contructor
                    var constructor = m.GetConstructor(Type.EmptyTypes);
                    if (constructor != null)
                    {
                        try
                        {
                            return (T)Activator.CreateInstance(m);
                        }
                        catch (Exception)
                        {
                            return null;
                        }
                    }
                    return (T)null;
                }).OfType<T>().ToList();
            }
            return null;
        }

        public static IEnumerable<T> GetLoadedTypesInstances<T>(Assembly[] assemblies) where T : class
        {

            // load all referenced assemblies manually since the .NET runtime does not do it automatically
            // http://stackoverflow.com/q/12779665
            var loadedAssemblies = assemblies;

            // load all the types that are found in all loaded assemblies
            // For the type to be found, the Module's project must be referenced within the MediTrak.Shell project or in the BIN directory
            // in the future, we might consider using manual project/assembly loading thus eliminating the need to add references
            var type = typeof(T);
            var types = loadedAssemblies.SelectMany(s => s.GetTypes()).Where(p => type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract).ToArray();
            if (types.Any())
            {
                return types.Select(m =>
                {
                    // exclude types that DO NOT have a parameterless contructor
                    var constructor = m.GetConstructor(Type.EmptyTypes);
                    if (constructor != null)
                    {
                        try
                        {
                            return (T)Activator.CreateInstance(m);
                        }
                        catch (Exception)
                        {
                            return null;
                        }
                    }
                    return (T)null;
                }).OfType<T>();
            }
            return null;
        }

        public static IEnumerable<T> GetLoadedTypesInstance<T>(Func<T, bool> predicate) where T : class
        {
            IEnumerable<T> types = GetLoadedTypesInstances<T>();
            return types.Where(predicate);
        }

        public static T CreateLoadedTypeInstance<T>(params Object[] constructorArguments) where T : class
        {
            var loadedType = GetLoadedTypes<T>().First();
            return (T)Activator.CreateInstance(loadedType, constructorArguments);
        }

        public static List<T> CreateLoadedTypeInstances<T>(params Object[] constructorArguments) where T : class
        {
            var loadedTypes = GetLoadedTypes<T>();
            var typeInstances = new List<T>();

            foreach (var loadedType in loadedTypes)
            {
                var instance = (T)Activator.CreateInstance(loadedType, constructorArguments);
                typeInstances.Add(instance);
            }

            return typeInstances;
        }
    }
}
