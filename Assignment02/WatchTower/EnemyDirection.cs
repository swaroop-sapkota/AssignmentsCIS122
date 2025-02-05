// Written by Swaroop Sapkota
// 02/03/2025
// WatchTower

using System;

namespace WatchTower
{
    public class EnemyDirection
    {
        // Class variables
        private int xValue;
        private int yValue;

        // Properties
        public int XValue
        {
            get { return this.xValue; }
            set { this.xValue = value; }
        }

        public int YValue
        {
            get { return this.yValue; }
            set { this.yValue = value; }
        }

        // Constructor
        public EnemyDirection(int x, int y)
        {
            this.XValue = x;
            this.YValue = y;
        }

        // Method to determine enemy direction
        public string Direction()
        {
            if (this.XValue < 0)
            {
                if (this.YValue > 0)
                    return "The enemy is to the northwest!";
                else if (this.YValue == 0)
                    return "The enemy is to the west!";
                else
                    return "The enemy is to the southwest!";
            }
            else if (this.XValue == 0)
            {
                if (this.YValue > 0)
                    return "The enemy is to the north!";
                else if (this.YValue == 0)
                    return "The enemy is here!";
                else
                    return "The enemy is to the south!";
            }
            else
            {
                if (this.YValue > 0)
                    return "The enemy is to the northeast!";
                else if (this.YValue == 0)
                    return "The enemy is to the east!";
                else
                    return "The enemy is to the southeast!";
            }
        }
    }
}
