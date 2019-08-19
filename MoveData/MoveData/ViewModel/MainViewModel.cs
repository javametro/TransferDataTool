using GalaSoft.MvvmLight;
using MoveData.Model;

namespace MoveData.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        private BackupDirectorys backupDirectory;
        public BackupDirectorys BackupDirectory
        {
            get
            {
                if(backupDirectory == null)
                {
                    backupDirectory = new BackupDirectorys();
                }

                return backupDirectory;
            }

            set
            {
                backupDirectory = value;
            }
        }
        private string defaultDestination;
        public string DefaultDestination
        {
            get
            {
                if(defaultDestination == string.Empty)
                {
                    defaultDestination = @"C:\";
                }

                return defaultDestination;
            }
            set
            {
                defaultDestination = value;
            }
        }
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///
            backupDirectory = new BackupDirectorys();
            backupDirectory.Desktop = @"c:\";

            DefaultDestination = @"c:\";
        }
    }
}