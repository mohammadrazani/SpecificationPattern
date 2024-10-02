using Domain.Entities.Base;

namespace Domain.Entities.Catalog
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal SpecialPrice { get; set; }

        public bool IsAvailable { get; set; }

        public decimal StockQuantity { get; set; }

        public string Sku { get; set; }

        public int DisplayOrder { get; set; }
    }
}
