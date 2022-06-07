using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace new_canteen_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

  
    public partial class Login : ContentPage
    {
       // public static string username;
        //public static string password;
        public Login()
        {
            InitializeComponent();
            
           
        }

        private void button_clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new OrderPage());
            Application.Current.MainPage = new NavigationPage(new SummaryPage());
        }
    }
}