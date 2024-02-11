using TravelAppMaui.Models;

namespace TravelAppMaui.Pages
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage(SecondPageViewModel secondPageViewModel)
        {
            InitializeComponent();
            BindingContext = secondPageViewModel;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}

