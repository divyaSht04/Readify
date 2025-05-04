using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Backend.enums;

namespace Backend.Model;

[Table("Users")]
public class Users
{
    [Key]
    public Guid Id { get; set; }
    
    [Column("full_name"), Required]
    public string Name { get; set; }
    
    [Column(name:"phone_number"), Required]
    public string PhoneNumber { get; set; }
    
    [Column("date_of_birth"), Required]
    public DateTime DateOfBirth { get; set; }
    
    [Column("email"), Required]
    public string Email { get; set; }
    
    [Column("password"), Required]
    public string Password { get; set; }

    public Roles Role { get; set; } = Roles.USER;
    
    public DateTime Created { get; set; } = DateTime.UtcNow;
    
    public DateTime Updated { get; set; } = DateTime.UtcNow;
}