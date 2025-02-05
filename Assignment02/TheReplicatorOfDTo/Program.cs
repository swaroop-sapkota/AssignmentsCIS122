// Written by Swaroop Sapkota
// 02/04/2025
// The Replicator of D'To

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheReplicatorOfDTo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Replicator replicator = new Replicator();

            replicator.GetUserInput();

            replicator.ReplicateArray();

            replicator.DisplayArrays();

            Console.ReadLine();
        }
    }
}
