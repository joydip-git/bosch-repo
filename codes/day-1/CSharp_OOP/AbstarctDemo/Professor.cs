using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctDemo
{
    class Professor : Person
    {
        int booksPublished;
        public Professor()
        {

        }
        public Professor(string name, int books) : base(name)
        {
            this.booksPublished = books;
        }

        public int BooksPublished { get => booksPublished; set => booksPublished = value; }

        public override bool IsOutstanding()
        {
            return this.booksPublished >= 5;
        }

        public override string Status => IsOutstanding() ? $"{Name} is outstanding Professor" : $"{Name} is not an outstanding Professor";
    }
}
