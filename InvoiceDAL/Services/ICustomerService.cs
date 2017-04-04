using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoicerDAL.Models;

namespace InvoicerDAL.Services
{
    public interface ICustomerService
    {
        //search for a customer
        List<Customer> GetAllCustomers();

        Customer GetCustomerByID(int ID);

        List<Customer> GetCustomerByFirstName(string name);

        List<Customer> GetCustomerByLastName(string name);

        List<Invoice> GetCustomerInvoices(int customerNumber);

        Customer AddCustomer(Customer customer);
    }
}
