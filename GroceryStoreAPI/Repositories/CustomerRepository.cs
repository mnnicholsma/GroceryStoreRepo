using GroceryStoreAPI.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GroceryStoreAPI
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly GrocertyStoreContext _context;

        public CustomerRepository(GrocertyStoreContext repositoryContext)
        {
            _context = repositoryContext;
        }

        public async Task<IList<Customer>> GetCustomer(int customerId)
        {
            var customer = _context.Customers
            .Select(c => c)
            .Where(c => c.Id == customerId);

            return await customer.ToListAsync();
        }

        public async Task<IList<Customer>> GetAllCustomers()
        {
            var customer = _context.Customers
            .Select(c => c)
            .OrderBy(c => c.LastName).ThenBy(c => c.FirstName);
            return await customer.ToListAsync();
        }

        public Task<Customer> UpdateCustomer(Customer customerObj)
        {
            var customer = _context.Customers
            .Select(c => c)
            .Where(c => c.Id == customerObj.Id).FirstOrDefault<Customer>();

            if (customer != null)
            {
                customer.FirstName = customerObj.FirstName;
                customer.LastName = customerObj.LastName;
                customer.DateOfBirth = customerObj.DateOfBirth;
            }

            return Task.FromResult(customer);
        }

        public async Task<Customer> InsertCustomer(Customer customerObj)
        {

            var customer = new Customer
            {
                FirstName = customerObj.FirstName,
                LastName = customerObj.LastName,
                DateOfBirth = customerObj.DateOfBirth
            };
            try
            {
                await _context.Customers.AddAsync(customer);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }
            return customer;
        }

    }
}