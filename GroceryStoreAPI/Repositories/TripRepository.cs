using GroceryStoreAPI.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroceryStoreAPI
{
    public class TripRepository : ITripRepository
    {
        private readonly GrocertyStoreContext _context;

        public TripRepository(GrocertyStoreContext repositoryContext)
        {
            _context = repositoryContext;
        }

    }
}