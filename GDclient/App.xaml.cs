using GDclient.ViewModel;

namespace MauiAppMapTest
{
    public partial class App : Application
    {
        public App(LoginVM loginVM)
        {
            InitializeComponent();

            MainPage = new AppShell(loginVM);
        }
    }
}
