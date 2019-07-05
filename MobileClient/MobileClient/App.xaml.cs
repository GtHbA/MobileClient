using Xamarin.Forms;

namespace MobileClient
{
    public partial class Aplication : Application
    {
        public Aplication()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FriendsListPage());
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}