using System;

namespace AddressBookLINQ
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme To AddressBook Using Linq");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            Contact contact = new Contact();
            addressBookRepo.CreateBookTable();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Welcome To AddressBook Linq");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 Display");
                Console.WriteLine("2 Add Contact");
                Console.WriteLine("3 Edit Existing Contact");
                Console.WriteLine("4 Delete Contact");
                Console.WriteLine("5 Get Person Belongings By Giving State");
                Console.WriteLine("6 Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookRepo.GetAllRecordsInTable();
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name:");
                        contact.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        contact.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        contact.Address = Console.ReadLine();
                        Console.WriteLine("Enter City:");
                        contact.City = Console.ReadLine();
                        Console.WriteLine("Enter State:");
                        contact.State = Console.ReadLine();
                        Console.WriteLine("Enter Zip code:");
                        contact.ZipCode = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number:");
                        contact.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email:");
                        contact.Email = Console.ReadLine();
                        addressBookRepo.AddContact(contact);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name: ");
                        contact.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name: ");
                        contact.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address: ");
                        contact.Address = Console.ReadLine();
                        Console.WriteLine("Enter City: ");
                        contact.City = Console.ReadLine();
                        Console.WriteLine("Enter State: ");
                        contact.State = Console.ReadLine();
                        Console.WriteLine("Enter Zip code: ");
                        contact.ZipCode = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number: ");
                        contact.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email ID: ");
                        contact.Email = Console.ReadLine();
                        addressBookRepo.EditContact(contact);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name: ");
                        contact.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name: ");
                        contact.LastName = Console.ReadLine();
                        addressBookRepo.DeleteContact(contact);
                        break;
                    case 5:
                        Console.WriteLine("Enter State: ");
                        contact.State = Console.ReadLine();
                        addressBookRepo.RetrievePersonDataByUsingState(contact);
                        break;
                    case 6:
                        return;
                }
            }
        }

    }
}
