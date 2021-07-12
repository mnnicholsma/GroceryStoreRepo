using GroceryStoreAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GroceryStoreAPI
{
    public interface ICustomerRepository
    {
        Task<Customer> InsertCustomer(Customer customerObj);
        Task<Customer> UpdateCustomer(Customer customerObj);
        Task<IList<Customer>> GetCustomer(int customerId);
        Task<IList<Customer>> GetAllCustomers();
    }

}