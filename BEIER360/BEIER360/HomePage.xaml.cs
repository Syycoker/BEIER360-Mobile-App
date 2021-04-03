using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BEIER360
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        //@unused POF & POM
        public double POF { get; set; }//Global variable to set 'Percentage of Females'
        public double POM { get; set; }

        public double maleUsersDouble = 65.0D; //Default values for the Male Users
        public double femaleUsersDouble = 35.0D;

        public static string PercentageOfMenOutput { get; set; }//Public getters and setters to output to the 'OutputPageExt' page
        public static string PercentageOfWomenOutput { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }

        private async void Calculate_Button(object sender, EventArgs e)
        {
            string maleUsersString = maleTextBox.Text; //Get string value(s) of the entries
            string femaleUsersString = femaleTextBox.Text;


            //try-catch block to parse user input and store into global variables
            try
            {
                double.TryParse(maleUsersString, out maleUsersDouble);
                double.TryParse(femaleUsersString, out femaleUsersDouble);
            }
            catch (FormatException) //to catch NumberFormatExceptions
            {
                Console.WriteLine("Please Input Digits." + maleUsersString + "&" + femaleUsersString + " are not numbers.");

                //to catch if the strings are empty
                if (maleUsersString == null)
                {
                    Console.WriteLine("Please Input Digits." + maleUsersString + " is not a valid input.");
                }

                if (femaleUsersString == null)
                {
                    Console.WriteLine("Please Input Digits." + femaleUsersString + " is not a valid input.");
                }
            }

            //formulaes to calculate the percentage of the total population and to find percentage of users compared to population size

            double totalUsers = maleUsersDouble + femaleUsersDouble;

            double PercentageOfFemales = (femaleUsersDouble / totalUsers) * 100;
            double PercentageOfMales = (maleUsersDouble / totalUsers) * 100;


            PercentageOfFemales = Math.Round(PercentageOfFemales, 2);
            PercentageOfMales = Math.Round(PercentageOfMales, 2);

            POF = PercentageOfFemales;
            POM = PercentageOfMales;

            //convert double values to string to output to 'OutputPageExt' page
            PercentageOfMenOutput = POM.ToString();
            PercentageOfWomenOutput = POF.ToString();

            //Update values
            maleLabel.Text = PercentageOfMenOutput;
            femaleLabel.Text = PercentageOfWomenOutput;

            //push new page into Navigation stack
            await Navigation.PushAsync(new OutputPageExt(this));

        }
    }
}