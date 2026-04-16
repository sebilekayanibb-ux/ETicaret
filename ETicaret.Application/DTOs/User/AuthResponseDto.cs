
namespace ETicaret.Application.DTOs.User
{
    public class AuthResponseDto
    {
        // AuthResponseDto, kullanıcı doğrulama işlemi sonrası döndürülecek verileri içerir.
        public UserResponseDto User { get; set; } = new();  // bu dtodakiler direkt eklendi.
        public string Token { get; set; } = string.Empty;
        public DateTime Expiration { get; set; }

    }
}
