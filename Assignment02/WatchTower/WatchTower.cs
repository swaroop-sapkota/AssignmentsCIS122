// Written by Swaroop Sapkota
// 02/03/2025
// WatchTower

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower
{
    public class WatchTower
    {
        static void Main(string[] args)
        {

            Console.Write("Enter x value: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y value: ");
            int y = Convert.ToInt32(Console.ReadLine());

            EnemyDirection enemyDirection = new EnemyDirection(x,y);

            string result = enemyDirection.Direction();

            Console.WriteLine(result);



        }
    }
}
