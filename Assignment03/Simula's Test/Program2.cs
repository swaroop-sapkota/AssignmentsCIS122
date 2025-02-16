// Written by Swaroop Sapkota
// 02/12/2025
// Simula's Test

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simula_sTest
{
    public class Program2
    {
        static void Main(string[] args)
        {
            Chest chest = new Chest();
            chest.DisplayCurrentState();

            while (true)
            {
                Console.Write("What do you want to do? ");
                string command = Console.ReadLine();

                chest.Commands(command);
            }
        }
    }
}
