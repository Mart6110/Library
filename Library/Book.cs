using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        // Properties
        private string name;
        private string author;

        // Encapsulation
        public string Name { get { return name; } }
        public string Author { get { return author; } }

        // Constructor
        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        // Override ToString, so we get the right output
        public override string ToString()
        {
            return Name + " by " + Author;
        }
    }
}
