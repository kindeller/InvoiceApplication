using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicerDAL.Models
{
    public class Customer
    {
        public Customer(){ }
        //Customer Object constructor
        public Customer(int customerNumber, string firstName, string lastName, int addressID, int contactNumber)
        {
            CustomerNumber = customerNumber;
            FirstName = firstName;
            LastName = lastName;
            AddressID = addressID;
            ContactNumber = contactNumber;
            Invoices = new List<Invoice>();
        }
        


        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AddressID { get; set; }
        public int ContactNumber { get; set; }
        public List<Invoice> Invoices { get; set; }

    }
}
