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

//commented and cleaned (04/04/2017)

namespace Invoicer
{
     public partial class CustomerSelection : Form
    {
        
        //array value representing the customers that have been returned.
        Customer[] CustomerList;
        //parent form that initiated the window, this will be returned to after action has completed.
        InvoiceTemplate parentForm;
        

        //init
        public CustomerSelection(Customer[] customerlist, InvoiceTemplate parent)
        {
            InitializeComponent();
            CustomerList = customerlist;
            populateListBox();
            parentForm = parent;
        }

        //clears and updates Listbox using array
        private void populateListBox()
        {
            clearList();
            foreach (Customer cust in CustomerList)
            {
                customerListBox.Items.Add(cust.CustomerNumber +": "+cust.FirstName+" "+cust.LastName);
            }
        }

        //Checks list for checked customer item
        private Customer getCheckedCustomer()
        {
            Customer chosenCustomer = null;

            for (int cust = 0; cust < customerListBox.Items.Count; ++cust)
            {
                //if checked 
                if (customerListBox.GetItemChecked(cust))
                {
                    //assign item to customer variable
                    chosenCustomer = CustomerList[cust];
                }
            }

            //will return null if it failed to assign
            return chosenCustomer;
        }

        //Select customer button
        private void selectCustomer_Click(object sender, EventArgs e)
        {
            //assign customer
            Customer cust = getCheckedCustomer();

            //if not null, update else throw error.
            if (cust != null)
            {
                // update info on main form
                parentForm.updateCustomerInfo(cust);
                this.Close();
            }
            else
            {
                //catches if the customer wasnt assigned due to no selection.
                MessageBox.Show("Error! No Customer selected.");
            }
        }


        //Clicked when an item in the customer list box is checked
        private void customerListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if checked
            if (e.NewValue == CheckState.Checked)
            {
             //loop through all items
             for(int checkedValue = 0; checkedValue < customerListBox.Items.Count; ++checkedValue)
                {
                    //avoiding this item
                    if(e.Index != checkedValue)
                    {
                        //and make sure they're turned off
                        customerListBox.SetItemChecked(checkedValue, false);
                    }
                }
            }

        }


        private void clearList()
        {
            customerListBox.Items.Clear();
        }



        /*  -- Redundant Function

        public void updateCustomerList(Customer[] custList, InvoiceTemplate parent)
        {
            parentForm = parent;
            CustomerList = custList;
            populateListBox();
        }
        */
    }
}
