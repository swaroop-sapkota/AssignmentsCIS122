// Written by Swaroop Sapkota
// 02/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        // class variables

        private string title = "n/a";
        private string author = "n/a";
        private int yearPublished = -1;

        // getter and setter

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        // Constructor
        public Book(string aTitle, string aAuthor, int aYearPublished)
        {
            this.Title = aTitle;
            this.Author = aAuthor;
            this.YearPublished = aYearPublished;
        }
        
        // ToString Method
        public override string ToString() 
        {
            return $"{this.Title} by {this.Author} ({this.YearPublished})";
        }

    }
}
