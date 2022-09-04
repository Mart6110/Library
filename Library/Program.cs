using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //A bool While false the program will keep running
            bool exit = false;

            //A bool That check if you wanna loan more books
            bool loan = true;

            //A list for the book the user has loaned
            List<Book> usersBook = new List<Book>();

            //A stack for the books the user is carrying and want to loan
            Stack<Book> bookToLoan = new Stack<Book>();

            //Objekt gui, used to show menu
            Gui gui = new Gui();

            //Objekt library
            Library library = new Library();

            //A variable to check different choices in the code
            ConsoleKeyInfo choice;

            //Adding books to the Library
            library.AddBookToLibrary("The Lord Of The Rings: One Volume", "J.R.R. Tolkien");
            library.AddBookToLibrary("Star Wars: Shadow of the Sith", "Adam Christopher");
            library.AddBookToLibrary("Fantastic Beasts and where to Find Them", "J.K. Rowling");
            library.AddBookToLibrary("Harry Potter and the Philosopher's Stone", "J.K. Rowling");

            do
            {
                Console.Clear();

                //Show the menu with the gui method called Menu
                gui.Menu();

                //Gets users input
                choice = Console.ReadKey();

                //A switch that does different things depending on the key pressed
                switch (choice.Key)
                {
                    case ConsoleKey.D1:

                        Console.Clear();

                        //Calls the ShowBooks method to show all books in the library
                        library.ShowBooks();

                        //Tells the user how to get back to the menu
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to go back to the menu");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D2:
                        do
                        {
                            Console.Clear();

                            //Shows library books
                            library.ShowBooks();

                            //Asks for the users input on what book they want to loan
                            Console.WriteLine("");
                            Console.WriteLine("Type the id of the book you want to loan");
                            int id = int.Parse(Console.ReadLine());

                            //Put the book the user want to loan into a stack called bookToLoan and removes the book from the library
                            library.Loan(id, bookToLoan);
                            Console.WriteLine("");

                            //Shows the book(s) the users has selected to loan
                            library.ShowBooksLoaning(bookToLoan);

                            //Ask if the user wants to loan more books
                            Console.WriteLine("Do you want to loan more book (y/n)");
                            choice = Console.ReadKey();

                            if (choice.Key == ConsoleKey.N)
                            {
                                loan = false;
                            }
                        //Loop breaks when loan isn't true anymore
                        } while (loan != false);
                        Console.Clear();

                        //Shows the book(s) the user wants to loan
                        library.ShowBooksLoaning(bookToLoan);

                        //Return to main menu
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to go back to the menu");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();

                        //Shows the book(s) the user selected to loan
                        library.ShowBooksLoaning(bookToLoan);

                        //Ask if user is ready to checkout
                        Console.WriteLine("");
                        Console.WriteLine("Ready to check out (y/n)");
                        choice = Console.ReadKey();

                        switch (choice.Key)
                        {
                            case ConsoleKey.Y:
                                Console.Clear();
                                //Checks out all the books the user selected to loan and put them in a list called usersBook
                                library.Checkout(bookToLoan, usersBook);
                                break;

                            default:
                                break;
                        }
                        //Clears Console and tell user how to get back to the menu
                        Console.Clear();
                        Console.WriteLine("Press Enter to go back to the menu");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        //Show the books the user currently has loaned
                        library.ShowCurrentlyLoaned(usersBook);

                        //tells user how to get back to the menu
                        Console.WriteLine("");
                        Console.WriteLine("press Enter to do back to the menu");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D5:

                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        break;
                }
                //Breaks the loop when exit isn't false anymore
            } while (exit != true);
        }
    }
}
