using ECommerceAPI.Application.Repositories.OrderRepo;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories.OrderRepo;

public class OrderWriteRepository : WriteRepository<Order> , IOrderWriteRepository
{
    public OrderWriteRepository(DatabaseContext context) : base(context)
    {
    }
}