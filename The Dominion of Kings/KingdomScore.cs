// Written by Swaroop Sapkota
// 01/30/2025
// The Dominion of Kings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DominionOfKings
{
    public class KingdomScore
    {
        // Class variables

        private int provinces = -1;
        private int duchies = -1;
        private int estates = -1;

        // Gets and sets
        public int Provinces
        {
            get { return this.provinces; }
            set { this.provinces = value; }
        }

        public int Duchies
        {
            get { return this.duchies; }
            set { this.duchies = value; }
        }

        public int Estates
        {
            get { return this.estates; }
            set { this.estates = value; }
        }

        // constructor
        public KingdomScore(int aProvinces, int aDuchies, int aEstates)
        {
            this.Provinces = aProvinces;
            this.Duchies = aDuchies;
            this.Estates = aEstates;
        }

        // Method to calculate the total score
        public int GetTotalScore()
        {
            return this.Provinces * 6 + this.Duchies * 3 + this.Estates * 1;
        }

        // ToString Method
        public override string ToString()
        {
            String msg = "";

            msg += $"\nProvinces: {Provinces}, Duchies: {Duchies}, Estates: {Estates} \nTotal Points: {GetTotalScore()}"; 
            return msg;
        }
    }
}
