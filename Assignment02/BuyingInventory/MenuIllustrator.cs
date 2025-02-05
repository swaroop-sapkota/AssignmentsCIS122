// Written by Swaroop Sapkota
// 02/03/2025
// Buying Inventory

using System;

namespace BuyingInventory
{
    public class MenuIllustrator
    {
        // Class variable
        private int input = -1;

        // Properties
        public int Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        // Constructor
        public MenuIllustrator() : this(-1) { }

        public MenuIllustrator(int ainput)
        {
            this.Input = ainput;
        }

        // Method to show the menu's list
        public string MenuList()
        {
            return "The following items are available: \n"
                + "1 - Rope\n"
                + "2 - Torches\n"
                + "3 - Climbing Equipment\n"
                + "4 - Clean Water\n"
                + "5 - Machete\n"
                + "6 - Canoe\n"
                + "7 - Food Supplies\n";
        }

        // Method to show the item's cost
        public string ItemCost()
        {
            switch (this.Input)
            {
                case 1: return "Rope costs 10 gold.";
                case 2: return "Torches cost 15 gold.";
                case 3: return "Climbing Equipment costs 25 gold.";
                case 4: return "Clean Water costs 1 gold.";
                case 5: return "Machete costs 20 gold.";
                case 6: return "Canoe costs 200 gold.";
                case 7: return "Food Supplies cost 1 gold.";
                default: return "Invalid Input!";
            }
        }
    }
}
