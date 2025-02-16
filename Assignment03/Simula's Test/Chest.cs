// Written by Swaroop Sapkota
// 02/12/2025
// Simula's Test

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simula_sTest
{
    public class Chest
    {
        // enumerator to represent the state of the chest
        public enum ChestState
        {
            Locked,
            Unlocked,
            Open
        }

        private ChestState currentState;

        // current state of the chest
        public Chest()
        {
            currentState = ChestState.Locked;
        }

        
        public void Commands(string command)
        {
            switch (command.ToLower())
            {
                case "unlock":
                    Unlock();
                    break;
                case "open":
                    Open();
                    break;
                case "close":
                    Close();
                    break;
                case "lock":
                    Lock();
                    break;
                default:
                    Console.Write("Invalid command. Please try again. ");
                    break;
            }
        }

        // Method to unlock the chest
        private void Unlock()
        {
            if (currentState == ChestState.Locked)
            {
                currentState = ChestState.Unlocked;
                Console.Write("The chest is unlocked. ");
            }
            else
            {
                Console.Write("You can't unlock the chest in it's current state. "); ;
            }
        }

        // Method to open the chest
        private void Open()
        {
            if (currentState == ChestState.Unlocked)
            {
                currentState = ChestState.Open;
                Console.Write("The chest is open. ");
            }
            else if (currentState == ChestState.Locked)
            {
                Console.Write("You can't open a locked chest. ");

            }
            else
            {
                Console.Write("The chest is already open. ");
            }
        }

        // Method to close the chest
        private void Close()
        {
            if (currentState == ChestState.Open)
            {
                currentState = ChestState.Unlocked;
                Console.Write("The chest is closed but unlocked. ");
            }
            else if (currentState == ChestState.Locked)
            {
                Console.Write("The chest is already locked. ");
            }
            else
            {
                Console.Write("The chest is already unlocked and closed. ");
            }
        }

        // Method to lock the chest
        private void Lock()
        {
            if (currentState == ChestState.Unlocked)
            {
                currentState = ChestState.Locked;
                Console.Write("The chest is locked. ");
            }
            else
            {
                Console.Write("You can't lock the chest in its current state. ");
            }
        }
        // Method to display the current state of the chest.
        public void DisplayCurrentState()
        {
            Console.Write($"The chest is {currentState}. ");
        }


    }
}
