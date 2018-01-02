using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Diagnostics;

namespace FileWatcher
{
    public partial class FileWatcherService : ServiceBase
    {
        string watchPath = ConfigurationManager.AppSettings["WatchPath"];
        bool eventReceived = false;
        public FileWatcherService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                fileSystemImageWatcher.Path = watchPath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void OnStop()
        {
            fileSystemImageWatcher.EnableRaisingEvents = false;
            fileSystemImageWatcher.Dispose();
        }

        
        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (eventReceived == false)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    //Debugger.Break();
                    //eventLog.Source = "FileWatcher";

                    //eventLog.WriteEntry("Batch file exceution started ...");
                    //var processInfo = new ProcessStartInfo();
                    //processInfo.FileName = @"C: \Users\pareeka2\Desktop\New Text Document.bat";
                    //processInfo.CreateNoWindow = true;
                    //processInfo.UseShellExecute = false;
                    //processInfo.RedirectStandardError = true;
                    //processInfo.RedirectStandardOutput = true;
                    //var process = Process.Start(processInfo.FileName);

                    //int timeout = 60000;

                    //process.WaitForExit(timeout);

                    //string errorMessage = process.StandardError.ReadToEnd();
                    //eventLog.WriteEntry("Error message of batch is  : " + errorMessage);
                    //process.WaitForExit();

                    eventLog.WriteEntry("Directory Changed=> New File Added :" + e.Name);
                }

                eventReceived = true;
            }
            else
            {
                eventReceived = false;
            }
        }
    }
}
