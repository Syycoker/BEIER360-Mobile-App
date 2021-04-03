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
    public partial class OutputPageExt : ContentPage
    {
        public OutputPageExt(HomePage page)
        {
            InitializeComponent();
            
        }

        private async void UserChange_OnClicked(object sender, EventArgs e)
        {
            //Wait till content is loaded and push homepage into navigation stack
            await Navigation.PushAsync(new HomePage());
        }
    }
}