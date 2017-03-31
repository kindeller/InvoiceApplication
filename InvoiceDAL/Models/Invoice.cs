using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicerDAL.Models
{
    public class Invoice
    {
        //Invoice Constructor
        public Invoice(int invoiceID, int customerID, int totalCost, bool paid, DateTime dueDate, DateTime paymentDate)
        {
            InvoiceID = invoiceID;
            CustomerID = customerID;
            TotalCost = totalCost;
            Paid = paid;
            DueDate = dueDate;
            PaymentDate = paymentDate;
        }

        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public int TotalCost { get; set; }
        public bool Paid { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
