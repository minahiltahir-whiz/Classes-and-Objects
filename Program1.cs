using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("     Library Management System     ");
            Book book_1 = new Book();
            book_1.Title = "Professional C# 7 and .NET Core 2.0.";
            book_1.Author = "Christian Nagel.";
            book_1.ISBN = "9888554032.";
            book_1.Price = 980;


            Book book_2 = new Book();
            book_2.Title = "C# 7.0 in a Nutshell.";
            book_2.Author = "Joseph Albahari and Ben Albahari.";
            book_2.ISBN = "00678787661.";
            book_2.Price = 1035;

            //Book Details
            book_1.DisplayDetails();
            book_2.DisplayDetails();

            //Applying Discount 
            book_1.Discount(10);
            book_2.Discount(25);

            //Details of Book After DIScount
            Console.WriteLine($"\n Details after Applying Discount.");

            book_1.DisplayDetails();
            book_2.DisplayDetails();

            Console.ReadLine();
        }
    }
}
