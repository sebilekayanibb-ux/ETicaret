
namespace ETicaret.Application.DTOs.Product
{
    public class ProductImageDto
    {
        public string ImageUrl { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsCover { get; set; }
    }
}
