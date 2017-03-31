using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicer;
using InvoicerDAL.Models;
using InvoicerDAL.Services;

namespace Invoicer
{
     public partial class CustomerSelection : Form
    {
        Customer chosenCustomer;
        Customer[] CustomerList;
        InvoiceTemplate parentForm;
        

        public CustomerSelection(Customer[] customerlist, InvoiceTemplate parent)
        {
            InitializeComponent();
            CustomerList = customerlist;
            populateListBox();
            parentForm = parent;
        }

        private void populateListBox()
        {
            clearList();
            foreach (Customer cust in CustomerList)
            {
                customerListBox.Items.Add(cust.CustomerNumber +": "+cust.FirstName+" "+cust.LastName);
            }
        }


        private void getCheckedCustomer()
        {
            
            for(int cust = 0; cust < customerListBox.Items.Count; ++cust)
            {
                if (customerListBox.GetItemChecked(cust))
                {
                    chosenCustomer = CustomerList[cust];
                }
            }

        }

        private void selectCustomer_Click(object sender, EventArgs e)
        {

            getCheckedCustomer();
            if (chosenCustomer != null)
            {
                parentForm.updateCustomerInfo(chosenCustomer.CustomerNumber.ToString(), chosenCustomer.FirstName, chosenCustomer.LastName, chosenCustomer.AddressID.ToString(), chosenCustomer.ContactNumber.ToString());
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void customerListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
             for(int checkedValue = 0; checkedValue < customerListBox.Items.Count; ++checkedValue)
                {
                    if(e.Index != checkedValue)
                    {
                        customerListBox.SetItemChecked(checkedValue, false);
                    }
                }
            }

        }

        public void updateCustomerList(Customer[] custList, InvoiceTemplate parent)
        {
            parentForm = parent;
            CustomerList = custList;
            populateListBox();
        }

        private void clearList()
        {
            customerListBox.Items.Clear();
        }
    }
}
