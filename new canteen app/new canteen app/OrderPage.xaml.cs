using System;
using System.Collections.Generic;
using System.Globalization;
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

            StringBuilder sb = new StringBuilder();
            CultureInfo culture = new CultureInfo("en-GB");

            foreach(FoodItems item in foodItems)
            {
                
                sb.Append($"{ item.name } x {item.quantity} = { (item.quantity * item.price).ToString("C", culture) } \n");
            }

            OrderCount.Text = sb.ToString();

            OrderCount.Text += "Total:" +  "£" + totalPrice ;
        }
    }
}