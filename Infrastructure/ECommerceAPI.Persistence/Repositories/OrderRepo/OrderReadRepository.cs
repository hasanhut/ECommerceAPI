using ECommerceAPI.Application.Repositories.OrderRepo;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories.OrderRepo;

public class OrderReadRepository : ReadRepository<Order> , IOrderReadRepository
{
    public OrderReadRepository(DatabaseContext context) : base(context)
    {
    }
}