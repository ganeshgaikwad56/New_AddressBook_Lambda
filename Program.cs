﻿using System;
using System.Collections.Generic;
namespace NewAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.ReadLine();
            AddressBook.RemovePeople();
            AddressBook.GetCustomer();
            AddressBook.ListingPeople();
        }
    }
}