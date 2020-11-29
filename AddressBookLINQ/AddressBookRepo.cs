using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookLINQ
{
    public class AddressBookRepo
    {
        /// <summary>
        /// UC1
        /// Initializes a new instances of the data table
        /// </summary>
        DataTable dataTable = new DataTable();

        /// <summary>
        /// UC2
        /// Creates the book table.
        /// </summary>
        public void CreateBookTable()
        {
            /// Creating columns
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));

            /// UC2
            /// Creating rows and inserting in column vice
            dataTable.Rows.Add("Ravi","Kumar","Gowtham Nagar","Bangarpet","Karnataka","563114","8073112156","shashidhar.sasic@gmail.com");
            dataTable.Rows.Add("Lalith", "Kumar", "Vijay Nagar", "Bangarpet", "Karnataka","563122", "8223112156", "lalith.lalu@gmail.com");
            dataTable.Rows.Add("Mohan", "Kumar", "Shanthi Nagar", "Bangalore", "Tamilnadu","560018", "9973112156", "mohanrah.mohan@gmail.com");
            dataTable.Rows.Add("Kiran", "Kumar", "Ambedkar Nagar", "Kolar", "AndhraPradesh","561363", "8073174156", "kiran.Kid@gmail.com");
            dataTable.Rows.Add("Sridhar", "Kumar", "Amravathi Nagar", "Kgf", "Delhi","560018", "8073114656", "sridhar.sri@gmail.com");
            dataTable.Rows.Add("Praveen", "Kumar", "Vivekanandha Nagar", "Malur", "Mumbai","563441", "8000112156", "praveen.pravi@gmail.com");
        }

        /// <summary>
        /// Gets all records in table.
        /// </summary>
        public void GetAllRecordsInTable()
        {
            foreach(var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("FirstName:- "+table.Field<String>("FirstName"));
                Console.WriteLine("LastName:- " + table.Field<String>("LastName"));
                Console.WriteLine("Address:- " + table.Field<String>("Address"));
                Console.WriteLine("City:- " + table.Field<String>("City"));
                Console.WriteLine("State:- " + table.Field<String>("State"));
                Console.WriteLine("ZipCode:- " + table.Field<String>("ZipCode"));
                Console.WriteLine("PhoneNumber:- " + table.Field<String>("PhoneNumber"));
                Console.WriteLine("Email:- " + table.Field<String>("Email"));
                Console.WriteLine("---------------------------------------------");
            }
        }

        /// <summary>
        /// UC3
        /// Adds the contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void AddContact(Contact contact)
        {
            dataTable.Rows.Add(contact.FirstName, contact.LastName,contact.Address,contact.City,contact.State,
                contact.ZipCode,contact.PhoneNumber,contact.Email);
            Console.WriteLine("Contact Added SuccesFull");
        }

        /// <summary>
        /// UC4
        /// Edits the contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void EditContact(Contact contact)
        {
            /// linq query to Check exist or not
            /// Returns first element of sequence
            var recordedData = dataTable.AsEnumerable().Where(data => data.Field<string>("FirstName") == contact.FirstName).First();
            if(recordedData != null)
            {
                recordedData.SetField("LastName", contact.LastName);
                recordedData.SetField("Address", contact.Address);
                recordedData.SetField("City", contact.City);
                recordedData.SetField("State", contact.State);
                recordedData.SetField("ZipCode", contact.ZipCode);
                recordedData.SetField("PhoneNumber", contact.PhoneNumber);
                recordedData.SetField("Email", contact.Email);
            }
            else
            {
                Console.WriteLine("No dataFound");
            }
        }

        /// <summary>
        /// UC5
        /// Deletes the contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void DeleteContact(Contact contact)
        {
            var recordedData = dataTable.AsEnumerable()
                               .Where(data => (data.Field<string>("FirstName") == contact.FirstName) && 
                               (data.Field<string>("LastName") == contact.LastName)).First();
            if(recordedData != null)
            {
                recordedData.Delete();
            }
        }

        /// <summary>
        /// UC6
        /// Retrieves the state of the person data by using.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void RetrievePersonDataByUsingState(Contact contact)
        {
            var selectedData = from dataTable in dataTable.AsEnumerable()
                               .Where(dataTable => dataTable.Field<string>("State") == contact.State)
                               select dataTable;
            foreach (var table in selectedData.AsEnumerable())
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("FirstName:- " + table.Field<String>("FirstName"));
                Console.WriteLine("LastName:- " + table.Field<String>("LastName"));
                Console.WriteLine("Address:- " + table.Field<String>("Address"));
                Console.WriteLine("City:- " + table.Field<String>("City"));
                Console.WriteLine("State:- " + table.Field<String>("State"));
                Console.WriteLine("ZipCode:- " + table.Field<String>("ZipCode"));
                Console.WriteLine("PhoneNumber:- " + table.Field<String>("PhoneNumber"));
                Console.WriteLine("Email:- " + table.Field<String>("Email"));
                Console.WriteLine("---------------------------------------------");
            }
        }

        /// <summary>
        /// UC6
        /// Retrieves the person data by using city.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void RetrievePersonDataByUsingCity(Contact contact)
        {
            var selectedData = from dataTable in dataTable.AsEnumerable()
                               .Where(dataTable => dataTable.Field<string>("City") == contact.City)
                               select dataTable;
            foreach (var table in selectedData.AsEnumerable())
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("FirstName:- " + table.Field<String>("FirstName"));
                Console.WriteLine("LastName:- " + table.Field<String>("LastName"));
                Console.WriteLine("Address:- " + table.Field<String>("Address"));
                Console.WriteLine("City:- " + table.Field<String>("City"));
                Console.WriteLine("State:- " + table.Field<String>("State"));
                Console.WriteLine("ZipCode:- " + table.Field<String>("ZipCode"));
                Console.WriteLine("PhoneNumber:- " + table.Field<String>("PhoneNumber"));
                Console.WriteLine("Email:- " + table.Field<String>("Email"));
                Console.WriteLine("---------------------------------------------");
            }
        }

        /// <summary>
        /// UC7
        /// Retrieves the count by city.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void RetrieveCountByCity(Contact contact)
        {
            var countData = dataTable.AsEnumerable()
                            .GroupBy(city => city.Field<String>("City"))
                            .Select(city => new
                            {
                                City = city.Key,
                                Count = city.Count()
                            });

            foreach (var Item in countData)
            {
                Console.WriteLine("City: " + Item.City + " " + "Count: " + Item.Count);
                break;
            }
        }

        /// <summary>
        /// UC7
        /// Retrieves the state of the count by.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void RetrieveCountByState(Contact contact)
        {
            var countData = dataTable.AsEnumerable()
                            .GroupBy(state => state.Field<String>("State"))
                            .Select(state => new
                            {
                                state = state.Key,
                                Count = state.Count()
                            });

            foreach (var Item in countData)
            {
                Console.WriteLine("City: " + Item.state + " " + "Count: " + Item.Count);
                break;
            }
        }

        /// <summary>
        /// UC8
        /// Sorts the person name alphabetically.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void SortPersonNameAlphabetically(Contact contact)
        {
            var sortData = from data in dataTable.AsEnumerable()
                           .Where(city => city.Field<String>("City") == contact.City)
                           .OrderBy(firstName => firstName.Field<String>("FirstName"))
                           select data;

            foreach (var table in sortData.AsEnumerable())
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("FirstName:- " + table.Field<String>("FirstName"));
                Console.WriteLine("LastName:- " + table.Field<String>("LastName"));
                Console.WriteLine("Address:- " + table.Field<String>("Address"));
                Console.WriteLine("City:- " + table.Field<String>("City"));
                Console.WriteLine("State:- " + table.Field<String>("State"));
                Console.WriteLine("ZipCode:- " + table.Field<String>("ZipCode"));
                Console.WriteLine("PhoneNumber:- " + table.Field<String>("PhoneNumber"));
                Console.WriteLine("Email:- " + table.Field<String>("Email"));
                Console.WriteLine("---------------------------------------------");
            }
        }
        /// <summary>
        /// UC9
        /// Adds the type of the address book name and book.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void AddAddressBookNameAndBookType(Contact contact)
        {
            /// Creating  two Columns
            dataTable.Columns.Add("BookName", typeof(string));
            dataTable.Columns.Add("BookType", typeof(string));
            /// Adding rows into columns vice
            dataTable.Rows.Add(contact.BookName, contact.BookType);
        }
    }
}
