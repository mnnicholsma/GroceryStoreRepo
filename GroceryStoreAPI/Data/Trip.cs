using System;
using System.Collections.Generic;

namespace GroceryStoreAPI.Data
{
    public class Trip
    {
        public int Id { get; set; }
        public DateTime TripDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }
}
