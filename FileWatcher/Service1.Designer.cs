namespace FileWatcher
{
    partial class FileWatcherService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemImageWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemImageWatcher)).BeginInit();
            // 
            // fileSystemImageWatcher
            // 
            this.fileSystemImageWatcher.EnableRaisingEvents = true;
           this.fileSystemImageWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // Service1
            // 
            this.ServiceName = "FileWatcher";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemImageWatcher)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemImageWatcher;
    }
}
