using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookLINQ
{
    /// <summary>
    /// Getters and setters of contact
    /// </summary>
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="FirstName">The first name.</param>
        /// <param name="LastName">The last name.</param>
        /// <param name="Address">The address.</param>
        /// <param name="City">The city.</param>
        /// <param name="State">The state.</param>
        /// <param name="ZipCode">The zip code.</param>
        /// <param name="PhoneNumber">The phone number.</param>
        /// <param name="Email">The email.</param>
        /// <param name="BookName">Name of the book.</param>
        /// <param name="BookType">Type of the book.</param>
        public Contact(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string PhoneNumber, string Email, string BookName, string BookType)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.BookName = BookName;
            this.BookType = BookType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
        }
    }
}
