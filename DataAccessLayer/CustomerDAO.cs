using BusinessObjects;
using BusinessObjects.Models;
namespace DataAccessLayer
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomers()
        {
            var listCustomer = new List<Customer>();
            try
            {
                using var db = new FuminiHotelManagementContext();
                listCustomer = db.Customers.ToList();
            }
            catch (Exception ex) { }

            return listCustomer;
        }

        public static void AddCustomer(Customer c)
        {
            try
            {
                using var context = new FuminiHotelManagementContext();
                context.Customers.Add(c);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);            
            }
        }

        public static void DeleteCustomer(Customer c)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                var customer = db.Customers.SingleOrDefault(cr => cr.CustomerId == c.CustomerId);
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }

        }

        public static void UpdateCustomer(Customer c)
        {
            try
            {
                using var db = new FuminiHotelManagementContext();
                db.Entry<Customer>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public static Customer GetCustomerById(int id)
        {
            using var db = new FuminiHotelManagementContext();
            return db.Customers.FirstOrDefault(cr => cr.CustomerId.Equals(id));
        }

        public static Customer GetCustomerByEmail(String email)
        {
            using var db = new FuminiHotelManagementContext();
            return db.Customers.SingleOrDefault(cr => cr.EmailAddress == email);
        }
    }

}
