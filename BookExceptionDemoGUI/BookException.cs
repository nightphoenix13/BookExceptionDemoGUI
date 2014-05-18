// Written by Zack Rosales
// Program for page 537-8, # 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExceptionDemoGUI
{
    class BookException : Exception
    {
        // class attributes
        private string title;
        private double price;
        private int pages;
        private string output;

        // constructor
        public BookException(string t, double pr, int pa)
        {
            setClass(t, pr, pa);
        } // constructor end

        // properties
        public string Title { get; set; } // Title property end
        public double Price { get; set; } // Price property end
        public int Pages { get; set; } // Pages property end
        public string Output { get; private set; } // Output property end

        // class set method
        private void setClass(string t, double pr, int pa)
        {
            Title = t;
            Price = pr;
            Pages = pa;
            output = "Book costs too much: " + t + ", $" + pr + ", Pages: " + pa;
        } // class set method end

        // override of ToString method
        public override string ToString()
        {
            return output;
        } // ToString method end
    } // BookException exception end
}
