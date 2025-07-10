using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using DataAccessLayer;

namespace Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        public void AddCustomer(Customer c) => CustomerDAO.AddCustomer(c);
        public void UpdateCustomer(Customer c) => CustomerDAO.UpdateCustomer(c);
        public void DeleteCustomer(Customer c) => CustomerDAO.DeleteCustomer(c);
        public List<Customer> GetCustomer() => CustomerDAO.GetCustomers();
        public Customer GetCustomerById(int id) => CustomerDAO.GetCustomerById(id);
        public Customer GetCustomerByEmail(string email) => CustomerDAO.GetCustomerByEmail(email);
    }
}
