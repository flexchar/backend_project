using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZIP { get; set; }
        public string City { get; set; }

        public List<string> PhoneNumbers { get; }

        public DateTime Birthday { get; set; }

        public int Age { get; }

        public List<Invoice> Invoices { get; set; }

        public Customer(int customerId, string firstName, string lastName, string address, string zip, string city)
        {
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.ZIP = zip;
            this.City = city;
        }

        public Customer AddPhoneNumber(string phone)
        {
            this.PhoneNumbers.Add(phone);
            return this;
        }

        public Customer AddInvoice(Invoice invoice)
        {
            this.Invoices.Add(invoice);
            return this;
        }


    }
}
