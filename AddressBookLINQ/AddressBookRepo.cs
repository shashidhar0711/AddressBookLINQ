using System;
using System.Collections.Generic;
using System.Data;
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

        public void GetAllRecordsInTable()
        {
            foreach(var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("FirstName:- "+table.Field<String>("FirstName"));
                Console.WriteLine("LastName:- " + table.Field<String>("LastName"));
                Console.WriteLine("Address:- " + table.Field<String>("Address"));
                Console.WriteLine("City:- " + table.Field<String>("City"));
                Console.WriteLine("State:- " + table.Field<String>("State"));
                Console.WriteLine("ZipCode:- " + table.Field<String>("ZipCode"));
                Console.WriteLine("PhoneNumber:- " + table.Field<String>("PhoneNumber"));
                Console.WriteLine("Email:- " + table.Field<String>("Email"));
            }
        }
    }
}
