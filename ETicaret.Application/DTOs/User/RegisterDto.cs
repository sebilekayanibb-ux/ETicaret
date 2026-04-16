namespace ETicaret.Application.DTOs.User;

/// Kullanıcı kayıt olurken gönderdiği veri.
/// PasswordHash değil Password alıyoruz → Service katmanında hash'lenir.

public class RegisterDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
