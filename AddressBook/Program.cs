namespace AddressBook
{
    public class Program
    {

        static List<Contact> addressbook = new List<Contact>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook program.");

            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. View all contacts");
                Console.WriteLine("3. Edit an existing contact");
                Console.WriteLine("4. Exit");
                Console.WriteLine(" ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddNewContact();
                            break;
                        case 2:
                            ViewAllContacts();
                            break;
                        case 3:
                            EditContact();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            static void AddNewContact()
            {
                Console.WriteLine("Enter Contact Details:");
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("State: ");
                string state = Console.ReadLine();

                Console.Write("Zipcode: ");
                string zip = Console.ReadLine();

                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Contact newContact = new Contact
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

                addressbook.Add(newContact);
                Console.WriteLine("New contact added successfully!");
            }
            static void ViewAllContacts()
            {
                if (addressbook.Count == 0)
                {
                    Console.WriteLine("Address book is empty.");
                }
                else
                {
                    Console.WriteLine("\nContact Details:");
                    foreach (var contact in addressbook)
                    {
                        Console.WriteLine("First Name: " + contact.FirstName);
                        Console.WriteLine("Last Name: " + contact.LastName);
                        Console.WriteLine("Address: " + contact.Address);
                        Console.WriteLine("City: " + contact.City);
                        Console.WriteLine("State: " + contact.State);
                        Console.WriteLine("Zip: " + contact.Zipcode);
                        Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                        Console.WriteLine("Email: " + contact.EmailAddress);
                        Console.WriteLine("---------------------------------");
                    }
                }


            }
            static void EditContact()
            {
                Console.Write("Enter the First Name of the contact you want to edit: ");
                string firstName = Console.ReadLine();

                Contact contactToEdit = null;
                foreach (Contact contact in addressbook)
                {
                    if (contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                    {
                        contactToEdit = contact;
                        break;
                    }
                }

                if (contactToEdit == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                Console.WriteLine($"\nEditing Contact: {contactToEdit.FirstName}");
                Console.Write("Enter New First Name: ");
                contactToEdit.FirstName = Console.ReadLine();

                Console.Write("Enter New Last Name: ");
                contactToEdit.LastName = Console.ReadLine();

                Console.Write("Enter New Address: ");
                contactToEdit.Address = Console.ReadLine();

                Console.Write("Enter New City: ");
                contactToEdit.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                contactToEdit.State = Console.ReadLine();

                Console.Write("Enter New Zipcode: ");
                contactToEdit.Zipcode = Console.ReadLine();

                Console.Write("Enter New Phone Number: ");
                contactToEdit.PhoneNumber = Console.ReadLine();

                Console.Write("Enter New Email: ");
                contactToEdit.EmailAddress = Console.ReadLine();

                Console.WriteLine("Contact details updated successfully!");
            }
        }

    }

    
}