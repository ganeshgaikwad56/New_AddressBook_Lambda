using System;
using System.Collections.Generic;
namespace NewAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Progam \n");
            CreateAddressBook createAddressBook = new CreateAddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();
        }
    }
}