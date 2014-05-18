// Written by Zack Rosales
// Program for page 537-8, # 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExceptionDemoGUI
{
    class Book
    {
        // class attributes
        private string title;
        private string author;
        private double price;
        private int pages;

        // constructor
        public Book(string t, string a, double pr, int pa)
        {
            if (pr / (double)pa > 10)
            {
                throw (new BookException(t, pr, pa));
            } // end if
            else
            {
                setClass(t, a, pr, pa);
            } // end else
        } // constructor end

        // properties
        public string Title { get; set; } // Title property end
        public string Author { get; set; } // Author property end
        public double Price { get; set; } // Price property end
        public int Pages { get; set; } // Pages property end

        // class set method
        private void setClass(string t, string a, double pr, int pa)
        {
            Title = t;
            Author = a;
            Price = pr;
            Pages = pa;
        } // class set method end
    } // Book class end
}
