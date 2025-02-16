// Written by Swaroop Sapkota
// 02/14/2025
// Vin's Trouble

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Vin Fletcher's Arrow Shop!");

        Console.WriteLine("Choose an arrowhead type: (1) Steel, (2) Wood, (3) Obsidian");
        int arrowChoice = Convert.ToInt32(Console.ReadLine());
        Arrowhead selectedArrow = (Arrowhead)(arrowChoice - 1);

        Console.WriteLine("Choose a fletching type: (1) Plastic, (2) Turkey Feathers, (3) Goose Feathers");
        int fletchingChoice = Convert.ToInt32(Console.ReadLine());
        Fletching selectedFletching = (Fletching)(fletchingChoice - 1);

        float shaftLength;
        do
        {
            Console.WriteLine("Enter the shaft length (between 60 and 100 cm): ");
            shaftLength = Convert.ToInt32(Console.ReadLine());
        } while (shaftLength < 60 || shaftLength > 100);

        Arrow2 arrow = new Arrow2(selectedArrow, selectedFletching, shaftLength);

        Console.WriteLine($"\nThe total cost of your arrow is: {arrow.GetCost()} gold.");
    }
}
