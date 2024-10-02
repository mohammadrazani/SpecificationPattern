using Domain.Entities.Catalog;
using Infrastructure.BaseServices;
using Infrastructure.Data;
using Services.Catalog.Interfaces;

namespace Services.Catalog.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(AppDbContext context) : base(context)
        {
        }
    }
}
