using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoicerDAL.Models;
using InvoicerDAL.Services;
using InvoicerDAL;

namespace Invoicer
{
    public partial class InvoiceTemplate : Form
    {
        private readonly ICustomerService customerService;

        public enum MessageBoxes
        {
            InvalidInput,
            NoCustFound,
            NoInvFound,
            UnknownError,
            SQLError
        }

        /* Array init */
        //Customer myCustomer;
        //Invoice myInvoice;
        //Customer[] Customers;

        //holds all customer search info
        Customer[] recentListArray = new Customer[30];

        public InvoiceTemplate()
        {
            InitializeComponent();


            //InitiateCustomerData();   -- Old Array init
            //InitiateInvoiceData();    -- Old Array init

            customerService = new CustomerService();
        }

        private void InvoiceTemplate_Load(object sender, EventArgs e)
        {

        }

        private void CustomerSearch_Click(object sender, EventArgs e)
        { 
            int id;
            int.TryParse(CustomerNumberBox.Text, out id);

            try
            {
                Customer customerSearch;
                customerSearch = customerService.GetCustomerByID(id);

                //if results are returned.
                if (customerSearch != null)
                {
                    //populate form with data
                    updateCustomerInfo(customerSearch);
                }
                else
                {
                    MessageBox.Show("No Customers Found!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            


        }

        //called to update customer info from Customer model
        public void updateCustomerInfo(Customer cust)
        {
            addToRecent(cust);
            CustomerNumberBox.Text = cust.CustomerNumber.ToString();
            FirstNameBox.Text = cust.FirstName;
            SurnameBox.Text = cust.LastName;
            AddressBox.Text = cust.AddressID.ToString();
            ContactBox.Text = cust.ContactNumber.ToString();
        }

        //reset form data - called before updating.
        private void ClearInvoice()
        {
            CustomerNumberBox.Clear();
            FirstNameBox.Clear();
            SurnameBox.Clear();
            ContactBox.Clear();
            AddressBox.Clear();
        }

        //called when application updates customer info
        private void addToRecent(Customer cust)
        {
            //if customer isnt on the list
            if (!checkRecentExists(cust))
            {
                //add to array index (after finding next free one)
                recentListArray[getRecentFreeIndex()] = cust;

                //Update UI to show new array list
                updateRecentList();
            }

        }



        //find free array index
        private int getRecentFreeIndex()
        {
            int index = 0;

            for(int items = 0; items < recentListArray.Length; items++)
            {
                if(recentListArray[items] == null)
                {
                    index = items;
                    return index;
                }
               
            }

            return index;
        }

        
        //update UI to show the array list of customers recently searched
        private void updateRecentList()
        {
            RecentSearchList.Items.Clear();

            string listString;

            //loop through recent list
            for (int index = 0; index < recentListArray.Length; index++)
            {
                //if not null
                if (recentListArray[index] != null)
                {
                    //create string item to show
                    listString = $"{index}: {recentListArray[index].FirstName}, {recentListArray[index].LastName}.";
                    //add string item
                    RecentSearchList.Items.Add(listString);
                }
            }



        }


        //check if recent array list has customer in it
        private bool checkRecentExists(Customer cust)
        {
            
            for(int id = 0; id < recentListArray.Length; id++)
            {
                if(recentListArray[id] != null)
                {

                    //why does removing customer number here fail to validate as true?                    ************************* QUESTION *******************
                    if (recentListArray[id].CustomerNumber == cust.CustomerNumber)
                    {
                        return true;
                    }
                }

            }
            return false;

        }

        private void CustomMessageBox(MessageBoxes msg)
        {
            switch (msg)
            {
                case MessageBoxes.UnknownError:
                    MessageBox.Show("Unknown error occured.");
                    break;
                case MessageBoxes.InvalidInput:
                    MessageBox.Show("Invalid Input.");
                    break;
                case MessageBoxes.NoCustFound:
                    MessageBox.Show("No customer found!");
                    break;
                case MessageBoxes.NoInvFound:
                    MessageBox.Show("No invoice found!");
                    break;
                case MessageBoxes.SQLError:
                    MessageBox.Show("SQL Error!");
                    break;
            }
        }

        private void clearCustomerInvoicesList()
        {
            InvoicesGrid.Rows.Clear();
        }


        private void InvoicesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridView invoiceGrid = (DataGridView)sender;


            if (invoiceGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //get invoice Numer
                MessageBox.Show(invoiceGrid[0, e.RowIndex].Value.ToString());
                //Send this to funciton to populate invoices.
            }
        }

        private void FirstNameSearch_Click(object sender, EventArgs e)
        {
            string nameSearch = FirstNameBox.Text;
            List<Customer> customerList;

            if (nameSearch.All(char.IsLetterOrDigit))
            {
                customerList = customerService.GetCustomerByFirstName(nameSearch);

                if (customerList != null)
                {
                    if (customerList.Count <= 1)
                    {
                        updateCustomerInfo(customerList[0]);
                    }
                    else
                    {
                        //MessageBox.Show("New menu opens to select a customer out of a list.");
                        Customer[] custArray = new Customer[customerList.Count];


                        for(int cust = 0; cust < custArray.Length; cust++)
                        {

                            custArray[cust] = new Customer(customerList[cust].CustomerNumber, customerList[cust].FirstName, customerList[cust].LastName, customerList[cust].AddressID, customerList[cust].ContactNumber);
                        }


                            CustomerSelection selectionForm = new CustomerSelection(custArray, this);
                            selectionForm.Show();


                    }
                }
            }else
            {
                CustomMessageBox(MessageBoxes.InvalidInput);
            }

        }

        private void SurnameSearch_Click(object sender, EventArgs e)
        {
            string nameSearch = SurnameBox.Text;
            List<Customer> customerList;

            if (nameSearch.All(char.IsLetterOrDigit))
            {
                customerList = customerService.GetCustomerByLastName(nameSearch);

                if (customerList != null)
                {
                    if (customerList.Count <= 1)
                    {
                        updateCustomerInfo(customerList[0]);
                    }
                    else
                    {
                        //MessageBox.Show("New menu opens to select a customer out of a list.");
                        Customer[] custArray = new Customer[customerList.Count];


                        for (int cust = 0; cust < custArray.Length; cust++)
                        {

                            custArray[cust] = new Customer(customerList[cust].CustomerNumber, customerList[cust].FirstName, customerList[cust].LastName, customerList[cust].AddressID, customerList[cust].ContactNumber);
                        }


                            CustomerSelection selectionForm = new CustomerSelection(custArray, this);
                            selectionForm.Show();

                    }
                }
            }
            else
            {
                CustomMessageBox(MessageBoxes.InvalidInput);
            }

        }


        //Double clicking on a recent search list item will show its details
        private void RecentSearchList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Customer selectedCustomer = recentListArray[RecentSearchList.SelectedIndex];

            MessageBox.Show($"Selected customer is: {selectedCustomer.FirstName} {selectedCustomer.LastName}.");

            updateCustomerInfo(selectedCustomer);
            

        }
    }






