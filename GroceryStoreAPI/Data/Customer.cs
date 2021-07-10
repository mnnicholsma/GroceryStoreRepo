﻿using System;
using System.Collections.Generic;

namespace GroceryStoreAPI.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Trip> Trips { get; set; }
    }
}

