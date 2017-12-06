using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
using Bizzle.Common.Common;

namespace Buzzle.Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Check if database exists, if not, attach a new one before continuing
            //if (DataBaseNotExists())
            //{
            //    if (BuzzleFunctions.AskQuestion("Can't find the database. Do you want to initialize a new one?"))
            //    {
            //        LoadDatabase();
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            BuzzleFunctions.ShowSplashScreen();
            BuzzleFunctions.ShowWaitForm();
            var loginForm = new BuzzleLoginForm();
            var buzzleManager = new BuzzleSessionManager(loginForm);
            Application.Run(loginForm);
            
        }

        private static bool DataBaseNotExists()
        {
            try
            {
                var connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=buzzle;Integrated Security=SSPI";
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    return false;
                }
            }
            catch
            {
                return true;
            }
        }

        private static void LoadDatabase()
        {
            //Connect to the server
            var connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=master;Integrated Security=SSPI";
            var con = new SqlConnection(connectionString);
            ServerConnection serverConnection = new ServerConnection(con);
            Server sqlServer = new Server(serverConnection);

            System.IO.FileInfo mdf = new System.IO.FileInfo(@"Buzzle.mdf");
            System.IO.FileInfo ldf = new System.IO.FileInfo(@"Buzzle_log.LDF");

            var dbPath = sqlServer.MasterDBPath;
            var databasePath = dbPath + @"\Buzzle.mdf";
            var databaseLogPath = dbPath + @"\Buzzle_log.LDF";

            File.Copy(mdf.FullName, databasePath, true);
            File.Copy(ldf.FullName, databaseLogPath, true);

            var databasename = mdf.Name.ToLower().Replace(@".mdf", @"");



            System.Collections.Specialized.StringCollection databasefiles = new System.Collections.Specialized.StringCollection();
            databasefiles.Add(databasePath);
            databasefiles.Add(databaseLogPath);

           
            
            sqlServer.AttachDatabase(databasename, databasefiles); 
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BuzzleEntities"].ConnectionString;
        }

        private static void CloseSlashScreen()
        {
            var splashScreen = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form.Name == "BuzzleSplashScreen");
            splashScreen.Invoke((MethodInvoker)(splashScreen.Close));
        }

        
    }
}
