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
    public partial class OrderPage : ContentPage
    {
        //public OrderPage(List<string> items, decimal totalPrice, int cheesecount, int friescount, int currycount)
        public OrderPage(List<FoodItems> foodItems, decimal totalPrice)
        {
            InitializeComponent();

            //OrderCount.Text = cheesecount.ToString() + friescount.ToString() + currycount.ToString() + totalPrice.ToString();
            
            foreach(FoodItems item in foodItems)
            {
                OrderCount.Text += item.name + "x" + item.quantity + "=" + item.quantity * item.price + "//n";

            }

            OrderCount.Text +=  "£" + totalPrice ;
        }
    }
}