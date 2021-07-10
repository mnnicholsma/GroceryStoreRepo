using GroceryStoreAPI.Data;
using System.Threading.Tasks;

namespace GroceryStoreAPI
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GrocertyStoreContext _repoContext;
        private ICustomerRepository _customer;
        private IProductRepository _product;
        private ITripRepository _trip;

        public ICustomerRepository Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CustomerRepository(_repoContext);
                }
                return _customer;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }
                return _product;
            }
        }

        public ITripRepository Trip
        {
            get
            {
                if (_trip == null)
                {
                    _trip = new TripRepository(_repoContext);
                }
                return _trip;
            }
        }

        public UnitOfWork(GrocertyStoreContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public async Task<bool> Save()
        {
            await _repoContext.SaveChangesAsync();
            return true;
        }
    }
}