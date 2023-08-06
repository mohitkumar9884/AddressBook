using System.Collections.Generic;

namespace AddressBook
{
    public class Program
    {
        static Dictionary<string, AddBook> addressbooks = new Dictionary<string, AddBook>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook program.");

            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add a new Address Book");
                Console.WriteLine("2. Select an Address Book");
                Console.WriteLine("3. Add a new contact");
                Console.WriteLine("4. View all contacts");
                Console.WriteLine("5. Edit an existing contact");
                Console.WriteLine("6. Delete a contact");
                Console.WriteLine("7. Exit");
                Console.WriteLine(" ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddNewAddressBook();
                            break;
                        case 2:
                            SelectAddressBook();
                            break;
                        case 3:
                            AddNewContact();
                            break;
                        case 4:
                            ViewAllContacts();
                            break;
                        case 5:
                            EditContact();
                            break;
                        case 6:
                            DeleteContact();
                            break;
                        case 7:
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
        }

        static void AddNewAddressBook()
        {
            Console.Write("Enter the name of the new Address Book: ");
            string name = Console.ReadLine();

            if (addressbooks.ContainsKey(name))
            {
                Console.WriteLine($"Address Book '{name}' already exists.");
            }
            else
            {
                addressbooks[name] = new AddBook { Name = name };
                Console.WriteLine($"Address Book '{name}' created successfully!");
            }
        }

        static void SelectAddressBook()
        {
            Console.Write("Enter the name of the Address Book you want to select: ");
            string name = Console.ReadLine();

            if (addressbooks.TryGetValue(name, out AddBook selectedAddressBook))
            {
                Console.WriteLine($"Selected Address Book: {selectedAddressBook.Name}");
            }
            else
            {
                Console.WriteLine($"Address Book '{name}' does not exist.");
            }
        }

        static void AddNewContact()
        {
            Console.Write("Enter the name of the Address Book where you want to add a new contact: ");
            string name = Console.ReadLine();

            if (addressbooks.TryGetValue(name, out AddBook selectedAddressBook))
            {
                Contact newContact = Contact.Personal();

                selectedAddressBook.Contacts.Add(newContact);
                Console.WriteLine("New contact added successfully!");
            }
            else
            {
                Console.WriteLine($"Address Book '{name}' does not exist.");
            }
        }

        static void ViewAllContacts()
        {
            Console.Write("Enter the name of the Address Book you want to view contacts: ");
            string name = Console.ReadLine();

            if (addressbooks.TryGetValue(name, out AddBook selectedAddressBook))
            {
                if (selectedAddressBook.Contacts.Count == 0)
                {
                    Console.WriteLine($"Address book '{name}' is empty.");
                }
                else
                {
                    Console.WriteLine($"\nContacts in Address Book '{name}':");
                    foreach (var contact in selectedAddressBook.Contacts)
                    {
                        Console.WriteLine($"First Name: {contact.FirstName}");
                        Console.WriteLine($"Last Name: {contact.LastName}");
                        Console.WriteLine($"Address: {contact.Address}");
                        Console.WriteLine($"City: {contact.City}");
                        Console.WriteLine($"State: {contact.State}");
                        Console.WriteLine($"Zip: {contact.Zipcode}");
                        Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                        Console.WriteLine($"Email: {contact.EmailAddress}");
                        Console.WriteLine("---------------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Address Book '{name}' does not exist.");
            }
        }
        static void EditContact()
        {
            Console.Write("Enter the name of the Address Book containing the contact you want to edit: ");
            string bookName = Console.ReadLine();

            if (addressbooks.TryGetValue(bookName, out AddBook selectedAddressBook))
            {
                Console.Write("Enter the First Name of the contact you want to edit: ");
                string firstName = Console.ReadLine();

                Contact contactToEdit = null;
                foreach (Contact contact in selectedAddressBook.Contacts)
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
            else
            {
                Console.WriteLine($"Address Book '{bookName}' does not exist.");
            }
        }
        static void DeleteContact()
        {
            Console.Write("Enter the name of the Address Book containing the contact you want to delete: ");
            string bookName = Console.ReadLine();

            if (addressbooks.TryGetValue(bookName, out AddBook selectedAddressBook))
            {
                Console.Write("Enter the First Name of the contact you want to delete: ");
                string firstName = Console.ReadLine();

                Contact contactToDelete = null;
                foreach (Contact contact in selectedAddressBook.Contacts)
                {
                    if (contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                    {
                        contactToDelete = contact;
                        break;
                    }
                }

                if (contactToDelete == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                selectedAddressBook.Contacts.Remove(contactToDelete);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Address Book '{bookName}' does not exist.");
            }
        }


    }

    
}