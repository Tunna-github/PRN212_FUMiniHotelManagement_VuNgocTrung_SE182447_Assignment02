using BusinessObjects.Models;
using MiniHotelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        public List<Customer> GetCustomers() => CustomerDAO.GetCustomers();

        public Customer GetCustomerById(int id) => CustomerDAO.GetCustomers().FirstOrDefault(c => c.CustomerId == id);

        public void SaveCustomer(Customer customer) => CustomerDAO.AddCustomer(customer);

        public void UpdateCustomer(Customer customer) => CustomerDAO.UpdateCustomer(customer);

        public void DeleteCustomer(int id) => CustomerDAO.DeleteCustomer(id);
    }
}
