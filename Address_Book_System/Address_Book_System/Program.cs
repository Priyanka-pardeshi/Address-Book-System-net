using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System !");
            AddressBook addr = new AddressBook();
            addr.Book();
            Console.ReadKey();
        }
    }
}
