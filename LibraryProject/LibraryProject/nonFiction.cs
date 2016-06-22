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

        //constructor for fiction books
        public nonFiction(string _title, string _author, string _synopsis, long _isbn, string _contentReference) : base (_title, _author, _synopsis, _isbn)
        {
            this.contentReference = _contentReference;
        }

    }
}
