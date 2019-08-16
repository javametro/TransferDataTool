using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveData.Model
{
    public class BackupDirectorys : INotifyPropertyChanged
    {
        private string desktop;
        public string Desktop
        {
            get
            {
                if(desktop == string.Empty)
                {
                    desktop = @"C:\Users\Stephen\Desktop";
                }

                return desktop;
            }

            set
            {
                desktop = value;
                this.OnPropertyChanged("Desktop");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
