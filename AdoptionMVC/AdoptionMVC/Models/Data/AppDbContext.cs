using Microsoft.EntityFrameworkCore;
namespace AdoptionMVC.Models.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    //What tables are in my database
    public DbSet<Animal> Animals { get; set; }
}
