using Domain.Entities.Catalog;
using Domain.Specifications.Base;

namespace Domain.Specifications.Catalog
{
    public class AvailableProductSpecification : Specification<Product>
    {
        public AvailableProductSpecification() : base(product => product.IsAvailable && product.StockQuantity > 0)
        {
            AddOrderBy(product => product.DisplayOrder);
        }
    }
}
