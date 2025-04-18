using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Model;

[Table("Users")]
public class Users
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public Roles Role { get; set; }
    
    public DateTime Created { get; set; } = DateTime.UtcNow;
    
    public DateTime Updated { get; set; } = DateTime.UtcNow;
}