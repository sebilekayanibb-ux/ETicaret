using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class ProductAttributeValue : BaseEntity
{
    //Product ↔ AttributeValue köprü tablo
    public Guid ProductId { get; set; }
    public Guid AttributeValueId { get; set; }

    // Navigation Properties
    public Product Product { get; set; } = null!;
    public AttributeValue AttributeValue { get; set; } = null!;
}
