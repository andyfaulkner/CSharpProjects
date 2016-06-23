using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Fiction : Book
    {
        //varibles for fiction books
        public string genre;
        private static int numberOfFictionBooks = 0;

        //constructor for fiction books
        public Fiction(string _title, string _author, string _synopsis,
            long _isbn, string _genre) : base (_title, _author, _synopsis, _isbn)
        {
            this.genre = _genre;
            numberOfFictionBooks++;
        }

        //polymorphic method 
        public override void getTypeOfBook()
        {
            Console.WriteLine("This book is in the {0} section", genre);
        }
    }
}
