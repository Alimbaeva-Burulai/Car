using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCarÁdám_2.Model
{
    public class OneResult : ObservableObject
    {
        private string carLicenceNumber;

        public string CarLicenceNumber
        {
            get { return carLicenceNumber; }
            set {
                OnPropertyChanged();
                SetProperty(ref carLicenceNumber, value);
            }
        }

        private TimeSpan raceTime;

        public TimeSpan RaceTime
        {
            get { return raceTime; }
            set {
                OnPropertyChanged();
                SetProperty(ref raceTime, value);
            }
        }


    }
}
