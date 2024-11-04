using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Customer
    {
        public Customer() { }

        public Customer(int id, string name, string phone, string email, DateOnly Birthday, int status, string password)
        {
            this.CustomerId = id;
            this.CustomerFullName = name;
            this.Telephone = phone;
            this.EmailAddress = email;
            this.Password = password;
            this.CustomerBirthday = Birthday;
            this.CustomerStatus = status;
        }

        public int CustomerId {  get; set; }
        public string CustomerFullName {  get; set; }
        public string Telephone {  get; set; }
        public  string EmailAddress {  get; set; }
        public string Password {  get; set; }
        public DateOnly CustomerBirthday { get; set; }
        public int CustomerStatus {  get; set; }
    }
}
