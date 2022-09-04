using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        //Creates a list called books to store all the books in the library
        public List<Book> books = new List<Book>();

        //Method to add books to the library
        public void AddBookToLibrary(string title, string author)
        {
            books.Add(new Book(title, author));
        }

        //Method to show all the books in the library
        public void ShowBooks()
        {
            int id = 1;
            foreach (Book b in books)
            {
                Console.WriteLine($"{b}/ Id: {id}");
                id++;
            }
        }
        //Method to loan books
        public void Loan(int id, Stack<Book> usersLoan)
        {
            id--;
            usersLoan.Push(books[id]);
            books.Remove(books[id]);

        }
        //Method to show the books you want to loan
        public void ShowBooksLoaning(Stack<Book> usersLoan)
        {
            Console.WriteLine("Book(s) you want to loan:");
            foreach (Book b in usersLoan)
            {
                Console.WriteLine(b);
            }
        }
        //Method to checkout the books you want to loan
        public void Checkout(Stack<Book> booksToLoan, List<Book> bag)
        {

            while (booksToLoan.Count > 0)
            {
                Console.WriteLine("Begining Checkout:");
                Console.WriteLine("");
                Console.WriteLine(booksToLoan.Peek());
                Console.WriteLine("Checking out...");
                Thread.Sleep(2000);
                Console.WriteLine("");
                Console.WriteLine(booksToLoan.Peek());
                Console.WriteLine("Checked out correctly");
                bag.Add(booksToLoan.Peek());
                booksToLoan.Pop();
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        //Method to show all the books the user is currently loaning
        public void ShowCurrentlyLoaned(List<Book> bag)
        {
            Console.WriteLine("Currently loaned books");
            Console.WriteLine("");
            foreach (Book b in bag)
            {
                Console.WriteLine(b);
            }
        }
    }
}
