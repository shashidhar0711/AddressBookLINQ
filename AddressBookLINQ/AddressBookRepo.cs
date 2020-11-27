using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLINQ
{
    public class AddressBookRepo
    {
        /// <summary>
        /// Initializes a new instances of the data table
        /// </summary>
        DataTable dataTable = new DataTable();
        /// <summary>
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
        }
    }
}
