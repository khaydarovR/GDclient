using GDclient.ViewModel;
using MauiAppMapTest.Page;
using GDclient.Services;
using Microsoft.Extensions.Logging;

namespace MauiAppMapTest
{
    public partial class AppShell : Shell
    {
        private readonly LoginVM loginVM;

        public AppShell(LoginVM loginVM)
        {
            InitializeComponent();
            //Register all routes
            //Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("main", typeof(MainPage));
            Routing.RegisterRoute("home", typeof(HomePage));
            Routing.RegisterRoute("settings", typeof(SettingsPage));
            Routing.RegisterRoute("deliv", typeof(DelivPage));
            Routing.RegisterRoute("acc", typeof(AccPage));
            Routing.RegisterRoute("login", typeof(LoginPage));
            this.loginVM = loginVM;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Shell.Current.GoToAsync("//login");
            var p = new NavigationPage(new LoginPage(loginVM));
            Navigation.PushModalAsync(p);
        }
    }
}
