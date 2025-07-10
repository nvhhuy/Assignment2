using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Repositories
{
    public interface ICustomersRepository
    {
        void AddCustomer(Customer c);
        void UpdateCustomer(Customer c);
        void DeleteCustomer(Customer c);
        List<Customer> GetCustomer();
        Customer GetCustomerById(int id);
        Customer GetCustomerByEmail(string email);
    }
}
