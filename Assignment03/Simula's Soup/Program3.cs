// Written By Swaroop Sapkota
// 02/11/2025
// Simula’s Soup

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simula_sSoup
{
    public class Program3
    {
        static void Main(string[] args)
        {
            Soup mySoup = new Soup();
            mySoup.GetUserChoice();

            var selected = mySoup.GetSoupChoice();

            Console.WriteLine($"\nYou have made: {selected.Item3} {selected.Item2} {selected.Item1}.");

        }
    }
}
