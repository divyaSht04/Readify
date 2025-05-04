using Microsoft.EntityFrameworkCore;
using Backend.Model; 

namespace Backend.Data;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    
    
    public DbSet<Users> Users { get; set; }
}