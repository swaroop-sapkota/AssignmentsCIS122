// Written by Swaroop Sapkota
// 02/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class ProgramLS
    {
        static void Main(string[] args)
        {
            Book genericBook = new Book("Mystery Novel", "Unknown Author", 2000);
            PrintedBook printedBook = new PrintedBook("Atomic Habits", "James Clear", 2018, 320);
            EBook eBook = new EBook("Can't Hurt Me", "David Goggins", 2018, 6.2);

            Console.WriteLine(genericBook);
            Console.WriteLine(printedBook);
            Console.WriteLine(eBook);

        }
    }
}
