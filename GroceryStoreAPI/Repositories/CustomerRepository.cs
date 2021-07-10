using GroceryStoreAPI.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroceryStoreAPI
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly GrocertyStoreContext _context;

        public CustomerRepository(GrocertyStoreContext repositoryContext)
        {
            _context = repositoryContext;
        }

    }
}