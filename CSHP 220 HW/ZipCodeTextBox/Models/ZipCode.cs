using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ZipCodeTextBox.Models
{
    class ZipCode : IDataErrorInfo, INotifyPropertyChanged
    {
        private string uszip = string.Empty;
        private string canzip = string.Empty;
        private string USZipError;
        private string CANZipError;

        public override string ToString()
        {
            return uszip;
        }

        public string USZip
        {
            get
            {
                return uszip;
            }
            set
            {
                if (uszip != value)
                {
                    uszip = value;
                    OnPropertyChanged("USZip");
                }
            }
        }

        public string CANZip
        {
            get
            {
                return canzip;
            }
            set
            {
                if (canzip != value)
                {
                    canzip = value;
                    OnPropertyChanged("CANZip");
                }
            }
        }

        public string uszipError
        {
            get
            {
                return USZipError;
            }
            set
            {
                if (USZipError != value)
                {
                    USZipError = value;
                    OnPropertyChanged("uszipError");
                }
            }
        }

        public string canzipError
        {
            get
            {
                return CANZipError;
            }
            set
            {
                if (CANZipError != value)
                {
                    CANZipError = value;
                    OnPropertyChanged("canzipError");
                }
            }
        }

        public string Error
        {
            get
            {
                return USZipError;
            }
        }
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "USZip":
                        {
                            USZipError = "";

                            if (string.IsNullOrEmpty(USZip))
                            {
                                USZipError = "Zip code cannot be empty";
                            }
                            break;
                        }
                    case "CANZip":
                        {
                            CANZipError = "";

                            if (string.IsNullOrEmpty(CANZip))
                            {
                                CANZipError = "Zip code cannot be empty";
                            }
                            break;
                        }
                }

                return null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
