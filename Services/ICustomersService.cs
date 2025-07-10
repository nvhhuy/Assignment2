using BusinessObjects.Models;
using System.Collections.Generic;

namespace Services
{
    public interface ICustomersService
    {
        void AddCustomer(Customer c);
        void UpdateCustomer(Customer c);
        void DeleteCustomer(Customer c);
        List<Customer> GetCustomer();
        Customer GetCustomerById(int id);
        Customer GetCustomerByEmail(string email);
    }
}
