using ECommerceAPI.Application.Repositories.CustomerRepo;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories.CustomerRepo;

public class CustomerWriteRepository : WriteRepository<Customer> , ICustomerWriteRepository
{
    public CustomerWriteRepository(DatabaseContext context) : base(context)
    {
    }
}