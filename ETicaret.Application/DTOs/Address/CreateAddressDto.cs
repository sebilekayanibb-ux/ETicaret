
namespace ETicaret.Application.DTOs.Address
{
    public class CreateAddressDto
    {
        public string City { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string RecipientName { get; set; } = string.Empty;
        public string Neighborhood { get; set; } = string.Empty;
        public string AddressDetail { get; set; } = string.Empty;
        public string AddressTitle { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }

    }
}
