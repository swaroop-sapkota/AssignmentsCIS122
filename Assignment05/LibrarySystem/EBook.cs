// Written by Swaroop Sapkota
// 02/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class EBook : Book
    {
        private double fileSizeMB = -99.99;

        // Gets and Sets
        public double FileSizeMB
        {
            get { return this.fileSizeMB; }
            set { this.fileSizeMB = value; }
        }

        // Constructor
        public EBook(string aTitle, string aAuthor, int aYearPublished, double aFileSizeMB) : base(aTitle, aAuthor, aYearPublished)
        {
            this.FileSizeMB = aFileSizeMB;
        }

        // ToString() method
        public override string ToString()
        {
            return $"{this.Title} by {this.Author}, {this.YearPublished}, File Size: {this.FileSizeMB}";
        }
    }
}
