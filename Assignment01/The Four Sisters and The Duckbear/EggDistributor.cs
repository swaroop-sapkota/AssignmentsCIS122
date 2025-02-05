// Written by Swaroop
// 01/29/2025
// The Four Sisters and the Duckbear

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSistersAndDuckbear
{
    public class EggDistributor
    {
        // Class Variables
        private const int noOfSisters = 4;
        private int noOfEggs = -1;

        // Gets and Sets
        public int NoOfEggs
        {
            get { return this.noOfEggs; }
            set { this.noOfEggs = value; }
        }

        // Method to calculate the no. of eggs each sister gets
        public int GetEggsPerSister()
        {
            return this.noOfEggs / noOfSisters;
        }

        // Method to calculate the no. of eggs duckbear gets
        public int GetEggsForDuckbear()
        {
            return this.noOfEggs % noOfSisters;
        }

        // ToStringMethod
        public override string ToString()
        {
            String msg = "";
            msg += $"\nEach sister gets {GetEggsPerSister()} eggs.\nThe duckbear gets {GetEggsForDuckbear()} eggs.";
            return msg;
        }
    }
}
