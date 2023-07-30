using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public static Contact Personal()
        {
            Console.Write("Enter Your First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Your Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Your City: ");
            string city = Console.ReadLine();

            Console.Write("Enter Your State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Zipcode: ");
            string zip = Console.ReadLine();

            Console.Write("Enter Your Cell Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Your Email-id: ");
            string email = Console.ReadLine();

            return new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                State = state,
                Zipcode = zip,
                PhoneNumber = phoneNumber,
                EmailAddress = email
            };
        }

    }
}
