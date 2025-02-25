// Written by Swaroop Sapkota
// 02/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class PrintedBook: Book
    {
        private int pageCount = -1;

        // Gets and Sets
        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount= value; }
        }

        // Constructor
        public PrintedBook(string aTitle, string aAuthor, int aYearPublished, int aPageCount) : base(aTitle, aAuthor, aYearPublished)
        {
            this.PageCount = aPageCount;
        }

        // ToString() method
        public override string ToString()
        {
            return $"{this.Title} by {this.Author}, {this.YearPublished}, Page Count: {this.PageCount}";
        }
    }
}
