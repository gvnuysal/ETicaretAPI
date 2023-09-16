using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Domain.Entities.Customers;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Customers
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
