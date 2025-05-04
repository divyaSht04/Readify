using System.ComponentModel.DataAnnotations;
namespace Backend.DTO;


public class RegisterDto
{[Required, MaxLength(100)] public string Name { get; set; }
    [Required, MaxLength(100)]
    public string PhoneNumber { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required, MaxLength(100), EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [MaxLength(100)]
    public string? Address { get; set; }

    [MaxLength(100)]
    public string? Image { get; set; }
}