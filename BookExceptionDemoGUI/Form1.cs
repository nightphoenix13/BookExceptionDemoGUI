// Written by Zack Rosales
// Program for page 537-8, # 6

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookExceptionDemoGUI
{
    public partial class Form1 : Form
    {
        // global variables and constants
        const int SIZE = 5;
        Book[] books = new Book[SIZE];
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(titleTextBox.Text) ||
                String.IsNullOrEmpty(authorTextBox.Text) ||
                String.IsNullOrEmpty(priceTextBox.Text) ||
                String.IsNullOrEmpty(pagesTextBox.Text))
            {
                MessageBox.Show("You must fill out all fields.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end if
            else
            {
                if (count == SIZE)
                {
                    MessageBox.Show("You can only have 5 books.", "Max Books",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // end if
                try
                {
                    books[count] = new Book(titleTextBox.Text, authorTextBox.Text,
                        Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(
                        pagesTextBox.Text));
                    count++;
                    refreshBooks();
                } // end try
                catch (FormatException exception)
                {
                    MessageBox.Show(e.ToString(), "Exception", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                } // end catch
            } // end else
        } // addBookButton_Click method end

        // refreshBooks method keeps books in the front of the array
        private void refreshBooks() // refreshBooks method start
        {
            if (count == 0)
            {
                removeButton.Enabled = false;
            } // end if
            else
            {
                removeButton.Enabled = true;
            } // end else
            if (count == SIZE)
            {
                addBookButton.Enabled = false;
            } // end if
            else
            {
                addBookButton.Enabled = true;
            } // end else
        } // refreshBooks method end
    }
}
