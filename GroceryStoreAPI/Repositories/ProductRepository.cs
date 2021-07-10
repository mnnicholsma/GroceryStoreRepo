using GroceryStoreAPI.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroceryStoreAPI
{
    public class ProductRepository : IProductRepository
    {
        private readonly GrocertyStoreContext _context;

        public ProductRepository(GrocertyStoreContext repositoryContext)
        {
            _context = repositoryContext;
        }

    }
}