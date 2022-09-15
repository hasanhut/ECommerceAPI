using ECommerceAPI.Application.Repositories.CustomerRepo;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories.CustomerRepo;

public class CustomerReadRepository : ReadRepository<Customer> , ICustomerReadRepository
{
    public CustomerReadRepository(DatabaseContext context) : base(context)
    {
    }
}