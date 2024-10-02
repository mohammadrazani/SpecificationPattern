using Domain.Entities.Catalog;
using Domain.Specifications.Catalog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Catalog.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productService
                         .GetAll(new AvailableProductSpecification())
                         .ToListAsync();
        }
    }
}
