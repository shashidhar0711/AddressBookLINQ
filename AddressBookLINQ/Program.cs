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
            addressBookRepo.CreateBookTable();
            addressBookRepo.GetAllRecordsInTable();
        }
    }
}
