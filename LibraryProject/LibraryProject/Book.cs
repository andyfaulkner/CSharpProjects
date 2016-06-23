using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Book
    {
        //all varibles used to descibe the book
        public string title;
        public string author;
        public string synopsis;
        public long isbn;

        //varible for total number of books
        private static int totalNumberOfBooks = 0;

        //Book constructer
        public Book(string _title, string _author, string _synopsis, long _isbn)
        {
            this.title = _title;
            this.author = _author;
            this.synopsis = _synopsis;
            this.isbn = _isbn;
            totalNumberOfBooks++;
        }

        //book printout
        public static void printBoookInfo()
        {
            Console.WriteLine();
        }

        ////demo inheritance method
        //public virtual void testMethod()
        //{
        //    Console.Write("This is contained in the book class");
        //}
    }
}
