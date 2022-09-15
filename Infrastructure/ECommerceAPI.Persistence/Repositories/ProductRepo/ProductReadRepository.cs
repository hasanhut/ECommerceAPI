using ECommerceAPI.Application.Repositories.ProductRepo;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories.ProductRepo;

public class ProductReadRepository : ReadRepository<Product> , IProductReadRepository
{
    public ProductReadRepository(DatabaseContext context) : base(context)
    {
    }
}