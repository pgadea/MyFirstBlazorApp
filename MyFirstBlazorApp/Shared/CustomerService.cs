using System.Collections.Generic;
using System.Linq;

namespace MyFirstBlazorApp.Shared
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customers;

        public CustomerService()
        {
            customers = new List<Customer>()
            {
                new Customer {Id = 1, Name = "Tom"},
                new Customer {Id = 2, Name = "John"},
                new Customer {Id = 3, Name = "Name"},
            };
        }

        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
