using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoicerDAL.Models;

namespace InvoicerDAL.Services
{
    public interface IInvoiceService
    {
        //get invoices by customer
        List<Invoice> GetInvoices();


    }
}
