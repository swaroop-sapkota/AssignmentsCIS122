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
    public class Program
    {
        static void Main(string[] args)
        {
            Discount discount = new Discount();

            Console.Write("Enter your name: ");
            discount.Name = Console.ReadLine();

            Console.Write("Enter the price of the item: ");
            discount.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n" + discount.ToString());

            Console.ReadLine();

        }
    }
}
