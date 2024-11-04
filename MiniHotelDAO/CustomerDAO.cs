using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelDAO
{
    public class CustomerDAO
    {
        private static List<Customer> customerList;

        static CustomerDAO()
        {
            customerList = new List<Customer>
            {
                    new Customer(1, "John Doe", "1234567890", "john.doe@example.com", new DateOnly(1985, 7, 15), 1, "john123"),
                    new Customer(2, "Jane Smith", "0987654321", "jane.smith@example.com", new DateOnly(1990, 3, 22), 1, "jane456"),
                    new Customer(3, "Bob Brown", "4445556666", "bob.brown@example.com", new DateOnly(1988, 11, 10), 2, "bob 789"),
                    new Customer(4, "Alice Johnson", "5557778888", "alice.johnson@example.com", new DateOnly(1995, 6, 30), 2, "alice123")

            };
        }

        public static List<Customer> GetCustomers()
        {
            return customerList;
        }

        public static void AddCustomer(Customer customer)
        {
            customer.CustomerId = customerList.Count > 0 ? customerList.Max(c => c.CustomerId) + 1 : 1;
            customerList.Add(customer);
        }

        public static Customer FindCustomerById(int id)
        {
            return customerList.Find(c => c.CustomerId == id);
        }
        public static bool UpdateCustomer(Customer updatedCustomer)
        {
            var existingCustomer = FindCustomerById(updatedCustomer.CustomerId);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerFullName = updatedCustomer.CustomerFullName;
                existingCustomer.Telephone = updatedCustomer.Telephone;
                existingCustomer.EmailAddress = updatedCustomer.EmailAddress;
                existingCustomer.CustomerBirthday = updatedCustomer.CustomerBirthday;
                existingCustomer.CustomerStatus = updatedCustomer.CustomerStatus;
                existingCustomer.Password = updatedCustomer.Password;
                return true;
            }
            return false; 
        }

        public static void DeleteCustomer(int id)
        {
            var customer = FindCustomerById(id);
            if (customer != null)
            {
                customerList.Remove(customer);
            }
        }
    }
}
