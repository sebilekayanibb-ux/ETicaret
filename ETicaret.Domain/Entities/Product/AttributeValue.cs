using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class AttributeValue : BaseEntity
{
    public Guid AttributeTypeId { get; set; }
    public string Value { get; set; } = string.Empty;

    // Navigation Properties
    public AttributeType AttributeType { get; set; } = null!;
    public ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = [];
}
