using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class nonFiction : Book
    {
        //varibles for none fiction books
        public string contentReference;
        private static int numberOfNoneFictionBooks = 0;

        //constructor for none fiction books
        public nonFiction(string _title, string _author, string _synopsis, long _isbn,
            string _contentReference) : base (_title, _author, _synopsis, _isbn)
        {
            this.contentReference = _contentReference;
            numberOfNoneFictionBooks++;
        }

        //polymorphic method 
        public new void getTypeOfBook()
        {
            Console.WriteLine("This book is in the {0} section", contentReference);
        }
    }
}
