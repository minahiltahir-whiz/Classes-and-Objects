using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Book
    {
        //Attributes/States/Varaible
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;


        //Behaviours/Methods

        public void DisplayDetails()
        {
            Console.WriteLine("           Book Details are as : ");
            Console.WriteLine($"-->Book Title: {Title}");
            Console.WriteLine($"-->Book Author: {Author}");
            Console.WriteLine($"-->Book ISBN: {ISBN}");
            Console.WriteLine($"-->Price of Book: ${Price}.");

        }

        public void Discount(double percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid discount percentage!");
                return;
            }
            Price -= Price * (percentage / 100);
        }

    }
}