    //Ignore Below - old array stuff


    /*

        private void UpdateInvoices()
        {
            for(int i = 0; i < myCustomer.invoices.Length; i++)
            {

                if(myCustomer.invoices[i] != null)
                {

                    DataGridViewRow row = (DataGridViewRow)InvoicesGrid.Rows[0].Clone();
                    row.Cells[0].Value = myCustomer.invoices[i].invoiceNumber.ToString();
                    row.Cells[1].Value = myCustomer.invoices[i].cost.ToString();
                    row.Cells[2].Value = myCustomer.invoices[i].dueDate.ToString();
                    row.Cells[3].Value = myCustomer.invoices[i].paid;
                    row.Cells[4].Value = "Details";
                    InvoicesGrid.Rows.Add(row);
                    //LOOK UP DATA GRIDS TABULAR AND CELLULAR DATA TO FIX THIS ISSUE
                    //CostInvoice1.Text = myCustomer.invoices[i].cost.ToString();
                    //DueDateInvoice1.Text = myCustomer.invoices[i].dueDate;
                    //PaidInvoice1.Checked = myCustomer.invoices[i].paid;
                }
                else
                {
                    break;
                }

            }

        }
        
        private void setCustomerInfo(Customer cust)
        {
            FirstNameBox.Text = cust.firstName;
            SurnameBox.Text = cust.surname;
            ContactBox.Text = cust.contactNumber.ToString();
            AddressBox.Text = cust.address;
        }

        private void InitiateCustomerData()
        {
            Customers = new Customer[10];
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172563;
            myCustomer.firstName = "Frank";
            myCustomer.surname = "Underwood";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[0] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172564;
            myCustomer.firstName = "Claire";
            myCustomer.surname = "Underwood";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[1] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172565;
            myCustomer.firstName = "Edward";
            myCustomer.surname = "Meechum";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[2] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172566;
            myCustomer.firstName = "Zoe Barnes";
            myCustomer.surname = "Underwood";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[3] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172567;
            myCustomer.firstName = "Doug";
            myCustomer.surname = "Stamper";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[4] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172568;
            myCustomer.firstName = "Lucas";
            myCustomer.surname = "Goodwin";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[5] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172569;
            myCustomer.firstName = "Garrett";
            myCustomer.surname = "Walker";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[6] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172570;
            myCustomer.firstName = "Linda";
            myCustomer.surname = "Vasques";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[7] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172571;
            myCustomer.firstName = "Raymond";
            myCustomer.surname = "Tusk";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[8] = myCustomer;
            myCustomer = new Customer();
            myCustomer.customerNumber = 0172572;
            myCustomer.firstName = "Peter";
            myCustomer.surname = "Russo";
            myCustomer.address = "1600 Pennsylvania Avenue, NW, Washington, D.C";
            myCustomer.contactNumber = 12024561111;
            Customers[9] = myCustomer;

        }

        private void InitiateInvoiceData()
        {

            myInvoice = new Invoice();
            myInvoice.invoiceNumber = 15484;
            myInvoice.cost = 3.00;
            myInvoice.dueDate = "2017-01-12";
            myInvoice.paymentDate = "2017-01-02";
            myInvoice.paid = true;
            Customers[0].invoices[0] = myInvoice;
            myInvoice = new Invoice();
            myInvoice.invoiceNumber = 15485;
            myInvoice.cost = 54.99;
            myInvoice.dueDate = "2017-01-21";
            myInvoice.paymentDate = "2017-01-02";
            myInvoice.paid = false;
            Customers[0].invoices[1] = myInvoice;
            myInvoice = new Invoice();
            myInvoice.invoiceNumber = 15486;
            myInvoice.cost = 34.00;
            myInvoice.dueDate = "2017-01-12";
            myInvoice.paymentDate = "2017-01-02";
            myInvoice.paid = false;
            Customers[1].invoices[0] = myInvoice;
            myInvoice = new Invoice();
            myInvoice.invoiceNumber = 15487;
            myInvoice.cost = 4.49;
            myInvoice.dueDate = "2017-02-01";
            myInvoice.paymentDate = "2017-01-19";
            myInvoice.paid = true;
            Customers[2].invoices[0] = myInvoice;
            myInvoice = new Invoice();
            myInvoice.invoiceNumber = 15487;
            myInvoice.cost = 453.49;
            myInvoice.dueDate = "2017-02-01";
            myInvoice.paymentDate = "2017-01-19";
            myInvoice.paid = true;
            Customers[2].invoices[1] = myInvoice;
            myInvoice = new Invoice();
            myInvoice.invoiceNumber = 15487;
            myInvoice.cost = 79.49;
            myInvoice.dueDate = "2017-02-01";
            myInvoice.paymentDate = "2017-01-19";
            myInvoice.paid = true;
            Customers[2].invoices[2] = myInvoice;

        }
   


    public class Customer
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

    public class Invoice
    {
        public int invoiceNumber { get; set; }
        public double cost { get; set; }
        public string paymentDate { get; set; }
        public string dueDate { get; set; }
        public bool paid { get; set; }

    }


    */



}
