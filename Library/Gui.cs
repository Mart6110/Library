using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Gui
    {
        //Using a method to create a menu
        public void Menu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("              Library Menu");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Show all book in Library");
            Console.WriteLine("2. Pick books you want to loan");
            Console.WriteLine("3. Checkout the books you want to loan");
            Console.WriteLine("4. Check currently loaned books");
            Console.WriteLine("5. exit program");
        }
    }
}
