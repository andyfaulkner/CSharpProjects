using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //create some books for the program to use
            Fiction ficBook1 = new Fiction("Ready Player One", "Ernest Cline", 
                "It's the year 2044, and the real world has become an ugly place. We're out of oil. We've wrecked the climate. Famine, poverty, and disease are widespread.",
                9780307887443, "Science Fiction");

            nonFiction nonFicBook1 = new nonFiction("JavaScript & JQuery: Interactive Front-end Web Development", "Jon Duckett",
                "This full–color book adopts a visual approach to teaching JavaScript & jQuery, showing you how to make web pages more interactive and interfaces more intuitive through the use of inspiring code examples, infographics, and photography.",
                9781118871652, "Programming");

            Book book1 = new Book("Instance of Book object", "Andy Faulkner",
                "Used to demo polymorphic methods", 1234567890123);

            //print out some details to test fiction
            Console.WriteLine(ficBook1.title);
            Console.WriteLine(ficBook1.author);
            Console.WriteLine(ficBook1.genre);
            Console.WriteLine(ficBook1.synopsis);

            //creating some blank lines
            Console.WriteLine("\n");

            //print out some details to test none fiction
            Console.WriteLine(nonFicBook1.title);
            Console.WriteLine(nonFicBook1.author);
            Console.WriteLine(nonFicBook1.contentReference);
            Console.WriteLine(nonFicBook1.synopsis);

            //creating some blank lines
            Console.WriteLine("\n");

            //print out some details to test using the book constructer
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.synopsis);

            //creating some blank lines
            Console.WriteLine("\n");

            //Demo of polymorphic methods
            ficBook1.getTypeOfBook();
            nonFicBook1.getTypeOfBook();
            book1.getTypeOfBook();
        }
    }
}
