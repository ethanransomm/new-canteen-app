using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace new_canteen_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           
           
            MainPage = new NavigationPage(new Login());
            //Login = new NavigationPage(new OrderPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
