using ECommerceAPI.Application.Repositories.ProductRepo;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories.ProductRepo;

public class ProductWriteRepository : WriteRepository<Product> , IProductWriteRepository
{
    public ProductWriteRepository(DatabaseContext context) : base(context)
    {
    }
}