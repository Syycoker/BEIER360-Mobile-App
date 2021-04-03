using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BEIER360
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string percentageofmen = HomePage.PercentageOfMenOutput;
        string percentageofwomen = HomePage.PercentageOfWomenOutput;

        public string PercentageOfMen //customised getters and setters
        {
            get
            {
                if (percentageofmen == null)
                {
                    return percentageofmen = "65"; //Default Value for percentage of men is 65
                }
                else
                    return percentageofmen;
            }
            set
            {
                if (percentageofmen == value)
                {
                    return; //if value is the same, return
                }

                percentageofmen = value;
                OnPropertyChanged2(nameof(POMDisplay)); //for binding content
            }
        }

        public string PercentageOfWomen
        {
            get
            {
                if (percentageofwomen == null)
                {
                    return percentageofwomen = "35";
                }
                else
                    return percentageofwomen;
            }
            set
            {
                if (percentageofwomen == value)
                {
                    return;
                }

                percentageofwomen = value;
                OnPropertyChanged3(nameof(POWDisplay));
            }
        }


        public string POMDisplay => $"{PercentageOfMen}"; //To bind percentage of Men to label
        public string POWDisplay => $"{PercentageOfWomen}";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged2(string PercentageOfMen)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PercentageOfMen));
        }

        void OnPropertyChanged3(string PercentageOfWomen)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PercentageOfWomen));
        }
    }
}
