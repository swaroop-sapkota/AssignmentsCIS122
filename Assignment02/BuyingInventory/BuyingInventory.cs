// Written by Swaroop Sapkota
// 02/03/2025
// Buying Inventory

using System;

namespace BuyingInventory
{
    public class BuyingInventory
    {
        static void Main(string[] args)
        {
            // Create menu object and show menu
            MenuIllustrator menuIllustrator = new MenuIllustrator();
            Console.WriteLine(menuIllustrator.MenuList());

            // Get user input
            Console.Write("What number do you want to see the price of? ");
            int number = Convert.ToInt32(Console.ReadLine());

            MenuIllustrator itemMenu = new MenuIllustrator(number);

            // Display item cost
            Console.WriteLine(itemMenu.ItemCost());
        }
    }
}
