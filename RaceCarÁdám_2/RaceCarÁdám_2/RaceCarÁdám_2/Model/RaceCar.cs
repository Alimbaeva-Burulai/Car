using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCarÁdám_2.Model
{
    public class RaceCar : ObservableObject
    {
        private string licenceNumber;

        public string LicenceNumber
        {
            get { return licenceNumber; }
            set
            {
                if (CheckLicenceNumber(value))
                {
                    //OnPropertyChanged(); mindenhová! 
                    OnPropertyChanged();
                    SetProperty(ref licenceNumber, value);
                }
            }
        }

        //bc AAABBB format
        private bool CheckLicenceNumber(string licenceNumber)
        {
            return char.IsLetter(licenceNumber[0]) && char.IsLetter(licenceNumber[1]) && char.IsLetter(licenceNumber[2]) &&
                char.IsNumber(licenceNumber[3]) && char.IsNumber(licenceNumber[4]) && char.IsNumber(licenceNumber[5]);
        }

        private string model;

        public string Model
        {
            get { return model; }
            set {
                OnPropertyChanged();
                SetProperty(ref model, value);
                 }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set {
                OnPropertyChanged();
                SetProperty(ref price, value);
            } 
        }

        private string brand;

        public string Brand
        {
            get { return brand; }
            set {
                OnPropertyChanged();
                SetProperty(ref brand, value);
            }  
        }

        private int maxSpeed;

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set {
                OnPropertyChanged();
                SetProperty(ref maxSpeed, value);
            } 
        }

        public void CopyFrom(RaceCar car)
        {

            this.LicenceNumber = car.LicenceNumber;
            this.Brand = car.Brand;
            this.Price = car.Price;
            this.Model = car.Model;
            this.MaxSpeed = car.MaxSpeed;
        }
    }
}
