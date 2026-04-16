namespace ETicaret.Application.DTOs.User
{
    public class UserResponseDto
    {
        // UserResponseDto, kullanıcı bilgilerini döndürmek için kullanılır.
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

    }
}
