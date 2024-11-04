using BusinessObjects.Models;
using MiniHotelRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo customerRepository;

        public CustomerService()
        {
            customerRepository = new CustomerRepo();
        }

        public List<Customer> GetCustomers() => customerRepository.GetCustomers();

        public Customer GetCustomerById(int id) => customerRepository.GetCustomerById(id);

        public void SaveCustomer(Customer customer) => customerRepository.SaveCustomer(customer);

        public void UpdateCustomer(Customer customer) => customerRepository.UpdateCustomer(customer); 

        public void DeleteCustomer(int id) => customerRepository.DeleteCustomer(id); 
    }
}
