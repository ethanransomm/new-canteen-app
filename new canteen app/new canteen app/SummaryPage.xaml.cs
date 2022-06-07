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
    public partial class SummaryPage : ContentPage
    {
        decimal totalPrice;
        decimal friesPrice = 2M;
        decimal curryPrice = 3.50M;

        int CurryCount;
        int CheeseCount;
        int FriesCount;
        int JackPotCount;
        int BeefBurgCount;
        int ChickBurgCount;

        List<string> items = new List<string>();


        List<FoodItems> foodItems = new List<FoodItems>();
        FoodItems fries = new FoodItems(2M, "Fries", 0);
        FoodItems curry = new FoodItems(3.50M, "Curry", 0);
        FoodItems cheese = new FoodItems(0.50M, "Cheese", 0);
        FoodItems jacketpotato = new FoodItems(3M, "Jacket Potato", 0);
        FoodItems beefburger = new FoodItems(2.99M, "Beef Burger", 0);
        FoodItems chickenburger = new FoodItems(3.25M, "Chicken Burger", 0);


        public SummaryPage()
        {
            InitializeComponent();
        }

        private void AddToKart(object sender, EventArgs e)
        {
            var button = (Button)sender; 
            var classId = button.ClassId;

            if(classId == "Fries")
            {
                receiptFunction(fries, classId);
            }

            if (classId == "Curry")
            {
                receiptFunction(curry, classId);


            }

            if (classId == "Cheese")
            {

                receiptFunction(cheese, classId);

            }

            if (classId == "JackPot")
            {
                receiptFunction(jacketpotato, classId);

            }

            if (classId == "BeefBurg")
            {
                receiptFunction(beefburger, classId);

            }

            if (classId == "ChickBurg")
            {
                totalPrice = totalPrice + chickenburger.price;
                if (foodItems.Contains(chickenburger) == false)
                {

                    foodItems.Add(chickenburger);
                }

                chickenburger.quantity++;
            }

            Price.Text = ("Total: £" + totalPrice);
        }

        public void receiptFunction(FoodItems item, string classId)
        {
            totalPrice = totalPrice + item.price;
            if (foodItems.Contains(item) == false)
            {

                foodItems.Add(item);
            }

            item.quantity++;
        }

        //private void SubmitOrder(object sender, EventArgs e)
        //{
        //   //Navigation.PushAsync(new OrderPage(CheeseCount, FriesCount, CurryCount));
        //}

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new OrderPage(items, totalPrice, CheeseCount, FriesCount, CurryCount));
            Navigation.PushAsync(new OrderPage(foodItems, totalPrice));
        }
    }
}