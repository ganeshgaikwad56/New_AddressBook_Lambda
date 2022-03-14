using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAddressBook
{
    /// <summary>
    /// UC1
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Firsts the person.(UC1)
        /// </summary>
        public void FirstPerson()
        {
            Console.WriteLine("Enter Your First Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Premanent Address");
            var Address = Console.ReadLine();
            Console.WriteLine("Enter Your City Name");
            string City = Console.ReadLine();
            Console.WriteLine("Enter Your State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code");
            int Zip = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter Your Phone Number");
            string Number= Console.ReadLine();
            Console.WriteLine("Enter Your MailID");
            string Mail = Console.ReadLine();

            Console.WriteLine("AddressBook");
            Console.WriteLine("*******AddressBook**********");
            Console.WriteLine(Name + LastName);
            Console.WriteLine(Address);
            Console.WriteLine(City);
            Console.WriteLine(State);
            Console.WriteLine(Zip);
            Console.WriteLine(Number);
            Console.WriteLine(Mail);
        }
    }
}
