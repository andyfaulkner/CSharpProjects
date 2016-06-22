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

            //print out some details to test
            Console.WriteLine(ficBook1.title);
            Console.WriteLine(ficBook1.author);
            Console.WriteLine(ficBook1.genre);
            Console.WriteLine(ficBook1.synopsis);
        }
    }
}
