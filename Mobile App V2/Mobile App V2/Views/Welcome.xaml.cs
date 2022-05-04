using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_App_V2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private async void UserProfile_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(UserProfile)}");
        }

        private async void FamilyTree_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(FamilyTree)}");
        }

        private async void Entry_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(AddUserEntry)}");
        }
    }
}