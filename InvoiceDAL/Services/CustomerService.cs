using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoicerDAL.Services;
using InvoicerDAL.Models;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace InvoicerDAL.Services
{
    public class CustomerService : ICustomerService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["TAFEConnection"].ConnectionString.ToString();

        
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();

            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand("SELECT ID, FirstName, LastName, AddressID, ContactNumber " +
                    "FROM Customer ORDER BY ID;", conn);

                conn.Open();


                //fails here as a result of an unknown column called "ID" 
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {
                        customerList.Add(new Customer
                            (
                            dataReader.GetInt32("Id"),
                            dataReader.GetString("FirstName"),
                            dataReader.GetString("LastName"),
                            dataReader.GetInt32("AddressID"),
                            dataReader.GetInt32("ContactNumber")
                            ));
                    }
                }

                conn.Close();
            }



                return customerList;
        }
        
        public Customer GetCustomerByID(int id)
        {

            Customer foundCustomer = new Customer();

            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand("SELECT ID, FirstName, LastName, AddressID, ContactNumber " +
                                        "FROM Customer " +
                                        "WHERE ID = @ID;", conn);


                MySqlParameter IDParameter =
                    new MySqlParameter("@ID", MySqlDbType.Int32, 50);
                IDParameter.Value = id;

                conn.Open();

                command.Parameters.Add(IDParameter);
                command.Prepare();


                //fails here as a result of an unknown column called "ID" 
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    

                    dataReader.Read();

                    foundCustomer.CustomerNumber = dataReader.GetInt32("Id");
                    foundCustomer.FirstName = dataReader.GetString("FirstName");
                    foundCustomer.LastName = dataReader.GetString("LastName");
                    foundCustomer.AddressID = dataReader.GetInt32("AddressID");
                    foundCustomer.ContactNumber = dataReader.GetInt32("ContactNumber");

                }

                conn.Close();
            }


            return foundCustomer;
        }

        public List<Customer> GetCustomerByFirstName(string name)
        {
            List<Customer> customerList = new List<Customer>();

            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT ID, FirstName, LastName, AddressID, ContactNumber FROM customer WHERE FirstName LIKE @FirstName; ", conn);


                MySqlParameter firstNameParameter =
                    new MySqlParameter("@FirstName", MySqlDbType.VarChar, 50);
                firstNameParameter.Value = name;

                conn.Open();

                command.Parameters.Add(firstNameParameter);
                command.Prepare();

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        customerList.Add(new Customer(
                            dataReader.GetInt32("Id"),
                            dataReader.GetString("FirstName"),
                            dataReader.GetString("LastName"),
                            dataReader.GetInt32("AddressID"),
                            dataReader.GetInt32("ContactNumber")
                            ));
                    }
                }
                conn.Close();
            }
            return customerList;
        }

        public List<Customer> GetCustomerByLastName(string name)
        {
            List<Customer> customerList = new List<Customer>();

            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT ID, FirstName, LastName, AddressID, ContactNumber FROM customer WHERE LastName LIKE @LastName; ", conn);


                MySqlParameter lastNameParameter =
                    new MySqlParameter("@LastName", MySqlDbType.VarChar, 50);
                lastNameParameter.Value = name;

                conn.Open();

                command.Parameters.Add(lastNameParameter);
                command.Prepare();

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        customerList.Add(new Customer(
                            dataReader.GetInt32("Id"),
                            dataReader.GetString("FirstName"),
                            dataReader.GetString("LastName"),
                            dataReader.GetInt32("AddressID"),
                            dataReader.GetInt32("ContactNumber")
                            ));
                    }
                }
                conn.Close();
            }
            return customerList;
        }
        
        public List<Invoice> GetCustomerInvoices(int customerNumber)
        {

            List<Invoice> Invoices = new List<Invoice>();



            return Invoices;


        }

    }
}
