﻿using System;

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
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 Display");
                Console.WriteLine("2 Add Contact");
                Console.WriteLine("3 Edit Existing Contact");
                Console.WriteLine("4 Delete Contact");
                Console.WriteLine("5 Get Person Belongings By Giving State");
                Console.WriteLine("6 Get Person Belongings By Giving City");
                Console.WriteLine("7 Get Person Count By Giving State");
                Console.WriteLine("8 Get Person Count By Giving City");
                Console.WriteLine("9 Get Person sorted in Alphabetically Order By Giving City");
                Console.WriteLine("10 Get Count by Book Type");
                Console.WriteLine("11 Get Person sorted in Alphabetically Order");
                Console.WriteLine("12 Get Sort Entries in Alphabetically Order By Giving City");
                Console.WriteLine("13 Get Sort Entries in Alphabetically Order By Giving State");
                Console.WriteLine("14 Get Sort Entries in Alphabetically Order By Giving ZipCode");
                Console.WriteLine("15 Exit");
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
                        Console.WriteLine("Enter City: ");
                        contact.City = Console.ReadLine();
                        addressBookRepo.RetrievePersonDataByUsingCity(contact);
                        break;
                    case 7:
                        addressBookRepo.RetrieveCountByState();
                        break;
                    case 8:
                        addressBookRepo.RetrieveCountByCity();
                        break;
                    case 9:
                        Console.WriteLine("Enter City: ");
                        contact.City = Console.ReadLine();
                        addressBookRepo.SortPersonNameAlphabetically(contact);
                        break;
                    case 10:
                        addressBookRepo.GetCountByABookType();
                        break;
                    case 11:
                        addressBookRepo.SortPersonNameAlphabeticallOrder();
                        break;
                    case 12:
                        Console.WriteLine("Enter City: ");
                        contact.City = Console.ReadLine();
                        addressBookRepo.SortPersonNameAlphabeticallyByGivingCity(contact);
                        break;
                    case 13:
                        Console.WriteLine("Enter State: ");
                        contact.City = Console.ReadLine();
                        addressBookRepo.SortPersonNameAlphabeticallyByGivingState(contact);
                        break;
                    case 14:
                        Console.WriteLine("Enter ZiCode: ");
                        contact.City = Console.ReadLine();
                        addressBookRepo.SortPersonNameAlphabeticallyByGivingiZip(contact);
                        break;
                    case 15:
                        return;
                    default:
                        Console.WriteLine("Enter valid choice between 1 to 15");
                        break;
                }
            }
        }

    }
}
