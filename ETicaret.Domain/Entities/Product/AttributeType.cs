using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class AttributeType : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    // Navigation Properties
    public ICollection<AttributeValue> AttributeValues { get; set; } = [];
}
