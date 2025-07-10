using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using Repositories;

namespace Services
{
    public class CustomersService : ICustomersService
    {
        private readonly ICustomersRepository icustomersService;

        public CustomersService()
        {
            icustomersService = new CustomersRepository();
        }
        public void AddCustomer(Customer c)
        {
            icustomersService.AddCustomer(c);
        }
        public void UpdateCustomer(Customer c)
        {
            icustomersService.UpdateCustomer(c);
        }
        public void DeleteCustomer(Customer c)
        {
            icustomersService.DeleteCustomer(c);
        }
        public List<Customer> GetCustomer()
        {
            return icustomersService.GetCustomer();
        }
        public Customer GetCustomerById(int id)
        {
            return icustomersService.GetCustomerById(id);
        }
        public Customer GetCustomerByEmail(string email)
        {
            return icustomersService.GetCustomerByEmail(email);
        }
    }
}
