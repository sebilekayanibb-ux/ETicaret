using ETicaret.Domain.Common;
using ETicaret.Domain.Enums;

namespace ETicaret.Domain.Entities.Category;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public CategoryGender? Gender { get; set; }
    public Guid? ParentCategoryId { get; set; }
    public string? IconUrl { get; set; }
    public int SortOrder { get; set; }
    public bool IsActive { get; set; } = true;

    // Navigation Properties
    public Category? ParentCategory { get; set; }
    public ICollection<Category> SubCategories { get; set; } = [];
    public ICollection<Product.Product> Products { get; set; } = [];
}
