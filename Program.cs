using System;

namespace NewAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");
            Console.ReadLine();
            AddressBook.GetCustomer();
            AddressBook.ListingPeople();
        }
    }
}