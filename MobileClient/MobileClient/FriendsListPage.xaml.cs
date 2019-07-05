using Plugin.Connectivity;
using Xamarin.Forms;

namespace MobileClient
{
    public partial class FriendsListPage : ContentPage
    {
        ApplicationViewModel viewModel;
        public FriendsListPage()
        {
            InitializeComponent();
            viewModel = new ApplicationViewModel() { Navigation = this.Navigation };
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            if (CheckingConnection.Checking())
                await viewModel.GetFriends();
            else
                await DisplayAlert("Connection erro", "Check your connection", "OK");
            base.OnAppearing();
        }
    }
}