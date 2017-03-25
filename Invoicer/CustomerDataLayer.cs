using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDataLayer.Services;

namespace CustomerDataLayer.Models
{
    public class Customer : ICustomer
    {

        public Customer()
        {
            invoices = new Invoice[5];
        }

        public int customerNumber { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public long contactNumber { get; set; }
        public string address { get; set; }
        public Invoice[] invoices { get; set; }

    }

    public class Invoice : IInvoice
    {
        public int invoiceNumber { get; set; }
        public double cost { get; set; }
        public string paymentDate { get; set; }
        public string dueDate { get; set; }
        public bool paid { get; set; }

    }

}

namespace CustomerDataLayer.Services
{

    public interface IInvoice
    {



    }

    public interface ICustomer
    {



    }

}
