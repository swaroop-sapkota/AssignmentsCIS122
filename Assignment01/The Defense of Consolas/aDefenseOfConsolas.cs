// Written by Swaroop
// 01/30/2025
// The Defense of Consolas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseOfConsolas
{
    public class aDefenseOfConsolas
    {
        // Class variables 

        private int targetRow;
        private int targetColumn;

        // constructor

        public aDefenseOfConsolas(int row, int column)
        {
            this.targetRow = row;
            this.targetColumn = column;
        }

        // ToString method

        public override string ToString()
        {
            String msg = "";
            msg += $"({targetRow}, {targetColumn - 1})\n" +  
                   $"({targetRow - 1}, {targetColumn})\n" +  
                   $"({targetRow}, {targetColumn + 1})\n" +  
                   $"({targetRow + 1}, {targetColumn})";
            return msg;
        }
    }
}
