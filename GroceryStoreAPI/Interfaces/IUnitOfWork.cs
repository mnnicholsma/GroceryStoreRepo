using GroceryStoreAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GroceryStoreAPI
{
    public interface IUnitOfWork
    {

        ICustomerRepository Customer { get; }
        IProductRepository Product { get; }
        ITripRepository Trip { get; }
        public Task<bool> Save();

    }

}