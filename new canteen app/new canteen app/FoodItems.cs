using System;
using System.Collections.Generic;
using System.Text;

namespace new_canteen_app
{
    public class FoodItems
    {
        public decimal price { get; }
        public string name;
        public int quantity;
        public FoodItems(decimal price, string name, int quantity)
        {
            this.price = price;
            this.name = name;
            this.quantity = quantity;
        }
        public void ClearQuantity()
        {
            quantity = 0;
        }
    }
}
