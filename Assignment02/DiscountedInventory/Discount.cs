// Written by Swaroop Sapkota
// 02/04/2025
// Discounted Inventory

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountedInventory
{
    public class Discount
    {
        // class variables
        private string name = "n/a";
        private double price = -9999.99;

        // Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        // Method to calculate final price after discount

        public double GetDiscountedPrice()
        {
            if(this.name.Equals("abc", StringComparison.CurrentCultureIgnoreCase))
            {
                return this.price / 2;
            }
            return this.price;
        }

        // ToString() Method
        public override string ToString()
        {

            double finalPrice = GetDiscountedPrice();
            return $"Customer Name: {this.Name}\nOriginal Price: ${this.Price}\nFinal Price After Discount: ${finalPrice}";
        }
    }
}
