using Acr.UserDialogs;
using Xamarin.Forms;

namespace LifeCycleExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePageWithXaml();
            //MainPage = new HomePageWithoutXaml();
        }

        protected override void OnStart()
        {
            UserDialogs.Instance.Alert("App aberto");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            UserDialogs.Instance.Alert("App voltando ao Foreground");
        }
    }
}

