using Microsoft.EntityFrameworkCore;

namespace CoffeeShopRegistration.Models.Data;
//represent database like select all; class goes in and runs=job
public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    //what tables are in my database?
    public DbSet<User> Users { get; set; }
}
