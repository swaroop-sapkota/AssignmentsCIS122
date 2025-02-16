// Written By Swaroop Sapkota
// 02/11/2025
// Simula’s Soup

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Simula_sSoup
{
    public class Soup
    {
        // Defining enumeration
        public enum FoodType
        {
            Soup,
            Stew,
            Gumbo
        }

        public enum MainIngredient
        {
            Mushrooms,
            Chicken,
            Carrots,
            Potatoes
        }

        public enum Seasoning
        {
            Spicy,
            Salty,
            Sweet
        }

        // class variable

        private FoodType type;
        private MainIngredient ingredient;
        private Seasoning aSeasoning;

        // properites

        public FoodType Type
        {
            get { return type; }
            set { type = value; }
        }

        public MainIngredient Ingredient
        {
            get { return ingredient; }
            set { ingredient = value; }
        }

        public Seasoning ASeasoning
        {
            get { return aSeasoning; }
            set { aSeasoning = value; }
        }

        // Method to get the user choices
        public void GetUserChoice()
        {
            Console.WriteLine("Welcome to Simula's Kitchen!");

            Console.WriteLine("Choose a food type: (1) Soup, (2) Stew, (3) Gumbo: ");
            int typeChoice = Convert.ToInt32(Console.ReadLine());
            Type = (FoodType)(typeChoice - 1);

            Console.WriteLine("Choose a main ingredient: (1) Mushrooms, (2) Chicken, (3) Carrots, (4) Potatoes: ");
            int ingredientChoice = Convert.ToInt32(Console.ReadLine());
            Ingredient = (MainIngredient)(ingredientChoice - 1);

            Console.WriteLine("Choose a seasoning: (1) Spicy, (2) Salty, (3) Sweet: ");
            int seasoningChoice = Convert.ToInt32(Console.ReadLine());
            ASeasoning = (Seasoning)(seasoningChoice - 1);

        }
        // Method to return a tuple
        public (FoodType, MainIngredient, Seasoning) GetSoupChoice()
        {
            return (Type, Ingredient, ASeasoning);
        }
        
        
    }
}
